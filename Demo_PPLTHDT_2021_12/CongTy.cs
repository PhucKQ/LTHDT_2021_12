using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    class CongTy
    {
        //Thanh phan du lieu
        public string Ten { get; set; }
        //private NhanVienSanXuat[] dsNhanVienSX { get; set; }
        //private List<NhanVienSanXuat> DanhSachSX { get; set; }
        //private NhanVienVanPhong[] dsNhanVienVP { get; set; }
        //private List<NhanVienVanPhong> DanhSachVP { get; set; }
        private List<NhanVien> DanhSachNhanVien { get; set; }

        //hàm Tạo (Constructor)
        public CongTy()
        {
            //this.DanhSachSX = new List<NhanVienSanXuat>();
            //this.DanhSachVP = new List<NhanVienVanPhong>();
            this.DanhSachNhanVien = new List<NhanVien>();
        }

        //Thanh phan xu ly
        public void Nhap(string ghiChu)
        {
            
            Console.WriteLine(ghiChu);
            Console.WriteLine("nhap ten CTY");
            this.Ten = Console.ReadLine();
            //nhập danh sách nhân viên văn phòng
            //Console.WriteLine("nhap so luong NhanVienVP");
            Console.WriteLine("nhap so luong Nhan Vien");
            int n = int.Parse(Console.ReadLine());
            //this.dsNhanVienVP = new NhanVienVanPhong[nvvp];
            for (int i = 0; i < n; i++)
            {
                //this.DanhSachVP[i] = new NhanVienVanPhong();
                //NhanVienVanPhong nv = new NhanVienVanPhong();
                Console.WriteLine("Nhap loai nhan vien (1. VP, 2. SX):");
                int loai = int.Parse(Console.ReadLine());
                NhanVien nv;
                if (loai == 1)
                {
                    nv = new NhanVienVanPhong();
                }
                else
                {
                    nv = new NhanVienSanXuat();
                }
                nv.NhapNhanVien($"nhap nv a{i}");
                this.DanhSachNhanVien.Add(nv);
            }

            /*
            //nhập danh sách nhân viên sản xuất
            Console.WriteLine("nhap so luong NhanVienSX");
            int nvsx = int.Parse(Console.ReadLine());
            //this.dsNhanVienSX = new NhanVienSanXuat[nvsx];
            for (int i = 0; i < nvsx; i++)
            {
                //this.DanhSachSX[i] = new NhanVienSanXuat();
                NhanVienSanXuat nv = new NhanVienSanXuat();
                nv.NhapNhanVien($"nhap thong tin NVSX thu {i}");
                this.DanhSachSX.Add(nv);
            }
            */
        }

        public double TinhTongLuong()
        {
            double kq = 0;
            /*
            foreach (NhanVienSanXuat nv in DanhSachSX)
            {
                kq += nv.TinhLuong();
            }

            foreach (NhanVienVanPhong nv in DanhSachVP)
            {
                kq += nv.TinhLuong();
            }
            */

            foreach (NhanVien nv in DanhSachNhanVien)
            {
                kq += nv.TinhLuong();
            }

            return kq;
        }
    }
}
