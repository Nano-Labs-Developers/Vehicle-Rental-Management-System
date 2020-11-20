namespace HotelTransportSystem.Login
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ResetPassword_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NewPassword_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.NewPassword_lbl = new System.Windows.Forms.Label();
            this.ConfirmPassword_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.ConfirmPassword_lbl = new System.Windows.Forms.Label();
            this.TileButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.Cancel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ResetPasswordDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TileButtonDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ResetPassword_btn
            // 
            this.ResetPassword_btn.Active = false;
            this.ResetPassword_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ResetPassword_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ResetPassword_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetPassword_btn.BorderRadius = 0;
            this.ResetPassword_btn.ButtonText = "Reset Password";
            this.ResetPassword_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPassword_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ResetPassword_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.ResetPassword_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.ResetPassword_btn.Iconimage = null;
            this.ResetPassword_btn.Iconimage_right = null;
            this.ResetPassword_btn.Iconimage_right_Selected = null;
            this.ResetPassword_btn.Iconimage_Selected = null;
            this.ResetPassword_btn.IconMarginLeft = 20;
            this.ResetPassword_btn.IconMarginRight = 0;
            this.ResetPassword_btn.IconRightVisible = true;
            this.ResetPassword_btn.IconRightZoom = 0D;
            this.ResetPassword_btn.IconVisible = false;
            this.ResetPassword_btn.IconZoom = 60D;
            this.ResetPassword_btn.IsTab = false;
            this.ResetPassword_btn.Location = new System.Drawing.Point(104, 371);
            this.ResetPassword_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ResetPassword_btn.Name = "ResetPassword_btn";
            this.ResetPassword_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ResetPassword_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ResetPassword_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.ResetPassword_btn.selected = false;
            this.ResetPassword_btn.Size = new System.Drawing.Size(171, 42);
            this.ResetPassword_btn.TabIndex = 16;
            this.ResetPassword_btn.Text = "Reset Password";
            this.ResetPassword_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetPassword_btn.Textcolor = System.Drawing.Color.White;
            this.ResetPassword_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassword_btn.Click += new System.EventHandler(this.ResetPassword_btn_Click);
            // 
            // NewPassword_txt
            // 
            this.NewPassword_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.NewPassword_txt.BorderColor = System.Drawing.Color.White;
            this.NewPassword_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NewPassword_txt.ForeColor = System.Drawing.Color.White;
            this.NewPassword_txt.Location = new System.Drawing.Point(44, 230);
            this.NewPassword_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPassword_txt.MaxLength = 999;
            this.NewPassword_txt.Name = "NewPassword_txt";
            this.NewPassword_txt.Size = new System.Drawing.Size(303, 31);
            this.NewPassword_txt.TabIndex = 15;
            this.NewPassword_txt.UseSystemPasswordChar = true;
            // 
            // NewPassword_lbl
            // 
            this.NewPassword_lbl.AutoSize = true;
            this.NewPassword_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.NewPassword_lbl.Location = new System.Drawing.Point(39, 202);
            this.NewPassword_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewPassword_lbl.Name = "NewPassword_lbl";
            this.NewPassword_lbl.Size = new System.Drawing.Size(145, 25);
            this.NewPassword_lbl.TabIndex = 14;
            this.NewPassword_lbl.Text = "New Password";
            // 
            // ConfirmPassword_txt
            // 
            this.ConfirmPassword_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ConfirmPassword_txt.BorderColor = System.Drawing.Color.White;
            this.ConfirmPassword_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ConfirmPassword_txt.ForeColor = System.Drawing.Color.White;
            this.ConfirmPassword_txt.Location = new System.Drawing.Point(44, 316);
            this.ConfirmPassword_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmPassword_txt.MaxLength = 999;
            this.ConfirmPassword_txt.Name = "ConfirmPassword_txt";
            this.ConfirmPassword_txt.Size = new System.Drawing.Size(303, 31);
            this.ConfirmPassword_txt.TabIndex = 17;
            this.ConfirmPassword_txt.UseSystemPasswordChar = true;
            // 
            // ConfirmPassword_lbl
            // 
            this.ConfirmPassword_lbl.AutoSize = true;
            this.ConfirmPassword_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.ConfirmPassword_lbl.Location = new System.Drawing.Point(39, 288);
            this.ConfirmPassword_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmPassword_lbl.Name = "ConfirmPassword_lbl";
            this.ConfirmPassword_lbl.Size = new System.Drawing.Size(175, 25);
            this.ConfirmPassword_lbl.TabIndex = 18;
            this.ConfirmPassword_lbl.Text = "Confirm Password";
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
            this.TileButton.Location = new System.Drawing.Point(91, 18);
            this.TileButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TileButton.Name = "TileButton";
            this.TileButton.Size = new System.Drawing.Size(207, 160);
            this.TileButton.TabIndex = 19;
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
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Cancel_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Cancel_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Cancel_btn.selected = false;
            this.Cancel_btn.Size = new System.Drawing.Size(123, 42);
            this.Cancel_btn.TabIndex = 20;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel_btn.Textcolor = System.Drawing.Color.White;
            this.Cancel_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // ResetPasswordDragControl
            // 
            this.ResetPasswordDragControl.Fixed = true;
            this.ResetPasswordDragControl.Horizontal = true;
            this.ResetPasswordDragControl.TargetControl = this;
            this.ResetPasswordDragControl.Vertical = true;
            // 
            // TileButtonDragControl
            // 
            this.TileButtonDragControl.Fixed = true;
            this.TileButtonDragControl.Horizontal = true;
            this.TileButtonDragControl.TargetControl = this.TileButton;
            this.TileButtonDragControl.Vertical = true;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(384, 517);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.TileButton);
            this.Controls.Add(this.ConfirmPassword_lbl);
            this.Controls.Add(this.ConfirmPassword_txt);
            this.Controls.Add(this.ResetPassword_btn);
            this.Controls.Add(this.NewPassword_txt);
            this.Controls.Add(this.NewPassword_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl ResetPasswordDragControl;
        private Bunifu.Framework.UI.BunifuDragControl TileButtonDragControl;
        protected Bunifu.Framework.UI.BunifuFlatButton ResetPassword_btn;
        protected Bunifu.Framework.BunifuCustomTextbox NewPassword_txt;
        protected System.Windows.Forms.Label NewPassword_lbl;
        protected System.Windows.Forms.Label ConfirmPassword_lbl;
        protected Bunifu.Framework.BunifuCustomTextbox ConfirmPassword_txt;
        protected Bunifu.Framework.UI.BunifuTileButton TileButton;
        protected Bunifu.Framework.UI.BunifuFlatButton Cancel_btn;
    }
}