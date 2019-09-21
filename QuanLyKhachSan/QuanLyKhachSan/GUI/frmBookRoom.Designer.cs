namespace QuanLyKhachSan.GUI
{
    partial class frmBookRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel_control = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.Date_CheckIn = new Guna.UI.WinForms.GunaDateTimePicker();
            this.date_CheckOut = new Guna.UI.WinForms.GunaDateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaDatPhong = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.showDataRoom = new Guna.UI.WinForms.GunaDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.dtp_NgaySinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txt_QuocTich = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txt_DiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txt_CMND = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txt_HoTen = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_DatPhong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataRoom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panel_control
            // 
            this.panel_control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_control.BackgroundImage")));
            this.panel_control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_control.Controls.Add(this.btn_exit);
            this.panel_control.Controls.Add(this.gunaLabel1);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.panel_control.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.panel_control.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.panel_control.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Quality = 10;
            this.panel_control.Size = new System.Drawing.Size(996, 36);
            this.panel_control.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(955, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(35, 27);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 21;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 2;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(11, 7);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(83, 21);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "Đặt phòng";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(109, 51);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(103, 17);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Nhân viên lập  :";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel3.Location = new System.Drawing.Point(412, 51);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(79, 17);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Ngày thuê :";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel4.Location = new System.Drawing.Point(704, 51);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(68, 17);
            this.gunaLabel4.TabIndex = 17;
            this.gunaLabel4.Text = "Ngày trả :";
            // 
            // Date_CheckIn
            // 
            this.Date_CheckIn.BaseColor = System.Drawing.Color.White;
            this.Date_CheckIn.BorderColor = System.Drawing.Color.Silver;
            this.Date_CheckIn.CustomFormat = null;
            this.Date_CheckIn.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Date_CheckIn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Date_CheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Date_CheckIn.ForeColor = System.Drawing.Color.Black;
            this.Date_CheckIn.Location = new System.Drawing.Point(414, 72);
            this.Date_CheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date_CheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date_CheckIn.Name = "Date_CheckIn";
            this.Date_CheckIn.OnHoverBaseColor = System.Drawing.Color.White;
            this.Date_CheckIn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Date_CheckIn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Date_CheckIn.OnPressedColor = System.Drawing.Color.Black;
            this.Date_CheckIn.Size = new System.Drawing.Size(204, 38);
            this.Date_CheckIn.TabIndex = 19;
            this.Date_CheckIn.Text = "Thursday, October 10, 2019";
            this.Date_CheckIn.Value = new System.DateTime(2019, 10, 10, 16, 28, 53, 770);
            this.Date_CheckIn.ValueChanged += new System.EventHandler(this.Date_CheckIn_ValueChanged);
            // 
            // date_CheckOut
            // 
            this.date_CheckOut.BaseColor = System.Drawing.Color.White;
            this.date_CheckOut.BorderColor = System.Drawing.Color.Silver;
            this.date_CheckOut.CustomFormat = null;
            this.date_CheckOut.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_CheckOut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_CheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_CheckOut.ForeColor = System.Drawing.Color.Black;
            this.date_CheckOut.Location = new System.Drawing.Point(706, 72);
            this.date_CheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_CheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_CheckOut.Name = "date_CheckOut";
            this.date_CheckOut.OnHoverBaseColor = System.Drawing.Color.White;
            this.date_CheckOut.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_CheckOut.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_CheckOut.OnPressedColor = System.Drawing.Color.Black;
            this.date_CheckOut.Size = new System.Drawing.Size(204, 38);
            this.date_CheckOut.TabIndex = 20;
            this.date_CheckOut.Text = "Thursday, October 10, 2019";
            this.date_CheckOut.Value = new System.DateTime(2019, 10, 10, 16, 28, 53, 770);
            this.date_CheckOut.ValueChanged += new System.EventHandler(this.date_CheckOut_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaDatPhong);
            this.groupBox1.Controls.Add(this.gunaLabel11);
            this.groupBox1.Controls.Add(this.showDataRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(43, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 395);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phòng";
            // 
            // txt_MaDatPhong
            // 
            this.txt_MaDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MaDatPhong.BaseColor = System.Drawing.Color.White;
            this.txt_MaDatPhong.BorderColor = System.Drawing.Color.Silver;
            this.txt_MaDatPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaDatPhong.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaDatPhong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_MaDatPhong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaDatPhong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDatPhong.ForeColor = System.Drawing.Color.Black;
            this.txt_MaDatPhong.Location = new System.Drawing.Point(69, 314);
            this.txt_MaDatPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaDatPhong.Name = "txt_MaDatPhong";
            this.txt_MaDatPhong.PasswordChar = '\0';
            this.txt_MaDatPhong.Size = new System.Drawing.Size(204, 38);
            this.txt_MaDatPhong.TabIndex = 40;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel11.Location = new System.Drawing.Point(66, 284);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(95, 17);
            this.gunaLabel11.TabIndex = 39;
            this.gunaLabel11.Text = "Mã đặt phòng";
            // 
            // showDataRoom
            // 
            this.showDataRoom.AllowUserToAddRows = false;
            this.showDataRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.showDataRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.showDataRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDataRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.showDataRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showDataRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showDataRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showDataRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.showDataRoom.ColumnHeadersHeight = 25;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showDataRoom.DefaultCellStyle = dataGridViewCellStyle12;
            this.showDataRoom.EnableHeadersVisualStyles = false;
            this.showDataRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataRoom.Location = new System.Drawing.Point(0, 23);
            this.showDataRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showDataRoom.Name = "showDataRoom";
            this.showDataRoom.ReadOnly = true;
            this.showDataRoom.RowHeadersVisible = false;
            this.showDataRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.showDataRoom.RowTemplate.Height = 24;
            this.showDataRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataRoom.Size = new System.Drawing.Size(358, 258);
            this.showDataRoom.TabIndex = 31;
            this.showDataRoom.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.showDataRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.showDataRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.showDataRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.showDataRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.showDataRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.showDataRoom.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.showDataRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.showDataRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDataRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.showDataRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.showDataRoom.ThemeStyle.HeaderStyle.Height = 25;
            this.showDataRoom.ThemeStyle.ReadOnly = true;
            this.showDataRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.showDataRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showDataRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDataRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.showDataRoom.ThemeStyle.RowsStyle.Height = 24;
            this.showDataRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(217)))), ((int)(((byte)(244)))));
            this.showDataRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.showDataRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataRoom_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_SDT);
            this.groupBox2.Controls.Add(this.gunaLabel12);
            this.groupBox2.Controls.Add(this.dtp_NgaySinh);
            this.groupBox2.Controls.Add(this.rd_female);
            this.groupBox2.Controls.Add(this.rd_male);
            this.groupBox2.Controls.Add(this.gunaLabel10);
            this.groupBox2.Controls.Add(this.gunaLabel9);
            this.groupBox2.Controls.Add(this.txt_QuocTich);
            this.groupBox2.Controls.Add(this.gunaLabel8);
            this.groupBox2.Controls.Add(this.txt_DiaChi);
            this.groupBox2.Controls.Add(this.gunaLabel7);
            this.groupBox2.Controls.Add(this.txt_CMND);
            this.groupBox2.Controls.Add(this.gunaLabel6);
            this.groupBox2.Controls.Add(this.txt_HoTen);
            this.groupBox2.Controls.Add(this.gunaLabel5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(423, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 395);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SDT.BaseColor = System.Drawing.Color.White;
            this.txt_SDT.BorderColor = System.Drawing.Color.Silver;
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_SDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_SDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.ForeColor = System.Drawing.Color.Black;
            this.txt_SDT.Location = new System.Drawing.Point(21, 227);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.Size = new System.Drawing.Size(204, 38);
            this.txt_SDT.TabIndex = 35;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel12.Location = new System.Drawing.Point(18, 206);
            this.gunaLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(91, 17);
            this.gunaLabel12.TabIndex = 34;
            this.gunaLabel12.Text = "Số điện thoại:";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.BaseColor = System.Drawing.Color.White;
            this.dtp_NgaySinh.BorderColor = System.Drawing.Color.Silver;
            this.dtp_NgaySinh.CustomFormat = null;
            this.dtp_NgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_NgaySinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgaySinh.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(23, 314);
            this.dtp_NgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_NgaySinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgaySinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_NgaySinh.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_NgaySinh.Size = new System.Drawing.Size(204, 38);
            this.dtp_NgaySinh.TabIndex = 33;
            this.dtp_NgaySinh.Text = "Thursday, October 10, 2019";
            this.dtp_NgaySinh.Value = new System.DateTime(2019, 10, 10, 16, 28, 53, 770);
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Location = new System.Drawing.Point(398, 245);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(43, 20);
            this.rd_female.TabIndex = 32;
            this.rd_female.Text = "Nữ";
            this.rd_female.UseVisualStyleBackColor = true;
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Checked = true;
            this.rd_male.Location = new System.Drawing.Point(315, 245);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(55, 20);
            this.rd_male.TabIndex = 31;
            this.rd_male.TabStop = true;
            this.rd_male.Text = "Nam";
            this.rd_male.UseVisualStyleBackColor = true;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel10.Location = new System.Drawing.Point(280, 216);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(66, 17);
            this.gunaLabel10.TabIndex = 29;
            this.gunaLabel10.Text = "Giới tính :";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel9.Location = new System.Drawing.Point(18, 284);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(76, 17);
            this.gunaLabel9.TabIndex = 27;
            this.gunaLabel9.Text = "Ngày sinh :";
            // 
            // txt_QuocTich
            // 
            this.txt_QuocTich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_QuocTich.BaseColor = System.Drawing.Color.White;
            this.txt_QuocTich.BorderColor = System.Drawing.Color.Silver;
            this.txt_QuocTich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QuocTich.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_QuocTich.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_QuocTich.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_QuocTich.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuocTich.ForeColor = System.Drawing.Color.Black;
            this.txt_QuocTich.Location = new System.Drawing.Point(283, 155);
            this.txt_QuocTich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_QuocTich.Name = "txt_QuocTich";
            this.txt_QuocTich.PasswordChar = '\0';
            this.txt_QuocTich.Size = new System.Drawing.Size(204, 38);
            this.txt_QuocTich.TabIndex = 26;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel8.Location = new System.Drawing.Point(280, 134);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(66, 17);
            this.gunaLabel8.TabIndex = 25;
            this.gunaLabel8.Text = "Quốc tịch";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DiaChi.BaseColor = System.Drawing.Color.White;
            this.txt_DiaChi.BorderColor = System.Drawing.Color.Silver;
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_DiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_DiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.Location = new System.Drawing.Point(21, 155);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.Size = new System.Drawing.Size(204, 38);
            this.txt_DiaChi.TabIndex = 24;
            this.txt_DiaChi.TextChanged += new System.EventHandler(this.txt_DiaChi_TextChanged);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel7.Location = new System.Drawing.Point(18, 134);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(55, 17);
            this.gunaLabel7.TabIndex = 23;
            this.gunaLabel7.Text = "Địa chỉ :";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CMND.BaseColor = System.Drawing.Color.White;
            this.txt_CMND.BorderColor = System.Drawing.Color.Silver;
            this.txt_CMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CMND.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_CMND.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_CMND.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_CMND.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.ForeColor = System.Drawing.Color.Black;
            this.txt_CMND.Location = new System.Drawing.Point(283, 81);
            this.txt_CMND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.PasswordChar = '\0';
            this.txt_CMND.Size = new System.Drawing.Size(204, 38);
            this.txt_CMND.TabIndex = 22;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel6.Location = new System.Drawing.Point(282, 60);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(54, 17);
            this.gunaLabel6.TabIndex = 21;
            this.gunaLabel6.Text = "CMND :";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_HoTen.BaseColor = System.Drawing.Color.White;
            this.txt_HoTen.BorderColor = System.Drawing.Color.Silver;
            this.txt_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTen.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_HoTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_HoTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.ForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.Location = new System.Drawing.Point(21, 81);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PasswordChar = '\0';
            this.txt_HoTen.Size = new System.Drawing.Size(204, 38);
            this.txt_HoTen.TabIndex = 20;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel5.Location = new System.Drawing.Point(18, 60);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(75, 17);
            this.gunaLabel5.TabIndex = 19;
            this.gunaLabel5.Text = "Họ và tên :";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel_control;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Hủy";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(446, 552);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(195)))), ((int)(((byte)(211)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(204, 38);
            this.bunifuFlatButton2.TabIndex = 34;
            this.bunifuFlatButton2.Text = "Hủy";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.btn_DatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btn_DatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DatPhong.BorderRadius = 0;
            this.btn_DatPhong.ButtonText = "Đặt phòng";
            this.btn_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatPhong.DisabledColor = System.Drawing.Color.Gray;
            this.btn_DatPhong.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_DatPhong.Iconimage = null;
            this.btn_DatPhong.Iconimage_right = null;
            this.btn_DatPhong.Iconimage_right_Selected = null;
            this.btn_DatPhong.Iconimage_Selected = null;
            this.btn_DatPhong.IconMarginLeft = 0;
            this.btn_DatPhong.IconMarginRight = 0;
            this.btn_DatPhong.IconRightVisible = false;
            this.btn_DatPhong.IconRightZoom = 0D;
            this.btn_DatPhong.IconVisible = false;
            this.btn_DatPhong.IconZoom = 40D;
            this.btn_DatPhong.IsTab = true;
            this.btn_DatPhong.Location = new System.Drawing.Point(708, 552);
            this.btn_DatPhong.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.btn_DatPhong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(195)))), ((int)(((byte)(211)))));
            this.btn_DatPhong.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_DatPhong.selected = false;
            this.btn_DatPhong.Size = new System.Drawing.Size(204, 38);
            this.btn_DatPhong.TabIndex = 35;
            this.btn_DatPhong.Text = "Đặt phòng";
            this.btn_DatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DatPhong.Textcolor = System.Drawing.Color.White;
            this.btn_DatPhong.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatPhong.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.bunifuFlatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Đóng";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = false;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = false;
            this.bunifuFlatButton4.IconZoom = 40D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(197, 552);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(154)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(195)))), ((int)(((byte)(211)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(204, 38);
            this.bunifuFlatButton4.TabIndex = 36;
            this.bunifuFlatButton4.Text = "Đóng";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // txt_user
            // 
            this.txt_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_user.BaseColor = System.Drawing.Color.White;
            this.txt_user.BorderColor = System.Drawing.Color.Silver;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Black;
            this.txt_user.Location = new System.Drawing.Point(111, 72);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.Size = new System.Drawing.Size(204, 38);
            this.txt_user.TabIndex = 18;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // frmBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 605);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.date_CheckOut);
            this.Controls.Add(this.Date_CheckIn);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.panel_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBookRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookRoom";
            this.Load += new System.EventHandler(this.frmBookRoom_Load);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataRoom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_control;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaDateTimePicker date_CheckOut;
        private Guna.UI.WinForms.GunaDateTimePicker Date_CheckIn;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.RadioButton rd_male;
        
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txt_QuocTich;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txt_DiaChi;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txt_CMND;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txt_HoTen;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_DatPhong;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Guna.UI.WinForms.GunaDataGridView showDataRoom;
        private Guna.UI.WinForms.GunaTextBox txt_MaDatPhong;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTextBox txt_user;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_NgaySinh;
        private Guna.UI.WinForms.GunaTextBox txt_SDT;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
    }
}