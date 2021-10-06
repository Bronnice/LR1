using System;

namespace ConsoleApp3
{
    class Drobi
    {
        int ch;
        int zn;

        public Drobi (int a)
        {
            this.ch = a;
            this.zn = 1;
        }
        public Drobi(int a, int b)
        {
            this.ch = a;
            this.zn = b;
        }
        public Drobi(int a, int b, int z)
        {
            this.zn = b;
            this.ch = z * b + a;
        }
        public double Desyat()
        {
            return (double) (ch) / zn;
        }
        public static Drobi operator + (Drobi x, Drobi y)
        {
            return new Drobi(x.ch*y.zn + y.ch*x.zn, x.zn*y.zn);
        }
        public static Drobi operator - (Drobi x, Drobi y)
        {
            return new Drobi(x.ch * y.zn - y.ch * x.zn, x.zn * y.zn);
        }
        public static Drobi operator * (Drobi x, Drobi y)
        {
            return new Drobi(x.ch * y.ch, x.zn * y.zn);
        }
        public static Drobi operator / (Drobi x, Drobi y)
        {
            return new Drobi(x.ch * y.zn, x.zn * y.ch);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
