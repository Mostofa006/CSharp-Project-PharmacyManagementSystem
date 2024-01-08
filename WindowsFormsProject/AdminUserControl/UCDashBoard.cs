using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUD;
namespace WindowsFormsProject.AdminUserControl
{
    public partial class UCDashBoard : UserControl
    {
        DataAccess Da = new DataAccess();
        DataSet ds;
        public UCDashBoard()
        {
            InitializeComponent();
        }

        private void UCDashBoard_Load(object sender, EventArgs e)
        {
            string query = "select count(userRole) from userInfo where userRole = 'Admin'";
            ds = this.Da.ExecuteQuery(query);
            setLabel(ds, lblAdmin);

            string sql = "select count(userRole) from userInfo where userRole = 'Employee'";
            ds = this.Da.ExecuteQuery(sql);
            setLabel(ds, lblEmployee);
        }
        private void setLabel(DataSet ds, Label lbl)
        {
            if(ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else { lbl.Text = "0"; }
        }
    }
}
