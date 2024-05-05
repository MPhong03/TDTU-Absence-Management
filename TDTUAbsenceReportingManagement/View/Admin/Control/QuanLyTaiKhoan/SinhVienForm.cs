using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.FormXacNhan;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan
{
    public partial class SinhVienForm : UserControl
    {
        BUS_SinhVien sv;
        public SinhVienForm()
        {
            InitializeComponent();
            sv = new BUS_SinhVien();

            successMessage.Parent = this.FindForm();
            warningMessage.Parent = this.FindForm();
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            danhSachSinhVienDataGrid.DataSource = sv.HienDanhSachSV();
        }

        private void themSinhVienButton_Click(object sender, EventArgs e)
        {
            ThemSinhVien uc = new ThemSinhVien();
            QuanTriVienForm quanTriVienForm = this.FindForm() as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);
            }
        }

        private void danhSachSinhVienDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = danhSachSinhVienDataGrid.Rows[e.RowIndex];
                string maSoSinhVien = row.Cells["MaSoSinhVien"].Value.ToString();

                ChiTietSinhVien uc = new ChiTietSinhVien(maSoSinhVien);
                QuanTriVienForm quanTriVienForm = this.FindForm() as QuanTriVienForm;

                if (quanTriVienForm != null)
                {
                    quanTriVienForm.addUserControl(uc);
                }
            }
        }

        private void nhapDanhSachSinhVienButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                List<DTO_SinhVien> danhSachSinhVien = DocDuLieuTuFileCSV(filePath);

                if (danhSachSinhVien != null)
                {

                    using (XacNhanImportDSSV formImport = new XacNhanImportDSSV(danhSachSinhVien))
                    {
                        formImport.FormClosed += (s, args) =>
                        {
                            LoadData();
                        };

                        formImport.ShowDialog();
                    }
                }
                else
                {
                    warningMessage.Show("Khóa tuyển sinh phải giống nhau.");
                }

            }
        }

        private List<DTO_SinhVien> DocDuLieuTuFileCSV(string filePath)
        {
            List<DTO_SinhVien> danhSachSinhVien = new List<DTO_SinhVien>();

            using (var reader = new StreamReader(filePath))
            {
                // Bỏ qua dòng tiêu đề (header) của file CSV
                reader.ReadLine();

                string firstKhoaTuyenSinh = null; // Lưu trữ giá trị của cột KhoaTuyenSinh từ dòng đầu tiên
                bool khoaTuyenSinhKhacNhau = false; // Biến kiểm tra xem có sự khác biệt trong cột KhoaTuyenSinh không

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (firstKhoaTuyenSinh == null)
                    {
                        firstKhoaTuyenSinh = values[7]; // Lấy giá trị từ dòng đầu tiên
                    }
                    else if (values[7] != firstKhoaTuyenSinh)
                    {
                        khoaTuyenSinhKhacNhau = true; // Nếu có giá trị khác thì đặt cờ này thành true
                        break; // Dừng vòng lặp vì đã có giá trị khác
                    }
                }

                // Kiểm tra nếu có sự khác biệt trong cột KhoaTuyenSinh
                if (khoaTuyenSinhKhacNhau)
                {
                    Console.WriteLine("Lỗi: Các dòng dữ liệu thuộc cột KhoaTuyenSinh không giống nhau.");
                    return null; // Trả về null để báo lỗi
                }
                else
                {
                    // Nếu các dòng dữ liệu đều giống nhau, gán giá trị vào biến
                    sv.dSV.KhoaTuyenSinh = firstKhoaTuyenSinh;
                }

                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                reader.DiscardBufferedData();

                // Bỏ qua dòng tiêu đề (header) của file CSV (đọc lại từ đầu)
                reader.ReadLine();

                //sv.dSV.KhoaTuyenSinh = ""; //TODO: Hãy kiểm tra tất cả các dòng dữ liệu thuộc cột KhoaTuyenSinh có giống nhau không, nếu có thì gắn KhoaTuyenSinh vào đây, không thì báo lỗi và return
                string tuTao = sv.TaoMaTuDong();
                Console.WriteLine("MÃ: " + tuTao);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string mssv = tuTao.Substring(0, 1) + values[7].Substring(values[7].Length - 2) + tuTao.Substring(3);

                    Console.WriteLine("MÃ: " + mssv);
                    // Tạo một đối tượng DTO_SinhVien từ các giá trị trong dòng
                    DTO_SinhVien sinhVien = new DTO_SinhVien(
                        mssv,
                        mssv + "@student.tdtu.edu.vn", // Email
                        values[0], // Mật khẩu mặc định
                        values[1], // Họ và tên
                        DateTime.Parse(values[2]), // Ngày sinh
                        values[3], // Giới tính
                        values[4], // Số điện thoại
                        values[5], // CCCD
                        values[6], // Chuyên ngành
                        values[7] // Khóa tuyển sinh
                    );

                    danhSachSinhVien.Add(sinhVien);

                    tuTao = TangMaSV(tuTao);
                }
            }

            return danhSachSinhVien;
        }

        private string TangMaSV(string tuTao)
        {
            int currentNumber = int.Parse(tuTao);

            currentNumber++;

            return currentNumber.ToString().PadLeft(8, '0');
        }
    }
}
