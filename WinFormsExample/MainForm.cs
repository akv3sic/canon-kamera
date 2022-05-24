using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EOSDigital.API;
using EOSDigital.SDK;

namespace WinFormsExample
{
    public partial class MainForm : Form
    {
        #region Variables

        CanonAPI APIHandler;
        //Camera MainCamera;
        List<Camera> CamList; // lista svih kamera
        bool IsInit = false;
        Bitmap Evf_Bmp;
        int LVBw, LVBh, w, h;
        float LVBratio, LVration;

        int ErrCount;
        object ErrLock = new object();
        object LvLock = new object();

        #endregion

        public MainForm()
        {
            try
            {
                InitializeComponent();
                this.Text="Računalni vid";
                APIHandler = new CanonAPI();
                APIHandler.CameraAdded += APIHandler_CameraAdded;
                ErrorHandler.SevereErrorHappened += ErrorHandler_SevereErrorHappened;
                ErrorHandler.NonSevereErrorHappened += ErrorHandler_NonSevereErrorHappened;
                SavePathTextBox.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "RemotePhoto");
                SaveFolderBrowser.Description = "Save Images To...";
                LiveViewPicBox1.Paint += LiveViewPicBox_Paint;
                LiveViewPicBox2.Paint += LiveViewPicBox_Paint;
                LVBw = LiveViewPicBox1.Width;
                LVBh = LiveViewPicBox1.Height;
                RefreshCamera();
                IsInit = true;
            }
            catch (DllNotFoundException) { ReportError("Canon DLLs not found!", true); }
            catch (Exception ex) { ReportError(ex.Message, true); }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IsInit = false;
                foreach (Camera cam in CamList) cam?.Dispose(); // raspusti sve kamere
                APIHandler?.Dispose();
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #region API Events

        private void APIHandler_CameraAdded(CanonAPI sender)
        {
            try { Invoke((Action)delegate { RefreshCamera(); }); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void MainCamera_StateChanged(Camera sender, StateEventID eventID, int parameter)
        {
            try { if (eventID == StateEventID.Shutdown && IsInit) { Invoke((Action)delegate { CloseSessions(); }); } }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }
        
        private void MainCamera_ProgressChanged(object sender, int progress)
        {
            try { Invoke((Action)delegate { MainProgressBar.Value = progress; }); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void MainCamera_LiveViewUpdated(Camera sender, Stream img)
        {
            try
            {
                lock (LvLock)
                {
                    Evf_Bmp?.Dispose();
                    Evf_Bmp = new Bitmap(img);
                }
                LiveViewPicBox1.Invalidate();
                LiveViewPicBox2.Invalidate();
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void MainCamera_DownloadReady(Camera sender, DownloadInfo Info)
        {
            try
            {
                string dir = null;
                Invoke((Action)delegate { dir = SavePathTextBox.Text; });
                sender.DownloadFile(Info, dir);
                Invoke((Action)delegate { MainProgressBar.Value = 0; });
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void ErrorHandler_NonSevereErrorHappened(object sender, ErrorCode ex)
        {
            ReportError($"SDK Error code: {ex} ({((int)ex).ToString("X")})", false);
        }

        private void ErrorHandler_SevereErrorHappened(object sender, Exception ex)
        {
            ReportError(ex.Message, true);
        }

        #endregion

        #region Session

        private void SessionButton_Click(object sender, EventArgs e)
        {
            // maybe // foreach (Camera cam in CamList) {};
            if (CamList[0]?.SessionOpen == true) CloseSessions();
            else OpenSessions();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try { RefreshCamera(); }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #endregion

        #region Settings

        private void TakePhotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Camera cam in CamList) cam.TakePhotoAsync();
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(SavePathTextBox.Text)) SaveFolderBrowser.SelectedPath = SavePathTextBox.Text;
                if (SaveFolderBrowser.ShowDialog() == DialogResult.OK)
                {
                    SavePathTextBox.Text = SaveFolderBrowser.SelectedPath;
                }
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        private void SaveToRdButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Camera cam in CamList)
                {
                    if (IsInit)
                    {
                        if (STCameraRdButton.Checked)
                        {
                            cam.SetSetting(PropertyID.SaveTo, (int)SaveTo.Camera);
                            BrowseButton.Enabled = false;
                            SavePathTextBox.Enabled = false;
                        }
                        else
                        {
                            if (STComputerRdButton.Checked) cam.SetSetting(PropertyID.SaveTo, (int)SaveTo.Host);
                            else if (STBothRdButton.Checked) cam.SetSetting(PropertyID.SaveTo, (int)SaveTo.Both);

                            cam.SetCapacity(4096, int.MaxValue);
                            BrowseButton.Enabled = true;
                            SavePathTextBox.Enabled = true;
                        }
                    }
                };

            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }

        #endregion

        #region Live view

        private void LiveViewButton_Click(object sender, EventArgs e)
        {
            if(!CamList[0].IsLiveViewOn)
            {
                foreach(Camera cam in CamList)
                {
                    try
                    {
                        { cam.StartLiveView(); LiveViewButton.Text = "Stop LV"; }
                    }
                    catch (Exception ex) { ReportError(ex.Message, false); }
                };
            }
            else
            {
                foreach(Camera cam in CamList)
                {
                    try
                    {
                        { cam.StopLiveView(); LiveViewButton.Text = "Start LV"; }
                    }
                    catch (Exception ex) { ReportError(ex.Message, false); }
                };
            }
        }

        private void LiveViewPicBox_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                LVBw = LiveViewPicBox1.Width;
                LVBh = LiveViewPicBox1.Height;
                LiveViewPicBox1.Invalidate();
                LiveViewPicBox2.Invalidate();
            }
            catch (Exception ex) { ReportError(ex.Message, false); }
        }
        // rotate bitmap helper
        public static Bitmap RotateImage(Bitmap b, float angle)
        {
        //create a new empty bitmap to hold rotated image
        Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
        //make a graphics object from the empty bitmap
        using(Graphics g = Graphics.FromImage(returnBitmap)) 
        {
            //move rotation point to center of image
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            //rotate
            g.RotateTransform(angle);
            //move image back
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            //draw passed in image onto graphics object
            g.DrawImage(b, new System.Drawing.Point(0, 0)); 
        }
        return returnBitmap;
        }
        private void LiveViewPicBox_Paint(object sender, PaintEventArgs e)  // ??
        {
            foreach (Camera cam in CamList) {
                if (cam == null || !cam.SessionOpen) return;

                if (!cam.IsLiveViewOn) e.Graphics.Clear(BackColor);
                else
                {
                    lock (LvLock)
                    {
                        if (Evf_Bmp != null)
                        {
                            LVBratio = LVBw / (float)LVBh;
                            LVration = Evf_Bmp.Width / (float)Evf_Bmp.Height;
                            if (LVBratio < LVration)
                            {
                                w = LVBw;
                                h = (int)(LVBw / LVration);
                            }
                            else
                            {
                                w = (int)(LVBh * LVration);
                                h = LVBh;
                            }
                            Evf_Bmp = RotateImage(Evf_Bmp, 90);
                            e.Graphics.DrawImage(Evf_Bmp, 0, 0, w, h);
                        }
                    }
                }                
            };

        }

        #endregion

        #region Subroutines

        private void CloseSessions()
        {
            foreach (Camera cam in CamList) cam.CloseSession(); // zatvori sve sesije
            SettingsGroupBox.Enabled = false;
            LiveViewGroupBox.Enabled = false;
            SessionButton.Text = "Open Session";
            SessionLabel.Text = "No open session";
            LiveViewButton.Text = "Start LV";
        }

        private void RefreshCamera()
        {
            CameraListBox.Items.Clear();
            CamList = APIHandler.GetCameraList();
            foreach (Camera cam in CamList) CameraListBox.Items.Add(cam.DeviceName);
            // if (MainCamera?.SessionOpen == true) CameraListBox.SelectedIndex = CamList.FindIndex(t => t.ID == MainCamera.ID);
            //else if (CamList.Count > 0) CameraListBox.SelectedIndex = 0;
            // NE TREBA NAM SelectedIndex ?
        }

        private void OpenSessions()
        {
            foreach (Camera cam in CamList)
            {
                cam.OpenSession();
                cam.LiveViewUpdated += MainCamera_LiveViewUpdated;
                cam.ProgressChanged += MainCamera_ProgressChanged;
                cam.StateChanged += MainCamera_StateChanged;
                cam.DownloadReady += MainCamera_DownloadReady;

                SessionButton.Text = "Close Sessions";
                SessionLabel.Text = "Br. sesija:" + CamList.Count;
                SettingsGroupBox.Enabled = true;
                LiveViewGroupBox.Enabled = true;
            }
        }

        private void ReportError(string message, bool lockdown)
        {
            int errc;
            lock (ErrLock) { errc = ++ErrCount; }

            if (lockdown) EnableUI(false);

            if (errc < 4) MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (errc == 4) MessageBox.Show("Many errors happened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lock (ErrLock) { ErrCount--; }
        }

        private void EnableUI(bool enable)
        {
            if (InvokeRequired) Invoke((Action)delegate { EnableUI(enable); });
            else
            {
                SettingsGroupBox.Enabled = enable;
                InitGroupBox.Enabled = enable;
                LiveViewGroupBox.Enabled = enable;
            }
        }

        #endregion        
    }
}