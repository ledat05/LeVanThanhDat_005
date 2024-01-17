using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt01
{
    class NhanVien
    {
        private string Hoten, BoPhan;
        private double SoNgayCong, SoNgayLamThem, XepLoai;

        public NhanVien()
        { }
        public NhanVien(string hoten, double songaycong, double songaylamthem, string bophan, double xeploai)
        {
            this.Hoten = hoten;
            this.SoNgayCong = songaycong;
            this.SoNgayLamThem = songaylamthem;
            this.BoPhan = bophan;
            this.XepLoai = xeploai;
        }
        public string Hotem
        {
            set { this.Hoten = value; }
            get { return Hoten; }
        }
        public double songaycong
        {
            set { this.SoNgayCong = value; }
            get { return SoNgayCong; }
        }
        public double songaylamthem
        {
            set { this.SoNgayLamThem = value; }
            get { return SoNgayLamThem; }
        }
        public string bophan
        {
            set { this.BoPhan = value; }
            get { return BoPhan; }

        }
        public double xeploai
        {
            set { this.XepLoai = value; }
            get { return XepLoai; }
        }
        public double TinhLuong()
        {
            double luongNgay = 100000; 
            double phanTramTang = 0;

            if (BoPhan == "TrucTiep")
            {
                //300% = 0,3
                phanTramTang = 0.3;
            }
            else if (BoPhan == "GianTiep")
            {
                //200%=0,2
                phanTramTang = 0.2;
            }
            // Tinh lương
            double luong = (SoNgayCong + SoNgayLamThem * (1 + phanTramTang)) * luongNgay;

            return luong;
        }
        public double TinhThuNhap()
        {
            return 0;
        }
        public void InThongTin()
        {

        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
                nv.TinhLuong();
            Console.ReadLine();
        }
    }
}
