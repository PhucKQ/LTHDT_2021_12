using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    class HinhTron : Hinh, IAnimal, IABC
    {
        public Diem TamDuongTron { get; set; }
        public double R { get; set; }

        //public new void NhapHinh(string ghiChu)
        public override void NhapHinh(string ghiChu) //keyword OVERRIDE de thiet lap lai HAM AO
        {
            base.NhapHinh(ghiChu);
            //Console.WriteLine("Nhap toa do tam I");
            //Diem TamDuongTron = new Diem();
            //TamDuongTron.Nhap("nhap toa do tam I cua duong tron");
            Console.WriteLine("Nhap ban kinh");
            this.R = double.Parse(Console.ReadLine());
        }

        public override double TinhChuVi()
        {
            return R * 2 * Math.PI;
        }

        public double A()
        {
            return 0;
        }

        public void B(string str)
        {
            Console.WriteLine(str);
        }

        public void C()
        {

        }
    }
}
