using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    class MatPhang
    {
        //public List<HinhTron> DanhSachHinhTron { get; set; }
        //public List<HinhChuNhat> DanhSachHinhChuNhat { get; set; }
        public List<Hinh> DanhSachHinh { get; set; }

        public MatPhang()
        {
            //this.DanhSachHinhChuNhat = new List<HinhChuNhat>();
            //this.DanhSachHinhTron = new List<HinhTron>();
            this.DanhSachHinh = new List<Hinh>();
        }
        
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so luong hinh trong mp");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Hinh h;
                Console.WriteLine("Nhap loai hinh (1. HCN, 2. Tron):");
                int loai = int.Parse(Console.ReadLine());
                if (loai == 1)
                {
                    h = new HinhChuNhat();
                }
                else
                {
                    h = new HinhTron();
                }
                h.NhapHinh($"Nhap hinh thu {i}");
                this.DanhSachHinh.Add(h);
            }
            //for (int i = 0; i < n; i++)
            //{
            //    HinhTron h = new HinhTron();
            //    h.NhapHinh($"Nhap hinh tron thu {i}");
            //    DanhSachHinhTron.Add(h);
            //}

            //Console.WriteLine("Nhap so luong hinh chu nhat");
            //n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    HinhChuNhat h = new HinhChuNhat();
            //    h.NhapHinh($"Nhap hinh chu nhat {i}");
            //    DanhSachHinhChuNhat.Add(h);
            //}
        }

        public double TinhTongChuVi()
        {
            double kq = 0;
            for (int i = 0; i < DanhSachHinh.Count; i++)
            {
                kq += DanhSachHinh[i].TinhChuVi();
            }

            //for (int i = 0; i < DanhSachHinhTron.Count; i++)
            //{
            //    kq += DanhSachHinhTron[i].TinhChuVi();
            //}

            //for (int i = 0; i < DanhSachHinhChuNhat.Count; i++)
            //{
            //    kq += DanhSachHinhChuNhat[i].TinhChuVi();
            //}

            return kq;
        }
    }
}
