using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace BarCodeTyper
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private string lastmessage = string.Empty;
        private Point point1 = new Point(0, 0);
        private Point point2 = new Point(0, 0);
        private Point point3 = new Point(0, 0);
        private Point point4 = new Point(0, 0);
        private string ultimaChaveLida = string.Empty;
        private bool ultimoStatusSucesso = false;
        private string ultimaMensagem = string.Empty;


        public Form1()
        {
            InitializeComponent();

            BuscaCamerasInstaladas();

            Oklabel.Parent = pictureBoxSource;

            Oklabel.Visible = false;

        }

        private void BuscaCamerasInstaladas()
        {
            comboBoxCameraSource.Items.Clear();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCameraSource.Items.Add(device.Name);
            }
            if (comboBoxCameraSource.Items.Count < 1)
            {
                //Nenhuma camera conectada
                Start.Enabled = false;

            }
            else
            {
                comboBoxCameraSource.SelectedIndex = comboBoxCameraSource.Items.Count - 1;
                videoSource = new VideoCaptureDevice();
                Start.Enabled = true;
            }
        }

        private async Task ClearFoundQRCode()
        {
            await Task.Delay(800);
            Oklabel.Visible = false;
            lblUltimoStatus.Text = "";
            point1 = new Point(0, 0);
            point2 = new Point(0, 0);
            point3 = new Point(0, 0);
            point4 = new Point(0, 0);

            Oklabel.Update();
        }

       

        private void CloseCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.NewFrame -= new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.SignalToStop();

                videoSource = null;
            }
        }

        private void StartCamera()
        {
            if (DesignMode)
                return;

            if (cbResolutions.SelectedIndex == -1 || comboBoxCameraSource.SelectedIndex == -1)
            {
                CloseSettingsMenu();
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {

                videoSource.NewFrame -= new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Stop();
                videoSource = null;
            }

            videoSource = new VideoCaptureDevice(videoDevices[comboBoxCameraSource.SelectedIndex].MonikerString);
            videoSource.VideoResolution = videoSource.VideoCapabilities[cbResolutions.SelectedIndex];
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();

            Thread.Sleep(200);

            CloseSettingsMenu();
        }

        private void CloseSettingsMenu()
        {
            EscolhaCameraPanel.Visible = false;
            EscolhaCameraPanel.Update();
            panelMenuCamera.Visible = false;
            pnlSettings.Visible = false;
            panelMenuCamera.Update();
        }

        private void ChangeStatusNoMessage()
        {
            ShowOnCameraMessage(string.Empty, Color.FromArgb(56, 199, 42));
        }
        private void ChangeStatusOk()
        {
            ultimoStatusSucesso = true;
            ShowOnCameraMessage("OK", Color.FromArgb(56, 199, 42));
        }

        private void ShowOnCameraMessage(string message, Color testfontColor)
        {
            Oklabel.ForeColor = testfontColor;
            Oklabel.Text = message;
            Oklabel.Visible = true;
            Oklabel.Update();

            Task ignoredAwaitableResult = this.ClearFoundQRCode();
        }

        private void ChangeStatusError()
        {
            ultimoStatusSucesso = false;
            ShowOnCameraMessage("OK", Color.FromArgb(255, 30, 0));
        }

        private int frameSkipCount = 0;

        private int CounterSameCode = 0;

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (frameSkipCount > 30)
                {
                    frameSkipCount = 0;
                    return;
                }
                frameSkipCount++;

                if (videoSource == null)
                    return;

                pictureBoxSource.Invoke((MethodInvoker)delegate
                {
                    Bitmap image = new Bitmap(eventArgs.Frame);

                    ////image = AdjustContrast(MakeGrayscale3(image), 1.50f);
                    //if (Management.Settings.InvertCameraX && Management.Settings.InvertCameraY)
                    //    image.RotateFlip(RotateFlipType.Rotate180FlipXY);
                    //else if (Management.Settings.InvertCameraX)
                    //    image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    //else if (Management.Settings.InvertCameraY)
                    //    image.RotateFlip(RotateFlipType.Rotate180FlipY);

                    pictureBoxSource.BackgroundImage = image;

                    pictureBoxSource.BackgroundImageLayout = ImageLayout.Stretch;

                    if (image != null)
                    {
                        var message = ExtractQRCodeMessageFromImage((MakeGrayscale3(image)));// AdjustContrast(MakeGrayscale3(image),3.00f));

                        if (message != null)
                        {
                            if (lastmessage != message)
                            {

                                var status = string.Empty;

                                var nf = GetData(message,tbAfterString.Text,tbBeforeString.Text);

                            if (nf != null)
                                if (ultimaChaveLida == nf)
                                {
                                    if (ultimoStatusSucesso)
                                    {

                                        Oklabel.Invoke((Action)ChangeStatusOk);

                                    }
                                    else
                                    {
                                        lblUltimoStatus.Invoke((MethodInvoker)delegate { lblUltimoStatus.Text = ultimaMensagem; });
                                        Oklabel.Invoke((Action)ChangeStatusError);

                                    }

                                    return;
                                }

                            lblUltimoStatus.Invoke((MethodInvoker)delegate { lblUltimoStatus.Text = status; });

                                if (nf == null)
                                {
                                    if (Oklabel.Visible == false)
                                    {
                                        ultimaMensagem = status;
                                        Oklabel.Invoke((Action)ChangeStatusError);
                                       
                                    }
                                }
                                else
                                {
                                    ultimaChaveLida = nf;

                                    if (status != string.Empty)
                                    {
                                        lblUltimoStatus.Invoke((MethodInvoker)delegate { lblUltimoStatus.Text = status; });

                                    }
                                    SendData(nf);
                                   
                                }
                           }
                           else
                            {
                                CounterSameCode++;
                                if (CounterSameCode > 100)
                                {
                                    CounterSameCode = 0;
                                    lastmessage = string.Empty;
                                }
                               if (Oklabel.Visible == false)
                                    Oklabel.Invoke((Action)ChangeStatusOk);
                           }

                        }
                    }
                   // GC.Collect();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //new ExceptionFileHandler().CreateCrashFile(ex.ToString());
                CloseCamera();
                Application.Exit();
            }
        }

        private string GetData( string qrInfo, string BeginsWith, string EndsWith)
        {
            //try
            //{
                var data = Regex.Match(qrInfo, $"{BeginsWith}(.*){EndsWith}");
                if (data.Success && data.Groups.Count >0)
                    return data.Groups[0].Value;
                return string.Empty;
                //return qrInfo.ToLowerInvariant().Split(new[] { BeginsWith.ToLowerInvariant() }, StringSplitOptions.RemoveEmptyEntries)[1]
                //                    .Split(new[] { EndsWith.ToLowerInvariant() }, StringSplitOptions.RemoveEmptyEntries)[0];
            //}
            //catch
            //{
            //    return string.Empty;
            //}
        }

        public static Bitmap MakeGrayscale3(Bitmap original)
        {

            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = filter.Apply(original);

            return grayImage;
        }

        private string ExtractQRCodeMessageFromImage(Bitmap bitmap)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader
                    (null, newbitmap => new BitmapLuminanceSource(bitmap), luminance => new GlobalHistogramBinarizer(luminance));

                reader.TryInverted = false;
                reader.Options = new DecodingOptions { TryHarder = true, PossibleFormats = new List<BarcodeFormat>() { BarcodeFormat.QR_CODE } };
                reader.AutoRotate = false;


                //var result = reader.Decode(bitmap);

                //if(result == null)
                var result = reader.Decode(bitmap);

                if (result != null)
                {
                    if (result.ResultPoints.Count() > 3)
                    {
                        point1 = new Point(((int)result.ResultPoints[0].X * pictureBoxSource.Width) / bitmap.Width, ((int)result.ResultPoints[0].Y * pictureBoxSource.Height) / bitmap.Height);
                        point2 = new Point(((int)result.ResultPoints[1].X * pictureBoxSource.Width) / bitmap.Width, ((int)result.ResultPoints[1].Y * pictureBoxSource.Height) / bitmap.Height);
                        point3 = new Point(((int)result.ResultPoints[2].X * pictureBoxSource.Width) / bitmap.Width, ((int)result.ResultPoints[2].Y * pictureBoxSource.Height) / bitmap.Height);
                        point4 = new Point(((int)result.ResultPoints[3].X * pictureBoxSource.Width) / bitmap.Width, ((int)result.ResultPoints[3].Y * pictureBoxSource.Height) / bitmap.Height);

                    }

                    return result.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }

        private void SendData(string data)
        {
           
            SendKeys.SendWait(string.Concat(data,tbAfterTextSend.Text));
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            CloseCamera();

            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void comboBoxCameraSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbResolutions.Items.Clear();
            videoSource = new VideoCaptureDevice(videoDevices[comboBoxCameraSource.SelectedIndex].MonikerString);
            foreach (var reso in videoSource.VideoCapabilities)
            {
                cbResolutions.Items.Add($"{reso.FrameSize.Width}x{reso.FrameSize.Height} - {reso.FrameRate}fps");
            }
            if (cbResolutions.Items.Count > 0)
                cbResolutions.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSource_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Oklabel.ForeColor, 6);
            
            // Draw line to screen.
            if (point1.X != 0)
            {
                e.Graphics.DrawLine(pen, point1, point2);
                e.Graphics.DrawLine(pen, point2, point3);
                e.Graphics.DrawLine(pen, point3, point4);
                e.Graphics.DrawLine(pen, point4, point1);
                CentralizarLabelOK();
                pictureBoxSource.Update();
            }
        }

        private void CentralizarLabelOK()
        {
            var pointXs = point1.X;
            var pointXg = point1.X;
            if (pointXs > point2.X)
                pointXs = point2.X;
            else if (pointXg < point2.X)
                pointXg = point2.X;

            if (pointXs > point3.X)
                pointXs = point3.X;
            else if (pointXg < point3.X)
                pointXg = point3.X;

            if (pointXs > point4.X)
                pointXs = point4.X;
            else if (pointXg < point4.X)
                pointXg = point4.X;

            var pointYs = point1.Y;
            var pointYg = point1.Y;
            if (pointYs > point2.Y)
                pointYs = point2.Y;
            else if (pointYg < point2.Y)
                pointYg = point2.Y;

            if (pointYs > point3.Y)
                pointYs = point3.Y;
            else if (pointYg < point3.Y)
                pointYg = point3.Y;

            if (pointYs > point4.Y)
                pointYs = point4.Y;
            else if (pointYg < point4.Y)
                pointYg = point4.Y;

            Oklabel.Location = new Point(((pointXs + pointXg) / 2) - (Oklabel.Width / 2), ((pointYs + pointYg) / 2) - (Oklabel.Height / 2));


            Oklabel.Update();
        }

        private void panelMenuCamera_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void pictureBoxSource_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void MoveForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void cameraconfigbtn_Click(object sender, EventArgs e)
        {
            CloseSettingsMenu();
        }
    }
}
