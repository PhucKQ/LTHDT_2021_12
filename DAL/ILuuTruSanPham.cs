using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface ILuuTruSanPham
    {
        SanPham DocSanPham(string id);
        bool ThemSanPham(SanPham t);
        List<SanPham> DocDanhSachSanPham();
        void LuuDanhSachSanPham(List<SanPham> dsSP);
        List<SanPham> TimKiem(string tuKhoa);
        void SuaSanPham(string id, string ten, int gia);
        void XoaSanPham(string id);
    }
}
