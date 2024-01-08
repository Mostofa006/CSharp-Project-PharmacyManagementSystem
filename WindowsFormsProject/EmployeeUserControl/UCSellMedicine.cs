using DGVPrinterHelper;
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
    public partial class UCSellMedicine : UserControl
    {
        private DataAccess Da { get; set; }
        public UCSellMedicine()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from medicineinfo where ExpireDate >= getdate();")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvViewMedicine.DataSource = ds.Tables[0];
        }

        private void dgvViewMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UCSellMedicine_Load(object sender, EventArgs e)
        {
            dgvCart.Rows[n].Cells[0].Value = txtMedicineId.Text;
            dgvCart.Rows[n].Cells[1].Value = txtMedicineName.Text;
            dgvCart.Rows[n].Cells[2].Value = txtMedicineNumber.Text;
            dgvCart.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
            dgvCart.Rows[n].Cells[4].Value = txtNoOfUnit.Text;
            dgvCart.Rows[n].Cells[5].Value = txtTotalAmount.Text;
        }

        private void dgvViewMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtMedicineId.Text = this.dgvViewMedicine.CurrentRow.Cells[0].Value.ToString();
            this.txtMedicineName.Text = this.dgvViewMedicine.CurrentRow.Cells[1].Value.ToString();
            this.txtMedicineNumber.Text = this.dgvViewMedicine.CurrentRow.Cells[2].Value.ToString();
            this.txtPricePerUnit.Text = this.dgvViewMedicine.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfUnit.Text != "")
            {
               Int64 pricePerUnit = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoOfUnit.Text);
                Int64 totalAmount = pricePerUnit * noOfUnit;
                txtTotalAmount.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalAmount.Clear();
            }
        }
        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "")
            {
                var query = "select Quantity from MedicineInfo where MedicineId = '" + txtMedicineId.Text + "'";
                var ds = this.Da.ExecuteQuery(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoOfUnit.Text);

                if (newQuantity >= 0)
                {
                    var sql = "insert into addtocart values('" + this.txtMedicineId.Text + "', '" + this.txtMedicineName.Text + "','" + this.txtMedicineNumber.Text + "', '" + this.txtPricePerUnit.Text + "','" + this.txtNoOfUnit.Text + "', '" + this.txtTotalAmount.Text + "');";
                    this.Da.ExecuteDMLQuery(sql);
                    this.dgvCart.DataSource = ds.Tables[0];

                    totalAmount = totalAmount + int.Parse(txtTotalAmount.Text);
                    lblTotalTaka.Text = "Tk." + totalAmount.ToString();

                    string quary = "update medicineinfo set quantity = '" + newQuantity + "' where medicineId = '" + txtMedicineId.Text + "'";
                    this.Da.ExecuteDMLQuery(quary);
                    this.PopulateGridView();
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only " + quantity + " Left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ClearAll();
                UCSellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }

        int valueAmount;
        String valueId;
        protected Int64 noOfunit;

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dgvCart.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(dgvCart.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
            catch (Exception) { }                      
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    if (dgvCart.SelectedRows.Count > 0)
                    {
                        int selectedIndex = dgvCart.SelectedRows[0].Index;
                        dgvCart.Rows.RemoveAt(selectedIndex);

                        string query = "select quantity from medicineinfo where medicineId = '" + valueId + "'";
                        var ds = this.Da.ExecuteQuery(query);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                            newQuantity = quantity + noOfunit ; 

                            string sql = "update medicineinfo set quantity ='" + newQuantity + "'where medicineId ='" + valueId + "'";
                            this.Da.ExecuteDMLQuery(sql);

                            totalAmount = totalAmount - valueAmount;
                            lblTotalTaka.Text = "Tk. " + totalAmount.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    UCSellMedicine_Load(this, EventArgs.Empty);
                }
            }
        }

            private void btnPurchase_Click(object sender, EventArgs e)
            {
                DGVPrinter print = new DGVPrinter();
                print.Title = "Medicine Bill";
                print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "Total Payable Amount : " + lblTotalTaka.Text;
                print.FooterSpacing = 15;
                print.PrintDataGridView(dgvCart);

                totalAmount = 0;
                lblTotalTaka.Text = "Tk. 00";
                dgvCart.DataSource = null;
            }
            protected void ClearAll()
            {
               txtMedicineId.Clear();
               txtMedicineName.Clear();
               txtMedicineNumber.Clear();
               txtPricePerUnit.Clear();
             }
    }
}
    

    
 
