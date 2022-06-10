using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    class NhanVienVanPhong : NhanVien
    {
        //Thanh phan du lieu
        public int LuongCoBan { get; set; }
        public int PhuCap { get; set; }

        //Thanh phan xu ly
        //public new void NhapNhanVien(string ghiChu)
        public override void NhapNhanVien(string ghiChu)
        {
            base.NhapNhanVien(ghiChu);
            Console.WriteLine("Nhap luong co ban");
            this.LuongCoBan = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap");
            this.PhuCap = int.Parse(Console.ReadLine());
        }

        //public int TinhLuong()
        public override int TinhLuong()
        {
            return this.LuongCoBan * 10 + this.PhuCap;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma nhan vien: {this.MaNV}");
            Console.WriteLine($"Ten nhan vien: {this.HoTen}");
            Console.WriteLine($"Dia chi: {this.DiaChi}");
            Console.WriteLine($"Luong co ban: {this.LuongCoBan}");
            Console.WriteLine($"Phu cap: {this.LuongCoBan}");
        }
    }
}
