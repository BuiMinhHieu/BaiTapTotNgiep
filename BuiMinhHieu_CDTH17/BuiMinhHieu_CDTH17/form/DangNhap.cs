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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MINHIEU\SQLEXPRESS;Initial Catalog=Buiminhhieu_Qlthuhocphi_17;Integrated Security=True");
            try
            {
               
                con.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sql = "select * from Admin where TaiKhoan='"+tk+"' and MatKhau='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    FormMain fm = new FormMain();
                    fm.ShowDialog();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("đăng nhập thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttaikhoan.Clear();
                    txtmatkhau.Clear();
                    txttaikhoan.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txttaikhoan.Focus();
        }
    }
}
