namespace BuiMinhHieu_CDTH17
{
    partial class MUCTHU
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
            this.txtngayapdung = new System.Windows.Forms.TextBox();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnamhoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmucthuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayapdungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buiminhhieu_Qlthuhocphi_17DataSet1 = new BuiMinhHieu_CDTH17.Buiminhhieu_Qlthuhocphi_17DataSet1();
            this.mucThuTableAdapter = new BuiMinhHieu_CDTH17.Buiminhhieu_Qlthuhocphi_17DataSet1TableAdapters.MucThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mucThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buiminhhieu_Qlthuhocphi_17DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResert
            // 
            this.btnResert.Location = new System.Drawing.Point(360, 50);
            this.btnResert.Margin = new System.Windows.Forms.Padding(4);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(100, 28);
            this.btnResert.TabIndex = 64;
            this.btnResert.Text = "Resert ";
            this.btnResert.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(360, 14);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 28);
            this.btnOpen.TabIndex = 63;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(468, 14);
            this.btntk.Margin = new System.Windows.Forms.Padding(4);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(100, 28);
            this.btntk.TabIndex = 62;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(468, 50);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 28);
            this.btnthoat.TabIndex = 61;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(339, 139);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 28);
            this.btnluu.TabIndex = 60;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(231, 139);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 59;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(123, 139);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 58;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(15, 139);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 57;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtngayapdung
            // 
            this.txtngayapdung.Location = new System.Drawing.Point(195, 69);
            this.txtngayapdung.Margin = new System.Windows.Forms.Padding(4);
            this.txtngayapdung.Name = "txtngayapdung";
            this.txtngayapdung.Size = new System.Drawing.Size(132, 22);
            this.txtngayapdung.TabIndex = 56;
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(195, 39);
            this.txtsotien.Margin = new System.Windows.Forms.Padding(4);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(132, 22);
            this.txtsotien.TabIndex = 55;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(195, 5);
            this.txtma.Margin = new System.Windows.Forms.Padding(4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(132, 22);
            this.txtma.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ngày Áp Dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Số Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(35, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mã Mức Thu";
            // 
            // txtnamhoc
            // 
            this.txtnamhoc.Location = new System.Drawing.Point(195, 99);
            this.txtnamhoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtnamhoc.Name = "txtnamhoc";
            this.txtnamhoc.Size = new System.Drawing.Size(132, 22);
            this.txtnamhoc.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Năm Học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idmucthuDataGridViewTextBoxColumn,
            this.sotienDataGridViewTextBoxColumn,
            this.ngayapdungDataGridViewTextBoxColumn,
            this.namhocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mucThuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 150);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // idmucthuDataGridViewTextBoxColumn
            // 
            this.idmucthuDataGridViewTextBoxColumn.DataPropertyName = "Idmucthu";
            this.idmucthuDataGridViewTextBoxColumn.HeaderText = "ID Mức Thu";
            this.idmucthuDataGridViewTextBoxColumn.Name = "idmucthuDataGridViewTextBoxColumn";
            // 
            // sotienDataGridViewTextBoxColumn
            // 
            this.sotienDataGridViewTextBoxColumn.DataPropertyName = "Sotien";
            this.sotienDataGridViewTextBoxColumn.HeaderText = "Số Tiền";
            this.sotienDataGridViewTextBoxColumn.Name = "sotienDataGridViewTextBoxColumn";
            // 
            // ngayapdungDataGridViewTextBoxColumn
            // 
            this.ngayapdungDataGridViewTextBoxColumn.DataPropertyName = "Ngayapdung";
            this.ngayapdungDataGridViewTextBoxColumn.HeaderText = "Ngày Áp Dụng";
            this.ngayapdungDataGridViewTextBoxColumn.Name = "ngayapdungDataGridViewTextBoxColumn";
            // 
            // namhocDataGridViewTextBoxColumn
            // 
            this.namhocDataGridViewTextBoxColumn.DataPropertyName = "Namhoc";
            this.namhocDataGridViewTextBoxColumn.HeaderText = "Năm Học";
            this.namhocDataGridViewTextBoxColumn.Name = "namhocDataGridViewTextBoxColumn";
            // 
            // mucThuBindingSource
            // 
            this.mucThuBindingSource.DataMember = "MucThu";
            this.mucThuBindingSource.DataSource = this.buiminhhieu_Qlthuhocphi_17DataSet1;
            // 
            // buiminhhieu_Qlthuhocphi_17DataSet1
            // 
            this.buiminhhieu_Qlthuhocphi_17DataSet1.DataSetName = "Buiminhhieu_Qlthuhocphi_17DataSet1";
            this.buiminhhieu_Qlthuhocphi_17DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mucThuTableAdapter
            // 
            this.mucThuTableAdapter.ClearBeforeFill = true;
            // 
            // MUCTHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 347);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnamhoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResert);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtngayapdung);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MUCTHU";
            this.Text = "MUCTHU";
            this.Load += new System.EventHandler(this.MUCTHU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mucThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buiminhhieu_Qlthuhocphi_17DataSet1)).EndInit();
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
        private System.Windows.Forms.TextBox txtngayapdung;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnamhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Buiminhhieu_Qlthuhocphi_17DataSet1 buiminhhieu_Qlthuhocphi_17DataSet1;
        private System.Windows.Forms.BindingSource mucThuBindingSource;
        private Buiminhhieu_Qlthuhocphi_17DataSet1TableAdapters.MucThuTableAdapter mucThuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmucthuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayapdungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhocDataGridViewTextBoxColumn;
    }
}