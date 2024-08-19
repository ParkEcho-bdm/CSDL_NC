using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToObj
{
    public partial class Form1 : Form
    {
        //Định nghĩa danh sách khoa, sinh viên, kết quả và môn học
        List<KHOA> Khoas;
        List<SINHVIEN> Sinhviens;
        List<KETQUA> Ketquas;
        List<MONHOC> Monhocs;
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvkq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            //Viết câu thí dụ: Xuất ra danh sách các khoa
            ThiDu1b();
        }

        private void ThiDu1a()
        {
            var kq = from kh in Khoas
                     select kh;
            dgvkq.DataSource = kq.ToList();
        }
        private void ThiDu1b()
        {
            var kq = Khoas;
            dgvkq.DataSource = kq.ToList();
        }
        private void KhoiTaoDuLieu()
        {
            Khoas = new List<KHOA>
        {
            new KHOA{MaKh="AV",TenKh="Anh van"},
            new KHOA{MaKh="TH",TenKh="Tin hoc"},
            new KHOA{MaKh="VL",TenKh="Vat ly"},
            new KHOA{MaKh="HH",TenKh="Hoa hoc"}
        };
            // Sinh viên B04, B05, C04 không có điểm
            Sinhviens = new List<SINHVIEN>
        {
            new SINHVIEN{MaSV="A01",HoTen="Nguyen Văn Hung",MaKh="AV",HocBong=120000},
            new SINHVIEN{MaSV="A02",HoTen="Nguyen Văn Tuan",MaKh="AV",HocBong=150000},
            new SINHVIEN{MaSV="A03",HoTen="Nguyen Văn Dung",MaKh="AV",HocBong=180000},
            new SINHVIEN{MaSV="B01",HoTen="Tran Thi Lan",MaKh="TH",HocBong=190000},
            new SINHVIEN{MaSV="B02",HoTen="Tran Thi Truc",MaKh="TH",HocBong=180000},
            new SINHVIEN{MaSV="B03",HoTen="Tran Thi Dao",MaKh="TH",HocBong=120000},
            new SINHVIEN{MaSV="B04",HoTen="Tran Van Ly",MaKh="TH",HocBong=180000},
            new SINHVIEN{MaSV="B05",HoTen="Tran Van Thanh",MaKh="TH",HocBong=250000},
            new SINHVIEN{MaSV="C01",HoTen="Le Van Truc",MaKh="VL",HocBong=190000},
            new SINHVIEN{MaSV="C02",HoTen="Le Van Cuong",MaKh="VL",HocBong=250000},
            new SINHVIEN{MaSV="C03",HoTen="Le Van Long",MaKh="VL",HocBong=140000},
            new SINHVIEN{MaSV="333",HoTen="33333333333",MaKh="33",HocBong=140000},
            new SINHVIEN{MaSV="C04",HoTen="Le Van Tu",MaKh="VL",HocBong=190000},
            new SINHVIEN{MaSV="C04",HoTen="Le Van Tu",MaKh="VL",HocBong=190000}
        };
            Ketquas = new List<KETQUA>
        {
            new KETQUA{MaSV="A01",MaMH="01",DiemThi=9},
            new KETQUA{MaSV="A01",MaMH="02",DiemThi=8},
            new KETQUA{MaSV="A01",MaMH="05",DiemThi=9},
            new KETQUA{MaSV="A02",MaMH="03",DiemThi=6},
            new KETQUA{MaSV="A02",MaMH="02",DiemThi=8},
            new KETQUA{MaSV="A03",MaMH="05",DiemThi=9},
            new KETQUA{MaSV="B01",MaMH="01",DiemThi=2},
            new KETQUA{MaSV="B01",MaMH="02",DiemThi=3},
            new KETQUA{MaSV="B01",MaMH="05",DiemThi=4},
            new KETQUA{MaSV="B02",MaMH="03",DiemThi=6},
            new KETQUA{MaSV="B02",MaMH="01",DiemThi=8},
            new KETQUA{MaSV="B02",MaMH="07",DiemThi=9},
            new KETQUA{MaSV="B02",MaMH="01",DiemThi=7},
            new KETQUA{MaSV="B02",MaMH="05",DiemThi=8},
            new KETQUA{MaSV="B03",MaMH="07",DiemThi=9},
            new KETQUA{MaSV="B03",MaMH="03",DiemThi=10},
            new KETQUA{MaSV="C01",MaMH="02",DiemThi=9},
            new KETQUA{MaSV="C01",MaMH="03",DiemThi=8},
            new KETQUA{MaSV="C01",MaMH="05",DiemThi=9},
            new KETQUA{MaSV="C01",MaMH="01",DiemThi=7},
            new KETQUA{MaSV="C02",MaMH="02",DiemThi=2},
            new KETQUA{MaSV="C02",MaMH="03",DiemThi=3},
            new KETQUA{MaSV="C02",MaMH="07",DiemThi=5},
            new KETQUA{MaSV="C03",MaMH="01",DiemThi=8}
        };
            // Môn 04, 06 không có sinh viên thi
            Monhocs = new List<MONHOC>
        {
            new MONHOC{MaMH="01",TenMH="Toan",SoTiet="45"},
            new MONHOC{MaMH="02",TenMH="Ly",SoTiet="60"},
            new MONHOC{MaMH="03",TenMH="Ngoai ngu",SoTiet="75"},
            new MONHOC{MaMH="04",TenMH="Sinh",SoTiet="90"},
            new MONHOC{MaMH="05",TenMH="Lap trinh",SoTiet="105"},
            new MONHOC{MaMH="06",TenMH="Lich su",SoTiet="60"},
            new MONHOC{MaMH="07",TenMH="Tam ly",SoTiet="45"},
        };
        }
    }
}
