using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.EmployeeUserControl;

namespace WindowsFormsProject
{
    public partial class FormEmployee : Form
    {
        private FormLogIn F1 { get; set; }
        public FormEmployee()
        {
            InitializeComponent();
            UCAddMedicine um = new UCAddMedicine();
            this.pnlEmployee.Controls.Add(um);
        }
        public FormEmployee(string info, FormLogIn f1) : this()
        {
            this.lblUser.Text =  info;
            this.F1 = f1;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.F1.Show();
        }

        private void FormEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            this.pnlEmployee.Controls.Clear();
            UCAddMedicine um = new UCAddMedicine();
            this.pnlEmployee.Controls.Add(um);
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            this.pnlEmployee.Controls.Clear();
            UCUpdateMedicine um = new UCUpdateMedicine();
            this.pnlEmployee.Controls.Add(um);
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            this.pnlEmployee.Controls.Clear();
            UCViewMedicine uvm = new UCViewMedicine();
            this.pnlEmployee.Controls.Add(uvm);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
                this.Hide();
                this.F1.Show();
        }

        private void btnMedicineValidityCheck_Click(object sender, EventArgs e)
        {
            this.pnlEmployee.Controls.Clear();
            UCMedicineValidityCheck uvc = new UCMedicineValidityCheck();
            this.pnlEmployee.Controls.Add(uvc);
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            this.pnlEmployee.Controls.Clear();
            UCSellMedicine usm = new UCSellMedicine();
            this.pnlEmployee.Controls.Add(usm);
        }
    }
}
