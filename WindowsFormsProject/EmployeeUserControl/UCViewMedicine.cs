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
    public partial class UCViewMedicine : UserControl
    {
        private DataAccess Da { get; set; }
        public UCViewMedicine()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from medicineinfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvViewMedicine.DataSource = ds.Tables[0];
        }
        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from MedicineInfo where MedicineName like '" + this.txtMedicineName.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void UCViewMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
