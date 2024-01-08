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
    public partial class UCProfile : UserControl
    {    
        private DataAccess Da { get; set; }
        public UCProfile()
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvViewUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                
                    //update
                    var sql = @"update UserInfo
                                    set Name = '" + this.txtName.Text + @"',
                                    DateOfBirth = '" + this.dtpDOB.Text + @"',
                                    MobileNo = '" + this.txtMobileNumber.Text + @"',
                                    UserRole = '" + this.cmbUserRole.Text + @"',
                                    Password = '" + this.txtPassword.Text + @"'
                                    where UserId = '" + this.txtUserId.Text + "'; ";
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
            this.cmbUserRole.SelectedIndex = -1;
            this.txtPassword.Clear();
            this.txtMobileNumber.Clear();
            this.txtName.Clear();
            //this.txtUserId.Clear();
            this.dtpDOB.Text = "";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvViewUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                var Userid = this.dgvViewUser.CurrentRow.Cells[0].Value.ToString();
                var Name = this.dgvViewUser.CurrentRow.Cells[1].Value.ToString();
                //MessageBox.Show(id);
                var sql = "delete from userinfo where UserId = '" +Userid+ "';";
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

        private void dgvViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dgvViewUser.Rows[index];
            txtUserId.Text = selectedrow.Cells[0].Value.ToString();
            txtName.Text = selectedrow.Cells[1].Value.ToString();
            dtpDOB.Text = selectedrow.Cells[2].Value.ToString();
            txtMobileNumber.Text = selectedrow.Cells[3].Value.ToString();
            cmbUserRole.Text = selectedrow.Cells[4].Value.ToString();
            txtPassword.Text = selectedrow.Cells[5].Value.ToString();
        }

        private void UCProfile_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }   
}
