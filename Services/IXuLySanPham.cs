using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace Services
{
    public interface IXuLySanPham
    {
        ServiceResult<bool> ThemSanPham(SanPham t);
        List<SanPham> TimKiem(string tuKhoa);
        ServiceResult<SanPham> DocSanPham(string id);
        bool SuaSanPham(string id, string tensp, int giasp);
        ServiceResult<bool> XoaSanPham(string id);
    }
}
