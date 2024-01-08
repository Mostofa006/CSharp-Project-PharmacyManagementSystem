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

namespace WindowsFormsProject.EmployeeUserControl
{
    public partial class UCMedicineValidityCheck : UserControl
    {
        private DataAccess Da { get; set; }
        public UCMedicineValidityCheck()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from medicineinfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvMedicineView.DataSource = ds.Tables[0];
        }

        private void cmbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCheck.SelectedIndex == 0)
            {
                string sql = "select * from medicineinfo where ExpireDate >= getdate()";
                this.PopulateGridView(sql);
            }
            else if(cmbCheck.SelectedIndex == 1)
            {
                string sql = "select * from medicineinfo where ExpireDate <= getdate()";
                this.PopulateGridView(sql);
            }
        }

        private void UCMedicineValidityCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
