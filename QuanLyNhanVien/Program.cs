using System;

namespace QuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.NhapDanhSach();
            ds.XuatDanhSach();
            Console.WriteLine($"Tổng lương của tất cả nhân viên: {ds.TinhTongLuong()}");
        }
    }
}
