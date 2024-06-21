using DevExpress.Xpo.Logger;
using DevExpress.XtraEditors;
using QLNhanSu.CHAMCONG;
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

namespace QLNhanSu.HETHONG
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập cả USERNAME và PASSWORD", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=.;Initial Catalog=QuanLyNhanSu_Master;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_NV FROM tb_SYS_User WHERE UserName = @username AND PassWord = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        this.Hide();
                        frmChamCong_NhanVien frm = new frmChamCong_NhanVien();
                        frm._idNhanVien = result.ToString();
                        // Đăng nhập thành công, mở form Main
                        
                        frm.Show();
                        //MainForm mainForm = new MainForm();
                        //mainForm.Show();
                    }
                    else
                    {
                        // Hiển thị thông báo lỗi
                        MessageBox.Show("USERNAME hoặc PASSWORD sai, vui lòng nhập lại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}