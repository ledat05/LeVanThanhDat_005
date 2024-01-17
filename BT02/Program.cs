using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Program
    {
        class ChuNhat
        {
            private double rong;
            private double dai;
            public ChuNhat()
            {
                rong = 5;
                dai = 6;
                    }
            public ChuNhat(double rong, double dai)
            {
                this.rong = rong;
                this.dai = dai;
            }
            public double Rong
            {
                set { this.rong = value; }
                get { return rong; }
            }
            public double Dai
            {
                set { this.dai = value; }
                get { return dai; }
            }
            public virtual double tinhChuVi()
            {
                return dai + rong * 2;
            }
            public virtual double tinhDienTich()
            {
                return dai * rong;
            }
            public virtual void Xuat()
            {
                Console.WriteLine("Xuat Chu Vi :{0}", tinhChuVi());
                Console.WriteLine("Xuat Dien Tich :{0}", tinhDienTich());
            }
            class Vuong : ChuNhat
            {
                private double canh;
                public Vuong()
                {
                    canh = 4;
                }
                public Vuong(double canh)
                {
                    this.canh = canh;
                }
                public double Canh
                {
                    set { this.canh = value; }
                    get { return canh; }
                }
                public override double tinhChuVi()
                {
                    return canh * 4;
                }
                public override double tinhDienTich()
                {
                    return canh * canh;
                }
                public override void Xuat()
                {
                    base.Xuat();
                }
                static void Main(string[] args)
                {
                    ChuNhat cn = new ChuNhat();
                    cn.tinhChuVi();
                    cn.tinhDienTich();
                    cn.Xuat();

                    Vuong vu = new Vuong();
                    vu.tinhChuVi();
                    vu.tinhDienTich();
                    vu.Xuat();
                    Console.ReadLine();
                }
            }
        }
    }
}
