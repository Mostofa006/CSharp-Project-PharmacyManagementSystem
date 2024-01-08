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

namespace WindowsFormsProject.AdminUserControl
{
    public partial class UCViewUser : UserControl
    {
        private DataAccess Da { get; set; }
        public UCViewUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from userinfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvViewUser.DataSource = ds.Tables[0];
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void UCViewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
