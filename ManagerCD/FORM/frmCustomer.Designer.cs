
namespace ManagerCD.FORM
{
    partial class frmCustomer
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
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewCus = new System.Windows.Forms.Button();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbSearchCus = new System.Windows.Forms.TextBox();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbQQCus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbSDTCus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmTypeCus = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbCMNDCus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbNameCus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbCusID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeCus)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(0, 62);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.Size = new System.Drawing.Size(470, 318);
            this.dtgvCustomer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewCus);
            this.panel1.Controls.Add(this.btnDeleteCus);
            this.panel1.Controls.Add(this.btnEditCus);
            this.panel1.Controls.Add(this.btnAddCus);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnViewCus
            // 
            this.btnViewCus.Location = new System.Drawing.Point(303, 0);
            this.btnViewCus.Name = "btnViewCus";
            this.btnViewCus.Size = new System.Drawing.Size(75, 51);
            this.btnViewCus.TabIndex = 7;
            this.btnViewCus.Text = "Xem";
            this.btnViewCus.UseVisualStyleBackColor = true;
            this.btnViewCus.Click += new System.EventHandler(this.btnViewCus_Click);
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.Location = new System.Drawing.Point(206, 0);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(75, 51);
            this.btnDeleteCus.TabIndex = 6;
            this.btnDeleteCus.Text = "Xóa";
            this.btnDeleteCus.UseVisualStyleBackColor = true;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // btnEditCus
            // 
            this.btnEditCus.Location = new System.Drawing.Point(110, 0);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(75, 51);
            this.btnEditCus.TabIndex = 5;
            this.btnEditCus.Text = "Sửa";
            this.btnEditCus.UseVisualStyleBackColor = true;
            this.btnEditCus.Click += new System.EventHandler(this.btnEditCus_Click);
            // 
            // btnAddCus
            // 
            this.btnAddCus.Location = new System.Drawing.Point(12, 0);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(75, 51);
            this.btnAddCus.TabIndex = 4;
            this.btnAddCus.Text = "Thêm";
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbSearchCus);
            this.panel5.Controls.Add(this.btnSearchCus);
            this.panel5.Location = new System.Drawing.Point(476, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 51);
            this.panel5.TabIndex = 3;
            // 
            // txbSearchCus
            // 
            this.txbSearchCus.Location = new System.Drawing.Point(3, 15);
            this.txbSearchCus.Name = "txbSearchCus";
            this.txbSearchCus.Size = new System.Drawing.Size(231, 20);
            this.txbSearchCus.TabIndex = 3;
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.Location = new System.Drawing.Point(240, 0);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(75, 51);
            this.btnSearchCus.TabIndex = 2;
            this.btnSearchCus.Text = "Tìm";
            this.btnSearchCus.UseVisualStyleBackColor = true;
            this.btnSearchCus.Click += new System.EventHandler(this.btnSearchCus_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(476, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 325);
            this.panel6.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbQQCus);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 39);
            this.panel3.TabIndex = 5;
            // 
            // txbQQCus
            // 
            this.txbQQCus.Location = new System.Drawing.Point(86, 9);
            this.txbQQCus.Name = "txbQQCus";
            this.txbQQCus.Size = new System.Drawing.Size(223, 20);
            this.txbQQCus.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quê quán:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbSDTCus);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 39);
            this.panel2.TabIndex = 4;
            // 
            // txbSDTCus
            // 
            this.txbSDTCus.Location = new System.Drawing.Point(86, 9);
            this.txbSDTCus.Name = "txbSDTCus";
            this.txbSDTCus.Size = new System.Drawing.Size(223, 20);
            this.txbSDTCus.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmTypeCus);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 228);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(317, 39);
            this.panel10.TabIndex = 4;
            // 
            // nmTypeCus
            // 
            this.nmTypeCus.Location = new System.Drawing.Point(97, 9);
            this.nmTypeCus.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmTypeCus.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTypeCus.Name = "nmTypeCus";
            this.nmTypeCus.Size = new System.Drawing.Size(68, 20);
            this.nmTypeCus.TabIndex = 1;
            this.nmTypeCus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbCMNDCus);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 93);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(317, 39);
            this.panel9.TabIndex = 3;
            // 
            // txbCMNDCus
            // 
            this.txbCMNDCus.Location = new System.Drawing.Point(86, 9);
            this.txbCMNDCus.Name = "txbCMNDCus";
            this.txbCMNDCus.Size = new System.Drawing.Size(223, 20);
            this.txbCMNDCus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "CMND:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbNameCus);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 48);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(317, 39);
            this.panel8.TabIndex = 2;
            // 
            // txbNameCus
            // 
            this.txbNameCus.Location = new System.Drawing.Point(86, 11);
            this.txbNameCus.Name = "txbNameCus";
            this.txbNameCus.Size = new System.Drawing.Size(223, 20);
            this.txbNameCus.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên KH:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbCusID);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(317, 39);
            this.panel7.TabIndex = 1;
            // 
            // txbCusID
            // 
            this.txbCusID.Location = new System.Drawing.Point(86, 11);
            this.txbCusID.Name = "txbCusID";
            this.txbCusID.ReadOnly = true;
            this.txbCusID.Size = new System.Drawing.Size(223, 20);
            this.txbCusID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvCustomer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeCus)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbSearchCus;
        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.Button btnViewCus;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbQQCus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSDTCus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmTypeCus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbCMNDCus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbNameCus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbCusID;
        private System.Windows.Forms.Label label1;
    }
}