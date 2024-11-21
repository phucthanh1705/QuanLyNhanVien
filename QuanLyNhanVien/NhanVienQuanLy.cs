using System;

namespace QuanLyNhanVien
{
    public class NhanVienQuanLy : NhanVien
    {
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }

        public override void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập bằng cấp: ");
            BangCap = Console.ReadLine();
            Console.Write("Nhập chức vụ: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhập số ngày công: ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhập bậc lương: ");
            BacLuong = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Bằng cấp: {BangCap}, Chức vụ: {ChucVu}, Số ngày công: {SoNgayCong}, Bậc lương: {BacLuong}");
        }

        public override double TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }
    }
}
