
namespace WindowsFormsProject.AdminUserControl
{
    partial class UCViewUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCViewUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvViewUser = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new WindowsFormsProject.MyDBDataSet();
            this.userInfoTableAdapter = new WindowsFormsProject.MyDBDataSetTableAdapters.UserInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(212, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 65);
            this.label6.TabIndex = 32;
            this.label6.Text = "View User List";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // dgvViewUser
            // 
            this.dgvViewUser.AutoGenerateColumns = false;
            this.dgvViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvViewUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvViewUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvViewUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvViewUser.ColumnHeadersHeight = 29;
            this.dgvViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.userRoleDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvViewUser.DataSource = this.userInfoBindingSource6;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewUser.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvViewUser.Location = new System.Drawing.Point(15, 193);
            this.dgvViewUser.Name = "dgvViewUser";
            this.dgvViewUser.RowHeadersWidth = 125;
            this.dgvViewUser.RowTemplate.Height = 24;
            this.dgvViewUser.Size = new System.Drawing.Size(686, 343);
            this.dgvViewUser.TabIndex = 50;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 78;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 111;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.Width = 96;
            // 
            // userRoleDataGridViewTextBoxColumn
            // 
            this.userRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.HeaderText = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userRoleDataGridViewTextBoxColumn.Name = "userRoleDataGridViewTextBoxColumn";
            this.userRoleDataGridViewTextBoxColumn.Width = 96;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 98;
            // 
            // userInfoBindingSource6
            // 
            this.userInfoBindingSource6.DataMember = "UserInfo";
            this.userInfoBindingSource6.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInfoTableAdapter
            // 
            this.userInfoTableAdapter.ClearBeforeFill = true;
            // 
            // UCViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.dgvViewUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "UCViewUser";
            this.Size = new System.Drawing.Size(718, 557);
            this.Load += new System.EventHandler(this.UCViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private System.Windows.Forms.BindingSource userInfoBindingSource1;
        private System.Windows.Forms.BindingSource userInfoBindingSource2;
        private System.Windows.Forms.BindingSource userInfoBindingSource3;
        private System.Windows.Forms.BindingSource userInfoBindingSource4;
        private System.Windows.Forms.BindingSource userInfoBindingSource5;
        private System.Windows.Forms.DataGridView dgvViewUser;
        private System.Windows.Forms.BindingSource userInfoBindingSource6;
        private MyDBDataSet myDBDataSet;
        private MyDBDataSetTableAdapters.UserInfoTableAdapter userInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}
