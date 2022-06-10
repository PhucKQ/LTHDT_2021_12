using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities;
using DAL;

namespace Services
{
    public class XuLySanPham : IXuLySanPham
    {
        public ILuuTruSanPham luuTruSanPham;

        public XuLySanPham()
        {
            luuTruSanPham = new LuuTruSanPham();
        }

        public ServiceResult<bool> ThemSanPham
            (SanPham sp)
        {
            try
            {
                var result = luuTruSanPham.ThemSanPham(sp);
                if (result)
                {
                    return new ServiceResult<bool>
                    (result, true, string.Empty);
                }
                else
                {
                    return new ServiceResult<bool>
                    (result, false, "san pham da ton tai");
                }
                
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>
                (false, false, ex.Message);
            }
        }

        public List<SanPham> TimKiem(string tuKhoa)
        {
            try
            {

            
            if (tuKhoa == null)
            {
                tuKhoa = string.Empty;
            }

            return luuTruSanPham.TimKiem(tuKhoa);
            }
            catch (Exception ex)
            {
                //ghi log Exception
                string mess = ex.Message;
                return new List<SanPham>();
            }
        }

        public ServiceResult<SanPham> DocSanPham(string id)
        {
            try
            {
                var sp = luuTruSanPham.DocSanPham(id);
                if (sp != null)
                {
                    return new ServiceResult<SanPham>
                        (true, sp, string.Empty);
                }
                else
                {
                    return new ServiceResult<SanPham>
                   (false, null, "San pham khong ton tai");
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult<SanPham>
                    (false, null, ex.Message);
            }
        }

        public bool SuaSanPham
            (string id, string ten, int gia)
        {
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(ten) ||
                gia <= 0)
            {
                return false;
            }
            luuTruSanPham.SuaSanPham(id, ten, gia);

            return true;
        }

        public ServiceResult<bool> XoaSanPham(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return new ServiceResult<bool>(false, false, "khong tim thay san pham");
            }

            luuTruSanPham.XoaSanPham(id);

            return new ServiceResult<bool>(true, true, string.Empty);
        }

    }
}
