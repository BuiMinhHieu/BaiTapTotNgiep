
using BuiMinhHieu_CDTH17.form;
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

namespace BuiMinhHieu_CDTH17
{
    public partial class InBienLai : Form
    {
        class ketnoi
        {

            public SqlConnection kn = new SqlConnection();
            public void kn_csdl()
            {
                string chuoikn = @"Data Source=MINHIEU\SQLEXPRESS;Initial Catalog=Buiminhhieu_Qlthuhocphi_17;Integrated Security=True";

                kn.ConnectionString = chuoikn;
                kn.Open();
            }
            public string lay1giatri(string sql)
            {
                string kq = "";
                try
                {
                    kn_csdl();

                    SqlCommand sqlComm = new SqlCommand(sql, kn);
                    SqlDataReader r = sqlComm.ExecuteReader();
                    if (r.Read())
                    {
                        kq = r["tong"].ToString();
                    }
                }
                catch
                { }
                return kq;
            }


            public void dongketnoi()
            {
                if (kn.State == ConnectionState.Open)
                { kn.Close(); }
            }
            public DataTable bangdulieu = new DataTable();
            public DataTable laybang(string caulenh)
            {
                try
                {
                    kn_csdl();
                    SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, kn);
                    DataSet ds = new DataSet();

                    Adapter.Fill(bangdulieu);
                }
                catch (System.Exception)
                {
                    bangdulieu = null;
                }
                finally
                {
                    dongketnoi();
                }

                return bangdulieu;
            }

            public int xulydulieu(string caulenhsql)
            {
                int kq = 0;
                try
                {
                    kn_csdl();
                    SqlCommand lenh = new SqlCommand(caulenhsql, kn);
                    kq = lenh.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //Thông báo lỗi ra!

                    kq = 0;
                }
                finally
                {
                    dongketnoi();
                }
                return kq;
            }
        }
        public InBienLai()
        {
            InitializeComponent();
        }
        public string temp;
        public string temp1;
        private void InBienLai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSInbienlai.BienLai' table. You can move, or remove it, as needed.
            
            BIENLAI frm = new BIENLAI();
            string Idbienlai = temp;
            string Idhocsinh = temp1;
            MessageBox.Show(Idbienlai);
            this.BienLaiTableAdapter.Fill(this.DSInbienlai.BIENLAI,Idbienlai);          
            this.ReportBienLai.RefreshReport();
        }

        

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
