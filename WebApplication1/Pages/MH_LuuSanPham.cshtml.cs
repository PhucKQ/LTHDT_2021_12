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
    public class MH_LuuSanPhamModel : PageModel
    {
        public string Chuoi = string.Empty;
        private IXuLySanPham xuLySanPham;

        [BindProperty]
        public string MaSP { get; set; }
        [BindProperty]
        public string TenSP { get; set; }
        [BindProperty]
        public int Gia { get; set; }

        public MH_LuuSanPhamModel()
        {
            xuLySanPham = new XuLySanPham();
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            try
            {
                SanPham sp = new SanPham
                    (MaSP, TenSP, Gia);
                //sp.MaSanPham = MaSP;
                //sp.TenSanPham = TenSP;
                //sp.Gia = Gia;
                var kq = xuLySanPham.ThemSanPham(sp);
                if (kq.IsSuccess)
                {
                    Chuoi = $"ket qua la {kq.IsSuccess}";
                }
                else
                {
                    Chuoi = kq.Message;
                }
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
            
        }
    }
}
