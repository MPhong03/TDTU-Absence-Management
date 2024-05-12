using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using TDTUAbsenceReportingManagement.View.Admin.Control.ChiTietTaiKhoan;
using TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.FormXacNhan;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan
{
    public partial class GiangVienForm : UserControl
    {
        BUS_GiangVien gv;
        public GiangVienForm()
        {
            InitializeComponent();
            gv = new BUS_GiangVien();

            successMessage.Parent = this.FindForm();
            warningMessage.Parent = this.FindForm();
        }

        private void GiangVienForm_Load(object sender, EventArgs e)
        {
             LoadData();
        }

        private void LoadData()
        {
            danhSachGiangVienDataGrid.DataSource = gv.HienDanhSachGV();
        }

        private void themGiangVienButton_Click(object sender, EventArgs e)
        {
            ThemGiangVien uc = new ThemGiangVien();
            QuanTriVienForm quanTriVienForm = this.FindForm() as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);

                this.Hide();
            }
        }

        private void danhSachGiangVienDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = danhSachGiangVienDataGrid.Rows[e.RowIndex];
                string maSoGiangVien = row.Cells["MaSoGiangVien"].Value.ToString();

                ChiTietGiangVien uc = new ChiTietGiangVien(maSoGiangVien);
                QuanTriVienForm quanTriVienForm = this.FindForm() as QuanTriVienForm;

                if (quanTriVienForm != null)
                {
                    quanTriVienForm.addUserControl(uc);
                }
            }
        }

        private void nhapDanhSachGiangVienButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                List<DTO_GiangVien> danhSachGiangVien = DocDuLieuTuFileCSV(filePath);

                if (danhSachGiangVien != null)
                {

                    using (XacNhanImportDSGV formImport = new XacNhanImportDSGV(danhSachGiangVien))
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
                    warningMessage.Show("Xảy ra lỗi trong quá trình đọc dữ liệu.");
                }

            }
        }

        private List<DTO_GiangVien> DocDuLieuTuFileCSV(string filePath)
        {
            List<DTO_GiangVien> danhSachGiangVien = new List<DTO_GiangVien>();

            try
            {

                using (var reader = new StreamReader(filePath))
                {
                    // Bỏ qua dòng tiêu đề
                    reader.ReadLine();

                    string tuTao = gv.TaoMaTuDong();
                    Console.WriteLine("MÃ: " + tuTao);

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        Console.WriteLine("MÃ: " + tuTao);
                        DTO_GiangVien giangVien = new DTO_GiangVien(
                            tuTao,
                            values[0],
                            values[1],
                            values[2],
                            DateTime.Parse(values[3]),
                            values[4],
                            values[5],
                            values[6],
                            values[7],
                            values[8]
                        );

                        danhSachGiangVien.Add(giangVien);

                        tuTao = TangMaGV(tuTao);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                warningMessage.Show("Lỗi: " + ex.Message);
            }
            catch (IOException ex)
            {
                warningMessage.Show("Lỗi: " + ex.Message);
            }
            catch (Exception ex)
            {
                warningMessage.Show("Lỗi: " + ex.Message);
            }

            return danhSachGiangVien;
        }

        private string TangMaGV(string tuTao)
        {
            string chuoiSo = tuTao.Substring(3);
            int soThuTu = int.Parse(chuoiSo);

            soThuTu++;

            string soThuTuMoi = soThuTu.ToString("000");

            string maMoi = tuTao.Substring(0, 3) + soThuTuMoi;

            return maMoi;
        }
    }
}
