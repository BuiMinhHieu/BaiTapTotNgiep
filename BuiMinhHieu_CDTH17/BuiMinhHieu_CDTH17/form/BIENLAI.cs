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
    public partial class BIENLAI : Form
    {
        string chuoiketnoi = @"Data Source=MINHIEU\SQLEXPRESS;Initial Catalog=Buiminhhieu_Qlthuhocphi_17;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static DateTime dtm = DateTime.Now;
        public BIENLAI()
        {
            InitializeComponent();
        }

        private void BIENLAI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buiminhhieu_Qlthuhocphi_17DataSet13.BienLai' table. You can move, or remove it, as needed.
            this.bienLaiTableAdapter4.Fill(this.buiminhhieu_Qlthuhocphi_17DataSet13.BienLai);              
            //// TODO: This line of code loads data into the 'buiminhhieu_Qlthuhocphi_17DataSet3.BienLai' table. You can move, or remove it, as needed.
            //this.bienLaiTableAdapter.Fill(this.buiminhhieu_Qlthuhocphi_17DataSet3.BienLai);
            //load();
            Lock();
            Show_cmbHS("");
            Unlock();
        }
        private void Show_cmbHS(string Idhocsinh)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string sql = "select Idhocsinh, Tenhocsinh from HocSinh";
            if (Idhocsinh != "")
            {
                sql = sql + "where Idhoccsinh = '" + Idhocsinh + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbHS.DataSource = dt;
            cmbHS.ValueMember = "Idhocsinh";
            cmbHS.DisplayMember = "Tenhocsinh";
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
            dataGridView1.DataSource = gettable("select * from BienLai");
            txtma.Clear();
            txtnguoithu.Clear();           
            dataGridView1.Enabled = true;
        }
        public void load1()//load bang csdl
        {
            connect();
            dataGridView2.DataSource = gettable("select * from BienLai");
            txtma.Clear();
            txtnguoithu.Clear();
       
            dataGridView1.Enabled = true;
        }
        private void Lock()
        {
            txtma.ReadOnly = true;// chỉ được nhìn
            cmbHS.Enabled = false;
            txtnguoithu.ReadOnly = true;                    
           
            btnluu.Enabled = false;
            btnthoat.Enabled = true;
        }
        private void Unlock()
        {
            txtma.ReadOnly = false;// chỉ được nhìn
            cmbHS.Enabled = true;
            txtnguoithu.ReadOnly = false;
            dateTimePicker1.Enabled = false;
            btnluu.Enabled = true;
            btnthoat.Enabled = true;
            txtma.Clear();
            txtnguoithu.Clear();
           
        }
        private string Sinhmatudong(string ma)
        {
            string Matusinh = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                Matusinh = "BL01";
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
            txtnguoithu.Focus();
            txtma.Text = Sinhmatudong("BL");
            txtnguoithu.Clear();
            trangthai = "add";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            SqlConnection con = new SqlConnection(chuoiketnoi);
            // thêm đối tượng
            if (trangthai == "add")
            {
                try
                {
                    if (txtma.Text != "" && cmbHS.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("them_bienlai", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", txtma.Text);
                        cmd.Parameters.AddWithValue("@thangnam", dtm);
                        cmd.Parameters.AddWithValue("@nguoithu", txtnguoithu.Text);
                        cmd.Parameters.AddWithValue("@Idhocsinh", cmbHS.SelectedValue.ToString());
                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show(" Thêm mới thành công.");
                            //load();
                            
                            try
                            {

                                string sqlSeach = "select * from BienLai where Idbienlai = @Idbienlai and Nguoithu = @Nguoithu";
                                SqlCommand cmd1 = new SqlCommand(sqlSeach, con);
                                cmd1.Parameters.AddWithValue("@Idbienlai", txtma.Text);
                                cmd1.Parameters.AddWithValue("@Nguoithu", txtnguoithu.Text);

                                cmd1.ExecuteNonQuery();
                                SqlDataReader dr = cmd1.ExecuteReader();
                                DataTable dt = new DataTable();
                                dt.Load(dr);
                                dataGridView1.DataSource = dt;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi kết nối..!!!" + ex.Message);
                            }
                        }
                        else
                            MessageBox.Show("Error");

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối..!!!" + ex.Message);
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            InBienLai frm = new InBienLai();
            frm.temp = txtma.Text;
            frm.ShowDialog();
        }

     

        private void btntk_Click(object sender, EventArgs e)
        {
            // viết chương trình tìm kiếm
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            // câu lệnh tìm kiếm
            string sqlSeach = "select * from BienLai  where Idbienlai = @Idbienlai";
            SqlCommand cmd = new SqlCommand(sqlSeach, con);
            cmd.Parameters.AddWithValue("Idbienlai", txtTK.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("text", dataGridView2.DataSource, "Idbienlai");
            cmbHS.DataBindings.Clear();
            cmbHS.DataBindings.Add("text", dataGridView2.DataSource, "Idhocsinh");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("text", dataGridView2.DataSource, "Thangnam");
            txtnguoithu.DataBindings.Clear();
            txtnguoithu.DataBindings.Add("text", dataGridView2.DataSource, "Nguoithu");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            load1();
            Unlock();
            txtma.ReadOnly = false;           
            txtnguoithu.Clear();
            txtTK.Clear();
            txtma.Clear();
            cmbHS.Enabled = false;
        }
            


    }
}
