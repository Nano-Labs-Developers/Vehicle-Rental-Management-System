namespace HotelTransportSystem.Login
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TileButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Forgot_PasswordDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TileButtonDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ForgotEmail_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.OTPCode_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.OTPCode_lbl = new System.Windows.Forms.Label();
            this.OPTSend_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Verify_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Cancel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.SuccessMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TileButton
            // 
            this.TileButton.BackColor = System.Drawing.Color.Transparent;
            this.TileButton.color = System.Drawing.Color.Transparent;
            this.TileButton.colorActive = System.Drawing.Color.Transparent;
            this.TileButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TileButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.TileButton.ForeColor = System.Drawing.Color.White;
            this.TileButton.Image = ((System.Drawing.Image)(resources.GetObject("TileButton.Image")));
            this.TileButton.ImagePosition = 20;
            this.TileButton.ImageZoom = 50;
            this.TileButton.LabelPosition = 0;
            this.TileButton.LabelText = "";
            this.TileButton.Location = new System.Drawing.Point(85, 18);
            this.TileButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TileButton.Name = "TileButton";
            this.TileButton.Size = new System.Drawing.Size(207, 160);
            this.TileButton.TabIndex = 1;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Email_lbl.Location = new System.Drawing.Point(35, 206);
            this.Email_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(61, 25);
            this.Email_lbl.TabIndex = 6;
            this.Email_lbl.Text = "Email";
            // 
            // Forgot_PasswordDragControl
            // 
            this.Forgot_PasswordDragControl.Fixed = true;
            this.Forgot_PasswordDragControl.Horizontal = true;
            this.Forgot_PasswordDragControl.TargetControl = this;
            this.Forgot_PasswordDragControl.Vertical = true;
            // 
            // TileButtonDragControl
            // 
            this.TileButtonDragControl.Fixed = true;
            this.TileButtonDragControl.Horizontal = true;
            this.TileButtonDragControl.TargetControl = this.TileButton;
            this.TileButtonDragControl.Vertical = true;
            // 
            // ForgotEmail_txt
            // 
            this.ForgotEmail_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ForgotEmail_txt.BorderColor = System.Drawing.Color.White;
            this.ForgotEmail_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ForgotEmail_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotEmail_txt.ForeColor = System.Drawing.Color.White;
            this.ForgotEmail_txt.Location = new System.Drawing.Point(40, 234);
            this.ForgotEmail_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ForgotEmail_txt.MaxLength = 999;
            this.ForgotEmail_txt.Multiline = true;
            this.ForgotEmail_txt.Name = "ForgotEmail_txt";
            this.ForgotEmail_txt.Size = new System.Drawing.Size(303, 36);
            this.ForgotEmail_txt.TabIndex = 10;
            this.ForgotEmail_txt.UseSystemPasswordChar = true;
            // 
            // OTPCode_txt
            // 
            this.OTPCode_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.OTPCode_txt.BorderColor = System.Drawing.Color.White;
            this.OTPCode_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OTPCode_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPCode_txt.ForeColor = System.Drawing.Color.White;
            this.OTPCode_txt.Location = new System.Drawing.Point(40, 370);
            this.OTPCode_txt.Margin = new System.Windows.Forms.Padding(4);
            this.OTPCode_txt.MaxLength = 999;
            this.OTPCode_txt.Multiline = true;
            this.OTPCode_txt.Name = "OTPCode_txt";
            this.OTPCode_txt.Size = new System.Drawing.Size(303, 36);
            this.OTPCode_txt.TabIndex = 11;
            this.OTPCode_txt.UseSystemPasswordChar = true;
            // 
            // OTPCode_lbl
            // 
            this.OTPCode_lbl.AutoSize = true;
            this.OTPCode_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPCode_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.OTPCode_lbl.Location = new System.Drawing.Point(35, 342);
            this.OTPCode_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OTPCode_lbl.Name = "OTPCode_lbl";
            this.OTPCode_lbl.Size = new System.Drawing.Size(102, 25);
            this.OTPCode_lbl.TabIndex = 12;
            this.OTPCode_lbl.Text = "OTP Code";
            // 
            // OPTSend_btn
            // 
            this.OPTSend_btn.Active = false;
            this.OPTSend_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.OPTSend_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.OPTSend_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OPTSend_btn.BorderRadius = 0;
            this.OPTSend_btn.ButtonText = "Send OTP";
            this.OPTSend_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OPTSend_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.OPTSend_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.OPTSend_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.OPTSend_btn.Iconimage = null;
            this.OPTSend_btn.Iconimage_right = null;
            this.OPTSend_btn.Iconimage_right_Selected = null;
            this.OPTSend_btn.Iconimage_Selected = null;
            this.OPTSend_btn.IconMarginLeft = 20;
            this.OPTSend_btn.IconMarginRight = 0;
            this.OPTSend_btn.IconRightVisible = true;
            this.OPTSend_btn.IconRightZoom = 0D;
            this.OPTSend_btn.IconVisible = false;
            this.OPTSend_btn.IconZoom = 60D;
            this.OPTSend_btn.IsTab = false;
            this.OPTSend_btn.Location = new System.Drawing.Point(119, 277);
            this.OPTSend_btn.Margin = new System.Windows.Forms.Padding(5);
            this.OPTSend_btn.Name = "OPTSend_btn";
            this.OPTSend_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.OPTSend_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.OPTSend_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.OPTSend_btn.selected = false;
            this.OPTSend_btn.Size = new System.Drawing.Size(123, 42);
            this.OPTSend_btn.TabIndex = 13;
            this.OPTSend_btn.Text = "Send OTP";
            this.OPTSend_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OPTSend_btn.Textcolor = System.Drawing.Color.White;
            this.OPTSend_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTSend_btn.Click += new System.EventHandler(this.OPTSend_btn_Click);
            // 
            // Verify_btn
            // 
            this.Verify_btn.Active = false;
            this.Verify_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Verify_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Verify_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Verify_btn.BorderRadius = 0;
            this.Verify_btn.ButtonText = "Verify";
            this.Verify_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Verify_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Verify_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Verify_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Verify_btn.Iconimage = null;
            this.Verify_btn.Iconimage_right = null;
            this.Verify_btn.Iconimage_right_Selected = null;
            this.Verify_btn.Iconimage_Selected = null;
            this.Verify_btn.IconMarginLeft = 20;
            this.Verify_btn.IconMarginRight = 0;
            this.Verify_btn.IconRightVisible = true;
            this.Verify_btn.IconRightZoom = 0D;
            this.Verify_btn.IconVisible = false;
            this.Verify_btn.IconZoom = 60D;
            this.Verify_btn.IsTab = false;
            this.Verify_btn.Location = new System.Drawing.Point(119, 414);
            this.Verify_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Verify_btn.Name = "Verify_btn";
            this.Verify_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Verify_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Verify_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Verify_btn.selected = false;
            this.Verify_btn.Size = new System.Drawing.Size(123, 42);
            this.Verify_btn.TabIndex = 14;
            this.Verify_btn.Text = "Verify";
            this.Verify_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Verify_btn.Textcolor = System.Drawing.Color.White;
            this.Verify_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verify_btn.Click += new System.EventHandler(this.Verify_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Active = false;
            this.Cancel_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Cancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel_btn.BorderRadius = 0;
            this.Cancel_btn.ButtonText = "Cancel";
            this.Cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Cancel_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Cancel_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Cancel_btn.Iconimage = null;
            this.Cancel_btn.Iconimage_right = null;
            this.Cancel_btn.Iconimage_right_Selected = null;
            this.Cancel_btn.Iconimage_Selected = null;
            this.Cancel_btn.IconMarginLeft = 20;
            this.Cancel_btn.IconMarginRight = 0;
            this.Cancel_btn.IconRightVisible = true;
            this.Cancel_btn.IconRightZoom = 0D;
            this.Cancel_btn.IconVisible = false;
            this.Cancel_btn.IconZoom = 60D;
            this.Cancel_btn.IsTab = false;
            this.Cancel_btn.Location = new System.Drawing.Point(245, 460);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Cancel_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Cancel_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Cancel_btn.selected = false;
            this.Cancel_btn.Size = new System.Drawing.Size(123, 42);
            this.Cancel_btn.TabIndex = 21;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_btn.Textcolor = System.Drawing.Color.White;
            this.Cancel_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.ContainerControl = this;
            this.ErrorMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorMessage.Icon")));
            // 
            // SuccessMessage
            // 
            this.SuccessMessage.ContainerControl = this;
            this.SuccessMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("SuccessMessage.Icon")));
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(384, 517);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Verify_btn);
            this.Controls.Add(this.OPTSend_btn);
            this.Controls.Add(this.OTPCode_lbl);
            this.Controls.Add(this.OTPCode_txt);
            this.Controls.Add(this.ForgotEmail_txt);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.TileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Forgot_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot_Password";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl Forgot_PasswordDragControl;
        private Bunifu.Framework.UI.BunifuDragControl TileButtonDragControl;
        protected Bunifu.Framework.UI.BunifuFlatButton OPTSend_btn;
        protected Bunifu.Framework.UI.BunifuTileButton TileButton;
        protected System.Windows.Forms.Label Email_lbl;
        protected System.Windows.Forms.Label OTPCode_lbl;
        protected Bunifu.Framework.BunifuCustomTextbox OTPCode_txt;
        protected Bunifu.Framework.BunifuCustomTextbox ForgotEmail_txt;
        protected Bunifu.Framework.UI.BunifuFlatButton Verify_btn;
        protected Bunifu.Framework.UI.BunifuFlatButton Cancel_btn;
        protected System.Windows.Forms.ErrorProvider ErrorMessage;
        protected System.Windows.Forms.ErrorProvider SuccessMessage;
    }
}