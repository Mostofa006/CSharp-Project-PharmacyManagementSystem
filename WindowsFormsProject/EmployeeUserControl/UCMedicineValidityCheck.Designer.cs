
namespace WindowsFormsProject.EmployeeUserControl
{
    partial class UCMedicineValidityCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMedicineValidityCheck));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMedicineView = new System.Windows.Forms.DataGridView();
            this.medicineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet5 = new WindowsFormsProject.MyDBDataSet5();
            this.cmbCheck = new System.Windows.Forms.ComboBox();
            this.medicineInfoTableAdapter = new WindowsFormsProject.MyDBDataSet5TableAdapters.MedicineInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(114, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(474, 47);
            this.label6.TabIndex = 49;
            this.label6.Text = "Medicine Validity Check";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(46, 44);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(62, 47);
            this.pictureBox10.TabIndex = 50;
            this.pictureBox10.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(224, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 34);
            this.label5.TabIndex = 54;
            this.label5.Text = "Check";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMedicineView
            // 
            this.dgvMedicineView.AutoGenerateColumns = false;
            this.dgvMedicineView.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicineView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMedicineView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicineView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineIdDataGridViewTextBoxColumn,
            this.medicineNameDataGridViewTextBoxColumn,
            this.medicineNumberDataGridViewTextBoxColumn,
            this.manufacturingDateDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.pricePerUnitDataGridViewTextBoxColumn});
            this.dgvMedicineView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMedicineView.DataSource = this.medicineInfoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicineView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicineView.Location = new System.Drawing.Point(14, 259);
            this.dgvMedicineView.Name = "dgvMedicineView";
            this.dgvMedicineView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMedicineView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicineView.RowTemplate.Height = 24;
            this.dgvMedicineView.Size = new System.Drawing.Size(687, 268);
            this.dgvMedicineView.TabIndex = 53;
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
            // medicineInfoBindingSource
            // 
            this.medicineInfoBindingSource.DataMember = "MedicineInfo";
            this.medicineInfoBindingSource.DataSource = this.myDBDataSet5;
            // 
            // myDBDataSet5
            // 
            this.myDBDataSet5.DataSetName = "MyDBDataSet5";
            this.myDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCheck
            // 
            this.cmbCheck.FormattingEnabled = true;
            this.cmbCheck.Items.AddRange(new object[] {
            "Valid Medicine",
            "Expired Medicine"});
            this.cmbCheck.Location = new System.Drawing.Point(224, 194);
            this.cmbCheck.Name = "cmbCheck";
            this.cmbCheck.Size = new System.Drawing.Size(283, 24);
            this.cmbCheck.TabIndex = 55;
            this.cmbCheck.Tag = "";
            this.cmbCheck.SelectedIndexChanged += new System.EventHandler(this.cmbCheck_SelectedIndexChanged);
            // 
            // medicineInfoTableAdapter
            // 
            this.medicineInfoTableAdapter.ClearBeforeFill = true;
            // 
            // UCMedicineValidityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.cmbCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMedicineView);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label6);
            this.Name = "UCMedicineValidityCheck";
            this.Size = new System.Drawing.Size(718, 557);
            this.Load += new System.EventHandler(this.UCMedicineValidityCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMedicineView;
        private System.Windows.Forms.ComboBox cmbCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicineInfoBindingSource;
        private MyDBDataSet5 myDBDataSet5;
        private MyDBDataSet5TableAdapters.MedicineInfoTableAdapter medicineInfoTableAdapter;
    }
}
