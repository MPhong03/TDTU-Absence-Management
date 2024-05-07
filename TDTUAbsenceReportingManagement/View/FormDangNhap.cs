using BUS;
using DAL;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.Data;
using TDTUAbsenceReportingManagement.View.Admin;
using TDTUAbsenceReportingManagement.View.Lecturers;
using TDTUAbsenceReportingManagement.View.Student;

namespace TDTUAbsenceReportingManagement
{
    public partial class FormDangNhap : Form
    {
        BUS_Auth auth;
        private string previousSearchText = "";
        public FormDangNhap()
        {
            InitializeComponent();
            auth = new BUS_Auth();
            
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailLogin.Text;
            string password = passwordLogin.Text;
            string role = roleLogin.SelectedItem.ToString();
            
            if (role == null || email == string.Empty || password == string.Empty)
            {
                errorDialog.Show("Nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                // Gọi phương thức DangNhap trong DAL
                string id = null;
                bool success = auth.DangNhap(email, password, role, out id);
                Debug.Write(success);
                if (success)
                {
                    Session.Login(id, email, role);
                    Debug.WriteLine(Session.UserID + " - " + Session.Username);
                    SaveEmailToFile(email);
                    switch (role)
                    {
                        case "Quản trị viên":
                            successDialog.Show();
                            QuanTriVienForm form = new QuanTriVienForm();
                            form.Show();

                            this.Hide();
                            break;
                        case "Giảng viên":
                            successDialog.Show();
                            ActorGiangVienForm gvForm = new ActorGiangVienForm();
                            gvForm.Show();

                            this.Hide();
                            break;
                        case "Sinh viên":
                            successDialog.Show();
                            ActorSinhVienForm svForm = new ActorSinhVienForm();
                            svForm.Show();

                            this.Hide();
                            break;
                    }
                }
                else
                {
                    errorDialog.Show("Email hoặc mật khẩu không đúng.");
                }
            }
            catch (Exception ex)
            {
                errorDialog.Show("Lỗi đăng nhập: " + ex);
                Debug.Write(ex);
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            roleLogin.SelectedIndex = 0;

            LoadAutoCompleteData();

            emailLogin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            emailLogin.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void unHideButton_Click(object sender, EventArgs e)
        {
            if (passwordLogin.PasswordChar == '\0')
            {
                hideButton.BringToFront();

                passwordLogin.PasswordChar = '*';
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (passwordLogin.PasswordChar == '*')
            {
                unHideButton.BringToFront();

                passwordLogin.PasswordChar = '\0';
            }
        }

        private void LoadAutoCompleteData()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string directoryPath = Path.Combine(appDataPath, "TDTUAbsenceLoginData");
            string fullPath = Path.Combine(directoryPath, "email.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath); // Tạo thư mục nếu chưa tồn tại
            }

            if (File.Exists(fullPath))
            {
                string[] emails = File.ReadAllLines(fullPath);
                // Lọc chỉ các email bắt đầu bằng chuỗi đã nhập
                var filteredEmails = emails.Where(email => email.StartsWith(emailLogin.Text));
                emailLogin.AutoCompleteCustomSource.AddRange(filteredEmails.ToArray());
            }
        }

        private void SaveEmailToFile(string email)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string directoryPath = Path.Combine(appDataPath, "TDTUAbsenceLoginData");
            string fullPath = Path.Combine(directoryPath, "email.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath); // Tạo thư mục nếu chưa tồn tại
            }

            using (StreamWriter writer = new StreamWriter(fullPath, true))
            {
                writer.WriteLine(email);
            }
        }
    }
}
