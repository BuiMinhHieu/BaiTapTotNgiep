﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiMinhHieu_CDTH17
{
    public partial class DOITUONGMG : Form
    {
        string chuoiketnoi = @"Data Source=MINHIEU\SQLEXPRESS;Initial Catalog=Buiminhhieu_Qlthuhocphi_17;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd; 
        public DOITUONGMG()
        {
            InitializeComponent();
        }

        private void DOITUONGMG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buiminhhieu_Qlthuhocphi_17DataSet.DoiTuongMienGiam' table. You can move, or remove it, as needed.
            this.doiTuongMienGiamTableAdapter.Fill(this.buiminhhieu_Qlthuhocphi_17DataSet.DoiTuongMienGiam);
            load();
            Lock();
        }
        private void connect()
        {
            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror!!!!" + ex.Message);
            }

        }
        private void LoadDataToCollectionDoiTuong()//load tên thông qua tự nhập vào
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            string strConnection = @"Data Source=MINHIEU\SQLEXPRESS;Initial Catalog=Buiminhhieu_Qlthuhocphi_17;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            string sql = "Select Tendoituong from DoiTuongMienGiam ";
            SqlCommand com = new SqlCommand();

            com.Connection = conn;
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader reader;
            reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto2.Add(reader["Tendoituong"].ToString());
                }
            }
            txtten.AutoCompleteMode = AutoCompleteMode.Append;
            txtten.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtten.AutoCompleteCustomSource = auto2;
            txtten.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        public static DataTable gettable(string sql)//chương trình lấy dữ liệu từ câu truy vấn
        {

            cmd = new SqlCommand(sql, con);//(kết nối , nhập dữ liệu)
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();//tạo bảng
            da.Fill(db);//đổ dữ liệu từ datadapter vào datatable
            return db;
        }
        public void load()//load bang csdl
        {
            connect();
            dataGridView1.DataSource = gettable("select * from DoiTuongMienGiam");
            txtma.Clear();
            txtten.Clear();
            txtmiengiam.Clear();
            dataGridView1.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;

        }
        private void Lock()
        {
            txtma.ReadOnly = true;// chỉ được nhìn
            txtten.ReadOnly = true;
            txtmiengiam.ReadOnly = true;

            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = false;
            btnthoat.Enabled = true;
        }
        private void Unlock()
        {
            txtma.ReadOnly = true;// chỉ được nhìn
            txtten.ReadOnly = false;
            txtmiengiam.ReadOnly = false;

            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = true;
            btnthoat.Enabled = true;
            txtten.Focus(); // chỉ con trỏ chuột về đây
        }
        private string Sinhmatudong(string ma)
        {
            string Matusinh = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                Matusinh = "DT01";
            }
            else
            {
                string chuoima = Convert.ToString(dataGridView1.Rows[count - 2].Cells[1].Value);
                chuoiso = Convert.ToInt32(chuoima.Replace(ma, ""));
                if (chuoiso + 1 < 10)
                {
                    Matusinh = ma + "00" + (chuoiso + 1).ToString();

                }
                else if (chuoiso + 1 < 100)
                {
                    Matusinh = ma + "0" + (chuoiso + 1).ToString();
                }
            }

            return Matusinh;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            Unlock();
            btnsua.Enabled = btnxoa.Enabled = false;
            txtma.Text = Sinhmatudong("DT");
            txtten.Focus();
            trangthai = "add";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Unlock();
            btnthem.Enabled = btnxoa.Enabled = false;
            trangthai = "edit";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Unlock();
            btnthem.Enabled = btnsua.Enabled = false; trangthai = "delete";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = btnxoa.Enabled = btnsua.Enabled = true;
            btnluu.Enabled = false;
            SqlConnection con = new SqlConnection(chuoiketnoi);
            // thêm đối tượng
            if (trangthai == "add")
            {
                try
                {
                    if (txtma.Text != "" && txtten.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("them_doituong", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtma.Text);
                        cmd.Parameters.AddWithValue("@ten", txtten.Text);
                        cmd.Parameters.AddWithValue("@miengiam", txtmiengiam.Text);

                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show(" Thêm mới thành công.");
                            load();
                        }
                        else
                            MessageBox.Show("Error");

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    }
                    txtma.Clear();
                    txtten.Clear();
                    txtmiengiam.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối..!!!" + ex.Message);
                }
            }
            // sửa sinh viên
            else if (trangthai == "edit")
            {
                try
                {
                    if (txtma.Text != "" && txtten.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sua_doituong", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtma.Text);
                        cmd.Parameters.AddWithValue("@ten", txtten.Text);
                        cmd.Parameters.AddWithValue("@miengiam", txtmiengiam.Text);

                        cmd.ExecuteNonQuery();

                        //thực thi thủ tục
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Sửa thành công");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa được");
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    }
                    txtma.Clear();
                    txtten.Clear();
                    txtmiengiam.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Kết Nối.." + ex.Message);
                }
            }
            //xóa sinh viên
            else if (trangthai == "delete")
            {
                try
                {
                    if (txtma.Text != "")
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên không?" + txtma.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();

                            SqlCommand cmd = new SqlCommand("xoa_doituong", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter p = new SqlParameter("@ma", txtma.Text);
                            cmd.Parameters.Add(p);
                            int count = cmd.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("Xóa thành công..!!!");
                                load();
                            }
                            else MessageBox.Show("Không thể xóa sinh viên..??");
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    }
                    txtma.Clear();
                    txtten.Clear();
                    txtmiengiam.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Kết Nối.." + ex.Message);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("text", dataGridView1.DataSource, "Iddoituong");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("text", dataGridView1.DataSource, "Tendoituong");
            txtmiengiam.DataBindings.Clear();
            txtmiengiam.DataBindings.Add("text", dataGridView1.DataSource, "Mucmiengiam");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            LoadDataToCollectionDoiTuong();
            Unlock();
            txtma.ReadOnly = false;
            txtten.Focus();
            dataGridView1.Enabled = true;
            txtten.Clear();
            txtma.Clear();
            txtmiengiam .Clear();
        }

        private void btnResert_Click(object sender, EventArgs e)
        {

        }

        private void btntk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoiketnoi);
                con.Open();
                string sqlSeach = "select * from DoiTuongMienGiam where Iddoituong = @Iddoituong or Tendoituong = @Tendoituong";
                SqlCommand cmd = new SqlCommand(sqlSeach, con);
                cmd.Parameters.AddWithValue("@Iddoituong", txtma.Text);
                cmd.Parameters.AddWithValue("@Tendoituong", txtten.Text);

                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối..!!!" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain frmm = new FormMain();
            frmm.ShowDialog();
        }






    }
}
