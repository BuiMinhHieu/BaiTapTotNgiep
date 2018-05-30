using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BuiMinhHieu_CDTH17.form
{
    public partial class HOCSINH : Form
    {
        string chuoiketnoi = @"Data Source=MINHIEU\SQLEXPRESS;Initial Catalog=Buiminhhieu_Qlthuhocphi_17;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd; 
        public HOCSINH()
        {
            InitializeComponent();
        }

        private void HOCSINH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buiminhhieu_Qlthuhocphi_17DataSet2.HocSinh' table. You can move, or remove it, as needed.
            this.hocSinhTableAdapter.Fill(this.buiminhhieu_Qlthuhocphi_17DataSet2.HocSinh);
            load();
            Lock();
            Show_cmbDoituongMG("");
            Show_cmbL("");
            
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
        private void LoadDataToCollectionHS()//load mã thông qua tự nhập vào
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            string strConnection = @"Data Source=MINHIEU\SQLEXPRESS;Initial Catalog=Buiminhhieu_Qlthuhocphi_17;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            string sql = "Select Idhocsinh from HocSinh ";
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
                    auto2.Add(reader["Idhocsinh"].ToString());
                }
            }
            txtMa.AutoCompleteMode = AutoCompleteMode.Append;
            txtMa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMa.AutoCompleteCustomSource = auto2;
            txtMa.AutoCompleteMode = AutoCompleteMode.Suggest;
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
            
            dataGridView1.DataSource = gettable("select * from HocSinh");
            txtMa.Clear();
            txtTen.Clear();
            txtDC.Clear();
            txtGT.Clear();
            txtNS.Clear();
            txtbantru.Clear();           
            dataGridView1.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            
        }
        private void Lock()
        {
            txtMa.ReadOnly = true;// chỉ được nhìn
            txtTen.ReadOnly = true;
            txtGT.ReadOnly = true;
            txtDC.ReadOnly = true;
            txtNS.ReadOnly = true;
            txtbantru.ReadOnly = true;
            cmbMaDT.Enabled = false;
            cmbL.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnthoat.Enabled = true;
        }
        private void Unlock()
        {
            txtMa.ReadOnly = false;// chỉ được nhìn
            txtTen.ReadOnly = false;
            txtGT.ReadOnly = false;
            txtDC.ReadOnly = false;
            txtbantru.ReadOnly = false;
            txtNS.ReadOnly = false;
            cmbMaDT.Enabled = true;
            cmbL.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = true;
            btnthoat.Enabled = true;
            txtMa.Focus(); // chỉ con trỏ chuột về đây
        }
        private string Sinhmatudong(string ma)
        {
            string Matusinh = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                Matusinh = "HS01";
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
           txtMa.Text = Sinhmatudong("HS");
           txtTen.Focus();
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
                    if (txtMa.Text != "" && txtTen.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("them_hocsinh", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                        cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                        cmd.Parameters.AddWithValue("@gt", txtGT.Text);
                        cmd.Parameters.AddWithValue("@ns", txtNS.Text);
                        cmd.Parameters.AddWithValue("@dc", txtDC.Text);
                        cmd.Parameters.AddWithValue("@madt", cmbMaDT.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@mal", cmbL.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@bantru", txtbantru.Text);
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
                    txtMa.Clear(); txtTen.Clear(); txtDC.Clear(); txtGT.Clear(); txtNS.Clear();
                    txtbantru.Clear();
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
                    if (txtMa.Text != "" && txtTen.Text  != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sua_hocsinh", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                        cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                        cmd.Parameters.AddWithValue("@gt", txtGT.Text);
                        cmd.Parameters.AddWithValue("@ns", txtNS.Text);
                        cmd.Parameters.AddWithValue("@dc", txtDC.Text);
                        cmd.Parameters.AddWithValue("@madt", cmbMaDT.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@mal", cmbL.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@bantru", txtbantru.Text);
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
                    txtMa.Clear(); txtTen.Clear(); txtDC.Clear(); txtGT.Clear(); txtNS.Clear();
                    txtbantru.Clear();

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
                    if (txtMa.Text != "" )
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa học sinh không?" + txtMa.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.Open();

                            SqlCommand cmd = new SqlCommand("xoa_hocsinh", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter p = new SqlParameter("@ma", txtMa.Text);
                            cmd.Parameters.Add(p);
                            int count = cmd.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("Xóa thành công..!!!");
                                load();
                            }
                            else MessageBox.Show("Không thể xóa học sinh..??");
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    }
                    txtMa.Clear(); txtTen.Clear(); txtDC.Clear(); txtGT.Clear(); txtNS.Clear();
                    txtbantru.Clear();

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
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text", dataGridView1.DataSource, "Idhocsinh");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", dataGridView1.DataSource, "Tenhocsinh");
            txtGT.DataBindings.Clear();
            txtGT.DataBindings.Add("text", dataGridView1.DataSource, "GT");
            txtNS.DataBindings.Clear();
            txtNS.DataBindings.Add("text", dataGridView1.DataSource, "NS");
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("text", dataGridView1.DataSource, "DC");
            txtbantru.DataBindings.Clear();
            txtbantru.DataBindings.Add("text", dataGridView1.DataSource, "Bantru");
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            
            //Unlock();       
            //txtTen.Focus();
            //dataGridView1.Enabled = true;
            //txtTen.Clear();
            //txtNS.Clear();
            //txtGT.Clear();
            //txtDC.Clear();
            //txtbantru.Clear();
            //LoadDataToCollectionHS();
          //  LoadDataToCollectionHS();
            Unlock();
            txtMa.ReadOnly = false;
            load();
            dataGridView1.Enabled = true;
            
        }

        private void Show_cmbDoituongMG(string Iddoituong)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string sql = "select Iddoituong, Tendoituong from DoiTuongMienGiam";
            if (Iddoituong != "")
            {
                sql = sql + "where Iddoituong= '" + Iddoituong + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMaDT.DataSource = dt;
            cmbMaDT.ValueMember = "Iddoituong";
            cmbMaDT.DisplayMember = "Tendoituong";
        }
        private void Show_cmbL(string Idlop)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string sql = "select Idlop, tenlop from Lop";
            if (Idlop != "")
            {
                sql = sql + "where MaLop= '" + Idlop + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbL.DataSource = dt;
            cmbL.ValueMember = "Idlop";
            cmbL.DisplayMember = "Tenlop";
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection(chuoiketnoi);
            //    con.Open();
            //    string sqlSeach = "select * from HocSinh where Idhocsinh = @Idhocsinh or Tenhocsinh = @Tenhocsinh";
            //    SqlCommand cmd = new SqlCommand(sqlSeach, con);
            //    cmd.Parameters.AddWithValue("@Idhocsinh", txtMa.Text);
            //    cmd.Parameters.AddWithValue("@Tenhocsinh", txtTen.Text);

            //    cmd.ExecuteNonQuery();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(dr);
            //    dataGridView1.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết nối..!!!" + ex.Message);
            //}
            // viết chương trình tìm kiếm
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            // câu lệnh tìm kiếm
            string sqlSeach = "select * from HocSinh   where Idhocsinh = @Idhocsinh";
            SqlCommand cmd = new SqlCommand(sqlSeach, con);
            cmd.Parameters.AddWithValue("Idhocsinh", txtTK.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }



    }
}
