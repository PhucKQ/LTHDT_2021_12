using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12
{
    //xac dinh cau truc cua doi tuong khi tao lap doi tuong
    class Diem
    {
        //thanh phan mang thong tin
        public int X { get; set; }

        public int Y { get; set; }

        public Diem()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Diem(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //thanh phan xu ly thong tin
        public void Nhap(string ghiChu) {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap toa do x");
            this.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y");
            this.Y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(Diem b) {
            return Math.Sqrt((this.X - b.X) * (this.X - b.X) + (this.Y - b.Y) * (this.Y - b.Y));
        }

        

        

    }
}
