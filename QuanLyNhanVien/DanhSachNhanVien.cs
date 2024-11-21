using System;
using System.Collections.Generic;

namespace QuanLyNhanVien
{
    public class DanhSachNhanVien
    {
        private List<NhanVien> danhSach;

        public DanhSachNhanVien()
        {
            danhSach = new List<NhanVien>();
        }

        public void NhapDanhSach()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int soLuong = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"Nhập thông tin nhân viên thứ {i + 1}:");
                Console.WriteLine("1. Nhân viên phòng thí nghiệm");
                Console.WriteLine("2. Nhân viên quản lý");
                Console.WriteLine("3. Nhà khoa học");

                Console.Write("Chọn loại nhân viên: ");
                int loai = int.Parse(Console.ReadLine());
                NhanVien nv;

                switch (loai)
                {
                    case 1:
                        nv = new NhanVienPhongThiNghiem();
                        break;
                    case 2:
                        nv = new NhanVienQuanLy();
                        break;
                    case 3:
                        nv = new NhaKhoaHoc();
                        break;
                    default:
                        Console.WriteLine("Loại nhân viên không hợp lệ. Bỏ qua.");
                        continue;
                }

                nv.Nhap();
                danhSach.Add(nv);
            }
        }

        public void XuatDanhSach()
        {
            Console.WriteLine("Danh sách nhân viên:");
            foreach (var nv in danhSach)
            {
                nv.Xuat();
            }
        }

        public double TinhTongLuong()
        {
            double tongLuong = 0;
            foreach (var nv in danhSach)
            {
                tongLuong += nv.TinhLuong();
            }
            return tongLuong;
        }
    }
}
