using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace Demo_PPLTHDT_2021_12_Web.Pages
{
    public class MH_SuaSanPhamModel : PageModel
    {
        public string Chuoi = string.Empty;
        public SanPham sanPham;
        private IXuLySanPham xuLySanPham;

        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public string TenSP { get; set; }
        [BindProperty]
        public int GiaSP { get; set; }

        public MH_SuaSanPhamModel()
        {
            xuLySanPham = new XuLySanPham();
            sanPham = new SanPham();
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(Id))
            {
                Chuoi = "khong tim thay san pham";
            }
            else
            {
                var result = xuLySanPham.DocSanPham(Id);
                if (result.IsSuccess)
                {
                    sanPham = result.Data;
                }
                else
                {
                    Chuoi = result.Message;
                }
                //sanPham = xuLySanPham.DocSanPham(Id);
            }
        }

        public void OnPost()
        {
            var kq = xuLySanPham.SuaSanPham
                (Id, TenSP, GiaSP);
            if (kq)
            {
                Response.Redirect
                    ("/MH_DanhSachSanPham");
            }
            else
            {
                Chuoi = "Sua khong thanh cong";
            }
        }
    }
}
