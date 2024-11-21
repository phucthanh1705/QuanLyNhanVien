using System;

namespace QuanLyNhanVien
{
    public class NhaKhoaHoc : NhanVienQuanLy
    {
        public int SoBaiBao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số bài báo: ");
            SoBaiBao = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số bài báo: {SoBaiBao}");
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + SoBaiBao * 500000; // Thưởng mỗi bài báo 500,000 VND
        }
    }
}
