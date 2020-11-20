namespace HotelTransportSystem.Return
{
    partial class ReturnPayUserController
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainMenuHeader_pnl = new System.Windows.Forms.Panel();
            this.MainMenu_lbl = new System.Windows.Forms.Label();
            this.MainMenuMinimize_btn = new System.Windows.Forms.Button();
            this.MainMenuMaximize_btn = new System.Windows.Forms.Button();
            this.MainMenuClose_btn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MainFill_panel = new System.Windows.Forms.Panel();
            this.payHire1 = new HotelTransportSystem.Hire_and_Rent.PayHire.PayHire();
            this.rent1 = new HotelTransportSystem.Hire_and_Rent.Rent();
            this.hire1 = new HotelTransportSystem.Hire_and_Rent.Hire();
            this.MainMenuHeader_pnl.SuspendLayout();
            this.MainFill_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MainMenuHeader_pnl
            // 
            this.MainMenuHeader_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.MainMenuHeader_pnl.Controls.Add(this.MainMenu_lbl);
            this.MainMenuHeader_pnl.Controls.Add(this.MainMenuMinimize_btn);
            this.MainMenuHeader_pnl.Controls.Add(this.MainMenuMaximize_btn);
            this.MainMenuHeader_pnl.Controls.Add(this.MainMenuClose_btn);
            this.MainMenuHeader_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuHeader_pnl.Location = new System.Drawing.Point(0, 0);
            this.MainMenuHeader_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuHeader_pnl.Name = "MainMenuHeader_pnl";
            this.MainMenuHeader_pnl.Size = new System.Drawing.Size(1236, 26);
            this.MainMenuHeader_pnl.TabIndex = 4;
            // 
            // MainMenu_lbl
            // 
            this.MainMenu_lbl.AutoSize = true;
            this.MainMenu_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_lbl.ForeColor = System.Drawing.Color.White;
            this.MainMenu_lbl.Location = new System.Drawing.Point(4, 1);
            this.MainMenu_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainMenu_lbl.Name = "MainMenu_lbl";
            this.MainMenu_lbl.Size = new System.Drawing.Size(107, 25);
            this.MainMenu_lbl.TabIndex = 0;
            this.MainMenu_lbl.Text = "PAYMENT";
            // 
            // MainMenuMinimize_btn
            // 
            this.MainMenuMinimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuMinimize_btn.BackgroundImage = global::HotelTransportSystem.Properties.Resources.icons8_new_moon_50px_2;
            this.MainMenuMinimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenuMinimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuMinimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainMenuMinimize_btn.FlatAppearance.BorderSize = 0;
            this.MainMenuMinimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MainMenuMinimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MainMenuMinimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuMinimize_btn.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuMinimize_btn.Location = new System.Drawing.Point(1128, 0);
            this.MainMenuMinimize_btn.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuMinimize_btn.Name = "MainMenuMinimize_btn";
            this.MainMenuMinimize_btn.Size = new System.Drawing.Size(36, 26);
            this.MainMenuMinimize_btn.TabIndex = 3;
            this.MainMenuMinimize_btn.Tag = "Minimize";
            this.MainMenuMinimize_btn.UseVisualStyleBackColor = false;
            this.MainMenuMinimize_btn.Click += new System.EventHandler(this.MainMenuMinimize_btn_Click);
            // 
            // MainMenuMaximize_btn
            // 
            this.MainMenuMaximize_btn.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuMaximize_btn.BackgroundImage = global::HotelTransportSystem.Properties.Resources.icons8_new_moon_50px_3;
            this.MainMenuMaximize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenuMaximize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuMaximize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainMenuMaximize_btn.FlatAppearance.BorderSize = 0;
            this.MainMenuMaximize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MainMenuMaximize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MainMenuMaximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuMaximize_btn.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuMaximize_btn.Location = new System.Drawing.Point(1164, 0);
            this.MainMenuMaximize_btn.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuMaximize_btn.Name = "MainMenuMaximize_btn";
            this.MainMenuMaximize_btn.Size = new System.Drawing.Size(36, 26);
            this.MainMenuMaximize_btn.TabIndex = 2;
            this.MainMenuMaximize_btn.UseVisualStyleBackColor = false;
            this.MainMenuMaximize_btn.Click += new System.EventHandler(this.MainMenuMaximize_btn_Click);
            // 
            // MainMenuClose_btn
            // 
            this.MainMenuClose_btn.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuClose_btn.BackgroundImage = global::HotelTransportSystem.Properties.Resources.icons8_new_moon_50px_4;
            this.MainMenuClose_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenuClose_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuClose_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainMenuClose_btn.FlatAppearance.BorderSize = 0;
            this.MainMenuClose_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MainMenuClose_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MainMenuClose_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuClose_btn.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuClose_btn.Location = new System.Drawing.Point(1200, 0);
            this.MainMenuClose_btn.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuClose_btn.Name = "MainMenuClose_btn";
            this.MainMenuClose_btn.Size = new System.Drawing.Size(36, 26);
            this.MainMenuClose_btn.TabIndex = 1;
            this.MainMenuClose_btn.UseVisualStyleBackColor = false;
            this.MainMenuClose_btn.Click += new System.EventHandler(this.MainMenuClose_btn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.MainMenu_lbl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.MainMenuHeader_pnl;
            this.bunifuDragControl2.Vertical = true;
            // 
            // MainFill_panel
            // 
            this.MainFill_panel.Controls.Add(this.payHire1);
            this.MainFill_panel.Controls.Add(this.rent1);
            this.MainFill_panel.Controls.Add(this.hire1);
            this.MainFill_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFill_panel.Location = new System.Drawing.Point(0, 26);
            this.MainFill_panel.Name = "MainFill_panel";
            this.MainFill_panel.Size = new System.Drawing.Size(1236, 776);
            this.MainFill_panel.TabIndex = 5;
            // 
            // payHire1
            // 
            this.payHire1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.payHire1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payHire1.Location = new System.Drawing.Point(0, 0);
            this.payHire1.Name = "payHire1";
            this.payHire1.Size = new System.Drawing.Size(1236, 776);
            this.payHire1.TabIndex = 2;
            // 
            // rent1
            // 
            this.rent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.rent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rent1.Location = new System.Drawing.Point(0, 0);
            this.rent1.Name = "rent1";
            this.rent1.Size = new System.Drawing.Size(1236, 776);
            this.rent1.TabIndex = 1;
            // 
            // hire1
            // 
            this.hire1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.hire1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hire1.Location = new System.Drawing.Point(0, 0);
            this.hire1.Name = "hire1";
            this.hire1.Size = new System.Drawing.Size(1236, 776);
            this.hire1.TabIndex = 0;
            // 
            // ReturnPayUserController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1236, 802);
            this.Controls.Add(this.MainFill_panel);
            this.Controls.Add(this.MainMenuHeader_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnPayUserController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnPayUserController";
            this.Load += new System.EventHandler(this.ReturnPayUserController_Load);
            this.MainMenuHeader_pnl.ResumeLayout(false);
            this.MainMenuHeader_pnl.PerformLayout();
            this.MainFill_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel MainMenuHeader_pnl;
        private System.Windows.Forms.Label MainMenu_lbl;
        private System.Windows.Forms.Button MainMenuMinimize_btn;
        private System.Windows.Forms.Button MainMenuMaximize_btn;
        private System.Windows.Forms.Button MainMenuClose_btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel MainFill_panel;
        private Hire_and_Rent.Rent rent1;
        private Hire_and_Rent.Hire hire1;
        private Hire_and_Rent.PayHire.PayHire payHire1;
    }
}