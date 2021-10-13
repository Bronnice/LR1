using System;

namespace ConsoleApp3
{
    class Drobi
    {
        int ch;
        int zn;

        public Drobi(int a)
        {
            ch = a;
            zn = 1;
        }
        public Drobi(int a, int b)
        {
            ch = a;
            zn = b;
        }
        public Drobi(int a, int b, int z)
        {
            zn = b;
            ch = z * b + a;
        }
        double Desyat()
        {
            return (double)(ch) / zn;
        }
        public static Drobi operator + (Drobi x, Drobi y)
        {
            return new Drobi(x.ch * y.zn + y.ch * x.zn, x.zn * y.zn);
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
        public static void GetZnak(Drobi a)
        {
            if(a.zn >= 0 & a.ch >= 0)
            {
                Console.WriteLine('+');
            }
            else
            {
                Console.WriteLine('-');
            }
        }
        public delegate void Changed(Drobi a, int b);

        public event Changed EventChanger;
        public int Ch
        {
            get { return ch; }
            set { ch = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Drobi drob1 = new Drobi(2, 1);
            Drobi drob2 = new Drobi(-3, 2);
            Drobi.GetZnak(drob1);
            Drobi.GetZnak(drob2);
            drob1.Ch = 3;

        }
    }
}