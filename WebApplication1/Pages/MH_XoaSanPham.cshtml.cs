using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace Demo_PPLTHDT_2021_12_Web.Pages
{
    public class MH_XoaSanPhamModel : PageModel
    {
        public string Chuoi = string.Empty;
        private IXuLySanPham xuLySanPham;
        public SanPham sanPham;

        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        public MH_XoaSanPhamModel()
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
            }
        }

        public void OnPost()
        {
            var kq = xuLySanPham.XoaSanPham(Id);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_DanhSachSanPham");
            }
            else if(kq.IsSuccess == false && kq.Message != null)
            {
                Chuoi = kq.Message;
            }
            else
            {
                Chuoi = "khong the xoa";
            }
        }

    }
}
