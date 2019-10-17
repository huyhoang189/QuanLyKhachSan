using QuanLyKhackSan.DataAcess;
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

namespace QuanLyKhachSan.GUI
{
    public partial class frmManagerialCustomer : Form
    {
        public frmManagerialCustomer()
        {
            InitializeComponent();
            showdata();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void showdata()
        {
            string query = "  SELECT IDCard AS 'Mã khách hàng', Name AS 'Họ tên',DateOfBirth AS 'Ngày sinh',Sex AS 'Giới tính', Address AS 'Địa chỉ',Nationality AS' Quốc tịch' FROM dbo.CUSTOMER";
            DataSet data = new DataSet();
            // create datatable connect database Users
            ConnectionString cnn = new ConnectionString();
            string con = cnn.getConnectionString(frmLogin.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            showDataRoom.DataSource = data.Tables[0];
        }
    }
}
