
namespace WindowsFormsProject.EmployeeUserControl
{
    partial class UCViewMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCViewMedicine));
            this.label6 = new System.Windows.Forms.Label();
            this.dgvViewMedicine = new System.Windows.Forms.DataGridView();
            this.medicineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet2 = new WindowsFormsProject.MyDBDataSet2();
            this.medicineInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.medicineInfoTableAdapter = new WindowsFormsProject.MyDBDataSet2TableAdapters.MedicineInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(136, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 47);
            this.label6.TabIndex = 48;
            this.label6.Text = "View Medicine";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // dgvViewMedicine
            // 
            this.dgvViewMedicine.AutoGenerateColumns = false;
            this.dgvViewMedicine.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvViewMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineIdDataGridViewTextBoxColumn,
            this.medicineNameDataGridViewTextBoxColumn,
            this.medicineNumberDataGridViewTextBoxColumn,
            this.manufacturingDateDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.pricePerUnitDataGridViewTextBoxColumn});
            this.dgvViewMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvViewMedicine.DataSource = this.medicineInfoBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewMedicine.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewMedicine.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvViewMedicine.Location = new System.Drawing.Point(15, 260);
            this.dgvViewMedicine.Name = "dgvViewMedicine";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewMedicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewMedicine.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvViewMedicine.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewMedicine.RowTemplate.Height = 24;
            this.dgvViewMedicine.Size = new System.Drawing.Size(687, 268);
            this.dgvViewMedicine.TabIndex = 49;
            // 
            // medicineIdDataGridViewTextBoxColumn
            // 
            this.medicineIdDataGridViewTextBoxColumn.DataPropertyName = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.HeaderText = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineIdDataGridViewTextBoxColumn.Name = "medicineIdDataGridViewTextBoxColumn";
            this.medicineIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            this.medicineNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicineNumberDataGridViewTextBoxColumn
            // 
            this.medicineNumberDataGridViewTextBoxColumn.DataPropertyName = "MedicineNumber";
            this.medicineNumberDataGridViewTextBoxColumn.HeaderText = "MedicineNumber";
            this.medicineNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineNumberDataGridViewTextBoxColumn.Name = "medicineNumberDataGridViewTextBoxColumn";
            this.medicineNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // manufacturingDateDataGridViewTextBoxColumn
            // 
            this.manufacturingDateDataGridViewTextBoxColumn.DataPropertyName = "ManufacturingDate";
            this.manufacturingDateDataGridViewTextBoxColumn.HeaderText = "ManufacturingDate";
            this.manufacturingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturingDateDataGridViewTextBoxColumn.Name = "manufacturingDateDataGridViewTextBoxColumn";
            this.manufacturingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            this.expireDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePerUnitDataGridViewTextBoxColumn
            // 
            this.pricePerUnitDataGridViewTextBoxColumn.DataPropertyName = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.HeaderText = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePerUnitDataGridViewTextBoxColumn.Name = "pricePerUnitDataGridViewTextBoxColumn";
            this.pricePerUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicineInfoBindingSource1
            // 
            this.medicineInfoBindingSource1.DataMember = "MedicineInfo";
            this.medicineInfoBindingSource1.DataSource = this.myDBDataSet2BindingSource;
            // 
            // myDBDataSet2BindingSource
            // 
            this.myDBDataSet2BindingSource.DataSource = this.myDBDataSet2;
            this.myDBDataSet2BindingSource.Position = 0;
            // 
            // myDBDataSet2
            // 
            this.myDBDataSet2.DataSetName = "MyDBDataSet2";
            this.myDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineInfoBindingSource
            // 
            this.medicineInfoBindingSource.DataMember = "MedicineInfo";
            this.medicineInfoBindingSource.DataSource = this.myDBDataSet2BindingSource;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(43, 50);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(87, 47);
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(225, 194);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(283, 22);
            this.txtMedicineName.TabIndex = 52;
            this.txtMedicineName.TextChanged += new System.EventHandler(this.txtMedicineName_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(221, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 34);
            this.label5.TabIndex = 51;
            this.label5.Text = "Medicine Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // medicineInfoTableAdapter
            // 
            this.medicineInfoTableAdapter.ClearBeforeFill = true;
            // 
            // UCViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.dgvViewMedicine);
            this.Controls.Add(this.label6);
            this.Name = "UCViewMedicine";
            this.Size = new System.Drawing.Size(718, 557);
            this.Load += new System.EventHandler(this.UCViewMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvViewMedicine;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicineInfoBindingSource;
        private System.Windows.Forms.BindingSource myDBDataSet2BindingSource;
        private MyDBDataSet2 myDBDataSet2;
        private MyDBDataSet2TableAdapters.MedicineInfoTableAdapter medicineInfoTableAdapter;
        private System.Windows.Forms.BindingSource medicineInfoBindingSource1;
    }
}
