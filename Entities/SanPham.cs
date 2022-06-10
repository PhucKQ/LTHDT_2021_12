using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SanPham
    {
        public string MaSanPham;
        public string TenSanPham;
        public int Gia;

        public SanPham()
        {
        }

        public SanPham(string masp,
            string tensp, int gia)
        {
            if (string.IsNullOrWhiteSpace(masp) ||
                string.IsNullOrWhiteSpace(tensp) ||
                gia <= 0)
            {
                throw new("thong tin san pham khong the de trong");
            }
            else
            {
                this.MaSanPham = masp;
                this.TenSanPham = tensp;
                this.Gia = gia;
            }
        }

    }
}
