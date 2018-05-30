namespace BuiMinhHieu_CDTH17
{
    partial class DOITUONGMG
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnResert = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmiengiam = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doiTuongMienGiamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buiminhhieu_Qlthuhocphi_17DataSet = new BuiMinhHieu_CDTH17.Buiminhhieu_Qlthuhocphi_17DataSet();
            this.doiTuongMienGiamTableAdapter = new BuiMinhHieu_CDTH17.Buiminhhieu_Qlthuhocphi_17DataSetTableAdapters.DoiTuongMienGiamTableAdapter();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddoituongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendoituongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucmiengiamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongMienGiamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buiminhhieu_Qlthuhocphi_17DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResert
            // 
            this.btnResert.Location = new System.Drawing.Point(359, 51);
            this.btnResert.Margin = new System.Windows.Forms.Padding(4);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(100, 28);
            this.btnResert.TabIndex = 50;
            this.btnResert.Text = "Resert ";
            this.btnResert.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(359, 15);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 28);
            this.btnOpen.TabIndex = 49;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(467, 15);
            this.btntk.Margin = new System.Windows.Forms.Padding(4);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(100, 28);
            this.btntk.TabIndex = 48;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(467, 51);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 28);
            this.btnthoat.TabIndex = 47;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(338, 140);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 28);
            this.btnluu.TabIndex = 46;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(230, 140);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(122, 140);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 44;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(14, 140);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 43;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmiengiam
            // 
            this.txtmiengiam.Location = new System.Drawing.Point(194, 70);
            this.txtmiengiam.Margin = new System.Windows.Forms.Padding(4);
            this.txtmiengiam.Name = "txtmiengiam";
            this.txtmiengiam.Size = new System.Drawing.Size(132, 22);
            this.txtmiengiam.TabIndex = 42;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(194, 40);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(132, 22);
            this.txtten.TabIndex = 41;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(194, 6);
            this.txtma.Margin = new System.Windows.Forms.Padding(4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(132, 22);
            this.txtma.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mức Miễn Giảm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên Đối Tượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(34, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã Đối Tượng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.iddoituongDataGridViewTextBoxColumn,
            this.tendoituongDataGridViewTextBoxColumn,
            this.mucmiengiamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doiTuongMienGiamBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 150);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // doiTuongMienGiamBindingSource
            // 
            this.doiTuongMienGiamBindingSource.DataMember = "DoiTuongMienGiam";
            this.doiTuongMienGiamBindingSource.DataSource = this.buiminhhieu_Qlthuhocphi_17DataSet;
            // 
            // buiminhhieu_Qlthuhocphi_17DataSet
            // 
            this.buiminhhieu_Qlthuhocphi_17DataSet.DataSetName = "Buiminhhieu_Qlthuhocphi_17DataSet";
            this.buiminhhieu_Qlthuhocphi_17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doiTuongMienGiamTableAdapter
            // 
            this.doiTuongMienGiamTableAdapter.ClearBeforeFill = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // iddoituongDataGridViewTextBoxColumn
            // 
            this.iddoituongDataGridViewTextBoxColumn.DataPropertyName = "Iddoituong";
            this.iddoituongDataGridViewTextBoxColumn.HeaderText = "ID Đối Tượng";
            this.iddoituongDataGridViewTextBoxColumn.Name = "iddoituongDataGridViewTextBoxColumn";
            // 
            // tendoituongDataGridViewTextBoxColumn
            // 
            this.tendoituongDataGridViewTextBoxColumn.DataPropertyName = "Tendoituong";
            this.tendoituongDataGridViewTextBoxColumn.HeaderText = "Tên Đối Tượng";
            this.tendoituongDataGridViewTextBoxColumn.Name = "tendoituongDataGridViewTextBoxColumn";
            // 
            // mucmiengiamDataGridViewTextBoxColumn
            // 
            this.mucmiengiamDataGridViewTextBoxColumn.DataPropertyName = "Mucmiengiam";
            this.mucmiengiamDataGridViewTextBoxColumn.HeaderText = "Mức Miễn Giảm";
            this.mucmiengiamDataGridViewTextBoxColumn.Name = "mucmiengiamDataGridViewTextBoxColumn";
            // 
            // DOITUONGMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnResert);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmiengiam);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DOITUONGMG";
            this.Text = "DOITUONGMG";
            this.Load += new System.EventHandler(this.DOITUONGMG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiTuongMienGiamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buiminhhieu_Qlthuhocphi_17DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmiengiam;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Buiminhhieu_Qlthuhocphi_17DataSet buiminhhieu_Qlthuhocphi_17DataSet;
        private System.Windows.Forms.BindingSource doiTuongMienGiamBindingSource;
        private Buiminhhieu_Qlthuhocphi_17DataSetTableAdapters.DoiTuongMienGiamTableAdapter doiTuongMienGiamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoituongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendoituongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucmiengiamDataGridViewTextBoxColumn;
    }
}