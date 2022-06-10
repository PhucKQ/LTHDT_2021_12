using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace Demo_PPLTHDT_2021_12_Web.Pages
{
    public class MH_TinhChuViTamGiacModel : PageModel
    {
        public string Chuoi = string.Empty;
        private IXuLyTamGiac xuLyTamGiac;
        public MH_TinhChuViTamGiacModel()
        {
            xuLyTamGiac = new XuLyTamGiac();
        }

        public void OnGet()
        {
            var kq = xuLyTamGiac.TinhChuVi();
            if (kq.IsSuccess)
            {
                Chuoi = $"Ket qua la {kq.Data}";
            }
            else
            {
                Chuoi = kq.Message;
            }
        }

    }
}
