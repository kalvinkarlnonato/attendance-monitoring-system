using Biometric.Forms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometric
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 50);
            leftPanel.Controls.Add(leftBorderButton);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }
        #region UI Design
        //Fields
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;
        //Structure
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(53,216,59);
            public static Color color2 = Color.FromArgb(250,84,127);
            public static Color color3 = Color.FromArgb(50,202,210);
            public static Color color4 = Color.FromArgb(249,88,155);
        }
        //Methods
        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButton();
                //Button
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
                //Icon current child form
                currentChildIcon.IconChar = currentButton.IconChar;
                currentChildIcon.IconColor = color;
            }
        }
        //Function
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(93, 106, 240);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
            currentChildIcon.IconChar = IconChar.Home;
            currentChildIcon.IconColor = Color.DarkSlateBlue;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            currentChildLabel.Text = childForm.Text;
        }
        #endregion

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new DashboardForm());
        }

        private void biometricButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new BiometricForm());
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildLabel.Text = "Home";
            }
            Reset();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

