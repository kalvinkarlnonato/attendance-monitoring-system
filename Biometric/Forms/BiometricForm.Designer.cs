namespace Biometric.Forms
{
    partial class BiometricForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FingerprintImage = new System.Windows.Forms.PictureBox();
            this.StartCapturing = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FingerprintImage)).BeginInit();
            this.SuspendLayout();
            // 
            // FingerprintImage
            // 
            this.FingerprintImage.Location = new System.Drawing.Point(252, 36);
            this.FingerprintImage.Name = "FingerprintImage";
            this.FingerprintImage.Size = new System.Drawing.Size(299, 349);
            this.FingerprintImage.TabIndex = 7;
            this.FingerprintImage.TabStop = false;
            // 
            // StartCapturing
            // 
            this.StartCapturing.Location = new System.Drawing.Point(438, 391);
            this.StartCapturing.Name = "StartCapturing";
            this.StartCapturing.Size = new System.Drawing.Size(113, 23);
            this.StartCapturing.TabIndex = 9;
            this.StartCapturing.Text = "StartCapturing";
            this.StartCapturing.UseVisualStyleBackColor = true;
            this.StartCapturing.Click += new System.EventHandler(this.StartCapturing_Click);
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(249, 396);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(35, 13);
            this.StatusText.TabIndex = 8;
            this.StatusText.Text = "label1";
            // 
            // BiometricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FingerprintImage);
            this.Controls.Add(this.StartCapturing);
            this.Controls.Add(this.StatusText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BiometricForm";
            this.Text = "BiometricForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FingerprintImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FingerprintImage;
        private System.Windows.Forms.Button StartCapturing;
        private System.Windows.Forms.Label StatusText;
    }
}