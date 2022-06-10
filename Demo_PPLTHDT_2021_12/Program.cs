using System;

namespace Demo_PPLTHDT_2021_12 {
    class Program {
        static void Main(string[] args) {

            /*
            PhanSo p, p1, p2;
            p = new PhanSo();
            p1 = new PhanSo(4);
            p2 = new PhanSo(2,3);

            //p.TUSO = 1;//p.GanTuSo(1); //t.TuSo = 1;
            //p.MAUSO = 2;//p.GanMauSo(2); //t.MauSo = 2;
            //p.Nhap("nhap phan so");

            p.XuatPhanSo();
            p1.XuatPhanSo();
            p2.XuatPhanSo();

            //p.MAUSO = 0;//p.GanMauSo(0);
            //*/

            /*
            DaGiac d;
            d = new DaGiac();
            d.NhapDaGiac("nhap cac dinh da giac");

            double kq;
            kq = d.TinhChuViDaGiac();
            Console.WriteLine(kq);
            */

            /*
            TamGiac t, t1;
            t = new TamGiac();
            t1 = new TamGiac(new Diem(1, 2), new Diem(4, 2), new Diem(1, 3));
            //t.Nhap3Dinh("Nhap toa do 3 dinh tam giac");

            double kq, kq1;
            kq = t.TinhChuVi();
            kq1 = t1.TinhChuVi();
            Console.WriteLine(kq);
            Console.WriteLine(kq1);
            */


            /*///////////nhap toa do 2 diem, tinh khoang cach
            Diem a, b;
            //a, b: object
            //Diem: class
            //B1. Tao doi tuong
            a = new Diem();
            a.X = 0;
            a.Y = 0;
            
            b = new Diem();
            b.X = 1;
            b.Y = 1;
            //B2. Yêu cầu đối tượng a thực hiện hành động nhập
            //a.Nhap("Nhap toa do diem A");
            //Yêu cầu đối tượng b thực hiện hành động nhập
            //b.Nhap("Nhap toa do diem B");
            //Yêu cầu đối tượng a thực hiện hành động Tính Khoảng Cách với b
            double kq = a.TinhKhoangCach(b);
            //Xuất kết quả
            Console.WriteLine(kq);
            //*/

            /*
            ///////////// nhap 2 phan so, thuc hien phep cong 2 phan so
            PhanSo a, b;
            //B1. Tao doi duong
            a = new PhanSo();
            b = new PhanSo();

            //B2. Yêu cầu các đối tượng a, b thực hiện các hành động cần thiết
            //B2.1 Yêu cầu đối tượng a thực hiện hành động nhập
            a.Nhap("Nhap phan so a");
            //B2.2 Yêu cầu đối tượng b thực hiện hành động nhập
            b.Nhap("Nhap phan so b");
            //B2.3 Yêu cầu đối tượng a thực hiện hành động Cộng với đối tượng b
            PhanSo kq;
            kq = new PhanSo();
            kq = a.Cong(b);
            //B2.4 Yêu cầu đối tượng kq thực hiện hành động Xuất giá trị
            Console.WriteLine("kết quả là: ");
            kq.XuatPhanSo();
            */

            /*
            CongTy c = new CongTy();
            c.Nhap("nhap thong tin cty");
            double kq = c.TinhTongLuong();
            Console.WriteLine(kq);
            */

            //NhanVienSanXuat t = new NhanVienSanXuat();
            //t.NhapNhanVien("Nhap nhan vien");

            MatPhang mp = new MatPhang();
            mp.Nhap("nhap thong tin mat phang");
            double kq = mp.TinhTongChuVi();
            Console.WriteLine($"Ket qua la {kq}");

            //khong the tao object tu ABSTRACT
            HinhTron tron = new HinhTron();
            tron.A();
            IAnimal a;
            a = tron;
            a.A();
            a.B("asdfasdf");

            IABC b;
            b = tron;
            b.C();

        }
    }
}
