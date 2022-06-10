using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public interface IXuLyPhanSo
    {
        ServiceResult<PhanSo> Cong2PhanSo
            (int tu1, int mau1, int tu2, int mau2);
    }
}
