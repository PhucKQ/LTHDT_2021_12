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
    public class XuLyTamGiac : IXuLyTamGiac
    {
        public ILuuTruTamGiac luuTruTamGiac;

        public XuLyTamGiac()
        {
            luuTruTamGiac = new LuuTruTamGiac();
        }

        public ServiceResult<double> TinhChuVi()
        {
            try
            {
            //Doc tam giac tu tap tin
            var tg = luuTruTamGiac.DocTamGiac();

            //Tinh chu vi tam giac
            var result = tg.TinhChuVi();

            //tra ket qua
            return new ServiceResult<double>
                (true, result, string.Empty);
            }
            catch (Exception ex)
            {
                return new ServiceResult<double>
                (false, 0, ex.Message);
            }
        }

        public ServiceResult<bool> LuuTamGiac(TamGiac t)
        {
            try
            {
                luuTruTamGiac.LuuTamGiac(t);
                return new ServiceResult<bool>
                (true, true, string.Empty);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>
                (false, false, ex.Message);
            }
        }

    }
}
