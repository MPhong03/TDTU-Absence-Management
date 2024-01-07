using FinalProject.Config;
using FinalProject.DTO;
using FinalProject.Views.Auths;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject.Views.Admin
{
    public partial class TrangChuAdmin : Form
    {
        public TrangChuAdmin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            // Tab HOME
            if (tabControlAdmin.SelectedIndex == 0)
            {
                adminTitleWelcome.Text = "Welcome, " + SessionManager.Username + ", Role: " + SessionManager.Role + "";
            }

            // Tab ACCOUNT
            if (tabControlAdmin.SelectedIndex == 1)
            {
                LoadAccountsData();
            }
        }

        private void tabPageAdminHome_Click(object sender, EventArgs e)
        {

        }

        private void LoadAccountsData()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    string query = "SELECT * FROM TaiKhoan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception)
            {
                errorMessage.Show("Lỗi kết nối cơ sở dữ liệu");
            }

            accountTable.DataSource = dataTable;
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tab HOME
            if (tabControlAdmin.SelectedIndex == 0)
            {
                adminTitleWelcome.Text = "Welcome, " + SessionManager.Username + ", Role: " + SessionManager.Role + "";
            }

            // Tab ACCOUNT
            if (tabControlAdmin.SelectedIndex == 1)
            {
                LoadAccountsData();

                editAccountButton.Enabled = false;
                deleteAccountButton.Enabled = false;

                roleComboBoxInput.SelectedIndex = 0;
                genderComboBoxInput.SelectedIndex = 0;
            }
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        private bool IsUsernameExists(string username)
        {
            bool exists = false;

            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        int count = (int)command.ExecuteScalar();
                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage.Show("Error checking username existence: " + ex.Message);
            }

            return exists;
        }

        private void ClearInputField()
        {
            usernameInput.Text = "";
            passwordInput.Text = "";
            staffNameInput.Text = "";
            roleComboBoxInput.SelectedIndex = 0;
            phoneNumberInput.Text = "";
            ageInput.Value = 0;
            genderComboBoxInput.SelectedItem = 0;
            birthDateInput.Value = DateTime.Today;
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string name = staffNameInput.Text;
            string role = roleComboBoxInput.SelectedItem.ToString();
            string phone = phoneNumberInput.Text;
            int age = (int)ageInput.Value;
            string gender = genderComboBoxInput.SelectedItem.ToString();
            string birth = birthDateInput.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(username))
            {
                warningMessage.Show("Vui lòng nhập tên đăng nhập.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                warningMessage.Show("Vui lòng nhập mật khẩu.");
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                warningMessage.Show("Vui lòng nhập tên nhân viên.");
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                warningMessage.Show("Vui lòng chọn chức vụ.");
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                warningMessage.Show("Vui lòng nhập số điện thoại.");
                return;
            }

            if (string.IsNullOrEmpty(gender))
            {
                warningMessage.Show("Vui lòng chọn giới tính.");
                return;
            }

            if (!phone.All(char.IsDigit))
            {
                warningMessage.Show("Số điện thoại không được chứa ký tự chữ hoặc ký tự đặc biệt.");
                return;
            }

            if (username.Contains(" "))
            {
                warningMessage.Show("Tên đăng nhập không được chứa khoảng trắng.");
                return;
            }

            if (!IsPasswordValid(password))
            {
                warningMessage.Show("Mật khẩu phải có ít nhất 6 ký tự, có ít nhất 1 chữ cái và 1 chữ số.");
                return;
            }

            AddAccountToDatabase(username, password, name, role, phone, age, gender, birth);
        }

        private void AddAccountToDatabase(string username, string password, string name, string role, string phone, int age, string gender, string birth)
        {
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    if (IsUsernameExists(username))
                    {
                        errorMessage.Show("Tên đăng nhập đã tồn tại.");
                        return;
                    }

                    string insertQuery = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, TenNhanVien, ChucVu, NgayTao, SoDienThoai, Tuoi, GioiTinh, NgaySinh) " +
                                         "VALUES (@Username, @Password, @Name, @Role, GETDATE(), @Phone, @Age, @Gender, @Birth)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@Password", password);
                        insertCommand.Parameters.AddWithValue("@Name", name);
                        insertCommand.Parameters.AddWithValue("@Role", role);
                        insertCommand.Parameters.AddWithValue("@Phone", phone);
                        insertCommand.Parameters.AddWithValue("@Age", age);
                        insertCommand.Parameters.AddWithValue("@Gender", gender);
                        insertCommand.Parameters.AddWithValue("@Birth", birth);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            successMesage.Show("Thêm tài khoản thành công.");
                        }
                        else
                        {
                            errorMessage.Show("Thêm tài khoản không thành công.");
                        }

                        LoadAccountsData();
                        ClearInputField();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
