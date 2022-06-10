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
    public class MH_DanhSachSanPhamModel : PageModel
    {
        private IXuLySanPham xuLySanPham;
        public List<SanPham> dsSP;

        [BindProperty]
        public string TuKhoa { get; set; }

        public MH_DanhSachSanPhamModel()
        {
            xuLySanPham = new XuLySanPham();
            dsSP = new List<SanPham>();
        }

        public void OnGet()
        {
            dsSP = xuLySanPham.TimKiem(string.Empty);
        }

        public void OnPost()
        {
            dsSP = xuLySanPham.TimKiem(TuKhoa);
        }
    }
}
