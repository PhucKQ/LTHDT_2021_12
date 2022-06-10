using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace Services
{
    public interface IXuLyTamGiac
    {
        ServiceResult<double> TinhChuVi();
        ServiceResult<bool> LuuTamGiac(TamGiac t);

    }
}
