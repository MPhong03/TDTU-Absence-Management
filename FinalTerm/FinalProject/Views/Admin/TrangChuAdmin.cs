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

            usernameInput.Enabled = true;
            addAccountButton.Enabled = true;
            editAccountButton.Enabled = false;
            deleteAccountButton.Enabled = false;
        }

        private string verifyInput(string username, string password, string name, string role, string phone, int age, string gender, string birth)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "Vui lòng nhập tên đăng nhập.";
            }

            if (string.IsNullOrEmpty(password))
            {
                return "Vui lòng nhập mật khẩu.";
            }

            if (string.IsNullOrEmpty(name))
            {
                return "Vui lòng nhập tên nhân viên.";
            }

            if (string.IsNullOrEmpty(role))
            {
                return "Vui lòng chọn chức vụ.";
            }

            if (string.IsNullOrEmpty(phone))
            {
                return "Vui lòng nhập số điện thoại.";
            }

            if (string.IsNullOrEmpty(gender))
            {
                return "Vui lòng chọn giới tính.";
            }

            if (!phone.All(char.IsDigit))
            {
                return "Số điện thoại không được chứa ký tự chữ hoặc ký tự đặc biệt.";
            }

            if (username.Contains(" "))
            {
                return "Tên đăng nhập không được chứa khoảng trắng.";
            }

            if (!IsPasswordValid(password))
            {
                return "Mật khẩu phải có ít nhất 6 ký tự, có ít nhất 1 chữ cái và 1 chữ số.";
            }

            return "OK";
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

            string chck = verifyInput(username, password, name, role, phone, age, gender, birth);
            if (!chck.Equals("OK"))
            {
                warningMessage.Show(chck);
                return;
            }

            DialogResult result = confirmDialog.Show("Xác nhận thêm tài khoản");

            Debug.WriteLine($"CLICK: {result.ToString()}");

            if (result == DialogResult.Yes)
            {
                AddAccountToDatabase(username, password, name, role, phone, age, gender, birth);
            }
            else
            {
                return;
            }

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

                    using (SqlCommand command = new SqlCommand("ThemTaiKhoan", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TenDangNhap", username);
                        command.Parameters.AddWithValue("@MatKhau", password);
                        command.Parameters.AddWithValue("@TenNhanVien", name);
                        command.Parameters.AddWithValue("@ChucVu", role);
                        command.Parameters.AddWithValue("@SoDienThoai", phone);
                        command.Parameters.AddWithValue("@Tuoi", age);
                        command.Parameters.AddWithValue("@GioiTinh", gender);
                        command.Parameters.AddWithValue("@NgaySinh", birth);

                        int rowsAffected = command.ExecuteNonQuery();

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

        private void EditAccountFromDatabase(string username, string password, string name, string role, string phone, int age, string gender, string birth)
        {
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE TaiKhoan SET MatKhau = @Password, TenNhanVien = @Name, ChucVu = @Role, " +
                                         "SoDienThoai = @Phone, Tuoi = @Age, GioiTinh = @Gender, NgaySinh = @Birth WHERE TenDangNhap = @Username";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Password", password);
                        updateCommand.Parameters.AddWithValue("@Name", name);
                        updateCommand.Parameters.AddWithValue("@Role", role);
                        updateCommand.Parameters.AddWithValue("@Phone", phone);
                        updateCommand.Parameters.AddWithValue("@Age", age);
                        updateCommand.Parameters.AddWithValue("@Gender", gender);
                        updateCommand.Parameters.AddWithValue("@Birth", birth);
                        updateCommand.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            successMesage.Show("Cập nhật thông tin tài khoản thành công.");
                        }
                        else
                        {
                            errorMessage.Show("Không có tài khoản nào được cập nhật.");
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

        private void DeleteAccountFromDatabase(string username)
        {
            try
            {
                using (SqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "DELETE FROM TaiKhoan WHERE TenDangNhap = @Username";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            successMesage.Show("Xóa tài khoản thành công.");
                        }
                        else
                        {
                            errorMessage.Show("Xóa tài khoản không thành công.");
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

        private void accountTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && accountTable[e.ColumnIndex, e.RowIndex].Value != null)
            {
                object cellData = accountTable[e.ColumnIndex, e.RowIndex].Value;

                if (cellData != null)
                {
                    usernameInput.Enabled = false;
                    addAccountButton.Enabled = false;
                    editAccountButton.Enabled = true;
                    deleteAccountButton.Enabled = true;

                    // Bind data to input field
                    string username = accountTable.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                    string password = accountTable.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                    string name = accountTable.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();
                    string role = accountTable.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
                    string phone = accountTable.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                    int age = Convert.ToInt32(accountTable.Rows[e.RowIndex].Cells["Tuoi"].Value);
                    string gender = accountTable.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                    DateTime birth = Convert.ToDateTime(accountTable.Rows[e.RowIndex].Cells["NgaySinh"].Value);

                    usernameInput.Text = username;
                    passwordInput.Text = password;
                    staffNameInput.Text = name;
                    roleComboBoxInput.SelectedItem = role;
                    phoneNumberInput.Text = phone;
                    ageInput.Value = age;
                    genderComboBoxInput.SelectedItem = gender;
                    birthDateInput.Value = birth;
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ClearInputField();
        }

        private void editAccountButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string name = staffNameInput.Text;
            string role = roleComboBoxInput.SelectedItem.ToString();
            string phone = phoneNumberInput.Text;
            int age = (int)ageInput.Value;
            string gender = genderComboBoxInput.SelectedItem.ToString();
            string birth = birthDateInput.Value.ToString("yyyy-MM-dd");

            string chck = verifyInput(username, password, name, role, phone, age, gender, birth);
            if (!chck.Equals("OK"))
            {
                warningMessage.Show(chck);
                return;
            }

            DialogResult result = confirmDialog.Show("Xác nhận thay đổi thông tin tài khoản này");

            Debug.WriteLine($"CLICK: {result.ToString()}");

            if (result == DialogResult.Yes)
            {
                // Edit account
                EditAccountFromDatabase(username, password, name, role, phone, age, gender, birth);
            }
            else
            {
                return;
            }

        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;

            if (username.Equals(SessionManager.Username))
            {
                errorMessage.Show("Tài khoản đang trong phiên làm việc");
                return;
            }

            DialogResult result = confirmDialog.Show("Bạn có chắc muốn xóa tài khoản này?");

            Debug.WriteLine($"CLICK: {result.ToString()}");

            if (result == DialogResult.Yes)
            {
                DeleteAccountFromDatabase(username);
            }
            else
            {
                return;
            }

        }
    }
}
