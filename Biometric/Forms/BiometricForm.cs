using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometric.Forms
{
    public partial class BiometricForm : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer = new DPFP.Capture.Capture();
        public BiometricForm()
        {
            InitializeComponent();
        }
        #region Mga kods ko
        private Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample converter.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return RotateImage(bitmap, 180);
        }
        private Bitmap RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void DrawPicture(Bitmap bitmap)
        {
            FingerprintImage.Image = new Bitmap(bitmap, FingerprintImage.Size);
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
        }
        private void MakeReport(string message)
        {
            this.Invoke(new Action(() =>
            {
                StatusText.Text = message;
            }));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Capturer != null)
                {
                    Capturer.EventHandler = this;
                    MakeReport("Press start capture to start scanning");
                }
                else
                {
                    MakeReport("Cannot initiate capture operation");
                }
            }
            catch
            {
                MakeReport("Fingerprint reader was disconnected");
            }
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Fingerprint reader was connected");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Fingerprint reader was disconnected");
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Finger removed");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Fingerprint touched");
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("Fingerprint captured");
            Process(Sample);
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            {
                MakeReport("Good finger!");
            }
            else
            {
                MakeReport("Bad finger!");
            }
        }

        private void StartCapturing_Click(object sender, EventArgs e)
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StartCapture();
                    MakeReport("Fingerprint reader was connected");
                }
                catch
                {
                    MakeReport("Failed!");
                }
            }
        }

        #endregion

    }
}
