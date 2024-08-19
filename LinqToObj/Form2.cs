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
    public partial class Form2 : Form
    {
        //Định nghĩa danh sách khoa, sinh viên, kết quả và môn học
        List<KHOA> Khoas;
        List<SINHVIEN> Sinhviens;
        List<KETQUA> Ketquas;
        List<MONHOC> Monhocs;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            //Cau1a();
            //Cau2a();
            //Cau3a();
            //Cau4a();
            //Cau5a();
            //Cau6a();
            //Cau7a();
            //Cau8a();
            //Cau1b();
            //Cau2b();
            //Cau3b();
            //Cau4b();
            //Cau5b();
            //Cau6b();
            //Cau7b();
            Cau8b();
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
        //Câu 1: Xuất danh sách sinh viên khoa TH. Sắp tăng dần theo học bổng, giảm dần theo họ tên
        void Cau1a()
        {
            var kq = from sv in Sinhviens
                     where sv.MaKh == "TH"
                     orderby sv.HocBong ascending, sv.HoTen descending
                     select sv;
            dgvkq.DataSource = kq.ToList();
        }
        void Cau1b()
        {
            var kq = Sinhviens.Where(w => w.MaKh == "TH")
                .OrderBy(o1 => o1.HocBong)
                .ThenByDescending(o2 => o2.HoTen);
            dgvkq.DataSource = kq.ToList();
        }
        //Câu 2: Xuất ra danh sách sinh viên(MaSV, HoTen) có họ tên bắt đầu là "tran"
        void Cau2a()
        {
            var kq = from sv in Sinhviens
                     where sv.HoTen.ToUpper().StartsWith("TRAN")
                     select new { MSV=sv.MaSV, HoTenSV=sv.HoTen };
            dgvkq.DataSource = kq.ToList();
        }
        void Cau2b()
        {
            var kq = Sinhviens.Where(w => w.HoTen.ToUpper().StartsWith("TRAN"))
                .Select(s => new { s.MaSV, s.HoTen });
                dgvkq.DataSource = kq.ToList();
        }
        //Câu 3: Xuất ra danh sách sinh viên(MaSV, HoTen) có họ tên kết thúc là "ng"
        void Cau3a()
        {
            var kq = from sv in Sinhviens
                     where sv.HoTen.ToUpper().EndsWith("NG")
                     select new { sv.MaSV,sv.HoTen };
            dgvkq.DataSource = kq.ToList();
        }
        void Cau3b()
        {
            var kq = Sinhviens.Where(w => w.HoTen.ToUpper().EndsWith("NG"))
                .Select(s => new { s.MaSV, s.HoTen });
            dgvkq.DataSource = kq.ToList();
        }
        //Câu 4: Xuất ra danh sách sinh viên(MaSV, HoTen) có họ tên chứa "van"
        void Cau4a()
        {
            var kq = from sv in Sinhviens
                     where sv.HoTen.ToUpper().Contains("VAN")
                     select new { sv.MaSV, sv.HoTen };
            dgvkq.DataSource = kq.ToList();
        }
        void Cau4b()
        {
            var kq = Sinhviens.Where(w => w.HoTen.ToUpper().Contains("VAN"))
                .Select(s => new { s.MaSV, s.HoTen });
            dgvkq.DataSource = kq.ToList();
        }
        //Câu 5: Xuất ra danh sách sinh viên(MaSV, HoTen, MaKH, HocBong) khoa TH có học bổng >150000
        void Cau5a()
        {
            var kq = from sv in Sinhviens
                     where sv.MaKh == "TH" && sv.HocBong > 150000
                     select sv;
            dgvkq.DataSource = kq.ToList();
        }
        void Cau5b()
        {
            var kq = Sinhviens.Where(x => x.MaKh == "TH" && x.HocBong > 150000);
            dgvkq.DataSource = kq.ToList();
        }
        //Câu 6: Xuất ra danh sách sinh viên(MaSV, HoTen,MaKH)khoa TH hay họ tên chứa "van"
        void Cau6a()
        {
            var kq = from sv in Sinhviens
                     where sv.MaKh == "TH" || sv.HoTen.ToUpper().Contains("VAN")
                     select new { sv.MaSV, sv.HoTen,sv.MaKh };
            dgvkq.DataSource = kq.ToList();
        }
        void Cau6b()
        {
            var kq = Sinhviens.Where(x => x.MaKh == "TH" || x.HoTen.ToUpper().Contains("VAN"))
                .Select(s => new { s.MaSV, s.HoTen, s.MaKh });
            dgvkq.DataSource = kq.ToList();
        }
        //Câu 7: Xuất ra danh sách sinh viên (MaSV, HoTen, MaKH, TenKH)
        void Cau7a()
        {
            var kq = from kh in Khoas
                     join sv in Sinhviens on kh.MaKh equals sv.MaKh
                     select new { sv.MaSV, sv.HoTen, sv.MaKh, kh.TenKh };
                     dgvkq.DataSource = kq.ToList();
        }
        void Cau7b()
        {
            var kq = Khoas.Join(Sinhviens, kh => kh.MaKh, sv => sv.MaKh, (kh, sv) => new { sv.MaSV, sv.HoTen, sv.MaKh, kh.TenKh });
            dgvkq.DataSource = kq.ToList();
        }
        //Câu 8: Xuất ra danh sách sinh viên (MaSV, HoTen, MaKH, TenKH, MaMH,Diem)
        void Cau8a()
        {
            var kq = from kh in Khoas
                     join sv in Sinhviens on kh.MaKh equals sv.MaKh
                     join kqd in Ketquas on sv.MaSV equals kqd.MaSV
                     select new { sv.MaSV, sv.HoTen, sv.MaKh, kh.TenKh,kqd.MaMH, kqd.DiemThi };
            dgvkq.DataSource = kq.ToList();
        }
        void Cau8b()
        {
            var kq = Khoas.Join(Sinhviens, kh => kh.MaKh, sv => sv.MaKh, (kh, sv) => new { sv.MaSV, sv.HoTen, sv.MaKh, kh.TenKh })
                .Join(Ketquas,svn => svn.MaSV , kqn => kqn.MaSV,(svn,kqn) => new { svn.MaSV,svn.HoTen,svn.MaKh,svn.TenKh,kqn.DiemThi});
            dgvkq.DataSource = kq.ToList();
        }
        void cau9a()
        {
            var kq = from kh in Khoas
                     join sv in Sinhviens on kh.MaKh equals sv.MaKh into NhomSV
                     from svn in NhomSV.DefaultIfEmpty()
                     select new { kh.MaKh, kh.TenKh, MSV = svn == null ? "---" : svn.MaSV, HTSV = svn == null ? "---" : svn.HoTen };

            dgvkq.DataSource = kq.ToList();
        }
        void cau9b()
        {
            var kq = Khoas.GroupJoin(Sinhviens, kh => kh.MaKh, sv => sv.MaKh, (k, svn) => new { MK = k.MaKh, TK = k.TenKh, svn })
                .SelectMany(nhomSV => nhomSV.svn.DefaultIfEmpty(), (kk, ssn) => new
                {
                    kk.MK,
                    kk.TK,
                    MSV = ssn == null ? "+++" : ssn.MaSV,
                    TSV = ssn == null ? "---" : ssn.HoTen
                });
            dgvkq.DataSource = kq.ToList();
        }
            void cau10a()
            {
                var kq = from sv in Sinhviens
                         group sv by sv.MaKh into Nhom_Khoa
                         select new { MaKhoa = Nhom_Khoa.Key, TongHB = Nhom_Khoa.Sum(X => X.HocBong) };
            dgvkq.DataSource = kq.ToList();
        }
        void cau10b()
        {
            var kq = Sinhviens.GroupBy(ns => ns.MaKh).Select(s => new { MaKh = s.Key, TongHB = s.Sum(x => x.HocBong) });
        }
        void cau11a()
        {
            var kq = from kh in Khoas
                     join sv in Sinhviens on kh.MaKh equals sv.MaKh

                     group sv by new { kh.MaKh, kh.TenKh } into Nhom_Khoa
                     select new { MaKhoa = Nhom_Khoa.Key.MaKh, TenKhoa = Nhom_Khoa.Key.TenKh,
                         TSSV = Nhom_Khoa.Count(), TongHB = Nhom_Khoa.Sum(x => x.HocBong) };
            dgvkq.DataSource = kq.ToList();
        }
        void cau11b()
        {
            var kq = Khoas.Join(Sinhviens, kh => kh.MaKh, sv => sv.MaKh, (k, s) => new { k.MaKh, k.TenKh, s.HocBong })
                .GroupBy(ns => new { ns.MaKh, ns.TenKh })
                .Select(s => new { MaKhoa = s.Key.MaKh, TenKhoa = s.Key.TenKh, TongHB = s.Sum(x => x.HocBong) };

            dgvkq.DataSource = kq.ToList();
        }
        void cau12a()
        {
            var kq = from kh in Khoas
                     join sv in Sinhviens on kh.MaKh equals sv.MaKh into SVLK
                     from sv1 in SVLK.DefaultIfEmpty()
                     group sv1 by new { kh.MaKh, kh.TenKh } into Nhom_Khoa
                     select new
                     {
                         MaKhoa = Nhom_Khoa.Key.MaKh,
                         TenKhoa = Nhom_Khoa.Key.TenKh,
                         TSSV = Nhom_Khoa.Count(x => x != null),
                         TongHB = Nhom_Khoa.Sum(x => x == null ? 0 : x.HocBong)

                     };
            dgvkq.DataSource = kq.ToList();
        }

        void cau12b()
        {
            var kq = Khoas.GroupJoin(Sinhviens, kh => kh.MaKh, sv => sv.MaKh, (k, svn) => new { MK = k.MaKh, TK = k.TenKh, svn })
            .SelectMany(NhomSV => NhomSV.svn.DefaultIfEmpty(), (kk, ssn) => new
            {
                MaKhoa = kk.MK,
                TenKhoa = kk.TK,
                HB = ssn == null ? 0 : ssn.HocBong
            }
            
             .GroupBy(ns => new { ns.Makhoa, ns.Tenkhoa })
            .Select(s => new { MaKh = s.Key.Makhoa, TenKH = s.Key.TenKhoa, TSSV = s.Count(XmlReadMode => XmlReadMode.HB })

            
        }



        void cau13aa1()
        {
            //cacsh 1 
            var kq = from kh in Khoas
                     where Sinhviens.All(s => s.MaKh != kh.MaKh)
                     select kh;
            dgvkq.DataSource = kq.ToList();
        }
        void cau13ab1()
        {
            var kq = Khoas.Where(k => Sinhviens.All(s => s.MaKh != k.MaKh));
            dgvkq.DataSource = kq.ToList();
        }

        }

    }

