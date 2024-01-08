using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.AdminUserControl;

namespace WindowsFormsProject
{
    public partial class FormAdmin : Form
    {
        private FormLogIn F1 { get; set; }

        public FormAdmin()
        {
            InitializeComponent();
            UCDashBoard ud = new UCDashBoard();
            this.pnlAdmin.Controls.Add(ud);
        }
        public FormAdmin(string info, FormLogIn f1) : this()
        {
            this.lblUser.Text = info;
            this.F1 = f1;
        }
        internal void btnAddUser_Click(object sender, EventArgs e)
        {
            this.pnlAdmin.Controls.Clear();         
            UCAddUser uc = new UCAddUser();
            this.pnlAdmin.Controls.Add(uc);
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            this.pnlAdmin.Controls.Clear();           
            UCViewUser vc = new UCViewUser();
            this.pnlAdmin.Controls.Add(vc);
        }
        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.F1.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {          
            this.pnlAdmin.Controls.Clear();
            UCProfile up = new UCProfile();
            this.pnlAdmin.Controls.Add(up);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.pnlAdmin.Controls.Clear();
            UCDashBoard ud = new UCDashBoard();
            this.pnlAdmin.Controls.Add(ud);
        }

        private void FormAdmin_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
