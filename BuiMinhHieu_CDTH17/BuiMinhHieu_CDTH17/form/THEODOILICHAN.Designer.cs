namespace BuiMinhHieu_CDTH17.form
{
    partial class THEODOILICHAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THEODOILICHAN));
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtsongaynghi = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idphieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songaynghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhocsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theoDoiLichAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buiminhhieu_Qlthuhocphi_17DataSet4 = new BuiMinhHieu_CDTH17.Buiminhhieu_Qlthuhocphi_17DataSet4();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbmahs = new System.Windows.Forms.ComboBox();
            this.theoDoiLichAnTableAdapter = new BuiMinhHieu_CDTH17.Buiminhhieu_Qlthuhocphi_17DataSet4TableAdapters.TheoDoiLichAnTableAdapter();
            this.txtthangnam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoDoiLichAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buiminhhieu_Qlthuhocphi_17DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(233, 137);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(132, 22);
            this.txtghichu.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Ghi Chú";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(507, 31);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(113, 44);
            this.btnOpen.TabIndex = 79;
            this.btnOpen.Text = "Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btntk
            // 
            this.btntk.Image = ((System.Drawing.Image)(resources.GetObject("btntk.Image")));
            this.btntk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntk.Location = new System.Drawing.Point(374, 31);
            this.btntk.Margin = new System.Windows.Forms.Padding(4);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(125, 44);
            this.btntk.TabIndex = 78;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(451, 104);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(120, 50);
            this.btnthoat.TabIndex = 77;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(271, 239);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(122, 51);
            this.btnluu.TabIndex = 76;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(150, 239);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 51);
            this.btnxoa.TabIndex = 75;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(271, 180);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(122, 51);
            this.btnsua.TabIndex = 74;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(150, 180);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 51);
            this.btnthem.TabIndex = 73;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtsongaynghi
            // 
            this.txtsongaynghi.Location = new System.Drawing.Point(233, 107);
            this.txtsongaynghi.Margin = new System.Windows.Forms.Padding(4);
            this.txtsongaynghi.Name = "txtsongaynghi";
            this.txtsongaynghi.Size = new System.Drawing.Size(132, 22);
            this.txtsongaynghi.TabIndex = 72;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(233, 13);
            this.txtma.Margin = new System.Windows.Forms.Padding(4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(132, 22);
            this.txtma.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Số Ngày Nghỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Ngày Tháng Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(94, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã Phiếu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idphieuDataGridViewTextBoxColumn,
            this.thangnamDataGridViewTextBoxColumn,
            this.songaynghiDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn,
            this.idhocsinhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.theoDoiLichAnBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // idphieuDataGridViewTextBoxColumn
            // 
            this.idphieuDataGridViewTextBoxColumn.DataPropertyName = "Idphieu";
            this.idphieuDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu";
            this.idphieuDataGridViewTextBoxColumn.Name = "idphieuDataGridViewTextBoxColumn";
            // 
            // thangnamDataGridViewTextBoxColumn
            // 
            this.thangnamDataGridViewTextBoxColumn.DataPropertyName = "Thangnam";
            this.thangnamDataGridViewTextBoxColumn.HeaderText = "Tháng Năm";
            this.thangnamDataGridViewTextBoxColumn.Name = "thangnamDataGridViewTextBoxColumn";
            // 
            // songaynghiDataGridViewTextBoxColumn
            // 
            this.songaynghiDataGridViewTextBoxColumn.DataPropertyName = "Songaynghi";
            this.songaynghiDataGridViewTextBoxColumn.HeaderText = "Số Ngày Nghỉ";
            this.songaynghiDataGridViewTextBoxColumn.Name = "songaynghiDataGridViewTextBoxColumn";
            // 
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "Ghichu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            // 
            // idhocsinhDataGridViewTextBoxColumn
            // 
            this.idhocsinhDataGridViewTextBoxColumn.DataPropertyName = "Idhocsinh";
            this.idhocsinhDataGridViewTextBoxColumn.HeaderText = "Mã Học Sinh";
            this.idhocsinhDataGridViewTextBoxColumn.Name = "idhocsinhDataGridViewTextBoxColumn";
            // 
            // theoDoiLichAnBindingSource
            // 
            this.theoDoiLichAnBindingSource.DataMember = "TheoDoiLichAn";
            this.theoDoiLichAnBindingSource.DataSource = this.buiminhhieu_Qlthuhocphi_17DataSet4;
            // 
            // buiminhhieu_Qlthuhocphi_17DataSet4
            // 
            this.buiminhhieu_Qlthuhocphi_17DataSet4.DataSetName = "Buiminhhieu_Qlthuhocphi_17DataSet4";
            this.buiminhhieu_Qlthuhocphi_17DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "Mã Học Sinh";
            // 
            // cmbmahs
            // 
            this.cmbmahs.FormattingEnabled = true;
            this.cmbmahs.Location = new System.Drawing.Point(233, 42);
            this.cmbmahs.Name = "cmbmahs";
            this.cmbmahs.Size = new System.Drawing.Size(132, 24);
            this.cmbmahs.TabIndex = 85;
            // 
            // theoDoiLichAnTableAdapter
            // 
            this.theoDoiLichAnTableAdapter.ClearBeforeFill = true;
            // 
            // txtthangnam
            // 
            this.txtthangnam.Location = new System.Drawing.Point(233, 79);
            this.txtthangnam.Margin = new System.Windows.Forms.Padding(4);
            this.txtthangnam.Name = "txtthangnam";
            this.txtthangnam.Size = new System.Drawing.Size(132, 22);
            this.txtthangnam.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 74);
            this.button1.TabIndex = 87;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // THEODOILICHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtthangnam);
            this.Controls.Add(this.cmbmahs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtsongaynghi);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "THEODOILICHAN";
            this.Text = "THEODOILICHAN";
            this.Load += new System.EventHandler(this.THEODOILICHAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoDoiLichAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buiminhhieu_Qlthuhocphi_17DataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtsongaynghi;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbmahs;
        private Buiminhhieu_Qlthuhocphi_17DataSet4 buiminhhieu_Qlthuhocphi_17DataSet4;
        private System.Windows.Forms.BindingSource theoDoiLichAnBindingSource;
        private Buiminhhieu_Qlthuhocphi_17DataSet4TableAdapters.TheoDoiLichAnTableAdapter theoDoiLichAnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songaynghiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhocsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtthangnam;
        private System.Windows.Forms.Button button1;
    }
}