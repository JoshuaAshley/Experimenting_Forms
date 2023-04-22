namespace Expertimenting_With_Forms
{
    partial class ImageTesting
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
            btnDisplay = new Button();
            btnChooseImage = new Button();
            picbPicture = new PictureBox();
            btnCloseImage = new Button();
            ((System.ComponentModel.ISupportInitialize)picbPicture).BeginInit();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(266, 577);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(268, 36);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display Image";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(266, 23);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(268, 36);
            btnChooseImage.TabIndex = 1;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // picbPicture
            // 
            picbPicture.Location = new Point(12, 65);
            picbPicture.Name = "picbPicture";
            picbPicture.Size = new Size(776, 506);
            picbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            picbPicture.TabIndex = 2;
            picbPicture.TabStop = false;
            // 
            // btnCloseImage
            // 
            btnCloseImage.Location = new Point(703, 577);
            btnCloseImage.Name = "btnCloseImage";
            btnCloseImage.Size = new Size(85, 36);
            btnCloseImage.TabIndex = 3;
            btnCloseImage.Text = "Close Image";
            btnCloseImage.UseVisualStyleBackColor = true;
            btnCloseImage.Click += btnCloseImage_Click;
            // 
            // ImageTesting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(btnCloseImage);
            Controls.Add(picbPicture);
            Controls.Add(btnChooseImage);
            Controls.Add(btnDisplay);
            Name = "ImageTesting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Testing";
            ((System.ComponentModel.ISupportInitialize)picbPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
        private Button btnChooseImage;
        private PictureBox picbPicture;
        private Button btnCloseImage;
    }
}