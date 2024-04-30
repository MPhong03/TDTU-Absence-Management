using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.View.Admin.Control.ChiTietTaiKhoan;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.QuanLyLopHoc
{
    public partial class ChiTietLopHoc : UserControl
    {
        private readonly string pattern = @"\((.*?)\)";

        BUS_GiangVien bus_GV;
        BUS_LopDay bus_LD;
        BUS_SinhVien bus_SV;
        BUS_MonHoc bus_MH;

        private string maSoGiangVien = string.Empty;
        private int maLopDay = 0;

        private bool isEditForm = false;
        public ChiTietLopHoc(string maSoGiangVien, int maLopDayChinhSua, bool isEdit)
        {
            InitializeComponent();
            bus_GV = new BUS_GiangVien();
            bus_LD = new BUS_LopDay();
            bus_SV = new BUS_SinhVien();
            bus_MH = new BUS_MonHoc();

            this.maSoGiangVien = maSoGiangVien;

            if (!isEdit)
            {
                this.maLopDay = bus_LD.TaoMaTuDong();
            }
            else
            {
                this.isEditForm = isEdit;
                this.maLopDay = maLopDayChinhSua;
            }

            questionDialog.Parent = this.FindForm();
            errorDialog.Parent = this.FindForm();
            successDialog.Parent = this.FindForm();
            warningMessage.Parent = this.FindForm();

            xoaSVKhoiLop.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            ChiTietGiangVien uc = new ChiTietGiangVien(maSoGiangVien);
            QuanTriVienForm quanTriVienForm = this.FindForm() as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);

                this.Hide();
            }
        }

        private void ThemLopHoc_Load(object sender, EventArgs e)
        {
            DTO_GiangVien gv = bus_GV.ChiTietGiangVien(maSoGiangVien);

            if (gv != null)
            {
                maLopDayInput.Text = maLopDay.ToString();
                maLopDayInput.Enabled = false;

                giangVienPhuTrachInput.Text = gv.MaSoGiangVien.ToString() + " - " + gv.HoVaTen.ToString();
                giangVienPhuTrachInput.Enabled = false;

                xoaNgayDay.Enabled = false;

                LoadMonHoc();

                caDayInput.SelectedIndex = 0;
                monHocInput.SelectedIndex = 0;

                luuChinhSuaButton.Enabled = false;

                if (isEditForm)
                {
                    Tuple<DTO_LopDay, string[], string[]> tuple = bus_LD.ChiTietLopDayTheoMaLopDay(maLopDay);

                    DTO_LopDay chiTietLopDay = tuple.Item1;
                    string[] ngayDayDaCo = tuple.Item2;
                    string[] cacSinhVienDaCo = tuple.Item3;

                    DTO_MonHoc monDangDay = bus_MH.ChiTietMonHoc(chiTietLopDay.MaSoMonHoc);
                    string text = $"({monDangDay.MaSoMonHoc}) {monDangDay.TenMonHoc}";

                    Debug.WriteLine(text);

                    nhomHocInput.Text = chiTietLopDay.Nhom;
                    toHocInput.Text = chiTietLopDay.ToTH;
                    phongHocInput.Text = chiTietLopDay.Phong;
                    soBuoiDayInput.Text = chiTietLopDay.SoBuoiDay.ToString();
                    caDayInput.SelectedIndex = caDayInput.Items.IndexOf("Ca " + chiTietLopDay.CaDay);
                    monHocInput.SelectedIndex = monHocInput.Items.IndexOf(text);

                    foreach (string date in ngayDayDaCo)
                    {
                        danhSachNgayDay.Rows.Add(DateTime.Parse(date));
                    }

                    List<string> missingMaSoSinhVien = new List<string>();

                    foreach (string id in cacSinhVienDaCo)
                    {
                        string maSoSV = id.Trim();
                        if (!string.IsNullOrEmpty(maSoSV))
                        {
                            if (!MaSoSinhVienTrung(maSoSV))
                            {
                                DTO_SinhVien sv = bus_SV.ChiTietSinhVien(maSoSV);

                                if (sv != null)
                                {
                                    int rowIndex = danhSachSinhVien.Rows.Add();

                                    DataGridViewRow newRow = danhSachSinhVien.Rows[rowIndex];

                                    newRow.Cells["MaSoSinhVien"].Value = sv.MaSoSinhVien;
                                    newRow.Cells["HoVaTen"].Value = sv.HoVaTen;
                                }
                                else
                                {
                                    missingMaSoSinhVien.Add(maSoSV);
                                }
                            }
                        }
                    }

                    if (missingMaSoSinhVien.Count > 0)
                    {
                        string missingMaSoSinhVienMessage = "Các mã số sinh viên sau không tồn tại trong cơ sở dữ liệu:\n";
                        foreach (string maSoSV in missingMaSoSinhVien)
                        {
                            missingMaSoSinhVienMessage += maSoSV + "\n";
                        }
                        warningMessage.Show(missingMaSoSinhVienMessage);
                    }

                    luuChinhSuaButton.Enabled = true;
                }
            }

        }

        private void LoadMonHoc()
        {
            DataTable dataTable = bus_MH.DanhSachMonHoc();
            foreach (DataRow row in dataTable.Rows)
            {
                string maMonHoc = row["MaSoMonHoc"].ToString();
                string tenMonHoc = row["TenMonHoc"].ToString();
                string displayText = $"({maMonHoc}) {tenMonHoc}";
                // Ví dụ: "(502045) Công nghệ phần mềm" khi chọn sẽ lấy Value là "502045"
                monHocInput.Items.Add(displayText);
            }
        }

        private void themNgayDay_Click(object sender, EventArgs e)
        {
            DateTime date = ngayDay.Value;

            danhSachNgayDay.Rows.Add(date);
        }

        private void danhSachNgayDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (danhSachNgayDay.SelectedRows.Count > 0)
            {
                xoaNgayDay.Enabled = true;
            }
            else
            {
                xoaNgayDay.Enabled = false;
            }
        }

        private void xoaNgayDay_Click(object sender, EventArgs e)
        {
            if (danhSachNgayDay.SelectedRows.Count > 0)
            {
                int selectedRowIndex = danhSachNgayDay.SelectedRows[0].Index;

                if (!danhSachNgayDay.Rows[selectedRowIndex].IsNewRow)
                {
                    danhSachNgayDay.Rows.RemoveAt(selectedRowIndex);

                }

                xoaNgayDay.Enabled = false;
            }
        }

        private void themSVVaoLop_Click(object sender, EventArgs e)
        {
            string mssv = maSoSVInput.Text;
            if (!string.IsNullOrEmpty(mssv))
            {
                if (!MaSoSinhVienTrung(mssv))
                {
                    DTO_SinhVien sv = bus_SV.ChiTietSinhVien(mssv);

                    if (sv != null)
                    {
                        int rowIndex = danhSachSinhVien.Rows.Add();

                        DataGridViewRow newRow = danhSachSinhVien.Rows[rowIndex];

                        newRow.Cells["MaSoSinhVien"].Value = sv.MaSoSinhVien;
                        newRow.Cells["HoVaTen"].Value = sv.HoVaTen;
                    }
                    else
                    {
                        errorDialog.Show("Mã số sinh viên không tồn tại");
                    }
                }
                else
                {
                    errorDialog.Show("Mã số sinh viên đã tồn tại trong danh sách");
                }
            }
            else
            {
                warningMessage.Show("Vui lòng nhập mã số sinh viên");
            }
        }

        private bool MaSoSinhVienTrung(string maSoSV)
        {
            foreach (DataGridViewRow row in danhSachSinhVien.Rows)
            {
                if (row.Cells["MaSoSinhVien"].Value != null && row.Cells["MaSoSinhVien"].Value.ToString() == maSoSV)
                {
                    return true;
                }
            }
            return false;
        }

        private void xoaSVKhoiLop_Click(object sender, EventArgs e)
        {
            string mssv = maSoSVInput.Text;
            if (!string.IsNullOrEmpty(mssv))
            {
                foreach (DataGridViewRow row in danhSachSinhVien.SelectedRows)
                {
                    danhSachSinhVien.Rows.Remove(row);
                }

                xoaSVKhoiLop.Enabled = false;
            }
            else
            {
                warningMessage.Show("Vui lòng nhập mã số sinh viên");
            }
        }

        private void danhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachSinhVien.Rows.Count - 1)
            {
                string maSoSV = danhSachSinhVien.Rows[e.RowIndex].Cells["MaSoSinhVien"].Value.ToString();
                string hoVaTen = danhSachSinhVien.Rows[e.RowIndex].Cells["HoVaTen"].Value.ToString();

                maSoSVInput.Text = maSoSV;
                hoVaTenSVInput.Text = hoVaTen;

                xoaSVKhoiLop.Enabled = true;
            }
        }

        private void importCSVMaSoSinhVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Chọn tệp CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc dữ liệu từ tệp CSV
                string[] lines = File.ReadAllLines(filePath);

                List<string> missingMaSoSinhVien = new List<string>();

                foreach (string line in lines)
                {
                    string maSoSV = line.Trim();
                    if (!string.IsNullOrEmpty(maSoSV))
                    {
                        // Kiểm tra xem mã số sinh viên đã tồn tại trong danhSachSinhVien và cơ sở dữ liệu chưa
                        if (!MaSoSinhVienTrung(maSoSV))
                        {
                            DTO_SinhVien sv = bus_SV.ChiTietSinhVien(maSoSV);

                            if (sv != null)
                            {
                                int rowIndex = danhSachSinhVien.Rows.Add();

                                DataGridViewRow newRow = danhSachSinhVien.Rows[rowIndex];

                                newRow.Cells["MaSoSinhVien"].Value = sv.MaSoSinhVien;
                                newRow.Cells["HoVaTen"].Value = sv.HoVaTen;
                            }
                            else
                            {
                                missingMaSoSinhVien.Add(maSoSV);
                            }
                        }
                    }
                }

                // Hiển thị cảnh báo về các mã số sinh viên không tồn tại trong cơ sở dữ liệu
                if (missingMaSoSinhVien.Count > 0)
                {
                    string missingMaSoSinhVienMessage = "Các mã số sinh viên sau không tồn tại trong cơ sở dữ liệu:\n";
                    foreach (string maSoSV in missingMaSoSinhVien)
                    {
                        missingMaSoSinhVienMessage += maSoSV + "\n";
                    }
                    warningMessage.Show(missingMaSoSinhVienMessage);
                }
            }
        }

        private void themLopHocButton_Click(object sender, EventArgs e)
        {
            string nhom = nhomHocInput.Text.Trim();
            string to = toHocInput.Text.Trim();
            string phong = phongHocInput.Text.Trim();
            int soBuoiDay = int.Parse(soBuoiDayInput.Text);
            int ca = int.Parse(caDayInput.Text.Substring(3));
            string monHoc = LayMaMonHoc(monHocInput.SelectedItem.ToString());

            // Kiểm tra xem đã nhập đủ thông tin chưa
            if (string.IsNullOrEmpty(nhom) || string.IsNullOrEmpty(phong)
                || !int.TryParse(soBuoiDayInput.Text, out soBuoiDay) || !int.TryParse(caDayInput.Text.Substring(3), out ca)
                || string.IsNullOrEmpty(monHoc))
            {
                Debug.WriteLine(nhom + " - " + to + " - " + phong + " - " + soBuoiDay + " - " + ca + " - " + monHoc);
                warningMessage.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string[] ngayDayList = LayDangSachNgayDay();
            string[] mssvList = LayDanhSachMSSV();

            if (ngayDayList.Length == 0 || mssvList.Length == 0)
            {
                warningMessage.Show("Vui lòng thêm ít nhất một ngày dạy và một sinh viên vào lớp học");
                return;
            }

            DTO_LopDay lopDay = new DTO_LopDay(
                    maLopDay,
                    ca,
                    soBuoiDay,
                    nhom,
                    to,
                    phong,
                    maSoGiangVien,
                    monHoc
                );

            var result = bus_LD.ThemLopDay(lopDay, ngayDayList, mssvList);

            if (result)
            {
                successDialog.Show("Thêm lớp học thành công");
                GoBack();
            }
            else
            {
                errorDialog.Show("Xảy ra lỗi trong quá trình thêm lớp học");
            }
        }

        private string LayMaMonHoc(string input)
        {
            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }

        private string[] LayDangSachNgayDay()
        {
            List<string> ngayDayList = new List<string>();

            foreach (DataGridViewRow row in danhSachNgayDay.Rows)
            {
                if (row.Cells["NgayDayColumn"].Value != null)
                {
                    string ngayDay = row.Cells["NgayDayColumn"].Value.ToString();
                    ngayDayList.Add(ngayDay);
                }
            }

            return ngayDayList.ToArray();
        }

        private string[] LayDanhSachMSSV()
        {
            List<string> svList = new List<string>();

            foreach (DataGridViewRow row in danhSachSinhVien.Rows)
            {
                if (row.Cells["MaSoSinhVien"].Value != null)
                {
                    string mssv = row.Cells["MaSoSinhVien"].Value.ToString();
                    svList.Add(mssv);
                }
            }

            return svList.ToArray();
        }

        private void luuChinhSuaButton_Click(object sender, EventArgs e)
        {
            string nhom = nhomHocInput.Text.Trim();
            string to = toHocInput.Text.Trim();
            string phong = phongHocInput.Text.Trim();
            int soBuoiDay = int.Parse(soBuoiDayInput.Text);
            int ca = int.Parse(caDayInput.Text.Substring(3));
            string monHoc = LayMaMonHoc(monHocInput.SelectedItem.ToString());

            // Kiểm tra xem đã nhập đủ thông tin chưa
            if (string.IsNullOrEmpty(nhom) || string.IsNullOrEmpty(phong)
                || !int.TryParse(soBuoiDayInput.Text, out soBuoiDay) || !int.TryParse(caDayInput.Text.Substring(3), out ca)
                || string.IsNullOrEmpty(monHoc))
            {
                Debug.WriteLine(nhom + " - " + to + " - " + phong + " - " + soBuoiDay + " - " + ca + " - " + monHoc);
                warningMessage.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string[] ngayDayList = LayDangSachNgayDay();
            string[] mssvList = LayDanhSachMSSV();

            if (ngayDayList.Length == 0 || mssvList.Length == 0)
            {
                warningMessage.Show("Vui lòng thêm ít nhất một ngày dạy và một sinh viên vào lớp học");
                return;
            }

            DTO_LopDay lopDay = new DTO_LopDay(
                    maLopDay,
                    ca,
                    soBuoiDay,
                    nhom,
                    to,
                    phong,
                    maSoGiangVien,
                    monHoc
                );

            var result = bus_LD.ChinhSuaLopHoc(lopDay, ngayDayList, mssvList);

            if (result)
            {
                successDialog.Show("Sửa lớp học thành công");
                GoBack();
            }
            else
            {
                errorDialog.Show("Xảy ra lỗi trong quá trình sửa lớp học");
            }
        }
    }
}
