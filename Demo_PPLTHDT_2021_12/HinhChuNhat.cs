using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    class HinhChuNhat : Hinh
    {
        public int ChieuDai { get; set; }
        public int ChieuRong { get; set; }

        //public new void NhapHinh(string ghiChu)
        public override void NhapHinh(string ghiChu) //keyword OVERRIDE de thiet lap lai HAM AO
        {
            base.NhapHinh(ghiChu);
            Console.WriteLine("Nhap chieu dai HCN");
            this.ChieuDai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong HCN");
            this.ChieuRong = int.Parse(Console.ReadLine());
        }

        public override double TinhChuVi()
        {
            return (this.ChieuDai + this.ChieuRong) * 2;
        }
    }
}
