using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;


namespace WebApplication1.Pages
{
    public class MH_TinhTongPhanSoModel : PageModel
    {
        private IXuLyPhanSo xuLyPhanSo;
        public string Chuoi = string.Empty;

        [BindProperty]
        public int Tu1 { get; set; }
        [BindProperty]
        public int Mau1 { get; set; }
        [BindProperty]
        public int Tu2 { get; set; }
        [BindProperty]
        public int Mau2 { get; set; }
        
        public void OnGet()
        {

        }

        //constructor
        public MH_TinhTongPhanSoModel()
        {
            xuLyPhanSo = new XuLyPhanSo();
        }

        public void OnPost()
        {
            
            var kq = xuLyPhanSo.Cong2PhanSo
                (Tu1, Mau1, Tu2, Mau2);
            if (kq.IsSuccess)
            {
                Chuoi = kq.Data.XuatPhanSo();
            }
            else
            {
                Chuoi = kq.Message;
            }
            
        }
    }
}
