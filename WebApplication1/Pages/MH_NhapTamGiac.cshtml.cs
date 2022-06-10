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
    public class MH_NhapTamGiacModel : PageModel
    {
        public string Chuoi = string.Empty;
        private IXuLyTamGiac xuLyTamGiac;

        [BindProperty]
        public int XA { get; set; }
        [BindProperty]
        public int YA { get; set; }
        [BindProperty]
        public int XB { get; set; }
        [BindProperty]
        public int YB { get; set; }
        [BindProperty]
        public int XC { get; set; }
        [BindProperty]
        public int YC { get; set; }

        public void OnGet()
        {
            
        }

        public MH_NhapTamGiacModel()
        {
            xuLyTamGiac = new XuLyTamGiac();
        }

        public void OnPost()
        {
            try
            {
                Diem A = new Diem(XA, YA);
                Diem B = new Diem(XB, YB);
                Diem C = new Diem(XC, YC);

                TamGiac tg = new TamGiac(A, B, C);
                //TamGiac tg = new TamGiac
                //    (XA, YA, XB, YB, XC, YC);
                xuLyTamGiac.LuuTamGiac(tg);
                Chuoi = "Luu tru thanh cong";
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }


    }
}
