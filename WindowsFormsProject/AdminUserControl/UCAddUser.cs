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
    public partial class UCAddUser : UserControl
    {
        private DataAccess Da { get; set; }

        public UCAddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoIdGenerate();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }
                //insert
                    var sql = "insert into userinfo values('" + this.txtUserId.Text + "', '" + this.txtName.Text + "','" + this.dtpAdd.Text + "', '" + this.txtMobileNo.Text + "','" + this.cmbUserRole.Text + "', '" + this.txtPassword.Text + "');";
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
    if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.cmbUserRole.Text) || String.IsNullOrEmpty(this.txtPassword.Text) ||
        String.IsNullOrEmpty(this.txtMobileNo.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
        String.IsNullOrEmpty(this.dtpAdd.Text))
        return false;
    else
        return true;
}

    private void ClearAll()
     {
            this.cmbUserRole.SelectedIndex = -1;
            this.txtPassword.Clear();
            this.txtMobileNo.Clear();
            this.txtName.Clear();
            //this.txtUserId.Clear();
            this.dtpAdd.Text = "";
            this.AutoIdGenerate();
     }

        private void AutoIdGenerate()
        {
            var sql = "select UserId from userinfo order by UserId desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            string oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "Id-" + (++num).ToString("d3");
            this.txtUserId.Text = newId;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void UCAddUser_Load(object sender, EventArgs e)
        {

        }
    }
    
}

