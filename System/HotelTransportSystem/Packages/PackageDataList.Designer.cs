namespace HotelTransportSystem.Packages
{
    partial class PackageDataList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PackageDataGridList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SearchBoxList_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.VehiclesDataListViewList_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.VehiclesDataStandardList_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.PackageDataGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // PackageDataGridList
            // 
            this.PackageDataGridList.AllowUserToAddRows = false;
            this.PackageDataGridList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PackageDataGridList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PackageDataGridList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackageDataGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PackageDataGridList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.PackageDataGridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PackageDataGridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PackageDataGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PackageDataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackageDataGridList.DoubleBuffered = true;
            this.PackageDataGridList.EnableHeadersVisualStyles = false;
            this.PackageDataGridList.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.PackageDataGridList.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.PackageDataGridList.Location = new System.Drawing.Point(12, 83);
            this.PackageDataGridList.Margin = new System.Windows.Forms.Padding(4);
            this.PackageDataGridList.Name = "PackageDataGridList";
            this.PackageDataGridList.ReadOnly = true;
            this.PackageDataGridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PackageDataGridList.RowHeadersVisible = false;
            this.PackageDataGridList.RowHeadersWidth = 51;
            this.PackageDataGridList.Size = new System.Drawing.Size(1212, 681);
            this.PackageDataGridList.TabIndex = 45;
            // 
            // SearchBoxList_txt
            // 
            this.SearchBoxList_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBoxList_txt.BorderColorFocused = System.Drawing.Color.White;
            this.SearchBoxList_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.SearchBoxList_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.SearchBoxList_txt.BorderThickness = 3;
            this.SearchBoxList_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchBoxList_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBoxList_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchBoxList_txt.ForeColor = System.Drawing.Color.White;
            this.SearchBoxList_txt.isPassword = false;
            this.SearchBoxList_txt.Location = new System.Drawing.Point(511, 25);
            this.SearchBoxList_txt.Margin = new System.Windows.Forms.Padding(5);
            this.SearchBoxList_txt.MaxLength = 32767;
            this.SearchBoxList_txt.Name = "SearchBoxList_txt";
            this.SearchBoxList_txt.Padding = new System.Windows.Forms.Padding(4);
            this.SearchBoxList_txt.Size = new System.Drawing.Size(345, 37);
            this.SearchBoxList_txt.TabIndex = 51;
            this.SearchBoxList_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBoxList_txt.OnValueChanged += new System.EventHandler(this.SearchBoxList_txt_OnValueChanged);
            // 
            // VehiclesDataListViewList_btn
            // 
            this.VehiclesDataListViewList_btn.Active = false;
            this.VehiclesDataListViewList_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.VehiclesDataListViewList_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VehiclesDataListViewList_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.VehiclesDataListViewList_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VehiclesDataListViewList_btn.BorderRadius = 0;
            this.VehiclesDataListViewList_btn.ButtonText = "List View";
            this.VehiclesDataListViewList_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehiclesDataListViewList_btn.DisabledColor = System.Drawing.Color.Gray;
            this.VehiclesDataListViewList_btn.Enabled = false;
            this.VehiclesDataListViewList_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.VehiclesDataListViewList_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.VehiclesDataListViewList_btn.Iconimage = null;
            this.VehiclesDataListViewList_btn.Iconimage_right = null;
            this.VehiclesDataListViewList_btn.Iconimage_right_Selected = null;
            this.VehiclesDataListViewList_btn.Iconimage_Selected = null;
            this.VehiclesDataListViewList_btn.IconMarginLeft = 20;
            this.VehiclesDataListViewList_btn.IconMarginRight = 0;
            this.VehiclesDataListViewList_btn.IconRightVisible = true;
            this.VehiclesDataListViewList_btn.IconRightZoom = 0D;
            this.VehiclesDataListViewList_btn.IconVisible = false;
            this.VehiclesDataListViewList_btn.IconZoom = 60D;
            this.VehiclesDataListViewList_btn.IsTab = false;
            this.VehiclesDataListViewList_btn.Location = new System.Drawing.Point(1086, 15);
            this.VehiclesDataListViewList_btn.Margin = new System.Windows.Forms.Padding(5);
            this.VehiclesDataListViewList_btn.Name = "VehiclesDataListViewList_btn";
            this.VehiclesDataListViewList_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.VehiclesDataListViewList_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.VehiclesDataListViewList_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.VehiclesDataListViewList_btn.selected = false;
            this.VehiclesDataListViewList_btn.Size = new System.Drawing.Size(137, 59);
            this.VehiclesDataListViewList_btn.TabIndex = 50;
            this.VehiclesDataListViewList_btn.Text = "List View";
            this.VehiclesDataListViewList_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VehiclesDataListViewList_btn.Textcolor = System.Drawing.Color.White;
            this.VehiclesDataListViewList_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // VehiclesDataStandardList_btn
            // 
            this.VehiclesDataStandardList_btn.Active = false;
            this.VehiclesDataStandardList_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.VehiclesDataStandardList_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VehiclesDataStandardList_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.VehiclesDataStandardList_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VehiclesDataStandardList_btn.BorderRadius = 0;
            this.VehiclesDataStandardList_btn.ButtonText = "Standard View";
            this.VehiclesDataStandardList_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehiclesDataStandardList_btn.DisabledColor = System.Drawing.Color.Gray;
            this.VehiclesDataStandardList_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.VehiclesDataStandardList_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.VehiclesDataStandardList_btn.Iconimage = null;
            this.VehiclesDataStandardList_btn.Iconimage_right = null;
            this.VehiclesDataStandardList_btn.Iconimage_right_Selected = null;
            this.VehiclesDataStandardList_btn.Iconimage_Selected = null;
            this.VehiclesDataStandardList_btn.IconMarginLeft = 20;
            this.VehiclesDataStandardList_btn.IconMarginRight = 0;
            this.VehiclesDataStandardList_btn.IconRightVisible = true;
            this.VehiclesDataStandardList_btn.IconRightZoom = 0D;
            this.VehiclesDataStandardList_btn.IconVisible = false;
            this.VehiclesDataStandardList_btn.IconZoom = 60D;
            this.VehiclesDataStandardList_btn.IsTab = false;
            this.VehiclesDataStandardList_btn.Location = new System.Drawing.Point(867, 15);
            this.VehiclesDataStandardList_btn.Margin = new System.Windows.Forms.Padding(5);
            this.VehiclesDataStandardList_btn.Name = "VehiclesDataStandardList_btn";
            this.VehiclesDataStandardList_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.VehiclesDataStandardList_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.VehiclesDataStandardList_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.VehiclesDataStandardList_btn.selected = false;
            this.VehiclesDataStandardList_btn.Size = new System.Drawing.Size(211, 59);
            this.VehiclesDataStandardList_btn.TabIndex = 49;
            this.VehiclesDataStandardList_btn.Text = "Standard View";
            this.VehiclesDataStandardList_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VehiclesDataStandardList_btn.Textcolor = System.Drawing.Color.White;
            this.VehiclesDataStandardList_btn.TextFont = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiclesDataStandardList_btn.Click += new System.EventHandler(this.VehiclesDataStandardList_btn_Click);
            // 
            // PackageDataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.SearchBoxList_txt);
            this.Controls.Add(this.VehiclesDataListViewList_btn);
            this.Controls.Add(this.VehiclesDataStandardList_btn);
            this.Controls.Add(this.PackageDataGridList);
            this.Name = "PackageDataList";
            this.Size = new System.Drawing.Size(1236, 776);
            this.Load += new System.EventHandler(this.PackageDataList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PackageDataGridList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid PackageDataGridList;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchBoxList_txt;
        private Bunifu.Framework.UI.BunifuFlatButton VehiclesDataListViewList_btn;
        private Bunifu.Framework.UI.BunifuFlatButton VehiclesDataStandardList_btn;
    }
}
