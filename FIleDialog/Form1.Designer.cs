namespace FIleDialog
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.saveBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.descriptionTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.descriptionOFD = new System.Windows.Forms.OpenFileDialog();
            this.descriptionSVD = new System.Windows.Forms.SaveFileDialog();
            this.pictureOFD = new System.Windows.Forms.OpenFileDialog();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(31, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(206, 32);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "EDIT INFORMATION";
            // 
            // openBtn
            // 
            this.openBtn.Animated = true;
            this.openBtn.AutoRoundedCorners = true;
            this.openBtn.BorderRadius = 22;
            this.openBtn.CheckedState.Parent = this.openBtn;
            this.openBtn.CustomImages.Parent = this.openBtn;
            this.openBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.openBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.openBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.HoverState.Parent = this.openBtn;
            this.openBtn.Location = new System.Drawing.Point(505, 299);
            this.openBtn.Name = "openBtn";
            this.openBtn.ShadowDecoration.Parent = this.openBtn;
            this.openBtn.Size = new System.Drawing.Size(110, 47);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "Open";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BorderRadius = 22;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.Green;
            this.saveBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Location = new System.Drawing.Point(505, 379);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(110, 47);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Animated = true;
            this.descriptionTxt.AutoRoundedCorners = true;
            this.descriptionTxt.BorderRadius = 84;
            this.descriptionTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTxt.DefaultText = "";
            this.descriptionTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTxt.DisabledState.Parent = this.descriptionTxt;
            this.descriptionTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTxt.FocusedState.Parent = this.descriptionTxt;
            this.descriptionTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.descriptionTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTxt.HoverState.Parent = this.descriptionTxt;
            this.descriptionTxt.Location = new System.Drawing.Point(148, 274);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.PasswordChar = '\0';
            this.descriptionTxt.PlaceholderText = "";
            this.descriptionTxt.SelectedText = "";
            this.descriptionTxt.ShadowDecoration.Parent = this.descriptionTxt;
            this.descriptionTxt.Size = new System.Drawing.Size(312, 171);
            this.descriptionTxt.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(31, 235);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(262, 32);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "ACCOUNT INFORMATION";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 299);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(108, 32);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "Description";
            // 
            // pictureBtn
            // 
            this.pictureBtn.Animated = true;
            this.pictureBtn.AutoRoundedCorners = true;
            this.pictureBtn.BorderRadius = 24;
            this.pictureBtn.CheckedState.Parent = this.pictureBtn;
            this.pictureBtn.CustomImages.Parent = this.pictureBtn;
            this.pictureBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.pictureBtn.ForeColor = System.Drawing.Color.White;
            this.pictureBtn.HoverState.Parent = this.pictureBtn;
            this.pictureBtn.Location = new System.Drawing.Point(226, 122);
            this.pictureBtn.Name = "pictureBtn";
            this.pictureBtn.ShadowDecoration.Parent = this.pictureBtn;
            this.pictureBtn.Size = new System.Drawing.Size(209, 50);
            this.pictureBtn.TabIndex = 7;
            this.pictureBtn.Text = "Choose Picture";
            this.pictureBtn.Click += new System.EventHandler(this.pictureBtn_Click);
            // 
            // descriptionOFD
            // 
            this.descriptionOFD.FileName = "descriptionOFD";
            // 
            // pictureOFD
            // 
            this.pictureOFD.FileName = "pictureOFD";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(240, 178);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(178, 23);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.Text = "Accepts only .PNG files";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::FIleDialog.Properties.Resources.photo_512;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(31, 70);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(176, 131);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(650, 452);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.pictureBtn);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(666, 491);
            this.MinimumSize = new System.Drawing.Size(666, 491);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton openBtn;
        private Guna.UI2.WinForms.Guna2GradientButton saveBtn;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2GradientButton pictureBtn;
        private System.Windows.Forms.OpenFileDialog descriptionOFD;
        private System.Windows.Forms.SaveFileDialog descriptionSVD;
        private System.Windows.Forms.OpenFileDialog pictureOFD;        
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}

