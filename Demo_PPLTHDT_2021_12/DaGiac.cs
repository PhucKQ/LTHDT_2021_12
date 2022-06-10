using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    class DaGiac
    {
        public Diem[] dsDinh;

        public void NhapDaGiac(string ghiChu) {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so luong dinh cua da giac");
            int n = int.Parse(Console.ReadLine());
            this.dsDinh = new Diem[n];
            for (int i = 0; i < this.dsDinh.Length; i++) {
                this.dsDinh[i] = new Diem();
                this.dsDinh[i].Nhap($"nhap toa do dinh thu {i}");
            }
        }

        public double TinhChuViDaGiac() {
            double cv = 0;
            for (int i = 0; i < this.dsDinh.Length - 1; i++) {
                cv += this.dsDinh[i].TinhKhoangCach(this.dsDinh[i + 1]);
            }
            cv += this.dsDinh[this.dsDinh.Length - 1].TinhKhoangCach(this.dsDinh[0]);

            return cv;
        }
    }
}
