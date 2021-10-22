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
            set 
            {
                EventChanger(this, value);
                ch = value; 
            }
        }
        public static void GetDrobe(Drobi a)
        {
            Console.WriteLine(a.ch+"/"+a.zn);
        }
        public int this[int index]
        {
            get { return (index == 0) ? ch : zn; }
        }
    }
    class Method
    {
       public static void MyMethod(Drobi a, int x)
        {
            Console.WriteLine("Дробь изменена");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Drobi drob1 = new Drobi(3, 1);
            drob1.EventChanger += Method.MyMethod;
            drob1.Ch = 7;
        }
    }
}