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
    public partial class UCAddMedicine : UserControl
    {
        private DataAccess Da { get; set; }
        public UCAddMedicine()
        {
            InitializeComponent();
            this.Da = new DataAccess();          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }
                //insert
                var sql = "insert into medicineInfo values('" + this.txtMedicineId.Text + "', '" + this.txtMedicineName.Text + "','" + this.txtMedicineNumber.Text + "', '" + this.dtpManufacturingDate.Text + "','" + this.dtpExpireDate.Text + "', '" + this.txtQuantity.Text + "','" + this.txtPricePerUnit.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Added");
                else
                    MessageBox.Show("Data Addition Failure");

            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error in your input: " + exc.Message);
            }
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtMedicineId.Text) || String.IsNullOrEmpty(this.txtMedicineName.Text) || String.IsNullOrEmpty(this.txtMedicineNumber.Text) ||
                String.IsNullOrEmpty(this.dtpManufacturingDate.Text) || String.IsNullOrEmpty(this.dtpExpireDate.Text) ||
                String.IsNullOrEmpty(this.txtQuantity.Text) || String.IsNullOrEmpty(this.txtPricePerUnit.Text))
                return false;
            else
                return true;
        }

        private void ClearAll()
        {
            this.txtMedicineId.Clear();
            this.txtMedicineName.Clear();
            this.txtMedicineNumber.Clear();
            this.dtpManufacturingDate.Text = "";
            this.dtpExpireDate.Text = "";
            this.txtQuantity.Clear();
            this.txtPricePerUnit.Clear();
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void UCAddMedicine_Load(object sender, EventArgs e)
        {

        }
        }
    }    


