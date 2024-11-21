using System;

namespace QuanLyNhanVien
{
    public abstract class NhanVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string BangCap { get; set; }

        public abstract void Nhap();
        public abstract void Xuat();
        public abstract double TinhLuong();
    }
}
