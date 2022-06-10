using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruSanPham : ILuuTruSanPham
    {
        public bool ThemSanPham(SanPham sp)
        {
            List<SanPham> dsSP = DocDanhSachSanPham();
            if (KiemTraTrungSanPham(sp))
            {
                return false;
            }
            dsSP.Add(sp);
            LuuDanhSachSanPham(dsSP);
            
            return true;
        }

        public List<SanPham> DocDanhSachSanPham()
        {
            StreamReader file = new StreamReader
                ("../DAL/sanpham.json");
            string jsonString = file.ReadToEnd();
            file.Close();

            var result = JsonConvert.DeserializeObject
                <List<SanPham>>(jsonString);

            return result;
        }

        public void LuuDanhSachSanPham(List<SanPham> dsSP)
        {
            StreamWriter writer = new StreamWriter
                ("../DAL/sanpham.json");

            string jsonString = JsonConvert.
                SerializeObject(dsSP);
            writer.Write(jsonString);

            writer.Close();
        }

        public bool KiemTraTrungSanPham(SanPham sp)
        {
            var dsSP = DocDanhSachSanPham();
            foreach (SanPham checkSP in dsSP)
            {
                if (checkSP.MaSanPham == sp.MaSanPham)
                {
                    return true;
                }
            }

            return false;
        }

        public List<SanPham> TimKiem(string tuKhoa)
        {
            var dsSP = DocDanhSachSanPham();
            var dsKQ = new List<SanPham>();
            foreach(var sp in dsSP)
            {
                if (sp.TenSanPham.Contains(tuKhoa))
                {
                    dsKQ.Add(sp);
                }
            }

            return dsKQ;
        }

        public SanPham DocSanPham(string id)
        {
            var dsSP = DocDanhSachSanPham();
            foreach (var sp in dsSP)
            {
                if (sp.MaSanPham == id)
                {
                    return sp;
                }
            }

            return null;
        }

        public void SuaSanPham
            (string id, string ten, int gia)
        {
            var dsSP = DocDanhSachSanPham();
            foreach(var sp in dsSP)
            {
                if(sp.MaSanPham == id)
                {
                    sp.TenSanPham = ten;
                    sp.Gia = gia;
                    break;
                }
            }
            LuuDanhSachSanPham(dsSP);
        }

        public void XoaSanPham(string id)
        {
            var dsSP = DocDanhSachSanPham();
            for (int i = 0; i < dsSP.Count; i++)
            {
                if(dsSP[i].MaSanPham == id)
                {
                    dsSP.RemoveAt(i);
                    LuuDanhSachSanPham(dsSP);
                    break;
                }
            }
        }
    }
}
