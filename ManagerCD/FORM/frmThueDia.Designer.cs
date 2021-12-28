
namespace ManagerCD.FORM
{
    partial class frmThueDia
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
            this.flpCD = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxCD = new System.Windows.Forms.ComboBox();
            this.nmCDCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddCD = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbSum = new System.Windows.Forms.TextBox();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCDCount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCD
            // 
            this.flpCD.Location = new System.Drawing.Point(0, 2);
            this.flpCD.Name = "flpCD";
            this.flpCD.Size = new System.Drawing.Size(444, 376);
            this.flpCD.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Location = new System.Drawing.Point(449, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 275);
            this.panel3.TabIndex = 4;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(1, 16);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(401, 259);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên CD";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 220;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxCD);
            this.panel2.Controls.Add(this.nmCDCount);
            this.panel2.Controls.Add(this.btnAddCD);
            this.panel2.Controls.Add(this.cbxCategory);
            this.panel2.Location = new System.Drawing.Point(450, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 48);
            this.panel2.TabIndex = 5;
            // 
            // cbxCD
            // 
            this.cbxCD.FormattingEnabled = true;
            this.cbxCD.Location = new System.Drawing.Point(3, 24);
            this.cbxCD.Name = "cbxCD";
            this.cbxCD.Size = new System.Drawing.Size(241, 21);
            this.cbxCD.TabIndex = 4;
            // 
            // nmCDCount
            // 
            this.nmCDCount.Location = new System.Drawing.Point(351, 15);
            this.nmCDCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCDCount.Name = "nmCDCount";
            this.nmCDCount.Size = new System.Drawing.Size(47, 20);
            this.nmCDCount.TabIndex = 3;
            this.nmCDCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddCD
            // 
            this.btnAddCD.Location = new System.Drawing.Point(250, 1);
            this.btnAddCD.Name = "btnAddCD";
            this.btnAddCD.Size = new System.Drawing.Size(95, 44);
            this.btnAddCD.TabIndex = 1;
            this.btnAddCD.Text = "Thêm";
            this.btnAddCD.UseVisualStyleBackColor = true;
            this.btnAddCD.Click += new System.EventHandler(this.btnAddCD_Click_1);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(3, 1);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(241, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbSum);
            this.panel4.Controls.Add(this.btnAddKH);
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Location = new System.Drawing.Point(450, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 48);
            this.panel4.TabIndex = 6;
            // 
            // txbSum
            // 
            this.txbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txbSum.Location = new System.Drawing.Point(198, 16);
            this.txbSum.Name = "txbSum";
            this.txbSum.ReadOnly = true;
            this.txbSum.Size = new System.Drawing.Size(110, 23);
            this.txbSum.TabIndex = 0;
            this.txbSum.Text = "0";
            this.txbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddKH
            // 
            this.btnAddKH.Location = new System.Drawing.Point(3, 1);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(95, 44);
            this.btnAddKH.TabIndex = 6;
            this.btnAddKH.Text = "Thêm";
            this.btnAddKH.UseVisualStyleBackColor = true;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(309, 1);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(95, 44);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // frmThueDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 410);
            this.Controls.Add(this.flpCD);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "frmThueDia";
            this.Text = "frmThueDia";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmCDCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxCD;
        private System.Windows.Forms.NumericUpDown nmCDCount;
        private System.Windows.Forms.Button btnAddCD;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbSum;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnCheckOut;
    }
}