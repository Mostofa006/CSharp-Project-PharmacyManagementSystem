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
    public partial class UCUpdateMedicine : UserControl
    {
        private DataAccess Da { get; set; }
        public UCUpdateMedicine()
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

        private void dgvViewMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dgvViewMedicine.Rows[index];
            txtMedicineId.Text = selectedrow.Cells[0].Value.ToString();
            txtMedicineName.Text = selectedrow.Cells[1].Value.ToString();
            txtMedicineNumber.Text = selectedrow.Cells[2].Value.ToString();
            dtpManufacturingDate.Text = selectedrow.Cells[3].Value.ToString();
            dtpExpireDate.Text = selectedrow.Cells[4].Value.ToString();
            txtQuantity.Text = selectedrow.Cells[5].Value.ToString();
            txtPricePerUnit.Text = selectedrow.Cells[6].Value.ToString();
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvViewMedicine.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
                totalQuantity = quantity + addQuantity;   
                //update
                var sql = @"update MedicineInfo
                                    set  MedicineName = '" + this.txtMedicineName.Text + @"',
                                    MedicineNumber = '" + this.txtMedicineNumber.Text + @"',
		                            ManufacturingDate = '" + this.dtpManufacturingDate.Text + @"',
                                    ExpireDate = '" + this.dtpExpireDate.Text + @"',
                                    Quantity = '" + totalQuantity + @"',
                                    PricePerUnit = '" + this.txtPricePerUnit.Text + @"'
                                    where MedicineId = '" + this.txtMedicineId.Text + "'; ";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Updated");
                else
                    MessageBox.Show("Data Upgradation Failure");


            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error in your input: " + exc.Message);
            }
        }
        private void ClearAll()
        {
            this.txtMedicineId.Clear();
            this.txtMedicineName.Clear(); this.txtMedicineNumber.Clear();
            this.dtpManufacturingDate.Text = "";
            this.dtpExpireDate.Text = "";
            this.txtQuantity.Clear();
            this.txtPricePerUnit.Clear();
            //is.txtUserId.Clear();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvViewMedicine.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                var MedicineId = this.dgvViewMedicine.CurrentRow.Cells[0].Value.ToString();
                var MedicineName = this.dgvViewMedicine.CurrentRow.Cells[1].Value.ToString();
                //MessageBox.Show(id);
                var sql = "delete from MedicineInfo where MedicineId = '" + MedicineId + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed from the UserInfo");
                else
                    MessageBox.Show("Data Deletion Failure");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error in your input: " + exc.Message);
            }
        }
    }
    
}

    
