using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhackSan.DataAcess;

namespace QuanLyKhachSan.GUI
{
    public partial class frmBookRoom : Form
    {
        SqlConnection conn;
        ConnectionString cnn = new ConnectionString();
        SqlDataAdapter adap;
        SqlCommand cmd;
        string query = "";
        public frmBookRoom()
        {
            InitializeComponent();
        }
        void load()
        {
            DataTable data_emptyroom = new DataTable();
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                query = "USP_LoadEmptyRoom"; 
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adap = new SqlDataAdapter(cmd);
                adap.Fill(data_emptyroom);
                showDataRoom.DataSource = data_emptyroom;
            }
            
        }
        string check_MaDatPhong()
        {
            string MaDatPhong = "";
            DataTable dt_bookroom = new DataTable();
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                query = "select *from BookRoom order by ID DESC";
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(dt_bookroom);
             }
            if (dt_bookroom.Rows.Count == 0) return "1";
            string temp = dt_bookroom.Rows[0]["ID"].ToString();
            int Id_phong = Convert.ToInt32(temp);
            Id_phong++;
            MaDatPhong = Id_phong.ToString();
            return MaDatPhong;
        }
        bool check_Customer(string CMND)
        {
            bool check=true;
            query = "select *from Customer where IDCard='"+CMND+"'";
            DataTable dt_customer = new DataTable();
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(dt_customer);
            }
            if (dt_customer.Rows.Count == 0) return false;
            return true;
        }
        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookRoom_Load(object sender, EventArgs e)
        {
            Date_CheckIn.Format = DateTimePickerFormat.Custom;
            date_CheckOut.Format = DateTimePickerFormat.Custom;
            Date_CheckIn.CustomFormat = "dd/MM/yyyy";
            date_CheckOut.CustomFormat = "dd/MM/yyyy";
            txt_MaDatPhong.Text = check_MaDatPhong();
            load();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
