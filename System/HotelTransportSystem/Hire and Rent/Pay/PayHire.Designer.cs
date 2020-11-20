namespace HotelTransportSystem.Hire_and_Rent.PayHire
{
    partial class PayHire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayHire));
            this.Bill_print = new System.Drawing.Printing.PrintDocument();
            this.Bill_printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PaymentBill_txt = new System.Windows.Forms.RichTextBox();
            this.PaymentPay_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PaymentCancel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PaymentPrintBill_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Payment_groupBox = new System.Windows.Forms.GroupBox();
            this.CarRegNo_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Car_regNo = new System.Windows.Forms.Label();
            this.PaymentCustomerNIC_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PaymentCustomerNIC_lbl = new System.Windows.Forms.Label();
            this.PaymentBalance_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Payment_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PaymentClear_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PaymentTotalCharge_Pay_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PaymentBalance_lbl = new System.Windows.Forms.Label();
            this.Payment_lbl = new System.Windows.Forms.Label();
            this.PaymentCheckBill_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PaymentTotalCharge_lbl = new System.Windows.Forms.Label();
            this.PaymentMethord_lbl = new System.Windows.Forms.Label();
            this.PaymentTour_DropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.Pay_panel = new System.Windows.Forms.Panel();
            this.Payment_groupBox.SuspendLayout();
            this.Pay_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bill_print
            // 
            this.Bill_print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Bill_print_PrintPage);
            // 
            // Bill_printPreviewDialog
            // 
            this.Bill_printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Bill_printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Bill_printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.Bill_printPreviewDialog.Enabled = true;
            this.Bill_printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("Bill_printPreviewDialog.Icon")));
            this.Bill_printPreviewDialog.Name = "Bill_printPreviewDialog";
            this.Bill_printPreviewDialog.Visible = false;
            // 
            // PaymentBill_txt
            // 
            this.PaymentBill_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentBill_txt.Location = new System.Drawing.Point(522, 57);
            this.PaymentBill_txt.Name = "PaymentBill_txt";
            this.PaymentBill_txt.ReadOnly = true;
            this.PaymentBill_txt.Size = new System.Drawing.Size(697, 637);
            this.PaymentBill_txt.TabIndex = 45;
            this.PaymentBill_txt.Text = "";
            // 
            // PaymentPay_btn
            // 
            this.PaymentPay_btn.Active = false;
            this.PaymentPay_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentPay_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentPay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentPay_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentPay_btn.BorderRadius = 0;
            this.PaymentPay_btn.ButtonText = "Pay";
            this.PaymentPay_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentPay_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PaymentPay_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.PaymentPay_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.PaymentPay_btn.Iconimage = null;
            this.PaymentPay_btn.Iconimage_right = null;
            this.PaymentPay_btn.Iconimage_right_Selected = null;
            this.PaymentPay_btn.Iconimage_Selected = null;
            this.PaymentPay_btn.IconMarginLeft = 20;
            this.PaymentPay_btn.IconMarginRight = 0;
            this.PaymentPay_btn.IconRightVisible = true;
            this.PaymentPay_btn.IconRightZoom = 0D;
            this.PaymentPay_btn.IconVisible = false;
            this.PaymentPay_btn.IconZoom = 60D;
            this.PaymentPay_btn.IsTab = false;
            this.PaymentPay_btn.Location = new System.Drawing.Point(1083, 712);
            this.PaymentPay_btn.Margin = new System.Windows.Forms.Padding(5);
            this.PaymentPay_btn.Name = "PaymentPay_btn";
            this.PaymentPay_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentPay_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentPay_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.PaymentPay_btn.selected = false;
            this.PaymentPay_btn.Size = new System.Drawing.Size(123, 42);
            this.PaymentPay_btn.TabIndex = 41;
            this.PaymentPay_btn.Text = "Pay";
            this.PaymentPay_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PaymentPay_btn.Textcolor = System.Drawing.Color.White;
            this.PaymentPay_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPay_btn.Click += new System.EventHandler(this.PaymentPay_btn_Click);
            // 
            // PaymentCancel_btn
            // 
            this.PaymentCancel_btn.Active = false;
            this.PaymentCancel_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentCancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentCancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentCancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentCancel_btn.BorderRadius = 0;
            this.PaymentCancel_btn.ButtonText = "Cancel";
            this.PaymentCancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentCancel_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PaymentCancel_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.PaymentCancel_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.PaymentCancel_btn.Iconimage = null;
            this.PaymentCancel_btn.Iconimage_right = null;
            this.PaymentCancel_btn.Iconimage_right_Selected = null;
            this.PaymentCancel_btn.Iconimage_Selected = null;
            this.PaymentCancel_btn.IconMarginLeft = 20;
            this.PaymentCancel_btn.IconMarginRight = 0;
            this.PaymentCancel_btn.IconRightVisible = true;
            this.PaymentCancel_btn.IconRightZoom = 0D;
            this.PaymentCancel_btn.IconVisible = false;
            this.PaymentCancel_btn.IconZoom = 60D;
            this.PaymentCancel_btn.IsTab = false;
            this.PaymentCancel_btn.Location = new System.Drawing.Point(817, 712);
            this.PaymentCancel_btn.Margin = new System.Windows.Forms.Padding(5);
            this.PaymentCancel_btn.Name = "PaymentCancel_btn";
            this.PaymentCancel_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentCancel_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentCancel_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.PaymentCancel_btn.selected = false;
            this.PaymentCancel_btn.Size = new System.Drawing.Size(123, 42);
            this.PaymentCancel_btn.TabIndex = 42;
            this.PaymentCancel_btn.Text = "Cancel";
            this.PaymentCancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PaymentCancel_btn.Textcolor = System.Drawing.Color.White;
            this.PaymentCancel_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCancel_btn.Visible = false;
            this.PaymentCancel_btn.Click += new System.EventHandler(this.PackageCancel_btn_Click);
            // 
            // PaymentPrintBill_btn
            // 
            this.PaymentPrintBill_btn.Active = false;
            this.PaymentPrintBill_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentPrintBill_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentPrintBill_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentPrintBill_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentPrintBill_btn.BorderRadius = 0;
            this.PaymentPrintBill_btn.ButtonText = "Print Bill";
            this.PaymentPrintBill_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentPrintBill_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PaymentPrintBill_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.PaymentPrintBill_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.PaymentPrintBill_btn.Iconimage = null;
            this.PaymentPrintBill_btn.Iconimage_right = null;
            this.PaymentPrintBill_btn.Iconimage_right_Selected = null;
            this.PaymentPrintBill_btn.Iconimage_Selected = null;
            this.PaymentPrintBill_btn.IconMarginLeft = 20;
            this.PaymentPrintBill_btn.IconMarginRight = 0;
            this.PaymentPrintBill_btn.IconRightVisible = true;
            this.PaymentPrintBill_btn.IconRightZoom = 0D;
            this.PaymentPrintBill_btn.IconVisible = false;
            this.PaymentPrintBill_btn.IconZoom = 60D;
            this.PaymentPrintBill_btn.IsTab = false;
            this.PaymentPrintBill_btn.Location = new System.Drawing.Point(950, 712);
            this.PaymentPrintBill_btn.Margin = new System.Windows.Forms.Padding(5);
            this.PaymentPrintBill_btn.Name = "PaymentPrintBill_btn";
            this.PaymentPrintBill_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentPrintBill_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentPrintBill_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.PaymentPrintBill_btn.selected = false;
            this.PaymentPrintBill_btn.Size = new System.Drawing.Size(123, 42);
            this.PaymentPrintBill_btn.TabIndex = 46;
            this.PaymentPrintBill_btn.Text = "Print Bill";
            this.PaymentPrintBill_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PaymentPrintBill_btn.Textcolor = System.Drawing.Color.White;
            this.PaymentPrintBill_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPrintBill_btn.Click += new System.EventHandler(this.PrintBill_btn_Click);
            // 
            // Payment_groupBox
            // 
            this.Payment_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Payment_groupBox.Controls.Add(this.CarRegNo_txt);
            this.Payment_groupBox.Controls.Add(this.Car_regNo);
            this.Payment_groupBox.Controls.Add(this.PaymentCustomerNIC_txt);
            this.Payment_groupBox.Controls.Add(this.PaymentCustomerNIC_lbl);
            this.Payment_groupBox.Controls.Add(this.PaymentBalance_txt);
            this.Payment_groupBox.Controls.Add(this.Payment_txt);
            this.Payment_groupBox.Controls.Add(this.PaymentClear_btn);
            this.Payment_groupBox.Controls.Add(this.PaymentTotalCharge_Pay_txt);
            this.Payment_groupBox.Controls.Add(this.PaymentBalance_lbl);
            this.Payment_groupBox.Controls.Add(this.Payment_lbl);
            this.Payment_groupBox.Controls.Add(this.PaymentCheckBill_btn);
            this.Payment_groupBox.Controls.Add(this.PaymentTotalCharge_lbl);
            this.Payment_groupBox.Controls.Add(this.PaymentMethord_lbl);
            this.Payment_groupBox.Controls.Add(this.PaymentTour_DropDown);
            this.Payment_groupBox.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.Payment_groupBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Payment_groupBox.Location = new System.Drawing.Point(15, 57);
            this.Payment_groupBox.Name = "Payment_groupBox";
            this.Payment_groupBox.Size = new System.Drawing.Size(457, 637);
            this.Payment_groupBox.TabIndex = 44;
            this.Payment_groupBox.TabStop = false;
            this.Payment_groupBox.Text = "Payment";
            // 
            // CarRegNo_txt
            // 
            this.CarRegNo_txt.BorderColorFocused = System.Drawing.Color.White;
            this.CarRegNo_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.CarRegNo_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.CarRegNo_txt.BorderThickness = 3;
            this.CarRegNo_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CarRegNo_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CarRegNo_txt.Enabled = false;
            this.CarRegNo_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CarRegNo_txt.ForeColor = System.Drawing.Color.White;
            this.CarRegNo_txt.isPassword = false;
            this.CarRegNo_txt.Location = new System.Drawing.Point(34, 147);
            this.CarRegNo_txt.Margin = new System.Windows.Forms.Padding(5);
            this.CarRegNo_txt.MaximumSize = new System.Drawing.Size(401, 41);
            this.CarRegNo_txt.MaxLength = 32767;
            this.CarRegNo_txt.Name = "CarRegNo_txt";
            this.CarRegNo_txt.Padding = new System.Windows.Forms.Padding(4);
            this.CarRegNo_txt.Size = new System.Drawing.Size(401, 41);
            this.CarRegNo_txt.TabIndex = 47;
            this.CarRegNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Car_regNo
            // 
            this.Car_regNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Car_regNo.AutoSize = true;
            this.Car_regNo.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car_regNo.ForeColor = System.Drawing.Color.DarkGray;
            this.Car_regNo.Location = new System.Drawing.Point(29, 117);
            this.Car_regNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Car_regNo.Name = "Car_regNo";
            this.Car_regNo.Size = new System.Drawing.Size(112, 25);
            this.Car_regNo.TabIndex = 46;
            this.Car_regNo.Text = "Car Reg No";
            // 
            // PaymentCustomerNIC_txt
            // 
            this.PaymentCustomerNIC_txt.BorderColorFocused = System.Drawing.Color.White;
            this.PaymentCustomerNIC_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.PaymentCustomerNIC_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.PaymentCustomerNIC_txt.BorderThickness = 3;
            this.PaymentCustomerNIC_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PaymentCustomerNIC_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PaymentCustomerNIC_txt.Enabled = false;
            this.PaymentCustomerNIC_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PaymentCustomerNIC_txt.ForeColor = System.Drawing.Color.White;
            this.PaymentCustomerNIC_txt.isPassword = false;
            this.PaymentCustomerNIC_txt.Location = new System.Drawing.Point(34, 60);
            this.PaymentCustomerNIC_txt.Margin = new System.Windows.Forms.Padding(5);
            this.PaymentCustomerNIC_txt.MaxLength = 32767;
            this.PaymentCustomerNIC_txt.MinimumSize = new System.Drawing.Size(411, 46);
            this.PaymentCustomerNIC_txt.Name = "PaymentCustomerNIC_txt";
            this.PaymentCustomerNIC_txt.Padding = new System.Windows.Forms.Padding(4);
            this.PaymentCustomerNIC_txt.Size = new System.Drawing.Size(411, 46);
            this.PaymentCustomerNIC_txt.TabIndex = 44;
            this.PaymentCustomerNIC_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PaymentCustomerNIC_lbl
            // 
            this.PaymentCustomerNIC_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PaymentCustomerNIC_lbl.AutoSize = true;
            this.PaymentCustomerNIC_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCustomerNIC_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.PaymentCustomerNIC_lbl.Location = new System.Drawing.Point(29, 30);
            this.PaymentCustomerNIC_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentCustomerNIC_lbl.Name = "PaymentCustomerNIC_lbl";
            this.PaymentCustomerNIC_lbl.Size = new System.Drawing.Size(136, 25);
            this.PaymentCustomerNIC_lbl.TabIndex = 45;
            this.PaymentCustomerNIC_lbl.Text = "Customer NIC";
            // 
            // PaymentBalance_txt
            // 
            this.PaymentBalance_txt.BorderColorFocused = System.Drawing.Color.White;
            this.PaymentBalance_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.PaymentBalance_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.PaymentBalance_txt.BorderThickness = 3;
            this.PaymentBalance_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PaymentBalance_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PaymentBalance_txt.Enabled = false;
            this.PaymentBalance_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PaymentBalance_txt.ForeColor = System.Drawing.Color.White;
            this.PaymentBalance_txt.isPassword = false;
            this.PaymentBalance_txt.Location = new System.Drawing.Point(34, 508);
            this.PaymentBalance_txt.Margin = new System.Windows.Forms.Padding(5);
            this.PaymentBalance_txt.MaximumSize = new System.Drawing.Size(401, 41);
            this.PaymentBalance_txt.MaxLength = 32767;
            this.PaymentBalance_txt.Name = "PaymentBalance_txt";
            this.PaymentBalance_txt.Padding = new System.Windows.Forms.Padding(4);
            this.PaymentBalance_txt.Size = new System.Drawing.Size(401, 41);
            this.PaymentBalance_txt.TabIndex = 31;
            this.PaymentBalance_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Payment_txt
            // 
            this.Payment_txt.BorderColorFocused = System.Drawing.Color.White;
            this.Payment_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.Payment_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.Payment_txt.BorderThickness = 3;
            this.Payment_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Payment_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Payment_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Payment_txt.ForeColor = System.Drawing.Color.White;
            this.Payment_txt.isPassword = false;
            this.Payment_txt.Location = new System.Drawing.Point(34, 415);
            this.Payment_txt.Margin = new System.Windows.Forms.Padding(5);
            this.Payment_txt.MaximumSize = new System.Drawing.Size(401, 41);
            this.Payment_txt.MaxLength = 32767;
            this.Payment_txt.Name = "Payment_txt";
            this.Payment_txt.Padding = new System.Windows.Forms.Padding(4);
            this.Payment_txt.Size = new System.Drawing.Size(401, 41);
            this.Payment_txt.TabIndex = 31;
            this.Payment_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PaymentClear_btn
            // 
            this.PaymentClear_btn.Active = false;
            this.PaymentClear_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentClear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PaymentClear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentClear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentClear_btn.BorderRadius = 0;
            this.PaymentClear_btn.ButtonText = "Clear";
            this.PaymentClear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentClear_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PaymentClear_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.PaymentClear_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.PaymentClear_btn.Iconimage = null;
            this.PaymentClear_btn.Iconimage_right = null;
            this.PaymentClear_btn.Iconimage_right_Selected = null;
            this.PaymentClear_btn.Iconimage_Selected = null;
            this.PaymentClear_btn.IconMarginLeft = 20;
            this.PaymentClear_btn.IconMarginRight = 0;
            this.PaymentClear_btn.IconRightVisible = true;
            this.PaymentClear_btn.IconRightZoom = 0D;
            this.PaymentClear_btn.IconVisible = false;
            this.PaymentClear_btn.IconZoom = 60D;
            this.PaymentClear_btn.IsTab = false;
            this.PaymentClear_btn.Location = new System.Drawing.Point(30, 567);
            this.PaymentClear_btn.Margin = new System.Windows.Forms.Padding(5);
            this.PaymentClear_btn.Name = "PaymentClear_btn";
            this.PaymentClear_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentClear_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentClear_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.PaymentClear_btn.selected = false;
            this.PaymentClear_btn.Size = new System.Drawing.Size(123, 42);
            this.PaymentClear_btn.TabIndex = 43;
            this.PaymentClear_btn.Text = "Clear";
            this.PaymentClear_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PaymentClear_btn.Textcolor = System.Drawing.Color.White;
            this.PaymentClear_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PaymentTotalCharge_Pay_txt
            // 
            this.PaymentTotalCharge_Pay_txt.BorderColorFocused = System.Drawing.Color.White;
            this.PaymentTotalCharge_Pay_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.PaymentTotalCharge_Pay_txt.BorderColorMouseHover = System.Drawing.Color.LightGray;
            this.PaymentTotalCharge_Pay_txt.BorderThickness = 3;
            this.PaymentTotalCharge_Pay_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PaymentTotalCharge_Pay_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PaymentTotalCharge_Pay_txt.Enabled = false;
            this.PaymentTotalCharge_Pay_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PaymentTotalCharge_Pay_txt.ForeColor = System.Drawing.Color.White;
            this.PaymentTotalCharge_Pay_txt.isPassword = false;
            this.PaymentTotalCharge_Pay_txt.Location = new System.Drawing.Point(30, 234);
            this.PaymentTotalCharge_Pay_txt.Margin = new System.Windows.Forms.Padding(5);
            this.PaymentTotalCharge_Pay_txt.MaximumSize = new System.Drawing.Size(401, 41);
            this.PaymentTotalCharge_Pay_txt.MaxLength = 32767;
            this.PaymentTotalCharge_Pay_txt.Name = "PaymentTotalCharge_Pay_txt";
            this.PaymentTotalCharge_Pay_txt.Padding = new System.Windows.Forms.Padding(4);
            this.PaymentTotalCharge_Pay_txt.Size = new System.Drawing.Size(401, 41);
            this.PaymentTotalCharge_Pay_txt.TabIndex = 31;
            this.PaymentTotalCharge_Pay_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PaymentBalance_lbl
            // 
            this.PaymentBalance_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PaymentBalance_lbl.AutoSize = true;
            this.PaymentBalance_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBalance_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.PaymentBalance_lbl.Location = new System.Drawing.Point(29, 476);
            this.PaymentBalance_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentBalance_lbl.Name = "PaymentBalance_lbl";
            this.PaymentBalance_lbl.Size = new System.Drawing.Size(84, 25);
            this.PaymentBalance_lbl.TabIndex = 30;
            this.PaymentBalance_lbl.Text = "Balance";
            // 
            // Payment_lbl
            // 
            this.Payment_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Payment_lbl.AutoSize = true;
            this.Payment_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.Payment_lbl.Location = new System.Drawing.Point(29, 383);
            this.Payment_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Payment_lbl.Name = "Payment_lbl";
            this.Payment_lbl.Size = new System.Drawing.Size(90, 25);
            this.Payment_lbl.TabIndex = 30;
            this.Payment_lbl.Text = "Payment";
            // 
            // PaymentCheckBill_btn
            // 
            this.PaymentCheckBill_btn.Active = false;
            this.PaymentCheckBill_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentCheckBill_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentCheckBill_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentCheckBill_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentCheckBill_btn.BorderRadius = 0;
            this.PaymentCheckBill_btn.ButtonText = "Check Bill";
            this.PaymentCheckBill_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentCheckBill_btn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.PaymentCheckBill_btn.Font = new System.Drawing.Font("Yu Gothic", 8.25F);
            this.PaymentCheckBill_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.PaymentCheckBill_btn.Iconimage = null;
            this.PaymentCheckBill_btn.Iconimage_right = null;
            this.PaymentCheckBill_btn.Iconimage_right_Selected = null;
            this.PaymentCheckBill_btn.Iconimage_Selected = null;
            this.PaymentCheckBill_btn.IconMarginLeft = 20;
            this.PaymentCheckBill_btn.IconMarginRight = 0;
            this.PaymentCheckBill_btn.IconRightVisible = true;
            this.PaymentCheckBill_btn.IconRightZoom = 0D;
            this.PaymentCheckBill_btn.IconVisible = false;
            this.PaymentCheckBill_btn.IconZoom = 60D;
            this.PaymentCheckBill_btn.IsTab = false;
            this.PaymentCheckBill_btn.Location = new System.Drawing.Point(308, 567);
            this.PaymentCheckBill_btn.Margin = new System.Windows.Forms.Padding(5);
            this.PaymentCheckBill_btn.Name = "PaymentCheckBill_btn";
            this.PaymentCheckBill_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.PaymentCheckBill_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.PaymentCheckBill_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.PaymentCheckBill_btn.selected = false;
            this.PaymentCheckBill_btn.Size = new System.Drawing.Size(123, 42);
            this.PaymentCheckBill_btn.TabIndex = 41;
            this.PaymentCheckBill_btn.Text = "Check Bill";
            this.PaymentCheckBill_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PaymentCheckBill_btn.Textcolor = System.Drawing.Color.White;
            this.PaymentCheckBill_btn.TextFont = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCheckBill_btn.Click += new System.EventHandler(this.CheckBill_btn_Click);
            // 
            // PaymentTotalCharge_lbl
            // 
            this.PaymentTotalCharge_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PaymentTotalCharge_lbl.AutoSize = true;
            this.PaymentTotalCharge_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTotalCharge_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.PaymentTotalCharge_lbl.Location = new System.Drawing.Point(25, 204);
            this.PaymentTotalCharge_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentTotalCharge_lbl.Name = "PaymentTotalCharge_lbl";
            this.PaymentTotalCharge_lbl.Size = new System.Drawing.Size(124, 25);
            this.PaymentTotalCharge_lbl.TabIndex = 30;
            this.PaymentTotalCharge_lbl.Text = "Total Charge";
            // 
            // PaymentMethord_lbl
            // 
            this.PaymentMethord_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PaymentMethord_lbl.AutoSize = true;
            this.PaymentMethord_lbl.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethord_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.PaymentMethord_lbl.Location = new System.Drawing.Point(29, 292);
            this.PaymentMethord_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentMethord_lbl.Name = "PaymentMethord_lbl";
            this.PaymentMethord_lbl.Size = new System.Drawing.Size(170, 25);
            this.PaymentMethord_lbl.TabIndex = 30;
            this.PaymentMethord_lbl.Text = "Payment Methord";
            // 
            // PaymentTour_DropDown
            // 
            this.PaymentTour_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.PaymentTour_DropDown.BorderRadius = 3;
            this.PaymentTour_DropDown.DisabledColor = System.Drawing.Color.Gray;
            this.PaymentTour_DropDown.ForeColor = System.Drawing.Color.Black;
            this.PaymentTour_DropDown.items = new string[] {
        "Cash",
        "Visa Card",
        "Master Card",
        "Online"};
            this.PaymentTour_DropDown.Location = new System.Drawing.Point(34, 324);
            this.PaymentTour_DropDown.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.PaymentTour_DropDown.MaximumSize = new System.Drawing.Size(401, 38);
            this.PaymentTour_DropDown.Name = "PaymentTour_DropDown";
            this.PaymentTour_DropDown.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.PaymentTour_DropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PaymentTour_DropDown.selectedIndex = -1;
            this.PaymentTour_DropDown.Size = new System.Drawing.Size(401, 38);
            this.PaymentTour_DropDown.TabIndex = 24;
            // 
            // Pay_panel
            // 
            this.Pay_panel.Controls.Add(this.Payment_groupBox);
            this.Pay_panel.Controls.Add(this.PaymentPrintBill_btn);
            this.Pay_panel.Controls.Add(this.PaymentCancel_btn);
            this.Pay_panel.Controls.Add(this.PaymentPay_btn);
            this.Pay_panel.Controls.Add(this.PaymentBill_txt);
            this.Pay_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pay_panel.Location = new System.Drawing.Point(0, 0);
            this.Pay_panel.Name = "Pay_panel";
            this.Pay_panel.Size = new System.Drawing.Size(1236, 776);
            this.Pay_panel.TabIndex = 47;
            // 
            // PayHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.Pay_panel);
            this.Name = "PayHire";
            this.Size = new System.Drawing.Size(1236, 776);
            this.Load += new System.EventHandler(this.PayHire_Load);
            this.Payment_groupBox.ResumeLayout(false);
            this.Payment_groupBox.PerformLayout();
            this.Pay_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument Bill_print;
        private System.Windows.Forms.PrintPreviewDialog Bill_printPreviewDialog;
        private System.Windows.Forms.RichTextBox PaymentBill_txt;
        protected internal Bunifu.Framework.UI.BunifuFlatButton PaymentPay_btn;
        protected internal Bunifu.Framework.UI.BunifuFlatButton PaymentCancel_btn;
        protected internal Bunifu.Framework.UI.BunifuFlatButton PaymentPrintBill_btn;
        private System.Windows.Forms.GroupBox Payment_groupBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox PaymentBalance_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox Payment_txt;
        protected internal Bunifu.Framework.UI.BunifuFlatButton PaymentClear_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox PaymentTotalCharge_Pay_txt;
        private System.Windows.Forms.Label PaymentBalance_lbl;
        private System.Windows.Forms.Label Payment_lbl;
        protected internal Bunifu.Framework.UI.BunifuFlatButton PaymentCheckBill_btn;
        private System.Windows.Forms.Label PaymentTotalCharge_lbl;
        private System.Windows.Forms.Label PaymentMethord_lbl;
        private Bunifu.Framework.UI.BunifuDropdown PaymentTour_DropDown;
        private System.Windows.Forms.Panel Pay_panel;
        private Bunifu.Framework.UI.BunifuMetroTextbox PaymentCustomerNIC_txt;
        private System.Windows.Forms.Label PaymentCustomerNIC_lbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox CarRegNo_txt;
        private System.Windows.Forms.Label Car_regNo;
    }
}
