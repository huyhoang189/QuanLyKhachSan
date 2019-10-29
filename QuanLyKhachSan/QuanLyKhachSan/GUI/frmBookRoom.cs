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
            date_CheckOut.Format = DateTimePickerFormat.Custom;
            Date_CheckIn.CustomFormat = "dd/MM/yyyy";
            date_CheckOut.CustomFormat = "dd/MM/yyyy";
            load();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
