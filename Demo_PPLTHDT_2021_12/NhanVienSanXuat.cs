using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    class NhanVienSanXuat : NhanVien
    {
        //Thanh phan du lieu
        public int SoSanPham { get; set; }

        //Thanh phan xu ly

        // dùng toán tử new để cài đặt lại hàm kế thừa
        //public void Nhap(string ghiChu)
        //nếu không thiết lập lại hàm thì người dùng có tới
        //2 hàm nhập Nhap và NhapNhanVien do đó ta cần thiết lập lại
        //public new void NhapNhanVien(string ghiChu)
        public override void NhapNhanVien(string ghiChu)
        {
            //this: đại diện cho đối tượng gọi hàm
            //base: đại diện cho lớp cơ sở (lớp cha)
            base.NhapNhanVien(ghiChu);
            Console.WriteLine("Nhap so san pham");
            this.SoSanPham = int.Parse(Console.ReadLine());
        }

        //public int TinhLuong()
        public override int TinhLuong()
        {
            return this.SoSanPham * 100;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma nhan vien: {this.MaNV}");
            Console.WriteLine($"Ten nhan vien: {this.HoTen}");
            Console.WriteLine($"Dia chi: {this.DiaChi}");
            Console.WriteLine($"So san pham: {this.SoSanPham}");
        }
    }
}
