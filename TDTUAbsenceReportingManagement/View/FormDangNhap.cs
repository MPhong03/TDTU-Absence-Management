﻿using BUS;
using DAL;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.View.Admin;

namespace TDTUAbsenceReportingManagement
{
    public partial class FormDangNhap : Form
    {
        BUS_Auth auth;
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
                bool success = auth.DangNhap(email, password, role);
                Debug.Write(success);
                if (success)
                {
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
                            break;
                        case "Sinh viên":
                            successDialog.Show();
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
        }
    }
}
