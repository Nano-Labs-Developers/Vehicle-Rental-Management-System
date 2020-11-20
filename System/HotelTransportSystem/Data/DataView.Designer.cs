namespace HotelTransportSystem.Data
{
    partial class DataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataView));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainSide_pnl = new System.Windows.Forms.Panel();
            this.SideMenu_pnl = new System.Windows.Forms.Panel();
            this.BackHome_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NameTag_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.SideMenuSideColor_pnl = new System.Windows.Forms.Panel();
            this.Vehicles_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Driver_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Customer_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Packages_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MainMenusettings_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Booked_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SidePanelHadler_pnl = new System.Windows.Forms.Panel();
            this.SidePanelHide_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MainMenuHeader_pnl = new System.Windows.Forms.Panel();
            this.MainMenu_lbl = new System.Windows.Forms.Label();
            this.MainMenuMinimize_btn = new System.Windows.Forms.Button();
            this.MainMenuMaximize_btn = new System.Windows.Forms.Button();
            this.MainMenuClose_btn = new System.Windows.Forms.Button();
            this.SideMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.packageData1 = new HotelTransportSystem.Packages.PackageData();
            this.settings1 = new HotelTransportSystem.MainMenuSettings.Settings.Settings();
            this.driversDataList1 = new HotelTransportSystem.Drivers.DriversDataList();
            this.driversData1 = new HotelTransportSystem.Drivers.DriversData();
            this.customerDataList1 = new HotelTransportSystem.Customer.CustomerDataList();
            this.customer1 = new HotelTransportSystem.Customer.Customer();
            this.vehicleDataList1 = new HotelTransportSystem.Vehicles.VehicleDataList();
            this.vehicleData1 = new HotelTransportSystem.Vehicles.VehicleData();
            this.bookedData1 = new HotelTransportSystem.Booked.BookedData();
            this.bookedDataList1 = new HotelTransportSystem.Booked.BookedDataList();
            this.panel1.SuspendLayout();
            this.MainSide_pnl.SuspendLayout();
            this.SideMenu_pnl.SuspendLayout();
            this.SidePanelHadler_pnl.SuspendLayout();
            this.MainMenuHeader_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookedDataList1);
            this.panel1.Controls.Add(this.bookedData1);
            this.panel1.Controls.Add(this.packageData1);
            this.panel1.Controls.Add(this.settings1);
            this.panel1.Controls.Add(this.driversDataList1);
            this.panel1.Controls.Add(this.driversData1);
            this.panel1.Controls.Add(this.customerDataList1);
            this.panel1.Controls.Add(this.customer1);
            this.panel1.Controls.Add(this.vehicleDataList1);
            this.panel1.Controls.Add(this.vehicleData1);
            this.panel1.Controls.Add(this.MainSide_pnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 776);
            this.panel1.TabIndex = 0;
            // 
            // MainSide_pnl
            // 
            this.MainSide_pnl.Controls.Add(this.SideMenu_pnl);
            this.MainSide_pnl.Controls.Add(this.SidePanelHadler_pnl);
            this.MainSide_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainSide_pnl.Location = new System.Drawing.Point(0, 0);
            this.MainSide_pnl.Name = "MainSide_pnl";
            this.MainSide_pnl.Size = new System.Drawing.Size(281, 776);
            this.MainSide_pnl.TabIndex = 3;
            // 
            // SideMenu_pnl
            // 
            this.SideMenu_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.SideMenu_pnl.Controls.Add(this.BackHome_btn);
            this.SideMenu_pnl.Controls.Add(this.NameTag_btn);
            this.SideMenu_pnl.Controls.Add(this.SideMenuSideColor_pnl);
            this.SideMenu_pnl.Controls.Add(this.Vehicles_btn);
            this.SideMenu_pnl.Controls.Add(this.Driver_btn);
            this.SideMenu_pnl.Controls.Add(this.Customer_btn);
            this.SideMenu_pnl.Controls.Add(this.Packages_btn);
            this.SideMenu_pnl.Controls.Add(this.MainMenusettings_btn);
            this.SideMenu_pnl.Controls.Add(this.Booked_btn);
            this.SideMenu_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideMenu_pnl.Location = new System.Drawing.Point(0, 52);
            this.SideMenu_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.SideMenu_pnl.Name = "SideMenu_pnl";
            this.SideMenu_pnl.Size = new System.Drawing.Size(281, 724);
            this.SideMenu_pnl.TabIndex = 2;
            // 
            // BackHome_btn
            // 
            this.BackHome_btn.Active = false;
            this.BackHome_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.BackHome_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BackHome_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackHome_btn.BorderRadius = 0;
            this.BackHome_btn.ButtonText = "    Home";
            this.BackHome_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackHome_btn.DisabledColor = System.Drawing.Color.Gray;
            this.BackHome_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackHome_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.BackHome_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.BackHome_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("BackHome_btn.Iconimage")));
            this.BackHome_btn.Iconimage_right = null;
            this.BackHome_btn.Iconimage_right_Selected = null;
            this.BackHome_btn.Iconimage_Selected = null;
            this.BackHome_btn.IconMarginLeft = 20;
            this.BackHome_btn.IconMarginRight = 0;
            this.BackHome_btn.IconRightVisible = true;
            this.BackHome_btn.IconRightZoom = 0D;
            this.BackHome_btn.IconVisible = true;
            this.BackHome_btn.IconZoom = 50D;
            this.BackHome_btn.IsTab = false;
            this.BackHome_btn.Location = new System.Drawing.Point(0, 606);
            this.BackHome_btn.Margin = new System.Windows.Forms.Padding(5);
            this.BackHome_btn.Name = "BackHome_btn";
            this.BackHome_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BackHome_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.BackHome_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.BackHome_btn.selected = false;
            this.BackHome_btn.Size = new System.Drawing.Size(281, 59);
            this.BackHome_btn.TabIndex = 8;
            this.BackHome_btn.Text = "    Home";
            this.BackHome_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackHome_btn.Textcolor = System.Drawing.Color.White;
            this.BackHome_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackHome_btn.Click += new System.EventHandler(this.BackHome_btn_Click);
            // 
            // NameTag_btn
            // 
            this.NameTag_btn.BackColor = System.Drawing.Color.Transparent;
            this.NameTag_btn.color = System.Drawing.Color.Transparent;
            this.NameTag_btn.colorActive = System.Drawing.Color.Transparent;
            this.NameTag_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NameTag_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.NameTag_btn.ForeColor = System.Drawing.Color.White;
            this.NameTag_btn.Image = ((System.Drawing.Image)(resources.GetObject("NameTag_btn.Image")));
            this.NameTag_btn.ImagePosition = 20;
            this.NameTag_btn.ImageZoom = 50;
            this.NameTag_btn.LabelPosition = 41;
            this.NameTag_btn.LabelText = "Pasan Kalhara";
            this.NameTag_btn.Location = new System.Drawing.Point(43, 15);
            this.NameTag_btn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NameTag_btn.Name = "NameTag_btn";
            this.NameTag_btn.Size = new System.Drawing.Size(192, 159);
            this.NameTag_btn.TabIndex = 5;
            // 
            // SideMenuSideColor_pnl
            // 
            this.SideMenuSideColor_pnl.BackColor = System.Drawing.Color.White;
            this.SideMenuSideColor_pnl.Location = new System.Drawing.Point(0, 299);
            this.SideMenuSideColor_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.SideMenuSideColor_pnl.Name = "SideMenuSideColor_pnl";
            this.SideMenuSideColor_pnl.Size = new System.Drawing.Size(7, 59);
            this.SideMenuSideColor_pnl.TabIndex = 0;
            // 
            // Vehicles_btn
            // 
            this.Vehicles_btn.Active = false;
            this.Vehicles_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Vehicles_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Vehicles_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Vehicles_btn.BorderRadius = 0;
            this.Vehicles_btn.ButtonText = "    Vehicles";
            this.Vehicles_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vehicles_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Vehicles_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Vehicles_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Vehicles_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Vehicles_btn.Iconimage")));
            this.Vehicles_btn.Iconimage_right = null;
            this.Vehicles_btn.Iconimage_right_Selected = null;
            this.Vehicles_btn.Iconimage_Selected = null;
            this.Vehicles_btn.IconMarginLeft = 20;
            this.Vehicles_btn.IconMarginRight = 0;
            this.Vehicles_btn.IconRightVisible = true;
            this.Vehicles_btn.IconRightZoom = 0D;
            this.Vehicles_btn.IconVisible = true;
            this.Vehicles_btn.IconZoom = 60D;
            this.Vehicles_btn.IsTab = false;
            this.Vehicles_btn.Location = new System.Drawing.Point(0, 300);
            this.Vehicles_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Vehicles_btn.Name = "Vehicles_btn";
            this.Vehicles_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Vehicles_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Vehicles_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Vehicles_btn.selected = false;
            this.Vehicles_btn.Size = new System.Drawing.Size(281, 59);
            this.Vehicles_btn.TabIndex = 2;
            this.Vehicles_btn.Text = "    Vehicles";
            this.Vehicles_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vehicles_btn.Textcolor = System.Drawing.Color.White;
            this.Vehicles_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicles_btn.Click += new System.EventHandler(this.Vehicles_btn_Click);
            // 
            // Driver_btn
            // 
            this.Driver_btn.Active = false;
            this.Driver_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Driver_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Driver_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Driver_btn.BorderRadius = 0;
            this.Driver_btn.ButtonText = "    Drivers";
            this.Driver_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Driver_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Driver_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Driver_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Driver_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Driver_btn.Iconimage")));
            this.Driver_btn.Iconimage_right = null;
            this.Driver_btn.Iconimage_right_Selected = null;
            this.Driver_btn.Iconimage_Selected = null;
            this.Driver_btn.IconMarginLeft = 20;
            this.Driver_btn.IconMarginRight = 0;
            this.Driver_btn.IconRightVisible = true;
            this.Driver_btn.IconRightZoom = 0D;
            this.Driver_btn.IconVisible = true;
            this.Driver_btn.IconZoom = 60D;
            this.Driver_btn.IsTab = false;
            this.Driver_btn.Location = new System.Drawing.Point(0, 359);
            this.Driver_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Driver_btn.Name = "Driver_btn";
            this.Driver_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Driver_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Driver_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Driver_btn.selected = false;
            this.Driver_btn.Size = new System.Drawing.Size(281, 59);
            this.Driver_btn.TabIndex = 4;
            this.Driver_btn.Text = "    Drivers";
            this.Driver_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Driver_btn.Textcolor = System.Drawing.Color.White;
            this.Driver_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_btn.Click += new System.EventHandler(this.Driver_btn_Click);
            // 
            // Customer_btn
            // 
            this.Customer_btn.Active = false;
            this.Customer_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Customer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Customer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Customer_btn.BorderRadius = 0;
            this.Customer_btn.ButtonText = "    Customer";
            this.Customer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customer_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Customer_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Customer_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Customer_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Customer_btn.Iconimage")));
            this.Customer_btn.Iconimage_right = null;
            this.Customer_btn.Iconimage_right_Selected = null;
            this.Customer_btn.Iconimage_Selected = null;
            this.Customer_btn.IconMarginLeft = 20;
            this.Customer_btn.IconMarginRight = 0;
            this.Customer_btn.IconRightVisible = true;
            this.Customer_btn.IconRightZoom = 0D;
            this.Customer_btn.IconVisible = true;
            this.Customer_btn.IconZoom = 60D;
            this.Customer_btn.IsTab = false;
            this.Customer_btn.Location = new System.Drawing.Point(0, 418);
            this.Customer_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Customer_btn.Name = "Customer_btn";
            this.Customer_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Customer_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Customer_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Customer_btn.selected = false;
            this.Customer_btn.Size = new System.Drawing.Size(281, 59);
            this.Customer_btn.TabIndex = 3;
            this.Customer_btn.Text = "    Customer";
            this.Customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customer_btn.Textcolor = System.Drawing.Color.White;
            this.Customer_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_btn.Click += new System.EventHandler(this.Customer_btn_Click);
            // 
            // Packages_btn
            // 
            this.Packages_btn.Active = false;
            this.Packages_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Packages_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Packages_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Packages_btn.BorderRadius = 0;
            this.Packages_btn.ButtonText = "    Packages";
            this.Packages_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Packages_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Packages_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Packages_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Packages_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Packages_btn.Iconimage")));
            this.Packages_btn.Iconimage_right = null;
            this.Packages_btn.Iconimage_right_Selected = null;
            this.Packages_btn.Iconimage_Selected = null;
            this.Packages_btn.IconMarginLeft = 20;
            this.Packages_btn.IconMarginRight = 0;
            this.Packages_btn.IconRightVisible = true;
            this.Packages_btn.IconRightZoom = 0D;
            this.Packages_btn.IconVisible = true;
            this.Packages_btn.IconZoom = 60D;
            this.Packages_btn.IsTab = false;
            this.Packages_btn.Location = new System.Drawing.Point(0, 241);
            this.Packages_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Packages_btn.Name = "Packages_btn";
            this.Packages_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Packages_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Packages_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Packages_btn.selected = false;
            this.Packages_btn.Size = new System.Drawing.Size(281, 59);
            this.Packages_btn.TabIndex = 9;
            this.Packages_btn.Text = "    Packages";
            this.Packages_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Packages_btn.Textcolor = System.Drawing.Color.White;
            this.Packages_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Packages_btn.Click += new System.EventHandler(this.Packages_btn_Click);
            // 
            // MainMenusettings_btn
            // 
            this.MainMenusettings_btn.Active = false;
            this.MainMenusettings_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.MainMenusettings_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.MainMenusettings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenusettings_btn.BorderRadius = 0;
            this.MainMenusettings_btn.ButtonText = "    Settings";
            this.MainMenusettings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenusettings_btn.DisabledColor = System.Drawing.Color.Gray;
            this.MainMenusettings_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainMenusettings_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.MainMenusettings_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.MainMenusettings_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("MainMenusettings_btn.Iconimage")));
            this.MainMenusettings_btn.Iconimage_right = null;
            this.MainMenusettings_btn.Iconimage_right_Selected = null;
            this.MainMenusettings_btn.Iconimage_Selected = null;
            this.MainMenusettings_btn.IconMarginLeft = 20;
            this.MainMenusettings_btn.IconMarginRight = 0;
            this.MainMenusettings_btn.IconRightVisible = true;
            this.MainMenusettings_btn.IconRightZoom = 0D;
            this.MainMenusettings_btn.IconVisible = true;
            this.MainMenusettings_btn.IconZoom = 50D;
            this.MainMenusettings_btn.IsTab = false;
            this.MainMenusettings_btn.Location = new System.Drawing.Point(0, 665);
            this.MainMenusettings_btn.Margin = new System.Windows.Forms.Padding(5);
            this.MainMenusettings_btn.Name = "MainMenusettings_btn";
            this.MainMenusettings_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.MainMenusettings_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.MainMenusettings_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.MainMenusettings_btn.selected = false;
            this.MainMenusettings_btn.Size = new System.Drawing.Size(281, 59);
            this.MainMenusettings_btn.TabIndex = 7;
            this.MainMenusettings_btn.Text = "    Settings";
            this.MainMenusettings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenusettings_btn.Textcolor = System.Drawing.Color.White;
            this.MainMenusettings_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenusettings_btn.Click += new System.EventHandler(this.MainMenusettings_btn_Click);
            // 
            // Booked_btn
            // 
            this.Booked_btn.Active = false;
            this.Booked_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Booked_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Booked_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Booked_btn.BorderRadius = 0;
            this.Booked_btn.ButtonText = "    Booked";
            this.Booked_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Booked_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Booked_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Booked_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Booked_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Booked_btn.Iconimage")));
            this.Booked_btn.Iconimage_right = null;
            this.Booked_btn.Iconimage_right_Selected = null;
            this.Booked_btn.Iconimage_Selected = null;
            this.Booked_btn.IconMarginLeft = 20;
            this.Booked_btn.IconMarginRight = 0;
            this.Booked_btn.IconRightVisible = true;
            this.Booked_btn.IconRightZoom = 0D;
            this.Booked_btn.IconVisible = true;
            this.Booked_btn.IconZoom = 60D;
            this.Booked_btn.IsTab = false;
            this.Booked_btn.Location = new System.Drawing.Point(0, 474);
            this.Booked_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Booked_btn.Name = "Booked_btn";
            this.Booked_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Booked_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Booked_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Booked_btn.selected = false;
            this.Booked_btn.Size = new System.Drawing.Size(281, 59);
            this.Booked_btn.TabIndex = 10;
            this.Booked_btn.Text = "    Booked";
            this.Booked_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Booked_btn.Textcolor = System.Drawing.Color.White;
            this.Booked_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booked_btn.Click += new System.EventHandler(this.Booked_btn_Click);
            // 
            // SidePanelHadler_pnl
            // 
            this.SidePanelHadler_pnl.Controls.Add(this.SidePanelHide_btn);
            this.SidePanelHadler_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidePanelHadler_pnl.Location = new System.Drawing.Point(0, 0);
            this.SidePanelHadler_pnl.Name = "SidePanelHadler_pnl";
            this.SidePanelHadler_pnl.Size = new System.Drawing.Size(281, 52);
            this.SidePanelHadler_pnl.TabIndex = 0;
            // 
            // SidePanelHide_btn
            // 
            this.SidePanelHide_btn.Active = false;
            this.SidePanelHide_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.SidePanelHide_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.SidePanelHide_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanelHide_btn.BorderRadius = 0;
            this.SidePanelHide_btn.ButtonText = "";
            this.SidePanelHide_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SidePanelHide_btn.DisabledColor = System.Drawing.Color.Gray;
            this.SidePanelHide_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelHide_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.SidePanelHide_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.SidePanelHide_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("SidePanelHide_btn.Iconimage")));
            this.SidePanelHide_btn.Iconimage_right = null;
            this.SidePanelHide_btn.Iconimage_right_Selected = null;
            this.SidePanelHide_btn.Iconimage_Selected = null;
            this.SidePanelHide_btn.IconMarginLeft = 20;
            this.SidePanelHide_btn.IconMarginRight = 0;
            this.SidePanelHide_btn.IconRightVisible = true;
            this.SidePanelHide_btn.IconRightZoom = 0D;
            this.SidePanelHide_btn.IconVisible = true;
            this.SidePanelHide_btn.IconZoom = 60D;
            this.SidePanelHide_btn.IsTab = false;
            this.SidePanelHide_btn.Location = new System.Drawing.Point(0, 0);
            this.SidePanelHide_btn.Margin = new System.Windows.Forms.Padding(5);
            this.SidePanelHide_btn.Name = "SidePanelHide_btn";
            this.SidePanelHide_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.SidePanelHide_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.SidePanelHide_btn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.SidePanelHide_btn.selected = false;
            this.SidePanelHide_btn.Size = new System.Drawing.Size(83, 52);
            this.SidePanelHide_btn.TabIndex = 6;
            this.SidePanelHide_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SidePanelHide_btn.Textcolor = System.Drawing.Color.White;
            this.SidePanelHide_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidePanelHide_btn.Click += new System.EventHandler(this.SidePanelHide_btn_Click);
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
            this.MainMenuHeader_pnl.Size = new System.Drawing.Size(1516, 26);
            this.MainMenuHeader_pnl.TabIndex = 1;
            // 
            // MainMenu_lbl
            // 
            this.MainMenu_lbl.AutoSize = true;
            this.MainMenu_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_lbl.ForeColor = System.Drawing.Color.White;
            this.MainMenu_lbl.Location = new System.Drawing.Point(4, 1);
            this.MainMenu_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainMenu_lbl.Name = "MainMenu_lbl";
            this.MainMenu_lbl.Size = new System.Drawing.Size(64, 25);
            this.MainMenu_lbl.TabIndex = 0;
            this.MainMenu_lbl.Text = "DATA";
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
            this.MainMenuMinimize_btn.Location = new System.Drawing.Point(1408, 0);
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
            this.MainMenuMaximize_btn.Location = new System.Drawing.Point(1444, 0);
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
            this.MainMenuClose_btn.Location = new System.Drawing.Point(1480, 0);
            this.MainMenuClose_btn.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuClose_btn.Name = "MainMenuClose_btn";
            this.MainMenuClose_btn.Size = new System.Drawing.Size(36, 26);
            this.MainMenuClose_btn.TabIndex = 1;
            this.MainMenuClose_btn.UseVisualStyleBackColor = false;
            this.MainMenuClose_btn.Click += new System.EventHandler(this.MainMenuClose_btn_Click);
            // 
            // SideMenuTimer
            // 
            this.SideMenuTimer.Tick += new System.EventHandler(this.SideMenuTimer_Tick);
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
            // packageData1
            // 
            this.packageData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.packageData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageData1.Location = new System.Drawing.Point(281, 0);
            this.packageData1.Name = "packageData1";
            this.packageData1.Size = new System.Drawing.Size(1235, 776);
            this.packageData1.TabIndex = 11;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings1.Location = new System.Drawing.Point(281, 0);
            this.settings1.Margin = new System.Windows.Forms.Padding(4);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(1235, 776);
            this.settings1.TabIndex = 10;
            // 
            // driversDataList1
            // 
            this.driversDataList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.driversDataList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driversDataList1.Location = new System.Drawing.Point(281, 0);
            this.driversDataList1.Margin = new System.Windows.Forms.Padding(4);
            this.driversDataList1.Name = "driversDataList1";
            this.driversDataList1.Size = new System.Drawing.Size(1235, 776);
            this.driversDataList1.TabIndex = 9;
            // 
            // driversData1
            // 
            this.driversData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.driversData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driversData1.Location = new System.Drawing.Point(281, 0);
            this.driversData1.Margin = new System.Windows.Forms.Padding(4);
            this.driversData1.Name = "driversData1";
            this.driversData1.Size = new System.Drawing.Size(1235, 776);
            this.driversData1.TabIndex = 8;
            // 
            // customerDataList1
            // 
            this.customerDataList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.customerDataList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataList1.Location = new System.Drawing.Point(281, 0);
            this.customerDataList1.Margin = new System.Windows.Forms.Padding(4);
            this.customerDataList1.Name = "customerDataList1";
            this.customerDataList1.Size = new System.Drawing.Size(1235, 776);
            this.customerDataList1.TabIndex = 7;
            // 
            // customer1
            // 
            this.customer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer1.Location = new System.Drawing.Point(281, 0);
            this.customer1.Margin = new System.Windows.Forms.Padding(4);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(1235, 776);
            this.customer1.TabIndex = 6;
            // 
            // vehicleDataList1
            // 
            this.vehicleDataList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.vehicleDataList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleDataList1.Location = new System.Drawing.Point(281, 0);
            this.vehicleDataList1.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleDataList1.Name = "vehicleDataList1";
            this.vehicleDataList1.Size = new System.Drawing.Size(1235, 776);
            this.vehicleDataList1.TabIndex = 5;
            // 
            // vehicleData1
            // 
            this.vehicleData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.vehicleData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleData1.Location = new System.Drawing.Point(281, 0);
            this.vehicleData1.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleData1.Name = "vehicleData1";
            this.vehicleData1.Size = new System.Drawing.Size(1235, 776);
            this.vehicleData1.TabIndex = 4;
            // 
            // bookedData1
            // 
            this.bookedData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.bookedData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookedData1.Location = new System.Drawing.Point(281, 0);
            this.bookedData1.Name = "bookedData1";
            this.bookedData1.Size = new System.Drawing.Size(1235, 776);
            this.bookedData1.TabIndex = 12;
            // 
            // bookedDataList1
            // 
            this.bookedDataList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.bookedDataList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookedDataList1.Location = new System.Drawing.Point(281, 0);
            this.bookedDataList1.Name = "bookedDataList1";
            this.bookedDataList1.Size = new System.Drawing.Size(1235, 776);
            this.bookedDataList1.TabIndex = 13;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1516, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenuHeader_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataView";
            this.Load += new System.EventHandler(this.DataView_Load);
            this.panel1.ResumeLayout(false);
            this.MainSide_pnl.ResumeLayout(false);
            this.SideMenu_pnl.ResumeLayout(false);
            this.SidePanelHadler_pnl.ResumeLayout(false);
            this.MainMenuHeader_pnl.ResumeLayout(false);
            this.MainMenuHeader_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainMenuHeader_pnl;
        private System.Windows.Forms.Label MainMenu_lbl;
        private System.Windows.Forms.Button MainMenuMinimize_btn;
        private System.Windows.Forms.Button MainMenuMaximize_btn;
        private System.Windows.Forms.Button MainMenuClose_btn;
        private System.Windows.Forms.Panel SideMenu_pnl;
        private Bunifu.Framework.UI.BunifuFlatButton MainMenusettings_btn;
        private Bunifu.Framework.UI.BunifuTileButton NameTag_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Driver_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Customer_btn;
        private System.Windows.Forms.Panel SideMenuSideColor_pnl;
        private Bunifu.Framework.UI.BunifuFlatButton Vehicles_btn;
        private System.Windows.Forms.Panel MainSide_pnl;
        private System.Windows.Forms.Panel SidePanelHadler_pnl;
        private System.Windows.Forms.Timer SideMenuTimer;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuFlatButton SidePanelHide_btn;
        private Vehicles.VehicleDataList vehicleDataList1;
        private Vehicles.VehicleData vehicleData1;
        private Bunifu.Framework.UI.BunifuFlatButton BackHome_btn;
        private Drivers.DriversDataList driversDataList1;
        private Drivers.DriversData driversData1;
        private Customer.CustomerDataList customerDataList1;
        private Customer.Customer customer1;
        private MainMenuSettings.Settings.Settings settings1;
        private Bunifu.Framework.UI.BunifuFlatButton Packages_btn;
        private Packages.PackageData packageData1;
        private Bunifu.Framework.UI.BunifuFlatButton Booked_btn;
        private Booked.BookedDataList bookedDataList1;
        private Booked.BookedData bookedData1;
    }
}