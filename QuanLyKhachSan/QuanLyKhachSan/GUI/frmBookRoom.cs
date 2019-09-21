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
                //showDataRoom.DataSource = data_emptyroom;
                showDataRoom.DataSource = data_emptyroom;
            }
            
        }
        
        string check_MaDatPhong()
        {
            string MaDatPhong = "";
            DataTable dt_bookroom = new DataTable();
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                conn.Open();
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
        int check_Customer(string CMND)
        {
            bool check=true;
            query = "select *from Customer where IDCard='"+CMND+"'";
            DataTable dt_customer = new DataTable();
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(dt_customer);
            }
            if (dt_customer.Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                int kh_id;
                kh_id =Convert.ToInt32(dt_customer.Rows[0]["ID"].ToString());
                return kh_id;
            }
            

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
        bool Check_InfoCustomer()
        {
            if(txt_CMND.Text ==""|| txt_DiaChi.Text==""||txt_HoTen.Text==""||txt_QuocTich.Text=="")
            {
                return false;
            }
            return true;
        }
        int getId()
        {
            int kh_id;
            DataTable dt_customer = new DataTable();
            try
            {
                using (conn = new SqlConnection(cnn.getConnectionString(1)))
                {
                    query = "selecr *from Customer order by ID desc";
                    conn.Open();
                    adap = new SqlDataAdapter(query, conn);
                    adap.Fill(dt_customer);
                    kh_id = Convert.ToInt32(dt_customer.Rows[0]["ID"].ToString());
                    conn.Close();
                }
            }
            catch
            {
                return 0;
            }
            return kh_id;
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int index;
            int kh_ID=0;
            string kh_CMND = "";
            string kh_sex = "";
            if(rd_male.Checked==true)
            {
                kh_sex = "Nam";
            }
            else
            {
                kh_sex = "Nữ";
            }
            index = showDataRoom.SelectedRows.Count;
            if (Check_InfoCustomer() == false)
            {
                MessageBox.Show("Thông tin khách hàng chưa đầy đủ!");
                return;
            }
            else
            {
                if(check_Customer(txt_CMND.Text.Trim())==1)
                {
                    try
                    {
                        query = "USP_InsertCustomer_";
                        using (conn = new SqlConnection(cnn.getConnectionString(1)))
                        {
                            conn.Open();
                            cmd = new SqlCommand(query, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idCard", txt_CMND.Text);
                            cmd.Parameters.AddWithValue("@name", txt_HoTen.Text);
                            cmd.Parameters.AddWithValue("@idCustomerType",Convert.ToInt32(1));
                            cmd.Parameters.AddWithValue("@dateOfBirth", dtp_NgaySinh.Value);
                            cmd.Parameters.AddWithValue("@address", txt_DiaChi.Text);
                            cmd.Parameters.AddWithValue("@phoneNumber", Convert.ToInt32(txt_SDT.Text));
                            cmd.Parameters.AddWithValue("@sex", kh_sex);
                            cmd.Parameters.AddWithValue("@nationality", txt_QuocTich.Text.Trim());
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            kh_ID = getId();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin khách hàng chưa đúng");
                    }
                    
                }
                else
                {
                    kh_ID = check_Customer(txt_CMND.Text.Trim());
                }
                

                string id_Room = showDataRoom.Rows[index-1].Cells["ID"].Value.ToString();
                try
                {
                    using (conn = new SqlConnection(cnn.getConnectionString(1)))
                    {
                        query = "insert_BookRoom";
                        conn.Open();
                        cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDRoom", Convert.ToInt32(id_Room));
                        cmd.Parameters.AddWithValue("@IDCustomer", kh_ID);
                        cmd.Parameters.AddWithValue("@Date_Checkin", Date_CheckIn.Value);
                        cmd.Parameters.AddWithValue("@Date_checkout", date_CheckOut.Value);
                        cmd.Parameters.AddWithValue("@Date_book", date_CheckOut.Value);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Đặt phòng thành công!");
                        load();
                    }
                }

                catch
                {
                    MessageBox.Show("Đặt phòng thất bại!");
                }
                }
            }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void showDataRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Date_CheckIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_CheckOut_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    /*
     * 
     * 
     * 
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
                //showDataRoom.DataSource = data_emptyroom;
                showDataRoom.DataSource = data_emptyroom;
            }
            
        }
        
        string check_MaDatPhong()
        {
            string MaDatPhong = "";
            DataTable dt_bookroom = new DataTable();
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                conn.Open();
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
        int check_Customer(string CMND)
        {
            bool check=true;
            query = "select *from Customer where IDCard='"+CMND+"'";
            DataTable dt_customer = new DataTable();
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                adap = new SqlDataAdapter(query, conn);
                adap.Fill(dt_customer);
            }
            if (dt_customer.Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                int kh_id;
                kh_id =Convert.ToInt32(dt_customer.Rows[0]["ID"].ToString());
                return kh_id;
            }
            

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
        bool Check_InfoCustomer()
        {
            if(txt_CMND.Text ==""|| txt_DiaChi.Text==""||txt_HoTen.Text==""||txt_QuocTich.Text=="")
            {
                return false;
            }
            return true;
        }
        int getId()
        {
            int kh_id;
            DataTable dt_customer = new DataTable();
            try
            {
                using (conn = new SqlConnection(cnn.getConnectionString(1)))
                {
                    query = "selecr *from Customer order by ID desc";
                    conn.Open();
                    adap = new SqlDataAdapter(query, conn);
                    adap.Fill(dt_customer);
                    kh_id = Convert.ToInt32(dt_customer.Rows[0]["ID"].ToString());
                    conn.Close();
                }
            }
            catch
            {
                return 0;
            }
            return kh_id;
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int index;
            int kh_ID=0;
            string kh_CMND = "";
            string kh_sex = "";
            if(rd_male.Checked==true)
            {
                kh_sex = "Nam";
            }
            else
            {
                kh_sex = "Nữ";
            }
            index = showDataRoom.SelectedRows.Count;
            if (Check_InfoCustomer() == false)
            {
                MessageBox.Show("Thông tin khách hàng chưa đầy đủ!");
                return;
            }
            else
            {
                if(check_Customer(txt_CMND.Text.Trim())==1)
                {
                    try
                    {
                        query = "USP_InsertCustomer_";
                        using (conn = new SqlConnection(cnn.getConnectionString(1)))
                        {
                            conn.Open();
                            cmd = new SqlCommand(query, conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idCard", txt_CMND.Text);
                            cmd.Parameters.AddWithValue("@name", txt_HoTen.Text);
                            cmd.Parameters.AddWithValue("@idCustomerType",Convert.ToInt32(1));
                            cmd.Parameters.AddWithValue("@dateOfBirth", dtp_NgaySinh.Value);
                            cmd.Parameters.AddWithValue("@address", txt_DiaChi.Text);
                            cmd.Parameters.AddWithValue("@phoneNumber", Convert.ToInt32(txt_SDT.Text));
                            cmd.Parameters.AddWithValue("@sex", kh_sex);
                            cmd.Parameters.AddWithValue("@nationality", txt_QuocTich.Text.Trim());
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            kh_ID = getId();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin khách hàng chưa đúng");
                    }
                    
                }
                else
                {
                    kh_ID = check_Customer(txt_CMND.Text.Trim());
                }
                

                string id_Room = showDataRoom.Rows[index-1].Cells["ID"].Value.ToString();
                try
                {
                    using (conn = new SqlConnection(cnn.getConnectionString(1)))
                    {
                        query = "insert_BookRoom";
                        conn.Open();
                        cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDRoom", Convert.ToInt32(id_Room));
                        cmd.Parameters.AddWithValue("@IDCustomer", kh_ID);
                        cmd.Parameters.AddWithValue("@Date_Checkin", Date_CheckIn.Value);
                        cmd.Parameters.AddWithValue("@Date_checkout", date_CheckOut.Value);
                        cmd.Parameters.AddWithValue("@Date_book", date_CheckOut.Value);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Đặt phòng thành công!");
                        load();
                    }
                }

                catch
                {
                    MessageBox.Show("Đặt phòng thất bại!");
                }
                }
            }
        }

     * 
    */

}

