namespace HotelTransportSystem.Return
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.CustomerNIC_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Search_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Hire_btn = new System.Windows.Forms.RadioButton();
            this.Rent_btn = new System.Windows.Forms.RadioButton();
            this.MainMenuHeader_pnl = new System.Windows.Forms.Panel();
            this.MainMenu_lbl = new System.Windows.Forms.Label();
            this.MainMenuMinimize_btn = new System.Windows.Forms.Button();
            this.MainMenuMaximize_btn = new System.Windows.Forms.Button();
            this.MainMenuClose_btn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.CustomerDetails_groupBox = new System.Windows.Forms.GroupBox();
            this.Next_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AddNew_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Clear_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CustomerName_lbl = new System.Windows.Forms.Label();
            this.CustomerName_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CustomerTelNo_lbl = new System.Windows.Forms.Label();
            this.CustomerAddress_lbl = new System.Windows.Forms.Label();
            this.CustomerTelNo_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CustomerNIC_lbl = new System.Windows.Forms.Label();
            this.CustomerAddress_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.AlredyExistError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Search_lbl = new System.Windows.Forms.Label();
            this.MainMenuHeader_pnl.SuspendLayout();
            this.CustomerDetails_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlredyExistError)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNIC_txt
            // 
            this.CustomerNIC_txt.BorderColorFocused = System.Drawing.Color.White;
            this.CustomerNIC_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.CustomerNIC_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.CustomerNIC_txt.BorderThickness = 3;
            this.CustomerNIC_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerNIC_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNIC_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerNIC_txt.ForeColor = System.Drawing.Color.White;
            this.CustomerNIC_txt.isPassword = false;
            this.CustomerNIC_txt.Location = new System.Drawing.Point(61, 207);
            this.CustomerNIC_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerNIC_txt.MaxLength = 32767;
            this.CustomerNIC_txt.MinimumSize = new System.Drawing.Size(411, 46);
            this.CustomerNIC_txt.Name = "CustomerNIC_txt";
            this.CustomerNIC_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerNIC_txt.Size = new System.Drawing.Size(411, 46);
            this.CustomerNIC_txt.TabIndex = 34;
            this.CustomerNIC_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Search_txt
            // 
            this.Search_txt.BorderColorFocused = System.Drawing.Color.White;
            this.Search_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.Search_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.Search_txt.BorderThickness = 3;
            this.Search_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Search_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Search_txt.ForeColor = System.Drawing.Color.White;
            this.Search_txt.isPassword = false;
            this.Search_txt.Location = new System.Drawing.Point(811, 49);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(5);
            this.Search_txt.MaxLength = 32767;
            this.Search_txt.MinimumSize = new System.Drawing.Size(411, 46);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Padding = new System.Windows.Forms.Padding(4);
            this.Search_txt.Size = new System.Drawing.Size(411, 46);
            this.Search_txt.TabIndex = 46;
            this.Search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Search_txt.OnValueChanged += new System.EventHandler(this.Search_txt_OnValueChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Hire_btn
            // 
            this.Hire_btn.AutoSize = true;
            this.Hire_btn.Checked = true;
            this.Hire_btn.Enabled = false;
            this.Hire_btn.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Hire_btn.ForeColor = System.Drawing.Color.White;
            this.Hire_btn.Location = new System.Drawing.Point(61, 581);
            this.Hire_btn.Name = "Hire_btn";
            this.Hire_btn.Size = new System.Drawing.Size(66, 26);
            this.Hire_btn.TabIndex = 0;
            this.Hire_btn.TabStop = true;
            this.Hire_btn.Text = "Hire";
            this.Hire_btn.UseVisualStyleBackColor = true;
            // 
            // Rent_btn
            // 
            this.Rent_btn.AutoSize = true;
            this.Rent_btn.Enabled = false;
            this.Rent_btn.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Rent_btn.ForeColor = System.Drawing.Color.White;
            this.Rent_btn.Location = new System.Drawing.Point(137, 581);
            this.Rent_btn.Name = "Rent_btn";
            this.Rent_btn.Size = new System.Drawing.Size(70, 26);
            this.Rent_btn.TabIndex = 1;
            this.Rent_btn.Text = "Rent";
            this.Rent_btn.UseVisualStyleBackColor = true;
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
            this.MainMenuHeader_pnl.TabIndex = 3;
            // 
            // MainMenu_lbl
            // 
            this.MainMenu_lbl.AutoSize = true;
            this.MainMenu_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_lbl.ForeColor = System.Drawing.Color.White;
            this.MainMenu_lbl.Location = new System.Drawing.Point(4, 1);
            this.MainMenu_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainMenu_lbl.Name = "MainMenu_lbl";
            this.MainMenu_lbl.Size = new System.Drawing.Size(93, 25);
            this.MainMenu_lbl.TabIndex = 0;
            this.MainMenu_lbl.Text = "RETURN";
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
            // CustomerDetails_groupBox
            // 
            this.CustomerDetails_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerDetails_groupBox.Controls.Add(this.Next_btn);
            this.CustomerDetails_groupBox.Controls.Add(this.AddNew_btn);
            this.CustomerDetails_groupBox.Controls.Add(this.Clear_btn);
            this.CustomerDetails_groupBox.Controls.Add(this.CustomerName_lbl);
            this.CustomerDetails_groupBox.Controls.Add(this.Rent_btn);
            this.CustomerDetails_groupBox.Controls.Add(this.CustomerName_txt);
            this.CustomerDetails_groupBox.Controls.Add(this.Hire_btn);
            this.CustomerDetails_groupBox.Controls.Add(this.CustomerTelNo_lbl);
            this.CustomerDetails_groupBox.Controls.Add(this.CustomerNIC_txt);
            this.CustomerDetails_groupBox.Controls.Add(this.CustomerAddress_lbl);
            this.CustomerDetails_groupBox.Controls.Add(this.CustomerTelNo_txt);
            this.CustomerDetails_groupBox.Controls.Add(this.CustomerNIC_lbl);
            this.CustomerDetails_groupBox.Controls.Add(this.CustomerAddress_txt);
            this.CustomerDetails_groupBox.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.CustomerDetails_groupBox.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerDetails_groupBox.Location = new System.Drawing.Point(12, 49);
            this.CustomerDetails_groupBox.Name = "CustomerDetails_groupBox";
            this.CustomerDetails_groupBox.Size = new System.Drawing.Size(558, 715);
            this.CustomerDetails_groupBox.TabIndex = 42;
            this.CustomerDetails_groupBox.TabStop = false;
            this.CustomerDetails_groupBox.Text = "Customer Details";
            // 
            // Next_btn
            // 
            this.Next_btn.Active = false;
            this.Next_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Next_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next_btn.BorderRadius = 0;
            this.Next_btn.ButtonText = "Next [Pay]";
            this.Next_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Next_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Next_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Next_btn.Iconimage = null;
            this.Next_btn.Iconimage_right = null;
            this.Next_btn.Iconimage_right_Selected = null;
            this.Next_btn.Iconimage_Selected = null;
            this.Next_btn.IconMarginLeft = 20;
            this.Next_btn.IconMarginRight = 0;
            this.Next_btn.IconRightVisible = true;
            this.Next_btn.IconRightZoom = 0D;
            this.Next_btn.IconVisible = false;
            this.Next_btn.IconZoom = 60D;
            this.Next_btn.IsTab = false;
            this.Next_btn.Location = new System.Drawing.Point(349, 648);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Next_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Next_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Next_btn.selected = false;
            this.Next_btn.Size = new System.Drawing.Size(123, 42);
            this.Next_btn.TabIndex = 45;
            this.Next_btn.Text = "Next [Pay]";
            this.Next_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Next_btn.Textcolor = System.Drawing.Color.White;
            this.Next_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // AddNew_btn
            // 
            this.AddNew_btn.Active = false;
            this.AddNew_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.AddNew_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNew_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.AddNew_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNew_btn.BorderRadius = 0;
            this.AddNew_btn.ButtonText = "Add New";
            this.AddNew_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNew_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.AddNew_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.AddNew_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.AddNew_btn.Iconimage = null;
            this.AddNew_btn.Iconimage_right = null;
            this.AddNew_btn.Iconimage_right_Selected = null;
            this.AddNew_btn.Iconimage_Selected = null;
            this.AddNew_btn.IconMarginLeft = 20;
            this.AddNew_btn.IconMarginRight = 0;
            this.AddNew_btn.IconRightVisible = true;
            this.AddNew_btn.IconRightZoom = 0D;
            this.AddNew_btn.IconVisible = false;
            this.AddNew_btn.IconZoom = 60D;
            this.AddNew_btn.IsTab = false;
            this.AddNew_btn.Location = new System.Drawing.Point(204, 648);
            this.AddNew_btn.Margin = new System.Windows.Forms.Padding(5);
            this.AddNew_btn.Name = "AddNew_btn";
            this.AddNew_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.AddNew_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.AddNew_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.AddNew_btn.selected = false;
            this.AddNew_btn.Size = new System.Drawing.Size(123, 42);
            this.AddNew_btn.TabIndex = 44;
            this.AddNew_btn.Text = "Add New";
            this.AddNew_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddNew_btn.Textcolor = System.Drawing.Color.White;
            this.AddNew_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew_btn.Visible = false;
            this.AddNew_btn.Click += new System.EventHandler(this.AddNew_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Active = false;
            this.Clear_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear_btn.BorderRadius = 0;
            this.Clear_btn.ButtonText = "Clear";
            this.Clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Clear_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Clear_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Clear_btn.Iconimage = null;
            this.Clear_btn.Iconimage_right = null;
            this.Clear_btn.Iconimage_right_Selected = null;
            this.Clear_btn.Iconimage_Selected = null;
            this.Clear_btn.IconMarginLeft = 20;
            this.Clear_btn.IconMarginRight = 0;
            this.Clear_btn.IconRightVisible = true;
            this.Clear_btn.IconRightZoom = 0D;
            this.Clear_btn.IconVisible = false;
            this.Clear_btn.IconZoom = 60D;
            this.Clear_btn.IsTab = false;
            this.Clear_btn.Location = new System.Drawing.Point(60, 648);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Clear_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Clear_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Clear_btn.selected = false;
            this.Clear_btn.Size = new System.Drawing.Size(123, 42);
            this.Clear_btn.TabIndex = 43;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clear_btn.Textcolor = System.Drawing.Color.White;
            this.Clear_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click_1);
            // 
            // CustomerName_lbl
            // 
            this.CustomerName_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerName_lbl.AutoSize = true;
            this.CustomerName_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerName_lbl.Location = new System.Drawing.Point(55, 62);
            this.CustomerName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerName_lbl.Name = "CustomerName_lbl";
            this.CustomerName_lbl.Size = new System.Drawing.Size(155, 25);
            this.CustomerName_lbl.TabIndex = 29;
            this.CustomerName_lbl.Text = "Customer Name";
            // 
            // CustomerName_txt
            // 
            this.CustomerName_txt.BorderColorFocused = System.Drawing.Color.White;
            this.CustomerName_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.CustomerName_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.CustomerName_txt.BorderThickness = 3;
            this.CustomerName_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerName_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerName_txt.ForeColor = System.Drawing.Color.White;
            this.CustomerName_txt.isPassword = false;
            this.CustomerName_txt.Location = new System.Drawing.Point(61, 99);
            this.CustomerName_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerName_txt.MaxLength = 32767;
            this.CustomerName_txt.MinimumSize = new System.Drawing.Size(411, 46);
            this.CustomerName_txt.Name = "CustomerName_txt";
            this.CustomerName_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerName_txt.Size = new System.Drawing.Size(411, 46);
            this.CustomerName_txt.TabIndex = 28;
            this.CustomerName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerTelNo_lbl
            // 
            this.CustomerTelNo_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerTelNo_lbl.AutoSize = true;
            this.CustomerTelNo_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTelNo_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerTelNo_lbl.Location = new System.Drawing.Point(55, 462);
            this.CustomerTelNo_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerTelNo_lbl.Name = "CustomerTelNo_lbl";
            this.CustomerTelNo_lbl.Size = new System.Drawing.Size(159, 25);
            this.CustomerTelNo_lbl.TabIndex = 33;
            this.CustomerTelNo_lbl.Text = "Customer Tel No";
            // 
            // CustomerAddress_lbl
            // 
            this.CustomerAddress_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerAddress_lbl.AutoSize = true;
            this.CustomerAddress_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerAddress_lbl.Location = new System.Drawing.Point(55, 281);
            this.CustomerAddress_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerAddress_lbl.Name = "CustomerAddress_lbl";
            this.CustomerAddress_lbl.Size = new System.Drawing.Size(175, 25);
            this.CustomerAddress_lbl.TabIndex = 30;
            this.CustomerAddress_lbl.Text = "Customer Address";
            // 
            // CustomerTelNo_txt
            // 
            this.CustomerTelNo_txt.BorderColorFocused = System.Drawing.Color.White;
            this.CustomerTelNo_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.CustomerTelNo_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.CustomerTelNo_txt.BorderThickness = 3;
            this.CustomerTelNo_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerTelNo_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerTelNo_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerTelNo_txt.ForeColor = System.Drawing.Color.White;
            this.CustomerTelNo_txt.isPassword = false;
            this.CustomerTelNo_txt.Location = new System.Drawing.Point(61, 499);
            this.CustomerTelNo_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerTelNo_txt.MaxLength = 32767;
            this.CustomerTelNo_txt.MinimumSize = new System.Drawing.Size(411, 46);
            this.CustomerTelNo_txt.Name = "CustomerTelNo_txt";
            this.CustomerTelNo_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerTelNo_txt.Size = new System.Drawing.Size(411, 46);
            this.CustomerTelNo_txt.TabIndex = 32;
            this.CustomerTelNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerTelNo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerTelNo_txt_KeyPress);
            // 
            // CustomerNIC_lbl
            // 
            this.CustomerNIC_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerNIC_lbl.AutoSize = true;
            this.CustomerNIC_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNIC_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerNIC_lbl.Location = new System.Drawing.Point(55, 171);
            this.CustomerNIC_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNIC_lbl.Name = "CustomerNIC_lbl";
            this.CustomerNIC_lbl.Size = new System.Drawing.Size(136, 25);
            this.CustomerNIC_lbl.TabIndex = 35;
            this.CustomerNIC_lbl.Text = "Customer NIC";
            // 
            // CustomerAddress_txt
            // 
            this.CustomerAddress_txt.BorderColorFocused = System.Drawing.Color.White;
            this.CustomerAddress_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.CustomerAddress_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.CustomerAddress_txt.BorderThickness = 3;
            this.CustomerAddress_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerAddress_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerAddress_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerAddress_txt.ForeColor = System.Drawing.Color.White;
            this.CustomerAddress_txt.isPassword = false;
            this.CustomerAddress_txt.Location = new System.Drawing.Point(61, 319);
            this.CustomerAddress_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerAddress_txt.MaxLength = 32767;
            this.CustomerAddress_txt.MinimumSize = new System.Drawing.Size(411, 118);
            this.CustomerAddress_txt.Name = "CustomerAddress_txt";
            this.CustomerAddress_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerAddress_txt.Size = new System.Drawing.Size(411, 118);
            this.CustomerAddress_txt.TabIndex = 31;
            this.CustomerAddress_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(585, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 661);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.ContainerControl = this;
            this.ErrorMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorMessage.Icon")));
            // 
            // AlredyExistError
            // 
            this.AlredyExistError.ContainerControl = this;
            this.AlredyExistError.Icon = ((System.Drawing.Icon)(resources.GetObject("AlredyExistError.Icon")));
            // 
            // Search_lbl
            // 
            this.Search_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Search_lbl.Location = new System.Drawing.Point(647, 60);
            this.Search_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(155, 25);
            this.Search_lbl.TabIndex = 35;
            this.Search_lbl.Text = "Search with NIC";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1236, 776);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CustomerDetails_groupBox);
            this.Controls.Add(this.MainMenuHeader_pnl);
            this.Controls.Add(this.Search_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.MainMenuHeader_pnl.ResumeLayout(false);
            this.MainMenuHeader_pnl.PerformLayout();
            this.CustomerDetails_groupBox.ResumeLayout(false);
            this.CustomerDetails_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlredyExistError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.RadioButton Rent_btn;
        private System.Windows.Forms.RadioButton Hire_btn;
        private System.Windows.Forms.Panel MainMenuHeader_pnl;
        private System.Windows.Forms.Label MainMenu_lbl;
        private System.Windows.Forms.Button MainMenuMinimize_btn;
        private System.Windows.Forms.Button MainMenuMaximize_btn;
        private System.Windows.Forms.Button MainMenuClose_btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.GroupBox CustomerDetails_groupBox;
        private System.Windows.Forms.Label CustomerName_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerName_txt;
        private System.Windows.Forms.Label CustomerTelNo_lbl;
        private System.Windows.Forms.Label CustomerAddress_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerTelNo_txt;
        private System.Windows.Forms.Label CustomerNIC_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerAddress_txt;
        protected internal Bunifu.Framework.UI.BunifuFlatButton Clear_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected internal Bunifu.Framework.UI.BunifuFlatButton AddNew_btn;
        private System.Windows.Forms.ErrorProvider ErrorMessage;
        protected internal Bunifu.Framework.UI.BunifuFlatButton Next_btn;
        private System.Windows.Forms.ErrorProvider AlredyExistError;
        private System.Windows.Forms.Label Search_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerNIC_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox Search_txt;
    }
}