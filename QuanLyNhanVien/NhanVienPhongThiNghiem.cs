using System;

namespace QuanLyNhanVien
{
    public class NhanVienPhongThiNghiem : NhanVien
    {
        public double LuongTrongThang { get; set; }

        public override void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập bằng cấp: ");
            BangCap = Console.ReadLine();
            Console.Write("Nhập lương trong tháng: ");
            LuongTrongThang = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Bằng cấp: {BangCap}, Lương trong tháng: {LuongTrongThang}");
        }

        public override double TinhLuong()
        {
            return LuongTrongThang;
        }
    }
}
