namespace HotelTransportSystem.Hire_and_Rent
{
    partial class Boocking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boocking));
            this.BookingStartingDetails_groupBox = new System.Windows.Forms.GroupBox();
            this.BookingStartTime_lbl = new System.Windows.Forms.Label();
            this.BookingStartDate_DateTimePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BookingStartingMilage_lbl = new System.Windows.Forms.Label();
            this.BookingStartingMilage_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BookingSelectTypes_groupBox = new System.Windows.Forms.GroupBox();
            this.BookingRent_btn = new System.Windows.Forms.RadioButton();
            this.BookingHire_btn = new System.Windows.Forms.RadioButton();
            this.BookingVehicle_DropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.BookingVehicle_lbl = new System.Windows.Forms.Label();
            this.BookingAvailableVehicles_txt = new Bunifu.Framework.UI.BunifuDropdown();
            this.BookingAvailableVehicles_lbl = new System.Windows.Forms.Label();
            this.WithDriver_checkbox = new System.Windows.Forms.CheckBox();
            this.BookingTourType_DropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.BookingTour_lbl = new System.Windows.Forms.Label();
            this.BookingPackages_lbl = new System.Windows.Forms.Label();
            this.BookingPackages_DropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.BookingVehicleTypes_DropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.BookingDriverReq_lbl = new System.Windows.Forms.Label();
            this.BookingVehicleType_lbl = new System.Windows.Forms.Label();
            this.BookinghelpProvider = new System.Windows.Forms.HelpProvider();
            this.BookingClear_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Book_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerName_lbl = new System.Windows.Forms.Label();
            this.CustomerAddress_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CustomerAddress_lbl = new System.Windows.Forms.Label();
            this.CustomerNIC_lbl = new System.Windows.Forms.Label();
            this.CustomerName_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CustomerNIC_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CustomerTelNo_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CustomerTelNo_lbl = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.BookingStartingDetails_groupBox.SuspendLayout();
            this.BookingSelectTypes_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingStartingDetails_groupBox
            // 
            this.BookingStartingDetails_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingStartingDetails_groupBox.Controls.Add(this.BookingStartTime_lbl);
            this.BookingStartingDetails_groupBox.Controls.Add(this.BookingStartDate_DateTimePicker);
            this.BookingStartingDetails_groupBox.Controls.Add(this.BookingStartingMilage_lbl);
            this.BookingStartingDetails_groupBox.Controls.Add(this.BookingStartingMilage_txt);
            this.BookingStartingDetails_groupBox.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.BookingStartingDetails_groupBox.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingStartingDetails_groupBox.Location = new System.Drawing.Point(655, 22);
            this.BookingStartingDetails_groupBox.Name = "BookingStartingDetails_groupBox";
            this.BookingStartingDetails_groupBox.Size = new System.Drawing.Size(560, 234);
            this.BookingStartingDetails_groupBox.TabIndex = 50;
            this.BookingStartingDetails_groupBox.TabStop = false;
            this.BookingStartingDetails_groupBox.Text = "Starting Details";
            // 
            // BookingStartTime_lbl
            // 
            this.BookingStartTime_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingStartTime_lbl.AutoSize = true;
            this.BookingStartTime_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingStartTime_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingStartTime_lbl.Location = new System.Drawing.Point(88, 36);
            this.BookingStartTime_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingStartTime_lbl.Name = "BookingStartTime_lbl";
            this.BookingStartTime_lbl.Size = new System.Drawing.Size(105, 25);
            this.BookingStartTime_lbl.TabIndex = 31;
            this.BookingStartTime_lbl.Text = "Start Time";
            // 
            // BookingStartDate_DateTimePicker
            // 
            this.BookingStartDate_DateTimePicker.BackColor = System.Drawing.Color.LightGray;
            this.BookingStartDate_DateTimePicker.BorderRadius = 0;
            this.BookingStartDate_DateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.BookingStartDate_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BookingStartDate_DateTimePicker.FormatCustom = null;
            this.BookingStartDate_DateTimePicker.Location = new System.Drawing.Point(99, 67);
            this.BookingStartDate_DateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.BookingStartDate_DateTimePicker.MaximumSize = new System.Drawing.Size(364, 45);
            this.BookingStartDate_DateTimePicker.MinimumSize = new System.Drawing.Size(364, 45);
            this.BookingStartDate_DateTimePicker.Name = "BookingStartDate_DateTimePicker";
            this.BookingStartDate_DateTimePicker.Size = new System.Drawing.Size(364, 45);
            this.BookingStartDate_DateTimePicker.TabIndex = 30;
            this.BookingStartDate_DateTimePicker.Value = new System.DateTime(2020, 7, 2, 23, 43, 43, 863);
            // 
            // BookingStartingMilage_lbl
            // 
            this.BookingStartingMilage_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BookingStartingMilage_lbl.AutoSize = true;
            this.BookingStartingMilage_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingStartingMilage_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingStartingMilage_lbl.Location = new System.Drawing.Point(88, 141);
            this.BookingStartingMilage_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingStartingMilage_lbl.Name = "BookingStartingMilage_lbl";
            this.BookingStartingMilage_lbl.Size = new System.Drawing.Size(146, 25);
            this.BookingStartingMilage_lbl.TabIndex = 32;
            this.BookingStartingMilage_lbl.Text = "Starting Milage";
            // 
            // BookingStartingMilage_txt
            // 
            this.BookingStartingMilage_txt.BorderColorFocused = System.Drawing.Color.White;
            this.BookingStartingMilage_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.BookingStartingMilage_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.BookingStartingMilage_txt.BorderThickness = 3;
            this.BookingStartingMilage_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BookingStartingMilage_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookingStartingMilage_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BookingStartingMilage_txt.ForeColor = System.Drawing.Color.White;
            this.BookingStartingMilage_txt.isPassword = false;
            this.BookingStartingMilage_txt.Location = new System.Drawing.Point(93, 171);
            this.BookingStartingMilage_txt.Margin = new System.Windows.Forms.Padding(5);
            this.BookingStartingMilage_txt.MaxLength = 32767;
            this.BookingStartingMilage_txt.Name = "BookingStartingMilage_txt";
            this.BookingStartingMilage_txt.Padding = new System.Windows.Forms.Padding(4);
            this.BookingStartingMilage_txt.Size = new System.Drawing.Size(370, 41);
            this.BookingStartingMilage_txt.TabIndex = 33;
            this.BookingStartingMilage_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookingStartingMilage_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookingStartingMilage_txt_KeyPress);
            // 
            // BookingSelectTypes_groupBox
            // 
            this.BookingSelectTypes_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingRent_btn);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingHire_btn);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingVehicle_DropDown);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingVehicle_lbl);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingAvailableVehicles_txt);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingAvailableVehicles_lbl);
            this.BookingSelectTypes_groupBox.Controls.Add(this.WithDriver_checkbox);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingTourType_DropDown);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingTour_lbl);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingPackages_lbl);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingPackages_DropDown);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingVehicleTypes_DropDown);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingDriverReq_lbl);
            this.BookingSelectTypes_groupBox.Controls.Add(this.BookingVehicleType_lbl);
            this.BookingSelectTypes_groupBox.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.BookingSelectTypes_groupBox.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingSelectTypes_groupBox.Location = new System.Drawing.Point(24, 22);
            this.BookingSelectTypes_groupBox.Name = "BookingSelectTypes_groupBox";
            this.BookingSelectTypes_groupBox.Size = new System.Drawing.Size(611, 731);
            this.BookingSelectTypes_groupBox.TabIndex = 49;
            this.BookingSelectTypes_groupBox.TabStop = false;
            this.BookingSelectTypes_groupBox.Text = "Select Types";
            // 
            // BookingRent_btn
            // 
            this.BookingRent_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingRent_btn.AutoSize = true;
            this.BookingRent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookingRent_btn.Location = new System.Drawing.Point(518, 43);
            this.BookingRent_btn.Name = "BookingRent_btn";
            this.BookingRent_btn.Size = new System.Drawing.Size(75, 29);
            this.BookingRent_btn.TabIndex = 48;
            this.BookingRent_btn.Text = "Rent";
            this.BookingRent_btn.UseVisualStyleBackColor = true;
            this.BookingRent_btn.CheckedChanged += new System.EventHandler(this.BookingRent_btn_CheckedChanged);
            // 
            // BookingHire_btn
            // 
            this.BookingHire_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingHire_btn.AutoSize = true;
            this.BookingHire_btn.Checked = true;
            this.BookingHire_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookingHire_btn.Location = new System.Drawing.Point(432, 43);
            this.BookingHire_btn.Name = "BookingHire_btn";
            this.BookingHire_btn.Size = new System.Drawing.Size(70, 29);
            this.BookingHire_btn.TabIndex = 47;
            this.BookingHire_btn.TabStop = true;
            this.BookingHire_btn.Text = "Hire";
            this.BookingHire_btn.UseVisualStyleBackColor = true;
            this.BookingHire_btn.CheckedChanged += new System.EventHandler(this.BookingHire_btn_CheckedChanged);
            // 
            // BookingVehicle_DropDown
            // 
            this.BookingVehicle_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.BookingVehicle_DropDown.BorderRadius = 3;
            this.BookingVehicle_DropDown.DisabledColor = System.Drawing.Color.Gray;
            this.BookingVehicle_DropDown.ForeColor = System.Drawing.Color.Black;
            this.BookingVehicle_DropDown.items = new string[0];
            this.BookingVehicle_DropDown.Location = new System.Drawing.Point(44, 401);
            this.BookingVehicle_DropDown.Margin = new System.Windows.Forms.Padding(14);
            this.BookingVehicle_DropDown.MaximumSize = new System.Drawing.Size(364, 43);
            this.BookingVehicle_DropDown.MinimumSize = new System.Drawing.Size(364, 43);
            this.BookingVehicle_DropDown.Name = "BookingVehicle_DropDown";
            this.BookingVehicle_DropDown.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.BookingVehicle_DropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookingVehicle_DropDown.selectedIndex = -1;
            this.BookingVehicle_DropDown.Size = new System.Drawing.Size(364, 43);
            this.BookingVehicle_DropDown.TabIndex = 45;
            this.BookingVehicle_DropDown.onItemSelected += new System.EventHandler(this.BookingVehicle_DropDown_onItemSelected);
            // 
            // BookingVehicle_lbl
            // 
            this.BookingVehicle_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingVehicle_lbl.AutoSize = true;
            this.BookingVehicle_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingVehicle_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingVehicle_lbl.Location = new System.Drawing.Point(39, 362);
            this.BookingVehicle_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingVehicle_lbl.Name = "BookingVehicle_lbl";
            this.BookingVehicle_lbl.Size = new System.Drawing.Size(136, 25);
            this.BookingVehicle_lbl.TabIndex = 46;
            this.BookingVehicle_lbl.Text = "Vehicle Modle";
            // 
            // BookingAvailableVehicles_txt
            // 
            this.BookingAvailableVehicles_txt.BackColor = System.Drawing.Color.Transparent;
            this.BookingAvailableVehicles_txt.BorderRadius = 3;
            this.BookingAvailableVehicles_txt.DisabledColor = System.Drawing.Color.Gray;
            this.BookingAvailableVehicles_txt.ForeColor = System.Drawing.Color.Black;
            this.BookingAvailableVehicles_txt.items = new string[0];
            this.BookingAvailableVehicles_txt.Location = new System.Drawing.Point(44, 493);
            this.BookingAvailableVehicles_txt.Margin = new System.Windows.Forms.Padding(10);
            this.BookingAvailableVehicles_txt.MaximumSize = new System.Drawing.Size(364, 43);
            this.BookingAvailableVehicles_txt.MinimumSize = new System.Drawing.Size(364, 43);
            this.BookingAvailableVehicles_txt.Name = "BookingAvailableVehicles_txt";
            this.BookingAvailableVehicles_txt.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.BookingAvailableVehicles_txt.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookingAvailableVehicles_txt.selectedIndex = -1;
            this.BookingAvailableVehicles_txt.Size = new System.Drawing.Size(364, 43);
            this.BookingAvailableVehicles_txt.TabIndex = 36;
            // 
            // BookingAvailableVehicles_lbl
            // 
            this.BookingAvailableVehicles_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingAvailableVehicles_lbl.AutoSize = true;
            this.BookingAvailableVehicles_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingAvailableVehicles_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingAvailableVehicles_lbl.Location = new System.Drawing.Point(39, 458);
            this.BookingAvailableVehicles_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingAvailableVehicles_lbl.Name = "BookingAvailableVehicles_lbl";
            this.BookingAvailableVehicles_lbl.Size = new System.Drawing.Size(171, 25);
            this.BookingAvailableVehicles_lbl.TabIndex = 37;
            this.BookingAvailableVehicles_lbl.Text = "Available Vehicles";
            // 
            // WithDriver_checkbox
            // 
            this.WithDriver_checkbox.AutoSize = true;
            this.WithDriver_checkbox.Checked = true;
            this.WithDriver_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WithDriver_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WithDriver_checkbox.Enabled = false;
            this.WithDriver_checkbox.Location = new System.Drawing.Point(157, 55);
            this.WithDriver_checkbox.Name = "WithDriver_checkbox";
            this.BookinghelpProvider.SetShowHelp(this.WithDriver_checkbox, false);
            this.WithDriver_checkbox.Size = new System.Drawing.Size(18, 17);
            this.WithDriver_checkbox.TabIndex = 35;
            this.WithDriver_checkbox.UseVisualStyleBackColor = true;
            // 
            // BookingTourType_DropDown
            // 
            this.BookingTourType_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.BookingTourType_DropDown.BorderRadius = 3;
            this.BookingTourType_DropDown.DisabledColor = System.Drawing.Color.Gray;
            this.BookingTourType_DropDown.ForeColor = System.Drawing.Color.Black;
            this.BookingTourType_DropDown.items = new string[] {
        "Day Tour",
        "Long Tour"};
            this.BookingTourType_DropDown.Location = new System.Drawing.Point(44, 138);
            this.BookingTourType_DropDown.Margin = new System.Windows.Forms.Padding(10);
            this.BookingTourType_DropDown.MaximumSize = new System.Drawing.Size(364, 43);
            this.BookingTourType_DropDown.MinimumSize = new System.Drawing.Size(364, 43);
            this.BookingTourType_DropDown.Name = "BookingTourType_DropDown";
            this.BookingTourType_DropDown.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.BookingTourType_DropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookingTourType_DropDown.selectedIndex = -1;
            this.BookingTourType_DropDown.Size = new System.Drawing.Size(364, 43);
            this.BookingTourType_DropDown.TabIndex = 28;
            // 
            // BookingTour_lbl
            // 
            this.BookingTour_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingTour_lbl.AutoSize = true;
            this.BookingTour_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTour_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingTour_lbl.Location = new System.Drawing.Point(39, 103);
            this.BookingTour_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingTour_lbl.Name = "BookingTour_lbl";
            this.BookingTour_lbl.Size = new System.Drawing.Size(97, 25);
            this.BookingTour_lbl.TabIndex = 29;
            this.BookingTour_lbl.Text = "Tour Type";
            // 
            // BookingPackages_lbl
            // 
            this.BookingPackages_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingPackages_lbl.AutoSize = true;
            this.BookingPackages_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingPackages_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingPackages_lbl.Location = new System.Drawing.Point(39, 191);
            this.BookingPackages_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingPackages_lbl.Name = "BookingPackages_lbl";
            this.BookingPackages_lbl.Size = new System.Drawing.Size(98, 25);
            this.BookingPackages_lbl.TabIndex = 27;
            this.BookingPackages_lbl.Text = "Packages";
            // 
            // BookingPackages_DropDown
            // 
            this.BookingPackages_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.BookingPackages_DropDown.BorderRadius = 3;
            this.BookingPackages_DropDown.DisabledColor = System.Drawing.Color.Gray;
            this.BookingPackages_DropDown.ForeColor = System.Drawing.Color.Black;
            this.BookingPackages_DropDown.items = new string[0];
            this.BookingPackages_DropDown.Location = new System.Drawing.Point(44, 227);
            this.BookingPackages_DropDown.Margin = new System.Windows.Forms.Padding(10);
            this.BookingPackages_DropDown.MaximumSize = new System.Drawing.Size(364, 43);
            this.BookingPackages_DropDown.MinimumSize = new System.Drawing.Size(364, 43);
            this.BookingPackages_DropDown.Name = "BookingPackages_DropDown";
            this.BookingPackages_DropDown.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.BookingPackages_DropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookingPackages_DropDown.selectedIndex = -1;
            this.BookingPackages_DropDown.Size = new System.Drawing.Size(364, 43);
            this.BookingPackages_DropDown.TabIndex = 22;
            // 
            // BookingVehicleTypes_DropDown
            // 
            this.BookingVehicleTypes_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.BookingVehicleTypes_DropDown.BorderRadius = 3;
            this.BookingVehicleTypes_DropDown.DisabledColor = System.Drawing.Color.Gray;
            this.BookingVehicleTypes_DropDown.ForeColor = System.Drawing.Color.Black;
            this.BookingVehicleTypes_DropDown.items = new string[0];
            this.BookingVehicleTypes_DropDown.Location = new System.Drawing.Point(44, 312);
            this.BookingVehicleTypes_DropDown.Margin = new System.Windows.Forms.Padding(7);
            this.BookingVehicleTypes_DropDown.MaximumSize = new System.Drawing.Size(364, 43);
            this.BookingVehicleTypes_DropDown.MinimumSize = new System.Drawing.Size(364, 43);
            this.BookingVehicleTypes_DropDown.Name = "BookingVehicleTypes_DropDown";
            this.BookingVehicleTypes_DropDown.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.BookingVehicleTypes_DropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookingVehicleTypes_DropDown.selectedIndex = -1;
            this.BookingVehicleTypes_DropDown.Size = new System.Drawing.Size(364, 43);
            this.BookingVehicleTypes_DropDown.TabIndex = 22;
            this.BookingVehicleTypes_DropDown.onItemSelected += new System.EventHandler(this.BookingVehicleTypes_DropDown_onItemSelected);
            // 
            // BookingDriverReq_lbl
            // 
            this.BookingDriverReq_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingDriverReq_lbl.AutoSize = true;
            this.BookingDriverReq_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDriverReq_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingDriverReq_lbl.Location = new System.Drawing.Point(39, 52);
            this.BookingDriverReq_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingDriverReq_lbl.Name = "BookingDriverReq_lbl";
            this.BookingDriverReq_lbl.Size = new System.Drawing.Size(111, 25);
            this.BookingDriverReq_lbl.TabIndex = 24;
            this.BookingDriverReq_lbl.Text = "With Driver";
            // 
            // BookingVehicleType_lbl
            // 
            this.BookingVehicleType_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingVehicleType_lbl.AutoSize = true;
            this.BookingVehicleType_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingVehicleType_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookingVehicleType_lbl.Location = new System.Drawing.Point(39, 279);
            this.BookingVehicleType_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingVehicleType_lbl.Name = "BookingVehicleType_lbl";
            this.BookingVehicleType_lbl.Size = new System.Drawing.Size(122, 25);
            this.BookingVehicleType_lbl.TabIndex = 26;
            this.BookingVehicleType_lbl.Text = "Vehicle Type";
            // 
            // BookingClear_btn
            // 
            this.BookingClear_btn.Active = false;
            this.BookingClear_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.BookingClear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookingClear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BookingClear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookingClear_btn.BorderRadius = 0;
            this.BookingClear_btn.ButtonText = "Clear";
            this.BookingClear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookingClear_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BookingClear_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.BookingClear_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.BookingClear_btn.Iconimage = null;
            this.BookingClear_btn.Iconimage_right = null;
            this.BookingClear_btn.Iconimage_right_Selected = null;
            this.BookingClear_btn.Iconimage_Selected = null;
            this.BookingClear_btn.IconMarginLeft = 20;
            this.BookingClear_btn.IconMarginRight = 0;
            this.BookingClear_btn.IconRightVisible = true;
            this.BookingClear_btn.IconRightZoom = 0D;
            this.BookingClear_btn.IconVisible = false;
            this.BookingClear_btn.IconZoom = 60D;
            this.BookingClear_btn.IsTab = false;
            this.BookingClear_btn.Location = new System.Drawing.Point(959, 723);
            this.BookingClear_btn.Margin = new System.Windows.Forms.Padding(5);
            this.BookingClear_btn.MaximumSize = new System.Drawing.Size(123, 42);
            this.BookingClear_btn.Name = "BookingClear_btn";
            this.BookingClear_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BookingClear_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.BookingClear_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.BookingClear_btn.selected = false;
            this.BookingClear_btn.Size = new System.Drawing.Size(123, 42);
            this.BookingClear_btn.TabIndex = 52;
            this.BookingClear_btn.Text = "Clear";
            this.BookingClear_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BookingClear_btn.Textcolor = System.Drawing.Color.White;
            this.BookingClear_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Book_btn
            // 
            this.Book_btn.Active = false;
            this.Book_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Book_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Book_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Book_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Book_btn.BorderRadius = 0;
            this.Book_btn.ButtonText = "Book";
            this.Book_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Book_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.Book_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Book_btn.Iconimage = null;
            this.Book_btn.Iconimage_right = null;
            this.Book_btn.Iconimage_right_Selected = null;
            this.Book_btn.Iconimage_Selected = null;
            this.Book_btn.IconMarginLeft = 20;
            this.Book_btn.IconMarginRight = 0;
            this.Book_btn.IconRightVisible = true;
            this.Book_btn.IconRightZoom = 0D;
            this.Book_btn.IconVisible = false;
            this.Book_btn.IconZoom = 60D;
            this.Book_btn.IsTab = false;
            this.Book_btn.Location = new System.Drawing.Point(1092, 723);
            this.Book_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Book_btn.MaximumSize = new System.Drawing.Size(123, 42);
            this.Book_btn.Name = "Book_btn";
            this.Book_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Book_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Book_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Book_btn.selected = false;
            this.Book_btn.Size = new System.Drawing.Size(123, 42);
            this.Book_btn.TabIndex = 51;
            this.Book_btn.Text = "Book";
            this.Book_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Book_btn.Textcolor = System.Drawing.Color.White;
            this.Book_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_btn.Click += new System.EventHandler(this.Book_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CustomerName_lbl);
            this.groupBox1.Controls.Add(this.CustomerAddress_txt);
            this.groupBox1.Controls.Add(this.CustomerAddress_lbl);
            this.groupBox1.Controls.Add(this.CustomerNIC_lbl);
            this.groupBox1.Controls.Add(this.CustomerName_txt);
            this.groupBox1.Controls.Add(this.CustomerNIC_txt);
            this.groupBox1.Controls.Add(this.CustomerTelNo_txt);
            this.groupBox1.Controls.Add(this.CustomerTelNo_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(655, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 440);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // CustomerName_lbl
            // 
            this.CustomerName_lbl.AutoSize = true;
            this.CustomerName_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerName_lbl.Location = new System.Drawing.Point(29, 31);
            this.CustomerName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerName_lbl.Name = "CustomerName_lbl";
            this.CustomerName_lbl.Size = new System.Drawing.Size(155, 25);
            this.CustomerName_lbl.TabIndex = 37;
            this.CustomerName_lbl.Text = "Customer Name";
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
            this.CustomerAddress_txt.Location = new System.Drawing.Point(34, 221);
            this.CustomerAddress_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerAddress_txt.MaxLength = 32767;
            this.CustomerAddress_txt.Name = "CustomerAddress_txt";
            this.CustomerAddress_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerAddress_txt.Size = new System.Drawing.Size(429, 119);
            this.CustomerAddress_txt.TabIndex = 39;
            this.CustomerAddress_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerAddress_lbl
            // 
            this.CustomerAddress_lbl.AutoSize = true;
            this.CustomerAddress_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerAddress_lbl.Location = new System.Drawing.Point(29, 191);
            this.CustomerAddress_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerAddress_lbl.Name = "CustomerAddress_lbl";
            this.CustomerAddress_lbl.Size = new System.Drawing.Size(175, 25);
            this.CustomerAddress_lbl.TabIndex = 38;
            this.CustomerAddress_lbl.Text = "Customer Address";
            // 
            // CustomerNIC_lbl
            // 
            this.CustomerNIC_lbl.AutoSize = true;
            this.CustomerNIC_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNIC_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerNIC_lbl.Location = new System.Drawing.Point(29, 113);
            this.CustomerNIC_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNIC_lbl.Name = "CustomerNIC_lbl";
            this.CustomerNIC_lbl.Size = new System.Drawing.Size(136, 25);
            this.CustomerNIC_lbl.TabIndex = 43;
            this.CustomerNIC_lbl.Text = "Customer NIC";
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
            this.CustomerName_txt.Location = new System.Drawing.Point(34, 63);
            this.CustomerName_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerName_txt.MaxLength = 32767;
            this.CustomerName_txt.Name = "CustomerName_txt";
            this.CustomerName_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerName_txt.Size = new System.Drawing.Size(429, 43);
            this.CustomerName_txt.TabIndex = 36;
            this.CustomerName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.CustomerNIC_txt.Location = new System.Drawing.Point(34, 143);
            this.CustomerNIC_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerNIC_txt.MaxLength = 32767;
            this.CustomerNIC_txt.Name = "CustomerNIC_txt";
            this.CustomerNIC_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerNIC_txt.Size = new System.Drawing.Size(429, 43);
            this.CustomerNIC_txt.TabIndex = 42;
            this.CustomerNIC_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.CustomerTelNo_txt.Location = new System.Drawing.Point(34, 375);
            this.CustomerTelNo_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerTelNo_txt.MaxLength = 32767;
            this.CustomerTelNo_txt.Name = "CustomerTelNo_txt";
            this.CustomerTelNo_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerTelNo_txt.Size = new System.Drawing.Size(429, 43);
            this.CustomerTelNo_txt.TabIndex = 40;
            this.CustomerTelNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerTelNo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerTelNo_txt_KeyPress);
            // 
            // CustomerTelNo_lbl
            // 
            this.CustomerTelNo_lbl.AutoSize = true;
            this.CustomerTelNo_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTelNo_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerTelNo_lbl.Location = new System.Drawing.Point(29, 345);
            this.CustomerTelNo_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerTelNo_lbl.Name = "CustomerTelNo_lbl";
            this.CustomerTelNo_lbl.Size = new System.Drawing.Size(159, 25);
            this.CustomerTelNo_lbl.TabIndex = 41;
            this.CustomerTelNo_lbl.Text = "Customer Tel No";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.ContainerControl = this;
            this.ErrorMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorMessage.Icon")));
            // 
            // Boocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BookingClear_btn);
            this.Controls.Add(this.Book_btn);
            this.Controls.Add(this.BookingStartingDetails_groupBox);
            this.Controls.Add(this.BookingSelectTypes_groupBox);
            this.Name = "Boocking";
            this.Size = new System.Drawing.Size(1236, 776);
            this.Load += new System.EventHandler(this.Boocking_Load);
            this.BookingStartingDetails_groupBox.ResumeLayout(false);
            this.BookingStartingDetails_groupBox.PerformLayout();
            this.BookingSelectTypes_groupBox.ResumeLayout(false);
            this.BookingSelectTypes_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BookingStartingDetails_groupBox;
        private System.Windows.Forms.Label BookingStartTime_lbl;
        private Bunifu.Framework.UI.BunifuDatepicker BookingStartDate_DateTimePicker;
        private System.Windows.Forms.GroupBox BookingSelectTypes_groupBox;
        private Bunifu.Framework.UI.BunifuDropdown BookingVehicle_DropDown;
        private System.Windows.Forms.Label BookingVehicle_lbl;
        private Bunifu.Framework.UI.BunifuDropdown BookingAvailableVehicles_txt;
        private System.Windows.Forms.Label BookingAvailableVehicles_lbl;
        private System.Windows.Forms.CheckBox WithDriver_checkbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox BookingStartingMilage_txt;
        private System.Windows.Forms.Label BookingStartingMilage_lbl;
        private Bunifu.Framework.UI.BunifuDropdown BookingTourType_DropDown;
        private System.Windows.Forms.Label BookingTour_lbl;
        private System.Windows.Forms.Label BookingPackages_lbl;
        private Bunifu.Framework.UI.BunifuDropdown BookingPackages_DropDown;
        private Bunifu.Framework.UI.BunifuDropdown BookingVehicleTypes_DropDown;
        private System.Windows.Forms.Label BookingDriverReq_lbl;
        private System.Windows.Forms.Label BookingVehicleType_lbl;
        private System.Windows.Forms.HelpProvider BookinghelpProvider;
        private System.Windows.Forms.RadioButton BookingRent_btn;
        private System.Windows.Forms.RadioButton BookingHire_btn;
        protected internal Bunifu.Framework.UI.BunifuFlatButton BookingClear_btn;
        protected internal Bunifu.Framework.UI.BunifuFlatButton Book_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CustomerName_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerAddress_txt;
        private System.Windows.Forms.Label CustomerAddress_lbl;
        private System.Windows.Forms.Label CustomerNIC_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerName_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerNIC_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerTelNo_txt;
        private System.Windows.Forms.Label CustomerTelNo_lbl;
        private System.Windows.Forms.ErrorProvider ErrorMessage;
    }
}
