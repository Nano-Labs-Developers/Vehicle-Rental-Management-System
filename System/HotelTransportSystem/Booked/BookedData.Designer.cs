namespace HotelTransportSystem.Booked
{
    partial class BookedData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookedSearchBox_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Booked_groupBox = new System.Windows.Forms.GroupBox();
            this.BookedTimeDate_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BookedDateTime_lbl = new System.Windows.Forms.Label();
            this.TourType_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TourType_lbl = new System.Windows.Forms.Label();
            this.HireorRent_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.HireorRent_lbl = new System.Windows.Forms.Label();
            this.StartingMilage_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.StartingMilage_lbl = new System.Windows.Forms.Label();
            this.CustomerNIC_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CustomerNIC_lbl = new System.Windows.Forms.Label();
            this.PackageName_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PackageName_lbl = new System.Windows.Forms.Label();
            this.WithDriver_checkbox = new System.Windows.Forms.CheckBox();
            this.BookedVehicleRegNo_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BookedVehicleRegno_lbl = new System.Windows.Forms.Label();
            this.WithDriver_lbl = new System.Windows.Forms.Label();
            this.BookedDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BookedDataListView_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BookedDataStandard_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BookedDelete_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Booked_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BookedSearchBox_txt
            // 
            this.BookedSearchBox_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookedSearchBox_txt.BorderColorFocused = System.Drawing.Color.White;
            this.BookedSearchBox_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.BookedSearchBox_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.BookedSearchBox_txt.BorderThickness = 3;
            this.BookedSearchBox_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BookedSearchBox_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookedSearchBox_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BookedSearchBox_txt.ForeColor = System.Drawing.Color.White;
            this.BookedSearchBox_txt.isPassword = false;
            this.BookedSearchBox_txt.Location = new System.Drawing.Point(507, 25);
            this.BookedSearchBox_txt.Margin = new System.Windows.Forms.Padding(5);
            this.BookedSearchBox_txt.MaxLength = 32767;
            this.BookedSearchBox_txt.Name = "BookedSearchBox_txt";
            this.BookedSearchBox_txt.Padding = new System.Windows.Forms.Padding(4);
            this.BookedSearchBox_txt.Size = new System.Drawing.Size(345, 37);
            this.BookedSearchBox_txt.TabIndex = 51;
            this.BookedSearchBox_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookedSearchBox_txt.OnValueChanged += new System.EventHandler(this.BookedSearchBox_txt_OnValueChanged);
            // 
            // Booked_groupBox
            // 
            this.Booked_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Booked_groupBox.Controls.Add(this.BookedDelete_btn);
            this.Booked_groupBox.Controls.Add(this.BookedTimeDate_txt);
            this.Booked_groupBox.Controls.Add(this.BookedDateTime_lbl);
            this.Booked_groupBox.Controls.Add(this.TourType_txt);
            this.Booked_groupBox.Controls.Add(this.TourType_lbl);
            this.Booked_groupBox.Controls.Add(this.HireorRent_txt);
            this.Booked_groupBox.Controls.Add(this.HireorRent_lbl);
            this.Booked_groupBox.Controls.Add(this.StartingMilage_txt);
            this.Booked_groupBox.Controls.Add(this.StartingMilage_lbl);
            this.Booked_groupBox.Controls.Add(this.CustomerNIC_txt);
            this.Booked_groupBox.Controls.Add(this.CustomerNIC_lbl);
            this.Booked_groupBox.Controls.Add(this.PackageName_txt);
            this.Booked_groupBox.Controls.Add(this.PackageName_lbl);
            this.Booked_groupBox.Controls.Add(this.WithDriver_checkbox);
            this.Booked_groupBox.Controls.Add(this.BookedVehicleRegNo_txt);
            this.Booked_groupBox.Controls.Add(this.BookedVehicleRegno_lbl);
            this.Booked_groupBox.Controls.Add(this.WithDriver_lbl);
            this.Booked_groupBox.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.Booked_groupBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Booked_groupBox.Location = new System.Drawing.Point(18, 25);
            this.Booked_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.Booked_groupBox.Name = "Booked_groupBox";
            this.Booked_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.Booked_groupBox.Size = new System.Drawing.Size(481, 737);
            this.Booked_groupBox.TabIndex = 50;
            this.Booked_groupBox.TabStop = false;
            this.Booked_groupBox.Text = "Vehicle Booked Data";
            // 
            // BookedTimeDate_txt
            // 
            this.BookedTimeDate_txt.BorderColorFocused = System.Drawing.Color.White;
            this.BookedTimeDate_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.BookedTimeDate_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.BookedTimeDate_txt.BorderThickness = 3;
            this.BookedTimeDate_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BookedTimeDate_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookedTimeDate_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BookedTimeDate_txt.ForeColor = System.Drawing.Color.White;
            this.BookedTimeDate_txt.isPassword = false;
            this.BookedTimeDate_txt.Location = new System.Drawing.Point(33, 604);
            this.BookedTimeDate_txt.Margin = new System.Windows.Forms.Padding(5);
            this.BookedTimeDate_txt.MaxLength = 32767;
            this.BookedTimeDate_txt.Name = "BookedTimeDate_txt";
            this.BookedTimeDate_txt.Padding = new System.Windows.Forms.Padding(4);
            this.BookedTimeDate_txt.Size = new System.Drawing.Size(429, 40);
            this.BookedTimeDate_txt.TabIndex = 58;
            this.BookedTimeDate_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BookedDateTime_lbl
            // 
            this.BookedDateTime_lbl.AutoSize = true;
            this.BookedDateTime_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedDateTime_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookedDateTime_lbl.Location = new System.Drawing.Point(28, 574);
            this.BookedDateTime_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookedDateTime_lbl.Name = "BookedDateTime_lbl";
            this.BookedDateTime_lbl.Size = new System.Drawing.Size(214, 25);
            this.BookedDateTime_lbl.TabIndex = 59;
            this.BookedDateTime_lbl.Text = "Booked Date and Time";
            // 
            // TourType_txt
            // 
            this.TourType_txt.BorderColorFocused = System.Drawing.Color.White;
            this.TourType_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.TourType_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.TourType_txt.BorderThickness = 3;
            this.TourType_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TourType_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TourType_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TourType_txt.ForeColor = System.Drawing.Color.White;
            this.TourType_txt.isPassword = false;
            this.TourType_txt.Location = new System.Drawing.Point(33, 515);
            this.TourType_txt.Margin = new System.Windows.Forms.Padding(5);
            this.TourType_txt.MaxLength = 32767;
            this.TourType_txt.Name = "TourType_txt";
            this.TourType_txt.Padding = new System.Windows.Forms.Padding(4);
            this.TourType_txt.Size = new System.Drawing.Size(429, 40);
            this.TourType_txt.TabIndex = 56;
            this.TourType_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TourType_lbl
            // 
            this.TourType_lbl.AutoSize = true;
            this.TourType_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TourType_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.TourType_lbl.Location = new System.Drawing.Point(28, 485);
            this.TourType_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TourType_lbl.Name = "TourType_lbl";
            this.TourType_lbl.Size = new System.Drawing.Size(97, 25);
            this.TourType_lbl.TabIndex = 57;
            this.TourType_lbl.Text = "Tour Type";
            // 
            // HireorRent_txt
            // 
            this.HireorRent_txt.BorderColorFocused = System.Drawing.Color.White;
            this.HireorRent_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.HireorRent_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.HireorRent_txt.BorderThickness = 3;
            this.HireorRent_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HireorRent_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HireorRent_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.HireorRent_txt.ForeColor = System.Drawing.Color.White;
            this.HireorRent_txt.isPassword = false;
            this.HireorRent_txt.Location = new System.Drawing.Point(33, 425);
            this.HireorRent_txt.Margin = new System.Windows.Forms.Padding(5);
            this.HireorRent_txt.MaxLength = 32767;
            this.HireorRent_txt.Name = "HireorRent_txt";
            this.HireorRent_txt.Padding = new System.Windows.Forms.Padding(4);
            this.HireorRent_txt.Size = new System.Drawing.Size(429, 40);
            this.HireorRent_txt.TabIndex = 54;
            this.HireorRent_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HireorRent_lbl
            // 
            this.HireorRent_lbl.AutoSize = true;
            this.HireorRent_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HireorRent_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.HireorRent_lbl.Location = new System.Drawing.Point(28, 395);
            this.HireorRent_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HireorRent_lbl.Name = "HireorRent_lbl";
            this.HireorRent_lbl.Size = new System.Drawing.Size(119, 25);
            this.HireorRent_lbl.TabIndex = 55;
            this.HireorRent_lbl.Text = "Hire or Rent";
            // 
            // StartingMilage_txt
            // 
            this.StartingMilage_txt.BorderColorFocused = System.Drawing.Color.White;
            this.StartingMilage_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.StartingMilage_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.StartingMilage_txt.BorderThickness = 3;
            this.StartingMilage_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.StartingMilage_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartingMilage_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StartingMilage_txt.ForeColor = System.Drawing.Color.White;
            this.StartingMilage_txt.isPassword = false;
            this.StartingMilage_txt.Location = new System.Drawing.Point(33, 340);
            this.StartingMilage_txt.Margin = new System.Windows.Forms.Padding(5);
            this.StartingMilage_txt.MaxLength = 32767;
            this.StartingMilage_txt.Name = "StartingMilage_txt";
            this.StartingMilage_txt.Padding = new System.Windows.Forms.Padding(4);
            this.StartingMilage_txt.Size = new System.Drawing.Size(429, 40);
            this.StartingMilage_txt.TabIndex = 52;
            this.StartingMilage_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // StartingMilage_lbl
            // 
            this.StartingMilage_lbl.AutoSize = true;
            this.StartingMilage_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingMilage_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.StartingMilage_lbl.Location = new System.Drawing.Point(28, 310);
            this.StartingMilage_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartingMilage_lbl.Name = "StartingMilage_lbl";
            this.StartingMilage_lbl.Size = new System.Drawing.Size(146, 25);
            this.StartingMilage_lbl.TabIndex = 53;
            this.StartingMilage_lbl.Text = "Starting Milage";
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
            this.CustomerNIC_txt.Location = new System.Drawing.Point(33, 248);
            this.CustomerNIC_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerNIC_txt.MaxLength = 32767;
            this.CustomerNIC_txt.Name = "CustomerNIC_txt";
            this.CustomerNIC_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerNIC_txt.Size = new System.Drawing.Size(429, 40);
            this.CustomerNIC_txt.TabIndex = 50;
            this.CustomerNIC_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerNIC_lbl
            // 
            this.CustomerNIC_lbl.AutoSize = true;
            this.CustomerNIC_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNIC_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.CustomerNIC_lbl.Location = new System.Drawing.Point(28, 218);
            this.CustomerNIC_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNIC_lbl.Name = "CustomerNIC_lbl";
            this.CustomerNIC_lbl.Size = new System.Drawing.Size(136, 25);
            this.CustomerNIC_lbl.TabIndex = 51;
            this.CustomerNIC_lbl.Text = "Customer NIC";
            // 
            // PackageName_txt
            // 
            this.PackageName_txt.BorderColorFocused = System.Drawing.Color.White;
            this.PackageName_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.PackageName_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.PackageName_txt.BorderThickness = 3;
            this.PackageName_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PackageName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PackageName_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PackageName_txt.ForeColor = System.Drawing.Color.White;
            this.PackageName_txt.isPassword = false;
            this.PackageName_txt.Location = new System.Drawing.Point(33, 154);
            this.PackageName_txt.Margin = new System.Windows.Forms.Padding(5);
            this.PackageName_txt.MaxLength = 32767;
            this.PackageName_txt.Name = "PackageName_txt";
            this.PackageName_txt.Padding = new System.Windows.Forms.Padding(4);
            this.PackageName_txt.Size = new System.Drawing.Size(429, 40);
            this.PackageName_txt.TabIndex = 48;
            this.PackageName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PackageName_lbl
            // 
            this.PackageName_lbl.AutoSize = true;
            this.PackageName_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageName_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.PackageName_lbl.Location = new System.Drawing.Point(28, 124);
            this.PackageName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PackageName_lbl.Name = "PackageName_lbl";
            this.PackageName_lbl.Size = new System.Drawing.Size(145, 25);
            this.PackageName_lbl.TabIndex = 49;
            this.PackageName_lbl.Text = "Package Name";
            // 
            // WithDriver_checkbox
            // 
            this.WithDriver_checkbox.AutoSize = true;
            this.WithDriver_checkbox.Location = new System.Drawing.Point(146, 666);
            this.WithDriver_checkbox.Name = "WithDriver_checkbox";
            this.WithDriver_checkbox.Size = new System.Drawing.Size(18, 17);
            this.WithDriver_checkbox.TabIndex = 47;
            this.WithDriver_checkbox.UseVisualStyleBackColor = true;
            // 
            // BookedVehicleRegNo_txt
            // 
            this.BookedVehicleRegNo_txt.BorderColorFocused = System.Drawing.Color.White;
            this.BookedVehicleRegNo_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.BookedVehicleRegNo_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.BookedVehicleRegNo_txt.BorderThickness = 3;
            this.BookedVehicleRegNo_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BookedVehicleRegNo_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookedVehicleRegNo_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BookedVehicleRegNo_txt.ForeColor = System.Drawing.Color.White;
            this.BookedVehicleRegNo_txt.isPassword = false;
            this.BookedVehicleRegNo_txt.Location = new System.Drawing.Point(33, 63);
            this.BookedVehicleRegNo_txt.Margin = new System.Windows.Forms.Padding(5);
            this.BookedVehicleRegNo_txt.MaxLength = 32767;
            this.BookedVehicleRegNo_txt.Name = "BookedVehicleRegNo_txt";
            this.BookedVehicleRegNo_txt.Padding = new System.Windows.Forms.Padding(4);
            this.BookedVehicleRegNo_txt.Size = new System.Drawing.Size(429, 40);
            this.BookedVehicleRegNo_txt.TabIndex = 34;
            this.BookedVehicleRegNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BookedVehicleRegno_lbl
            // 
            this.BookedVehicleRegno_lbl.AutoSize = true;
            this.BookedVehicleRegno_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedVehicleRegno_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.BookedVehicleRegno_lbl.Location = new System.Drawing.Point(28, 33);
            this.BookedVehicleRegno_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookedVehicleRegno_lbl.Name = "BookedVehicleRegno_lbl";
            this.BookedVehicleRegno_lbl.Size = new System.Drawing.Size(214, 25);
            this.BookedVehicleRegno_lbl.TabIndex = 35;
            this.BookedVehicleRegno_lbl.Text = "Booked Vehicle Reg no";
            // 
            // WithDriver_lbl
            // 
            this.WithDriver_lbl.AutoSize = true;
            this.WithDriver_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithDriver_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.WithDriver_lbl.Location = new System.Drawing.Point(28, 662);
            this.WithDriver_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WithDriver_lbl.Name = "WithDriver_lbl";
            this.WithDriver_lbl.Size = new System.Drawing.Size(111, 25);
            this.WithDriver_lbl.TabIndex = 33;
            this.WithDriver_lbl.Text = "With Driver";
            // 
            // BookedDataGrid
            // 
            this.BookedDataGrid.AllowUserToAddRows = false;
            this.BookedDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookedDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.BookedDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookedDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookedDataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
            this.BookedDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookedDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookedDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.BookedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookedDataGrid.DoubleBuffered = true;
            this.BookedDataGrid.EnableHeadersVisualStyles = false;
            this.BookedDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.BookedDataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.BookedDataGrid.Location = new System.Drawing.Point(507, 81);
            this.BookedDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.BookedDataGrid.Name = "BookedDataGrid";
            this.BookedDataGrid.ReadOnly = true;
            this.BookedDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookedDataGrid.RowHeadersVisible = false;
            this.BookedDataGrid.RowHeadersWidth = 51;
            this.BookedDataGrid.Size = new System.Drawing.Size(712, 681);
            this.BookedDataGrid.TabIndex = 49;
            this.BookedDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookedDataGrid_CellClick);
            // 
            // BookedDataListView_btn
            // 
            this.BookedDataListView_btn.Active = false;
            this.BookedDataListView_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.BookedDataListView_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookedDataListView_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BookedDataListView_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookedDataListView_btn.BorderRadius = 0;
            this.BookedDataListView_btn.ButtonText = "List View";
            this.BookedDataListView_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookedDataListView_btn.DisabledColor = System.Drawing.Color.Gray;
            this.BookedDataListView_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.BookedDataListView_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.BookedDataListView_btn.Iconimage = null;
            this.BookedDataListView_btn.Iconimage_right = null;
            this.BookedDataListView_btn.Iconimage_right_Selected = null;
            this.BookedDataListView_btn.Iconimage_Selected = null;
            this.BookedDataListView_btn.IconMarginLeft = 20;
            this.BookedDataListView_btn.IconMarginRight = 0;
            this.BookedDataListView_btn.IconRightVisible = true;
            this.BookedDataListView_btn.IconRightZoom = 0D;
            this.BookedDataListView_btn.IconVisible = false;
            this.BookedDataListView_btn.IconZoom = 60D;
            this.BookedDataListView_btn.IsTab = false;
            this.BookedDataListView_btn.Location = new System.Drawing.Point(1082, 15);
            this.BookedDataListView_btn.Margin = new System.Windows.Forms.Padding(5);
            this.BookedDataListView_btn.Name = "BookedDataListView_btn";
            this.BookedDataListView_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BookedDataListView_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.BookedDataListView_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.BookedDataListView_btn.selected = false;
            this.BookedDataListView_btn.Size = new System.Drawing.Size(137, 59);
            this.BookedDataListView_btn.TabIndex = 48;
            this.BookedDataListView_btn.Text = "List View";
            this.BookedDataListView_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BookedDataListView_btn.Textcolor = System.Drawing.Color.White;
            this.BookedDataListView_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedDataListView_btn.Click += new System.EventHandler(this.BookedDataListView_btn_Click);
            // 
            // BookedDataStandard_btn
            // 
            this.BookedDataStandard_btn.Active = false;
            this.BookedDataStandard_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.BookedDataStandard_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookedDataStandard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BookedDataStandard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookedDataStandard_btn.BorderRadius = 0;
            this.BookedDataStandard_btn.ButtonText = "Standard View";
            this.BookedDataStandard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookedDataStandard_btn.DisabledColor = System.Drawing.Color.Gray;
            this.BookedDataStandard_btn.Enabled = false;
            this.BookedDataStandard_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.BookedDataStandard_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.BookedDataStandard_btn.Iconimage = null;
            this.BookedDataStandard_btn.Iconimage_right = null;
            this.BookedDataStandard_btn.Iconimage_right_Selected = null;
            this.BookedDataStandard_btn.Iconimage_Selected = null;
            this.BookedDataStandard_btn.IconMarginLeft = 20;
            this.BookedDataStandard_btn.IconMarginRight = 0;
            this.BookedDataStandard_btn.IconRightVisible = true;
            this.BookedDataStandard_btn.IconRightZoom = 0D;
            this.BookedDataStandard_btn.IconVisible = false;
            this.BookedDataStandard_btn.IconZoom = 60D;
            this.BookedDataStandard_btn.IsTab = false;
            this.BookedDataStandard_btn.Location = new System.Drawing.Point(863, 15);
            this.BookedDataStandard_btn.Margin = new System.Windows.Forms.Padding(5);
            this.BookedDataStandard_btn.Name = "BookedDataStandard_btn";
            this.BookedDataStandard_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BookedDataStandard_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.BookedDataStandard_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.BookedDataStandard_btn.selected = false;
            this.BookedDataStandard_btn.Size = new System.Drawing.Size(211, 59);
            this.BookedDataStandard_btn.TabIndex = 47;
            this.BookedDataStandard_btn.Text = "Standard View";
            this.BookedDataStandard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BookedDataStandard_btn.Textcolor = System.Drawing.Color.White;
            this.BookedDataStandard_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BookedDelete_btn
            // 
            this.BookedDelete_btn.Active = false;
            this.BookedDelete_btn.Activecolor = System.Drawing.Color.Red;
            this.BookedDelete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookedDelete_btn.BackColor = System.Drawing.Color.Red;
            this.BookedDelete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookedDelete_btn.BorderRadius = 7;
            this.BookedDelete_btn.ButtonText = "DELETE";
            this.BookedDelete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookedDelete_btn.DisabledColor = System.Drawing.Color.Gray;
            this.BookedDelete_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.BookedDelete_btn.Iconimage = null;
            this.BookedDelete_btn.Iconimage_right = null;
            this.BookedDelete_btn.Iconimage_right_Selected = null;
            this.BookedDelete_btn.Iconimage_Selected = null;
            this.BookedDelete_btn.IconMarginLeft = 0;
            this.BookedDelete_btn.IconMarginRight = 0;
            this.BookedDelete_btn.IconRightVisible = false;
            this.BookedDelete_btn.IconRightZoom = 0D;
            this.BookedDelete_btn.IconVisible = false;
            this.BookedDelete_btn.IconZoom = 90D;
            this.BookedDelete_btn.IsTab = false;
            this.BookedDelete_btn.Location = new System.Drawing.Point(345, 683);
            this.BookedDelete_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BookedDelete_btn.Name = "BookedDelete_btn";
            this.BookedDelete_btn.Normalcolor = System.Drawing.Color.Red;
            this.BookedDelete_btn.OnHovercolor = System.Drawing.Color.Crimson;
            this.BookedDelete_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.BookedDelete_btn.selected = false;
            this.BookedDelete_btn.Size = new System.Drawing.Size(117, 35);
            this.BookedDelete_btn.TabIndex = 60;
            this.BookedDelete_btn.Text = "DELETE";
            this.BookedDelete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BookedDelete_btn.Textcolor = System.Drawing.Color.White;
            this.BookedDelete_btn.TextFont = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedDelete_btn.Visible = false;
            this.BookedDelete_btn.Click += new System.EventHandler(this.BookedDelete_btn_Click);
            // 
            // BookedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.BookedSearchBox_txt);
            this.Controls.Add(this.Booked_groupBox);
            this.Controls.Add(this.BookedDataGrid);
            this.Controls.Add(this.BookedDataListView_btn);
            this.Controls.Add(this.BookedDataStandard_btn);
            this.Name = "BookedData";
            this.Size = new System.Drawing.Size(1236, 777);
            this.Load += new System.EventHandler(this.BookedData_Load);
            this.Booked_groupBox.ResumeLayout(false);
            this.Booked_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookedDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox BookedSearchBox_txt;
        private System.Windows.Forms.GroupBox Booked_groupBox;
        private System.Windows.Forms.CheckBox WithDriver_checkbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox BookedVehicleRegNo_txt;
        private System.Windows.Forms.Label BookedVehicleRegno_lbl;
        private System.Windows.Forms.Label WithDriver_lbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BookedDataGrid;
        private Bunifu.Framework.UI.BunifuFlatButton BookedDataListView_btn;
        private Bunifu.Framework.UI.BunifuFlatButton BookedDataStandard_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox BookedTimeDate_txt;
        private System.Windows.Forms.Label BookedDateTime_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox TourType_txt;
        private System.Windows.Forms.Label TourType_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox HireorRent_txt;
        private System.Windows.Forms.Label HireorRent_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox StartingMilage_txt;
        private System.Windows.Forms.Label StartingMilage_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox CustomerNIC_txt;
        private System.Windows.Forms.Label CustomerNIC_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox PackageName_txt;
        private System.Windows.Forms.Label PackageName_lbl;
        private Bunifu.Framework.UI.BunifuFlatButton BookedDelete_btn;
    }
}
