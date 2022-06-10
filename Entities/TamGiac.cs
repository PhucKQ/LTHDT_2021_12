using System;

namespace Entities
{
    public class TamGiac
    {
        public Diem A;
        public Diem B;
        public Diem C;

        public TamGiac()
        {
            this.A = new Diem(0, 0);
            this.B = new Diem(1, 0);
            this.C = new Diem(0, 1);
        }

        public TamGiac(Diem A, Diem B, Diem C)
        {
            if (KiemTraTamGiac(A, B, C))
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }
            else
            {
                //this.A = new Diem(0, 0);
                //this.B = new Diem(1, 0);
                //this.C = new Diem(0, 1);
                throw new Exception("Tam giac khong hop le");
            }
        }

        public TamGiac(int xa, int ya, int xb, int yb,
            int xc, int yc)
        {
            Diem A = new Diem(xa, ya);
            Diem B = new Diem(xb, yb);
            Diem C = new Diem(xc, yc);
            if (KiemTraTamGiac(A, B, C))
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }
            else
            {
                throw new Exception("Tam giac khong hop le");
            }
        }

        public TamGiac(TamGiac t)
        {
            if (KiemTraTamGiac(t.A, t.B, t.C) == true)
            {
                this.A = t.A;
                this.B = t.B;
                this.C = t.C;
            }
            else
            {
                this.A = new Diem(0, 0);
                this.B = new Diem(1, 0);
                this.C = new Diem(0, 1);
            }
        }

        public bool KiemTraTamGiac(Diem A, Diem B, Diem C)
        {
            double a, b, c;
            a = B.TinhKhoangCach(C);
            b = A.TinhKhoangCach(C);
            c = A.TinhKhoangCach(B);

            return a + b > c && a + c > b && b + c > a;
        }

        //public void Nhap3Dinh(string ghiChu) {
        //    this.A = new Diem();
        //    this.B = new Diem();
        //    this.C = new Diem();
        //    Console.WriteLine(ghiChu);
        //    this.A.Nhap("Nhap toa do dinh A");
        //    this.B.Nhap("Nhap toa do dinh B");
        //    this.C.Nhap("Nhap toa do dinh C");
        //}

        public double TinhChuVi() {
            double a, b, c;
            a = this.B.TinhKhoangCach(this.C);
            b = this.A.TinhKhoangCach(this.C);
            c = this.A.TinhKhoangCach(this.B);

            return a + b + c;
        }

    }
}
