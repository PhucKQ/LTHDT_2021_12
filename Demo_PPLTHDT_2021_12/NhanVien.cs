using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    class NhanVien
    {
        //Thanh phan du lieu
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        //Thanh phan xu ly
        //public void NhapNhanVien(string ghiChu)
        public virtual void NhapNhanVien(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma nhan vien");
            this.MaNV = Console.ReadLine();
            Console.WriteLine("Nhap ten nhan vien");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap dia chi");
            this.DiaChi = Console.ReadLine();
        }

        public virtual int TinhLuong()
        {
            int kq = 0;

            return kq;
        }
    }
}
