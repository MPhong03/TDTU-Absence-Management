using BUS;
using DTO;
using Guna.UI2.WinForms;
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
using TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.FormXacNhan;

namespace TDTUAbsenceReportingManagement.View.Admin.Control
{
    public partial class QuanLyMonHocForm : UserControl
    {
        BUS_MonHoc bus_MH;
        public QuanLyMonHocForm()
        {
            InitializeComponent();

            bus_MH = new BUS_MonHoc();
            xoaMonHocButton.Enabled = false;

            questionDialog.Parent = this.FindForm();
            errorDialog.Parent = this.FindForm();
            successDialog.Parent = this.FindForm();
            warningMessage.Parent = this.FindForm();
        }

        private void QuanLyMonHocForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            danhSachMonHoc.Rows.Clear();

            var data = bus_MH.DanhSachMonHoc();

            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    int index = danhSachMonHoc.Rows.Add();
                    danhSachMonHoc.Rows[index].Cells["MaSoMonHoc"].Value = row["MaSoMonHoc"];
                    danhSachMonHoc.Rows[index].Cells["TenMonHoc"].Value = row["TenMonHoc"];
                    danhSachMonHoc.Rows[index].Cells["SoTinChi"].Value = row["SoTinChi"];
                }
            }
            else
            {
                danhSachMonHoc.DataSource = new DataTable();
            }

            maMonHocInput.Text = bus_MH.TaoMaTuDong();
            maMonHocInput.Enabled = false;
            doKhoInput.SelectedIndex = 0;
        }

        private void danhSachMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachMonHoc.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = danhSachMonHoc.Rows[e.RowIndex];
                string maMonHoc = selectedRow.Cells["MaSoMonHoc"].Value.ToString();
                string tenMonHoc = selectedRow.Cells["TenMonHoc"].Value.ToString();
                string soTinChi = selectedRow.Cells["SoTinChi"].Value.ToString();

                maMonHocInput.Text = maMonHoc;
                tenMonHocInput.Text = tenMonHoc;
                soTinChiInput.Text = soTinChi;

                xoaMonHocButton.Enabled = true;
                chinhSuaMonHocButton.Enabled = true;

                doKhoInput.Enabled = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            maMonHocInput.Text = bus_MH.TaoMaTuDong();
            maMonHocInput.Enabled = false;

            tenMonHocInput.Clear();
            soTinChiInput.Clear();

            xoaMonHocButton.Enabled = false;
            chinhSuaMonHocButton.Enabled = false;

            doKhoInput.Enabled = true;
        }

        private void soTinChiInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void theMonHocButton_Click(object sender, EventArgs e)
        {
            string maMH = maMonHocInput.Text.Trim();
            string tenMH = tenMonHocInput.Text.Trim();
            string soTinChi = soTinChiInput.Text.Trim();

            if (string.IsNullOrEmpty(maMH) || string.IsNullOrEmpty(tenMH) || string.IsNullOrEmpty(soTinChi))
            {
                warningMessage.Show("Nhập đầy đủ thông tin");
                return;
            }

            int tinChi;
            if (!int.TryParse(soTinChi, out tinChi) || tinChi <= 0)
            {
                warningMessage.Show("Số tín chỉ phải là một số nguyên dương");
                return;
            }

            DTO_MonHoc dto = new DTO_MonHoc(maMH, tenMH, tinChi);

            var result = bus_MH.ThemMonHoc(dto);

            if (result)
            {
                successDialog.Show("Thêm môn học thành công");
                LoadData();
            }
            else
            {
                warningMessage.Show("Xảy ra lỗi trong quá trình thêm môn học");
            }
        }

        private void xoaMonHocButton_Click(object sender, EventArgs e)
        {
            if (danhSachMonHoc.SelectedRows.Count > 0)
            {
                DialogResult confirm = questionDialog.Show("Xác nhận xóa môn học này");
                if (confirm == DialogResult.Yes)
                {
                    var result = bus_MH.XoaMonHoc(maMonHocInput.Text.Trim());

                    if (result)
                    {
                        DialogResult goBack = successDialog.Show("Xóa môn học thành công");

                        if (goBack == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                    else
                    {
                        errorDialog.Show("Xảy ra lỗi khi xóa môn học hoặc đang có lớp dạy môn này");
                    }
                }
            }
        }

        private void chinhSuaMonHocButton_Click(object sender, EventArgs e)
        {
            string maMH = maMonHocInput.Text.Trim();
            string tenMH = tenMonHocInput.Text.Trim();
            int tinChi = int.Parse(soTinChiInput.Text.Trim());

            if (tinChi < 0)
            {
                warningMessage.Show("Số tín chỉ phải lớn hơn 0");
                return;
            }

            if (string.IsNullOrEmpty(maMH) || string.IsNullOrEmpty(tenMH))
            {
                warningMessage.Show("Nhập đầy đủ thông tin");
                return;
            }

            DialogResult confirm = questionDialog.Show("Xác nhận chỉnh sửa môn học này");
            if (confirm == DialogResult.Yes)
            { 

                DTO_MonHoc dto = new DTO_MonHoc(maMH, tenMH, tinChi);

                var result = bus_MH.ChinhSuaMonHoc(dto);

                if (result)
                {
                    successDialog.Show("Chỉnh sửa môn học thành công");
                    LoadData();
                }
                else
                {
                    warningMessage.Show("Xảy ra lỗi trong quá trình chỉnh sửa môn học");
                }
            }

        }

        private void doKhoInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị của mục được chọn trong comboBox
            string selectedDifficulty = doKhoInput.SelectedItem.ToString();

            int difficultyLevel = int.Parse(selectedDifficulty.Split(' ')[2]);

            string currentMaMonHoc = maMonHocInput.Text;
            string newMaMonHoc = currentMaMonHoc.Substring(0, 2) + difficultyLevel.ToString() + currentMaMonHoc.Substring(3);
            maMonHocInput.Text = newMaMonHoc;
        }

        private void importDSMH_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                List<DTO_MonHoc> danhSachMonHoc = DocDuLieuTuFileCSV(filePath);

                if (danhSachMonHoc != null)
                {

                    using (XacNhanImportDSMH formImport = new XacNhanImportDSMH(danhSachMonHoc))
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

        private List<DTO_MonHoc> DocDuLieuTuFileCSV(string filePath)
        {
            List<DTO_MonHoc> danhSachMonHoc = new List<DTO_MonHoc>();

            using (var reader = new StreamReader(filePath))
            {
                // Bỏ qua dòng tiêu đề
                reader.ReadLine();

                string tuTao = bus_MH.TaoMaTuDong();
                Console.WriteLine("MÃ: " + tuTao);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    string tempId = tuTao.Substring(0, 2) + values[2] + tuTao.Substring(3);

                    Console.WriteLine("MÃ: " + tuTao);
                    DTO_MonHoc monHoc = new DTO_MonHoc(
                        tempId,
                        values[0],
                        int.Parse(values[1])
                    );

                    danhSachMonHoc.Add(monHoc);

                    tuTao = TangMaMH(tuTao);
                }
            }

            return danhSachMonHoc;
        }

        private string TangMaMH(string tuTao)
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
