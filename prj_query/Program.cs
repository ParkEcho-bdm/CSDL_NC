using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_query
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
            string[] mangchuoi = { "dau", "long", "hai", "a", "to", "nga", "Thuy", "Kieu", "la", "chi", "em", "la", "Thuy", "Van" };
            //Cau 1: Liệt kê các phần tử chia hết cho 4 và chia hết cho 3
            //cau1a(mang);
            //cau1b(mang);

            //Cau 2: Liệt kê các phần tử nhỏ hơn một giá trị và sắp xếp tăng dần
            //cau2a(mang);
            //cau2b(mang);

            //Cau 3: Liệt kê các phần tử lớn hơn một giá trị và sắp xếp giảm dần
            //cau3a(mang);
            //cau3b(mang);

            //Cau 4: Liệt kê các phần tử thành mảng mới thoả: phần tử chẳn chia 2, phần tử lẻ thì giữ nguyên
            //cau4a(mang);
            //cau4b(mang);

            //Cau 5: Liệt kê các phần tử có đồ dài 4 ký tự và sắp xếp tăng dần theo ký tự đầu tiên
            //cau5a(mangchuoi);
            //cau5b(mangchuoi);

            //Cau 6: Liệt kê các phần tử có đồ dài 4 ký tự và sắp xếp tăng dần theo ký tự đầu tiên. Thông tin xuất ra có dạng < chữ thường > - < chữ in >
            //cau6a(mangchuoi);
            //cau6b(mangchuoi);

            //Cau 7: Liệt kê các phần tử có chứa ký tự 'u'. Thông tin xuất ra có dạng < chữ thường > - < chữ in >
            //cau7a(mangchuoi);
            //cau7b(mangchuoi);

            //Cau 8: Liệt kê các phần tử đầu tiên là chữ in. Thông tin xuất ra có dạng < chữ thường > - < chữ in >
            //cau8a(mangchuoi);
            cau8b(mangchuoi);
            
            Console.Read();
        }

        private static void cau8a(string[] mangchuoi)
        {
            var kq = from s in mangchuoi
                     where s.Substring(0, 1) == s.Substring(0, 1).ToUpper()
                     orderby s.Substring(0, 1)
                     select s.ToLower() + " - " + s.ToUpper();
            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }

        private static void cau8b(string[] mangchuoi)
        {
            var kq = mangchuoi.Where(s => s.Substring(0,1) == s.Substring(0,1).ToUpper()).Select(m => m.ToLower() + " - " + m.ToUpper());
            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }

        private static void cau7a(string[] mangchuoi)
        {
            var kq = from s in mangchuoi
                     where s.Contains("u")
                     orderby s.Substring(0, 1)
                     select s.ToLower() + " - " + s.ToUpper();
            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }
        private static void cau7b(string[] mangchuoi)
        {
            var kq = mangchuoi.Where(s => s.Contains("u")).Select(m => m.ToLower() + " - " + m.ToUpper());
            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }
        private static void cau6a(string[] mangchuoi)
        {
            var kq = from s in mangchuoi
                     where s.Length == 4
                     orderby s.Substring(0, 1)
                     select s.ToLower() + " - " + s.ToUpper();
            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }
        private static void cau6b(string[] mangchuoi)
        {
            var kq = mangchuoi.Where(s => s.Length == 4).OrderBy(o => o.Substring(0, 1)).Select(m => m.ToLower() + " - " + m.ToUpper());
            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }

        private static void cau5a(string[] mangchuoi)
        {
            var kq = from s in mangchuoi
                     where s.Length == 4
                     orderby s.Substring(0, 1)
                     select s;
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }

        private static void cau5b(string[] mangchuoi)
        {
            var kq = mangchuoi.Where(s => s.Length == 4).OrderBy(o => o.Substring(0, 1));
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }

        private static void cau4a(int[] mang)
        {
            var kq = from n in mang
                     select n % 2 == 0 ? n / 2 : n;
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }
        private static void cau4b(int[] mang)
        {
            var kq = mang.Select(x => x % 2 == 0 ? x / 2 : x);
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }

        private static void cau3a(int[] mang)
        {
            Console.Write("Nhap mot so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            var kq = from n in mang
                     where n > a
                     orderby n descending
                     select n;
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }

        private static void cau3b(int[] mang)
        {
            Console.Write("Nhap mot so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            var kq = mang.Where(x => x > a).OrderBy(p => p);
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }
        private static void cau2a(int[] mang)
        {
            Console.Write("Nhap mot so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            var kq = from n in mang
                     where n < a
                     orderby n
                     select n;
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }
        private static void cau2b(int[] mang)
        {
            Console.Write("Nhap mot so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            var kq = mang.Where(x => x < a).OrderBy(p => p);
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }
        private static void cau1a(int[] mang)
        {
            var kq = from n in mang
                     where n % 4 == 0 && n % 3 == 0
                     select n;
            kq.ToList().ForEach(x => Console.WriteLine("{0,5}", x));

        }
        private static void cau1b(int[] mang)
        {
            //Nếu giá trị ra giống giá trị vào thì không cần dùng phương thức select
            var kq = mang.Where(n => n % 4 == 0 && n % 3 == 0);
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));

        }
    }
}
