using FinalProject.DTO;
using FinalProject.Views;
using FinalProject.Views.Auths;

namespace FinalProject
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
            StartDelay();
        }

        private async void StartDelay()
        {
            await Task.Delay(1500);

            if (SessionManager.Username != null)
            {
                TrangChu trangChuForm = new TrangChu();
                trangChuForm.Show();
            }
            else
            {
                DangNhap dangNhapForm = new DangNhap();
                dangNhapForm.Show();
            }

            this.Hide();
        }
    }
}