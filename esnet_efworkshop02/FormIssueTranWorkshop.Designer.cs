namespace esnet_efworkshop02
{
    partial class FormIssueTranWorkshop
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.dgv_trans = new System.Windows.Forms.DataGridView();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_tran_id = new System.Windows.Forms.TextBox();
            this.lbl_TransID = new System.Windows.Forms.Label();
            this.sstrip_Main = new System.Windows.Forms.StatusStrip();
            this.slbl_Main = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_CustID = new System.Windows.Forms.Label();
            this.lbl_VidCode = new System.Windows.Forms.Label();
            this.lbl_DateIssued = new System.Windows.Forms.Label();
            this.lbl_DateDue = new System.Windows.Forms.Label();
            this.lbl_return_date = new System.Windows.Forms.Label();
            this.lbl_RentalSts = new System.Windows.Forms.Label();
            this.lbl_Remarks = new System.Windows.Forms.Label();
            this.txt_cust_id = new System.Windows.Forms.TextBox();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.lbl_Avail = new System.Windows.Forms.Label();
            this.txt_avaliable = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Rented = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.dtp_issue = new System.Windows.Forms.DateTimePicker();
            this.dtp_due = new System.Windows.Forms.DateTimePicker();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.gbx_RentalSts = new System.Windows.Forms.GroupBox();
            this.rbtn_Out = new System.Windows.Forms.RadioButton();
            this.rbtn_In = new System.Windows.Forms.RadioButton();
            this.txt_m_title = new System.Windows.Forms.TextBox();
            this.lbl_MovieTitle = new System.Windows.Forms.Label();
            this.txt_m_type = new System.Windows.Forms.TextBox();
            this.lbl_MovieType = new System.Windows.Forms.Label();
            this.txt_rating = new System.Windows.Forms.TextBox();
            this.lbl_MovieRating = new System.Windows.Forms.Label();
            this.txt_r_price = new System.Windows.Forms.TextBox();
            this.lbl_RentalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_video_code = new System.Windows.Forms.TextBox();
            this.txt_cust_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trans)).BeginInit();
            this.sstrip_Main.SuspendLayout();
            this.gbx_RentalSts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(548, 20);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 24);
            this.btn_remove.TabIndex = 32;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(672, 20);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(28, 24);
            this.btn_last.TabIndex = 31;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(232, 20);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(28, 24);
            this.btn_first.TabIndex = 30;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // dgv_trans
            // 
            this.dgv_trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trans.Location = new System.Drawing.Point(24, 414);
            this.dgv_trans.Name = "dgv_trans";
            this.dgv_trans.Size = new System.Drawing.Size(676, 301);
            this.dgv_trans.TabIndex = 29;
            this.dgv_trans.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trans_CellDoubleClick);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(644, 20);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(24, 24);
            this.btn_next.TabIndex = 28;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(264, 20);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(24, 24);
            this.btn_previous.TabIndex = 27;
            this.btn_previous.Text = "<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(468, 20);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 24);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // txt_tran_id
            // 
            this.txt_tran_id.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_tran_id.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tran_id.Location = new System.Drawing.Point(148, 68);
            this.txt_tran_id.Name = "txt_tran_id";
            this.txt_tran_id.ReadOnly = true;
            this.txt_tran_id.Size = new System.Drawing.Size(200, 29);
            this.txt_tran_id.TabIndex = 25;
            // 
            // lbl_TransID
            // 
            this.lbl_TransID.AutoSize = true;
            this.lbl_TransID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TransID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransID.Location = new System.Drawing.Point(16, 72);
            this.lbl_TransID.Name = "lbl_TransID";
            this.lbl_TransID.Size = new System.Drawing.Size(116, 20);
            this.lbl_TransID.TabIndex = 2;
            this.lbl_TransID.Text = "Transaction ID:";
            // 
            // sstrip_Main
            // 
            this.sstrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbl_Main});
            this.sstrip_Main.Location = new System.Drawing.Point(0, 725);
            this.sstrip_Main.Name = "sstrip_Main";
            this.sstrip_Main.Size = new System.Drawing.Size(722, 23);
            this.sstrip_Main.TabIndex = 20;
            this.sstrip_Main.Text = "statusStrip1";
            // 
            // slbl_Main
            // 
            this.slbl_Main.Font = new System.Drawing.Font("Roboto", 10F);
            this.slbl_Main.Name = "slbl_Main";
            this.slbl_Main.Size = new System.Drawing.Size(14, 18);
            this.slbl_Main.Text = "  ";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(388, 20);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 24);
            this.btn_find.TabIndex = 19;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(308, 20);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 24);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 8);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(183, 31);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Transactions";
            // 
            // lbl_CustID
            // 
            this.lbl_CustID.AutoSize = true;
            this.lbl_CustID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CustID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustID.Location = new System.Drawing.Point(16, 104);
            this.lbl_CustID.Name = "lbl_CustID";
            this.lbl_CustID.Size = new System.Drawing.Size(99, 20);
            this.lbl_CustID.TabIndex = 3;
            this.lbl_CustID.Text = "Customer ID:";
            // 
            // lbl_VidCode
            // 
            this.lbl_VidCode.AutoSize = true;
            this.lbl_VidCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VidCode.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VidCode.Location = new System.Drawing.Point(16, 171);
            this.lbl_VidCode.Name = "lbl_VidCode";
            this.lbl_VidCode.Size = new System.Drawing.Size(93, 20);
            this.lbl_VidCode.TabIndex = 4;
            this.lbl_VidCode.Text = "Video Code:";
            // 
            // lbl_DateIssued
            // 
            this.lbl_DateIssued.AutoSize = true;
            this.lbl_DateIssued.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateIssued.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateIssued.Location = new System.Drawing.Point(16, 203);
            this.lbl_DateIssued.Name = "lbl_DateIssued";
            this.lbl_DateIssued.Size = new System.Drawing.Size(95, 20);
            this.lbl_DateIssued.TabIndex = 5;
            this.lbl_DateIssued.Text = "Date Issued:";
            // 
            // lbl_DateDue
            // 
            this.lbl_DateDue.AutoSize = true;
            this.lbl_DateDue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateDue.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateDue.Location = new System.Drawing.Point(16, 235);
            this.lbl_DateDue.Name = "lbl_DateDue";
            this.lbl_DateDue.Size = new System.Drawing.Size(76, 20);
            this.lbl_DateDue.TabIndex = 6;
            this.lbl_DateDue.Text = "Date Due:";
            // 
            // lbl_return_date
            // 
            this.lbl_return_date.AutoSize = true;
            this.lbl_return_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_return_date.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_return_date.Location = new System.Drawing.Point(16, 267);
            this.lbl_return_date.Name = "lbl_return_date";
            this.lbl_return_date.Size = new System.Drawing.Size(112, 20);
            this.lbl_return_date.TabIndex = 7;
            this.lbl_return_date.Text = "Date Returned:";
            // 
            // lbl_RentalSts
            // 
            this.lbl_RentalSts.AutoSize = true;
            this.lbl_RentalSts.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RentalSts.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentalSts.Location = new System.Drawing.Point(16, 312);
            this.lbl_RentalSts.Name = "lbl_RentalSts";
            this.lbl_RentalSts.Size = new System.Drawing.Size(107, 20);
            this.lbl_RentalSts.TabIndex = 8;
            this.lbl_RentalSts.Text = "Rental Status:";
            // 
            // lbl_Remarks
            // 
            this.lbl_Remarks.AutoSize = true;
            this.lbl_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Remarks.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remarks.Location = new System.Drawing.Point(16, 347);
            this.lbl_Remarks.Name = "lbl_Remarks";
            this.lbl_Remarks.Size = new System.Drawing.Size(75, 20);
            this.lbl_Remarks.TabIndex = 9;
            this.lbl_Remarks.Text = "Remarks:";
            // 
            // txt_cust_id
            // 
            this.txt_cust_id.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_id.Location = new System.Drawing.Point(148, 100);
            this.txt_cust_id.Name = "txt_cust_id";
            this.txt_cust_id.Size = new System.Drawing.Size(200, 29);
            this.txt_cust_id.TabIndex = 41;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(148, 342);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remarks.Size = new System.Drawing.Size(552, 66);
            this.txt_remarks.TabIndex = 47;
            // 
            // lbl_Avail
            // 
            this.lbl_Avail.AutoSize = true;
            this.lbl_Avail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Avail.Location = new System.Drawing.Point(372, 104);
            this.lbl_Avail.Name = "lbl_Avail";
            this.lbl_Avail.Size = new System.Drawing.Size(74, 20);
            this.lbl_Avail.TabIndex = 10;
            this.lbl_Avail.Text = "Available";
            // 
            // txt_avaliable
            // 
            this.txt_avaliable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_avaliable.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avaliable.Location = new System.Drawing.Point(368, 132);
            this.txt_avaliable.Name = "txt_avaliable";
            this.txt_avaliable.Size = new System.Drawing.Size(76, 29);
            this.txt_avaliable.TabIndex = 49;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(512, 104);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(46, 20);
            this.lbl_Total.TabIndex = 11;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Rented
            // 
            this.lbl_Rented.AutoSize = true;
            this.lbl_Rented.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rented.Location = new System.Drawing.Point(632, 104);
            this.lbl_Rented.Name = "lbl_Rented";
            this.lbl_Rented.Size = new System.Drawing.Size(58, 20);
            this.lbl_Rented.TabIndex = 12;
            this.lbl_Rented.Text = "Rented";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_total.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(496, 132);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(76, 29);
            this.txt_total.TabIndex = 52;
            // 
            // txt_rent
            // 
            this.txt_rent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_rent.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rent.Location = new System.Drawing.Point(624, 132);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.Size = new System.Drawing.Size(76, 29);
            this.txt_rent.TabIndex = 53;
            // 
            // dtp_issue
            // 
            this.dtp_issue.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_issue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_issue.Location = new System.Drawing.Point(148, 199);
            this.dtp_issue.Name = "dtp_issue";
            this.dtp_issue.Size = new System.Drawing.Size(200, 27);
            this.dtp_issue.TabIndex = 54;
            // 
            // dtp_due
            // 
            this.dtp_due.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_due.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_due.Location = new System.Drawing.Point(148, 231);
            this.dtp_due.Name = "dtp_due";
            this.dtp_due.Size = new System.Drawing.Size(200, 27);
            this.dtp_due.TabIndex = 55;
            // 
            // dtp_return
            // 
            this.dtp_return.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_return.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_return.Location = new System.Drawing.Point(148, 263);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(200, 27);
            this.dtp_return.TabIndex = 56;
            // 
            // gbx_RentalSts
            // 
            this.gbx_RentalSts.BackColor = System.Drawing.Color.Transparent;
            this.gbx_RentalSts.Controls.Add(this.rbtn_Out);
            this.gbx_RentalSts.Controls.Add(this.rbtn_In);
            this.gbx_RentalSts.Location = new System.Drawing.Point(148, 289);
            this.gbx_RentalSts.Name = "gbx_RentalSts";
            this.gbx_RentalSts.Size = new System.Drawing.Size(200, 33);
            this.gbx_RentalSts.TabIndex = 15;
            this.gbx_RentalSts.TabStop = false;
            // 
            // rbtn_Out
            // 
            this.rbtn_Out.AutoSize = true;
            this.rbtn_Out.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_Out.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Out.Location = new System.Drawing.Point(112, 9);
            this.rbtn_Out.Name = "rbtn_Out";
            this.rbtn_Out.Size = new System.Drawing.Size(50, 25);
            this.rbtn_Out.TabIndex = 14;
            this.rbtn_Out.TabStop = true;
            this.rbtn_Out.Text = "Out";
            this.rbtn_Out.UseVisualStyleBackColor = false;
            // 
            // rbtn_In
            // 
            this.rbtn_In.AutoSize = true;
            this.rbtn_In.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_In.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_In.Location = new System.Drawing.Point(32, 9);
            this.rbtn_In.Name = "rbtn_In";
            this.rbtn_In.Size = new System.Drawing.Size(40, 25);
            this.rbtn_In.TabIndex = 13;
            this.rbtn_In.TabStop = true;
            this.rbtn_In.Text = "In";
            this.rbtn_In.UseVisualStyleBackColor = false;
            // 
            // txt_m_title
            // 
            this.txt_m_title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_m_title.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_m_title.Location = new System.Drawing.Point(500, 196);
            this.txt_m_title.Name = "txt_m_title";
            this.txt_m_title.Size = new System.Drawing.Size(200, 29);
            this.txt_m_title.TabIndex = 58;
            // 
            // lbl_MovieTitle
            // 
            this.lbl_MovieTitle.AutoSize = true;
            this.lbl_MovieTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MovieTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MovieTitle.Location = new System.Drawing.Point(368, 200);
            this.lbl_MovieTitle.Name = "lbl_MovieTitle";
            this.lbl_MovieTitle.Size = new System.Drawing.Size(91, 20);
            this.lbl_MovieTitle.TabIndex = 16;
            this.lbl_MovieTitle.Text = "Movie Title:";
            // 
            // txt_m_type
            // 
            this.txt_m_type.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_m_type.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_m_type.Location = new System.Drawing.Point(500, 228);
            this.txt_m_type.Name = "txt_m_type";
            this.txt_m_type.Size = new System.Drawing.Size(200, 29);
            this.txt_m_type.TabIndex = 60;
            // 
            // lbl_MovieType
            // 
            this.lbl_MovieType.AutoSize = true;
            this.lbl_MovieType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MovieType.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MovieType.Location = new System.Drawing.Point(368, 232);
            this.lbl_MovieType.Name = "lbl_MovieType";
            this.lbl_MovieType.Size = new System.Drawing.Size(95, 20);
            this.lbl_MovieType.TabIndex = 17;
            this.lbl_MovieType.Text = "Movie Type:";
            // 
            // txt_rating
            // 
            this.txt_rating.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_rating.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rating.Location = new System.Drawing.Point(500, 260);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.Size = new System.Drawing.Size(200, 29);
            this.txt_rating.TabIndex = 62;
            // 
            // lbl_MovieRating
            // 
            this.lbl_MovieRating.AutoSize = true;
            this.lbl_MovieRating.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MovieRating.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MovieRating.Location = new System.Drawing.Point(368, 264);
            this.lbl_MovieRating.Name = "lbl_MovieRating";
            this.lbl_MovieRating.Size = new System.Drawing.Size(106, 20);
            this.lbl_MovieRating.TabIndex = 18;
            this.lbl_MovieRating.Text = "Movie Rating:";
            // 
            // txt_r_price
            // 
            this.txt_r_price.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_r_price.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_r_price.Location = new System.Drawing.Point(500, 292);
            this.txt_r_price.Name = "txt_r_price";
            this.txt_r_price.Size = new System.Drawing.Size(200, 29);
            this.txt_r_price.TabIndex = 64;
            // 
            // lbl_RentalPrice
            // 
            this.lbl_RentalPrice.AutoSize = true;
            this.lbl_RentalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RentalPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentalPrice.Location = new System.Drawing.Point(368, 296);
            this.lbl_RentalPrice.Name = "lbl_RentalPrice";
            this.lbl_RentalPrice.Size = new System.Drawing.Size(97, 20);
            this.lbl_RentalPrice.TabIndex = 19;
            this.lbl_RentalPrice.Text = "Rental Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Customer Name:";
            // 
            // txt_video_code
            // 
            this.txt_video_code.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_video_code.Location = new System.Drawing.Point(148, 167);
            this.txt_video_code.Name = "txt_video_code";
            this.txt_video_code.Size = new System.Drawing.Size(200, 29);
            this.txt_video_code.TabIndex = 42;
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cust_name.Location = new System.Drawing.Point(148, 134);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(200, 29);
            this.txt_cust_name.TabIndex = 66;
            //this.txt_cust_name.TabIndexChanged += new System.EventHandler(this.txt_cust_name_TabIndexChanged_1);
            //this.txt_cust_name.TextChanged += new System.EventHandler(this.txt_cust_name_TextChanged);
            // 
            // FormIssueTranWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 748);
            this.Controls.Add(this.txt_cust_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_r_price);
            this.Controls.Add(this.lbl_RentalPrice);
            this.Controls.Add(this.txt_rating);
            this.Controls.Add(this.lbl_MovieRating);
            this.Controls.Add(this.txt_m_type);
            this.Controls.Add(this.lbl_MovieType);
            this.Controls.Add(this.txt_m_title);
            this.Controls.Add(this.lbl_MovieTitle);
            this.Controls.Add(this.gbx_RentalSts);
            this.Controls.Add(this.dtp_return);
            this.Controls.Add(this.dtp_due);
            this.Controls.Add(this.dtp_issue);
            this.Controls.Add(this.txt_rent);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_Rented);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txt_avaliable);
            this.Controls.Add(this.lbl_Avail);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.txt_video_code);
            this.Controls.Add(this.txt_cust_id);
            this.Controls.Add(this.lbl_Remarks);
            this.Controls.Add(this.lbl_RentalSts);
            this.Controls.Add(this.lbl_return_date);
            this.Controls.Add(this.lbl_DateDue);
            this.Controls.Add(this.lbl_DateIssued);
            this.Controls.Add(this.lbl_VidCode);
            this.Controls.Add(this.lbl_CustID);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.dgv_trans);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_tran_id);
            this.Controls.Add(this.lbl_TransID);
            this.Controls.Add(this.sstrip_Main);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_add);
            this.MaximizeBox = false;
            this.Name = "FormIssueTranWorkshop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trans)).EndInit();
            this.sstrip_Main.ResumeLayout(false);
            this.sstrip_Main.PerformLayout();
            this.gbx_RentalSts.ResumeLayout(false);
            this.gbx_RentalSts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.DataGridView dgv_trans;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_tran_id;
        private System.Windows.Forms.Label lbl_TransID;
        private System.Windows.Forms.StatusStrip sstrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel slbl_Main;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_CustID;
        private System.Windows.Forms.Label lbl_VidCode;
        private System.Windows.Forms.Label lbl_DateIssued;
        private System.Windows.Forms.Label lbl_DateDue;
        private System.Windows.Forms.Label lbl_return_date;
        private System.Windows.Forms.Label lbl_RentalSts;
        private System.Windows.Forms.Label lbl_Remarks;
        private System.Windows.Forms.TextBox txt_cust_id;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Label lbl_Avail;
        private System.Windows.Forms.TextBox txt_avaliable;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Rented;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.DateTimePicker dtp_issue;
        private System.Windows.Forms.DateTimePicker dtp_due;
        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.GroupBox gbx_RentalSts;
        private System.Windows.Forms.RadioButton rbtn_Out;
        private System.Windows.Forms.RadioButton rbtn_In;
        private System.Windows.Forms.TextBox txt_m_title;
        private System.Windows.Forms.Label lbl_MovieTitle;
        private System.Windows.Forms.TextBox txt_m_type;
        private System.Windows.Forms.Label lbl_MovieType;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.Label lbl_MovieRating;
        private System.Windows.Forms.TextBox txt_r_price;
        private System.Windows.Forms.Label lbl_RentalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_video_code;
        private System.Windows.Forms.TextBox txt_cust_name;
    }
}