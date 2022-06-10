using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    //class Hinh
    abstract class Hinh
    //lop abstract khong the new object
    {
        //thanh phan mang thong tin
        public string MauSac { get; set; }

        //thanh phan xu ly
        //public void NhapHinh(string ghiChu)
        public virtual void NhapHinh(string ghiChu) 
        // keyword VIRTUAL de su dung tinh DA HINH
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap mau sac");
            this.MauSac = Console.ReadLine();
        }

        //ham abstract cung la ham virtual
        //khong co implemenation
        //public virtual double TinhChuVi()
        //{
        //    return 0;
        //}

        public abstract double TinhChuVi();
    }

    //xac dinh KHA NANG cua lop doi tuong
    interface IAnimal
    {
        double A();
        void B(string ghiChu);
    }

    interface IABC
    {
        void C();
    }
}
