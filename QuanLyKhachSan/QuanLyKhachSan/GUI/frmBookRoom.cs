using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhackSan.DataAcess;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyKhachSan.GUI
{
    public partial class frmBookRoom : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        ConnectionString cnn = new ConnectionString();
        SqlDataAdapter adap;
        string query = "";
        public frmBookRoom()
        {
            InitializeComponent();
        }
        void load()
        {
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                DataTable data_emptyRoom = new DataTable();
                query = "USP_LoadEmptyRoom";
                cmd = new SqlCommand(query, conn);
                adap = new SqlDataAdapter(cmd);
                adap.Fill(data_emptyRoom);
                showDataRoom.DataSource = data_emptyRoom;
            }
        }
        string MaDatPhong()
        {
            string MaDatPhong = "";
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                DataTable data = new DataTable();
                query = "Select *from BookRoom";
                cmd = new SqlCommand(query, conn);
                adap = new SqlDataAdapter(cmd);
                adap.Fill(data);

            }
                 
               return MaDatPhong;
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
            Date_CheckIn.CustomFormat = "dd/MM/yyyy";
            date_CheckOut.Format = DateTimePickerFormat.Custom;
            date_CheckOut.CustomFormat = "dd/MM/yyyy";
            load();
        }
    }
}
