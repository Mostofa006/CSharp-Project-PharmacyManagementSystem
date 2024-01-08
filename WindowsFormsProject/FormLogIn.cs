using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUD;

namespace WindowsFormsProject
{
    public partial class FormLogIn : Form
    {
        private DataAccess Da { get; set; }
        public FormLogIn()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void btnLogIN_Click(object sender, EventArgs e)
        {
                string query = "select * from UserInfo where UserId = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.Hide();
                    MessageBox.Show("Valid User");

                    if (ds.Tables[0].Rows[0][4].ToString() == "Admin")
                        new FormAdmin(ds.Tables[0].Rows[0][1].ToString(), this).Show();
                    else if (ds.Tables[0].Rows[0][4].ToString() == "Employee")
                        new FormEmployee(ds.Tables[0].Rows[0][1].ToString(), this).Show();
                }
                else
                {
                    MessageBox.Show("Inalid User");
                }
            
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (DialogResult.OK == cd.ShowDialog())
                this.pnlPharmacy.BackColor = cd.Color;
        }
    }     
       
}

