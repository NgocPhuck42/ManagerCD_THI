using ManagerCD.DAO;
using ManagerCD.DTO;
using ManagerCD.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCD
{
    public partial class Form1 : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get
            {
                return loginAccount;

            }
            set
            {
                loginAccount = value; ChangeAccount(loginAccount.Type);
            }


        }

        public Form1(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thốngKêToolStripMenuItem.Enabled = type == 1;
            hệThốngToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }

       

        private void AddForm(Form f)
        {
            this.gbContent.Controls.Clear();

            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.gbContent.Controls.Add(f);
            f.Show();
        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCategory();
            AddForm(f);
        }

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCD();
            AddForm(f);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            AddForm(f);
        }

         void f_UpdateAccount(object sender, AccountEvent e)
        {
            hệThốngToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

       

        private void thuêĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThueDia();
            AddForm(f);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoanhThu();
            AddForm(f);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCustomer();
            AddForm(f);
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmAdmin();
            f.loginAccount = loginAccount;
            AddForm(f);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
