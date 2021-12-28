
namespace ManagerCD.FORM
{
    partial class frmCD
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
            this.dtgvCD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearchCD = new System.Windows.Forms.TextBox();
            this.btnSearchCD = new System.Windows.Forms.Button();
            this.btnAddCD = new System.Windows.Forms.Button();
            this.btnDeleteCD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCD
            // 
            this.dtgvCD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCD.GridColor = System.Drawing.Color.Maroon;
            this.dtgvCD.Location = new System.Drawing.Point(0, 113);
            this.dtgvCD.MultiSelect = false;
            this.dtgvCD.Name = "dtgvCD";
            this.dtgvCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCD.Size = new System.Drawing.Size(801, 337);
            this.dtgvCD.TabIndex = 0;
            this.dtgvCD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCD_CellClick);
            this.dtgvCD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCD_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txbSearchCD
            // 
            this.txbSearchCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchCD.Location = new System.Drawing.Point(342, 75);
            this.txbSearchCD.Name = "txbSearchCD";
            this.txbSearchCD.Size = new System.Drawing.Size(203, 20);
            this.txbSearchCD.TabIndex = 2;
            // 
            // btnSearchCD
            // 
            this.btnSearchCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCD.Location = new System.Drawing.Point(551, 73);
            this.btnSearchCD.Name = "btnSearchCD";
            this.btnSearchCD.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCD.TabIndex = 3;
            this.btnSearchCD.Text = "Tìm kiếm";
            this.btnSearchCD.UseVisualStyleBackColor = true;
            this.btnSearchCD.Click += new System.EventHandler(this.btnSearchCD_Click);
            // 
            // btnAddCD
            // 
            this.btnAddCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCD.Location = new System.Drawing.Point(632, 73);
            this.btnAddCD.Name = "btnAddCD";
            this.btnAddCD.Size = new System.Drawing.Size(75, 23);
            this.btnAddCD.TabIndex = 4;
            this.btnAddCD.Text = "Thêm mới";
            this.btnAddCD.UseVisualStyleBackColor = true;
            this.btnAddCD.Click += new System.EventHandler(this.btnAddCD_Click);
            // 
            // btnDeleteCD
            // 
            this.btnDeleteCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCD.Location = new System.Drawing.Point(721, 73);
            this.btnDeleteCD.Name = "btnDeleteCD";
            this.btnDeleteCD.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCD.TabIndex = 5;
            this.btnDeleteCD.Text = "Xóa";
            this.btnDeleteCD.UseVisualStyleBackColor = true;
            this.btnDeleteCD.Click += new System.EventHandler(this.btnDeleteCD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUẢN LÍ ĐĨA CD";
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(12, 84);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteCD);
            this.Controls.Add(this.btnAddCD);
            this.Controls.Add(this.btnSearchCD);
            this.Controls.Add(this.txbSearchCD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvCD);
            this.Name = "frmCD";
            this.Text = "frmCD";
            this.Load += new System.EventHandler(this.frmCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearchCD;
        private System.Windows.Forms.Button btnSearchCD;
        private System.Windows.Forms.Button btnAddCD;
        private System.Windows.Forms.Button btnDeleteCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
    }
}