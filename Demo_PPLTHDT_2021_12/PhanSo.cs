using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PPLTHDT_2021_12 {
    class PhanSo {
        // thanh phan mang thong tin ==> nên là PRIVATE
        public int TuSo { get; set; }

        private int MauSo;

        public PhanSo() 
            //hàm tạo là hàm đặc biệt có tên trùng với tên CLASS
            //không có giá trị trả về
            //được gọi TỰ ĐỘNG khi NEW đối tượng
            //Dùng hàm tạo để khởi tạo những  giá trị mặc định cho đối tượng
            //Trong trường hợp trong CLASS không có hàm tạo nào, trình biên dịch
            //TỰ ĐỘNG phát sinh ra hàm tạo không đối số và không làm gì
            // CLASS có thể có rất nhiều hạm tạo với các tham số khác nhau
        {
            //Dùng để khởi tạo giá trị ban đầu cho đối tượng
            this.TuSo = 0;
            this.MauSo = 1;
        }

        public PhanSo(int t)
        {
            this.TuSo = t;
            this.MauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.TuSo = tuSo;
            if (mauSo != 0)
            {
                this.MauSo = mauSo;
            }
            else
            {
                this.MauSo = 1;
            }
        }

        // thanh phan xu ly thong tin ==> nên là PUBLIC
        public void Nhap(string ghiChu) {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhập tu so");
            TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mau so");
            MauSo = int.Parse(Console.ReadLine());
        }

        public PhanSo Cong(PhanSo b) {
            PhanSo kq;
            kq = new PhanSo();
            kq.TuSo = this.TuSo * b.MauSo + this.MauSo * b.TuSo;
            kq.MauSo = this.MauSo * b.MauSo;
            
            return kq;
        }

        public void XuatPhanSo() {
            Console.WriteLine($"{this.TuSo}/{this.MauSo}");
        }

        /*
        public int TUSO{
            get{
                return this.TuSo;
            }
            set{
                this.TuSo = value;
            }
        }

         */

        /*
        public int DocTuSo()
        {
            return this.TuSo;
        }

        public void GanTuSo(int t)
        {
            this.TuSo = t;
        }
        */

        public int MAUSO
        {
            get
            {
                return this.MauSo;
            }
            set
            {
                if (value != 0)
                {
                    this.MauSo = value;
                }
            }
        }

        /*
        public int DocMauSo()
        {
            return this.MauSo;
        }


        public void GanMauSo(int m)
        {
            if (m != 0) //kiểm tra tính hợp lệ của dữ liệu
            {
                this.MauSo = m;
            }
        }
        */
    }
}
