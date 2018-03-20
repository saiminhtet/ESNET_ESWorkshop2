namespace esnet_efworkshop02
{
    partial class FormEF_Practice2
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
            this.qBtn = new System.Windows.Forms.Button();
            this.custNameLbl = new System.Windows.Forms.Label();
            this.updBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.memRatingLbl = new System.Windows.Forms.Label();
            this.custNameTBox = new System.Windows.Forms.TextBox();
            this.memRatingTBox = new System.Windows.Forms.TextBox();
            this.custIDTBox = new System.Windows.Forms.TextBox();
            this.custIDLbl = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qBtn
            // 
            this.qBtn.Location = new System.Drawing.Point(80, 20);
            this.qBtn.Name = "qBtn";
            this.qBtn.Size = new System.Drawing.Size(75, 24);
            this.qBtn.TabIndex = 0;
            this.qBtn.Text = "Query";
            this.qBtn.UseVisualStyleBackColor = true;
            this.qBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // custNameLbl
            // 
            this.custNameLbl.AutoSize = true;
            this.custNameLbl.Location = new System.Drawing.Point(20, 92);
            this.custNameLbl.Name = "custNameLbl";
            this.custNameLbl.Size = new System.Drawing.Size(79, 13);
            this.custNameLbl.TabIndex = 1;
            this.custNameLbl.Text = "CustomerName";
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(160, 20);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(75, 24);
            this.updBtn.TabIndex = 3;
            this.updBtn.Text = "Update";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // memRatingLbl
            // 
            this.memRatingLbl.AutoSize = true;
            this.memRatingLbl.Location = new System.Drawing.Point(20, 120);
            this.memRatingLbl.Name = "memRatingLbl";
            this.memRatingLbl.Size = new System.Drawing.Size(76, 13);
            this.memRatingLbl.TabIndex = 5;
            this.memRatingLbl.Text = "MemberRating";
            // 
            // custNameTBox
            // 
            this.custNameTBox.Location = new System.Drawing.Point(100, 88);
            this.custNameTBox.Name = "custNameTBox";
            this.custNameTBox.Size = new System.Drawing.Size(100, 20);
            this.custNameTBox.TabIndex = 6;
            // 
            // memRatingTBox
            // 
            this.memRatingTBox.Location = new System.Drawing.Point(100, 116);
            this.memRatingTBox.Name = "memRatingTBox";
            this.memRatingTBox.Size = new System.Drawing.Size(100, 20);
            this.memRatingTBox.TabIndex = 7;
            // 
            // custIDTBox
            // 
            this.custIDTBox.Location = new System.Drawing.Point(100, 60);
            this.custIDTBox.Name = "custIDTBox";
            this.custIDTBox.Size = new System.Drawing.Size(100, 20);
            this.custIDTBox.TabIndex = 9;
            // 
            // custIDLbl
            // 
            this.custIDLbl.AutoSize = true;
            this.custIDLbl.Location = new System.Drawing.Point(20, 64);
            this.custIDLbl.Name = "custIDLbl";
            this.custIDLbl.Size = new System.Drawing.Size(62, 13);
            this.custIDLbl.TabIndex = 8;
            this.custIDLbl.Text = "CustomerID";
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(240, 20);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 24);
            this.newBtn.TabIndex = 10;
            this.newBtn.Text = "Add";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 12;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 415);
            this.dataGridView1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 24);
            this.button3.TabIndex = 14;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(428, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 24);
            this.button4.TabIndex = 15;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(320, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 24);
            this.button5.TabIndex = 16;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormEF_Practice2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.custIDTBox);
            this.Controls.Add(this.custIDLbl);
            this.Controls.Add(this.memRatingTBox);
            this.Controls.Add(this.custNameTBox);
            this.Controls.Add(this.memRatingLbl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.custNameLbl);
            this.Controls.Add(this.qBtn);
            this.Name = "FormEF_Practice2";
            this.Text = "FormEF_Practice2";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qBtn;
        private System.Windows.Forms.Label custNameLbl;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label memRatingLbl;
        private System.Windows.Forms.TextBox custNameTBox;
        private System.Windows.Forms.TextBox memRatingTBox;
        private System.Windows.Forms.TextBox custIDTBox;
        private System.Windows.Forms.Label custIDLbl;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}