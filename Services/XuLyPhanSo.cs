using System;
using Entities;

namespace Services
{
    public class XuLyPhanSo : IXuLyPhanSo
    {
        public ServiceResult<PhanSo> Cong2PhanSo
            (int tu1, int mau1, int tu2, int mau2)
        {
            //kiem tra tinh hop le cua du lieu
            if (mau1 == 0 || mau2 == 0)
            {
                return new ServiceResult<PhanSo>
                    (false, null, "Mau So bang 0");
            }

            PhanSo a = new PhanSo(tu1, mau1);
            PhanSo b = new PhanSo(tu2, mau2);
            var tong = a.Cong(b);
            
            return new ServiceResult<PhanSo>
                (true, tong, null);
        }
    }
}
