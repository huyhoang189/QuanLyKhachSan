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
    public partial class frm_registration : Form
    {
        public frm_registration()
        {
            InitializeComponent();
            txt_Pass.PasswordChar = '*';
            txt_pass2.PasswordChar = '*';
        }
        private void btn_dangky_Click(object sender, EventArgs e)
        {

        }
        private DataTable connectionTable(string query)
        {
            DataTable data = new DataTable();
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

            return data;
        }
        private int check_username(string name, string pass1, string pass2)
        {
            string query = "SELECT UserName,PassWord FROM staff";
            DataTable data = connectionTable(query);
            for (int i = 0; i < data.Rows.Count; i++)
            {

                string tempName = data.Rows[i]["UserName"].ToString().Trim();
                string tempPass = data.Rows[i]["PassWord"].ToString().Trim();
                if (name.Equals(tempName))
                {
                    return 0;
                }

            }
            if (pass1.Equals(pass2))
            {
                return 1;
            }
            else return -1;
        }
        
        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
