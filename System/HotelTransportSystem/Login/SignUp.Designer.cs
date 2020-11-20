namespace HotelTransportSystem.Login
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Username_lbl = new System.Windows.Forms.Label();
            this.LoginUsername_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPassword_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.Signup_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Signin_lbl = new System.Windows.Forms.LinkLabel();
            this.TileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Exit_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SignUpDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TileButton1DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Email_lbl = new System.Windows.Forms.Label();
            this.LoginEmail_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.ErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Username_lbl.Location = new System.Drawing.Point(28, 191);
            this.Username_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(103, 25);
            this.Username_lbl.TabIndex = 6;
            this.Username_lbl.Text = "Username";
            // 
            // LoginUsername_txt
            // 
            this.LoginUsername_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.LoginUsername_txt.BorderColor = System.Drawing.Color.White;
            this.LoginUsername_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginUsername_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsername_txt.ForeColor = System.Drawing.Color.White;
            this.LoginUsername_txt.Location = new System.Drawing.Point(33, 219);
            this.LoginUsername_txt.Margin = new System.Windows.Forms.Padding(4);
            this.LoginUsername_txt.MaxLength = 999;
            this.LoginUsername_txt.Multiline = true;
            this.LoginUsername_txt.Name = "LoginUsername_txt";
            this.LoginUsername_txt.Size = new System.Drawing.Size(303, 36);
            this.LoginUsername_txt.TabIndex = 7;
            this.LoginUsername_txt.Leave += new System.EventHandler(this.LoginUsername_txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(28, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // LoginPassword_txt
            // 
            this.LoginPassword_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.LoginPassword_txt.BorderColor = System.Drawing.Color.White;
            this.LoginPassword_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword_txt.ForeColor = System.Drawing.Color.White;
            this.LoginPassword_txt.Location = new System.Drawing.Point(33, 385);
            this.LoginPassword_txt.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPassword_txt.MaxLength = 999;
            this.LoginPassword_txt.Multiline = true;
            this.LoginPassword_txt.Name = "LoginPassword_txt";
            this.LoginPassword_txt.Size = new System.Drawing.Size(303, 36);
            this.LoginPassword_txt.TabIndex = 9;
            this.LoginPassword_txt.UseSystemPasswordChar = true;
            // 
            // Signup_btn
            // 
            this.Signup_btn.Active = false;
            this.Signup_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Signup_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Signup_btn.BorderRadius = 0;
            this.Signup_btn.ButtonText = "Sign Up";
            this.Signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Signup_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Signup_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Signup_btn.Iconimage = null;
            this.Signup_btn.Iconimage_right = null;
            this.Signup_btn.Iconimage_right_Selected = null;
            this.Signup_btn.Iconimage_Selected = null;
            this.Signup_btn.IconMarginLeft = 20;
            this.Signup_btn.IconMarginRight = 0;
            this.Signup_btn.IconRightVisible = true;
            this.Signup_btn.IconRightZoom = 0D;
            this.Signup_btn.IconVisible = false;
            this.Signup_btn.IconZoom = 60D;
            this.Signup_btn.IsTab = false;
            this.Signup_btn.Location = new System.Drawing.Point(125, 432);
            this.Signup_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Signup_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Signup_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Signup_btn.selected = false;
            this.Signup_btn.Size = new System.Drawing.Size(123, 42);
            this.Signup_btn.TabIndex = 11;
            this.Signup_btn.Text = "Sign Up";
            this.Signup_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Signup_btn.Textcolor = System.Drawing.Color.White;
            this.Signup_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // Signin_lbl
            // 
            this.Signin_lbl.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.Signin_lbl.AutoSize = true;
            this.Signin_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Signin_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signin_lbl.DisabledLinkColor = System.Drawing.Color.DarkGray;
            this.Signin_lbl.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Signin_lbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Signin_lbl.LinkColor = System.Drawing.Color.DarkGray;
            this.Signin_lbl.Location = new System.Drawing.Point(160, 513);
            this.Signin_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Signin_lbl.Name = "Signin_lbl";
            this.Signin_lbl.Size = new System.Drawing.Size(176, 22);
            this.Signin_lbl.TabIndex = 12;
            this.Signin_lbl.TabStop = true;
            this.Signin_lbl.Text = "Already have account";
            this.Signin_lbl.VisitedLinkColor = System.Drawing.Color.DarkGray;
            this.Signin_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signin_lbl_LinkClicked);
            // 
            // TileButton1
            // 
            this.TileButton1.BackColor = System.Drawing.Color.Transparent;
            this.TileButton1.color = System.Drawing.Color.Transparent;
            this.TileButton1.colorActive = System.Drawing.Color.Transparent;
            this.TileButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.TileButton1.ForeColor = System.Drawing.Color.White;
            this.TileButton1.Image = ((System.Drawing.Image)(resources.GetObject("TileButton1.Image")));
            this.TileButton1.ImagePosition = 20;
            this.TileButton1.ImageZoom = 50;
            this.TileButton1.LabelPosition = 0;
            this.TileButton1.LabelText = "";
            this.TileButton1.Location = new System.Drawing.Point(80, 18);
            this.TileButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TileButton1.Name = "TileButton1";
            this.TileButton1.Size = new System.Drawing.Size(207, 160);
            this.TileButton1.TabIndex = 1;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Active = false;
            this.Exit_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Exit_btn.BackgroundImage = global::HotelTransportSystem.Properties.Resources.icons8_delete_127px_2;
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_btn.BorderRadius = 0;
            this.Exit_btn.ButtonText = "";
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Exit_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Exit_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit_btn.Iconimage = null;
            this.Exit_btn.Iconimage_right = null;
            this.Exit_btn.Iconimage_right_Selected = null;
            this.Exit_btn.Iconimage_Selected = null;
            this.Exit_btn.IconMarginLeft = 0;
            this.Exit_btn.IconMarginRight = 0;
            this.Exit_btn.IconRightVisible = true;
            this.Exit_btn.IconRightZoom = 0D;
            this.Exit_btn.IconVisible = true;
            this.Exit_btn.IconZoom = 30D;
            this.Exit_btn.IsTab = false;
            this.Exit_btn.Location = new System.Drawing.Point(336, 15);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Exit_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Exit_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit_btn.selected = false;
            this.Exit_btn.Size = new System.Drawing.Size(20, 23);
            this.Exit_btn.TabIndex = 13;
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_btn.Textcolor = System.Drawing.Color.White;
            this.Exit_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // SignUpDragControl
            // 
            this.SignUpDragControl.Fixed = true;
            this.SignUpDragControl.Horizontal = true;
            this.SignUpDragControl.TargetControl = this;
            this.SignUpDragControl.Vertical = true;
            // 
            // TileButton1DragControl
            // 
            this.TileButton1DragControl.Fixed = true;
            this.TileButton1DragControl.Horizontal = true;
            this.TileButton1DragControl.TargetControl = this.TileButton1;
            this.TileButton1DragControl.Vertical = true;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Email_lbl.Location = new System.Drawing.Point(28, 272);
            this.Email_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(61, 25);
            this.Email_lbl.TabIndex = 8;
            this.Email_lbl.Text = "Email";
            // 
            // LoginEmail_txt
            // 
            this.LoginEmail_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.LoginEmail_txt.BorderColor = System.Drawing.Color.White;
            this.LoginEmail_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginEmail_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmail_txt.ForeColor = System.Drawing.Color.White;
            this.LoginEmail_txt.Location = new System.Drawing.Point(33, 300);
            this.LoginEmail_txt.Margin = new System.Windows.Forms.Padding(4);
            this.LoginEmail_txt.MaxLength = 999;
            this.LoginEmail_txt.Multiline = true;
            this.LoginEmail_txt.Name = "LoginEmail_txt";
            this.LoginEmail_txt.Size = new System.Drawing.Size(303, 36);
            this.LoginEmail_txt.TabIndex = 9;
            this.LoginEmail_txt.UseSystemPasswordChar = true;
            this.LoginEmail_txt.Leave += new System.EventHandler(this.LoginEmail_txt_Leave);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.ContainerControl = this;
            this.ErrorMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorMessage.Icon")));
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(372, 550);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Signin_lbl);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.LoginEmail_txt);
            this.Controls.Add(this.LoginPassword_txt);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginUsername_txt);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.TileButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton TileButton1;
        private System.Windows.Forms.Label Username_lbl;
        protected internal Bunifu.Framework.BunifuCustomTextbox LoginUsername_txt;
        private System.Windows.Forms.Label label1;
        protected internal Bunifu.Framework.BunifuCustomTextbox LoginPassword_txt;
        protected internal Bunifu.Framework.UI.BunifuFlatButton Signup_btn;
        protected internal System.Windows.Forms.LinkLabel Signin_lbl;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_btn;
        private Bunifu.Framework.UI.BunifuDragControl SignUpDragControl;
        private Bunifu.Framework.UI.BunifuDragControl TileButton1DragControl;
        protected internal Bunifu.Framework.BunifuCustomTextbox LoginEmail_txt;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.ErrorProvider ErrorMessage;
    }
}