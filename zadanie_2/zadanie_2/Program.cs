using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №1");

            double G, e, y, f;

            Console.WriteLine("Введите значение - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - f");
            f = Convert.ToDouble(Console.ReadLine());

            G = (Math.Pow(e, 2 * y) + Math.Sin(f))/(Math.Log(3.8 * y + f));
            Console.WriteLine($"G={G}");


            Console.WriteLine("Практическая работа №2");

            double F, d, y2;

            Console.WriteLine("Введите значение - d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            F = Math.Log(d) + ((3.5 * Math.Pow(d, 2) + 1) / (Math.Cos(2 * y2)));
            Console.WriteLine($"F={F}");


            Console.WriteLine("Практическая работа №3");

            double U, k, y3, e2;

            Console.WriteLine("Введите значение - k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y3");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e2");
            e2 = Convert.ToDouble(Console.ReadLine());

            U = (Math.Log(k - y3) + Math.Pow(y3, 4))/(Math.Pow(e2,y3) + 2.355 * Math.Pow(k,2))  ;
            Console.WriteLine($"U={U}");


            Console.WriteLine("Практическая работа №4");

            double G2, w, y4;

            Console.WriteLine("Введите значение - w");
            w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y4");
            y4 = Convert.ToDouble(Console.ReadLine());

            G2 = (9.33 * Math.Pow(w,3) + Math.Sqrt(w)) / (Math.Log(y4 + 3.5) + Math.Sqrt(y4));
            Console.WriteLine($"G2={G2}");


            Console.WriteLine("Практическая работа №5");

            double D, a, t, y5, e3;

            Console.WriteLine("Введите значение - a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y5");
            y5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e3");
            e3 = Convert.ToDouble(Console.ReadLine());

            D = (7.8 * Math.Pow(a,2) + 3.52 * t)/(Math.Log(a + 2 * y5) + Math.Pow(e3,y5));
            Console.WriteLine($"D={D}");


            Console.WriteLine("Практическая работа №6");

            double L, i, y6;

            Console.WriteLine("Введите значение - i");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y6");
            y6 = Convert.ToDouble(Console.ReadLine());

            L = (0.81 * Math.Cos(i))/(Math.Log(y6) + 2 * Math.Pow(i,3));
            Console.WriteLine($"L={L}");


            Console.WriteLine("Практическая работа №7");

            double N, m, y7;

            Console.WriteLine("Введите значение - m");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y7");
            y7 = Convert.ToDouble(Console.ReadLine());

            N = (Math.Pow(m,2) + 2.8 * m + 0.355)/(Math.Cos(2 * y7) + 3.6);
            Console.WriteLine($"N={N}");


            Console.WriteLine("Практическая работа №8");

            double T, t2, y8;

            Console.WriteLine("Введите значение - t2");
            t2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y8");
            y8 = Convert.ToDouble(Console.ReadLine());

            T = (2.37 * Math.Sin(t2 + 1))/(Math.Sqrt(4*Math.Pow(y8,2) - 0.1 * y8 + 5));
            Console.WriteLine($"T={T}");


            Console.WriteLine("Практическая работа №9");

            double V, y9, w2;

            Console.WriteLine("Введите значение - y9");
            y9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - w2");
            w2 = Convert.ToDouble(Console.ReadLine());

            V = (Math.Pow(y9 + 2*w2,3))/(Math.Log(y9+0.75));
            Console.WriteLine($"V={V}");


            Console.WriteLine("Практическая работа №10");

            double Z, t3, y10;

            Console.WriteLine("Введите значение - t3");
            t3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y10");
            y10 = Convert.ToDouble(Console.ReadLine());

            Z = (2 * t3 + y10 * Math.Cos(t3))/(Math.Sqrt(y10 + 4.831));
            Console.WriteLine($"Z={Z}");


            Console.WriteLine("Практическая работа №11");

            double D2, y11, n;

            Console.WriteLine("Введите значение - y11");
            y11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - n");
            n = Convert.ToDouble(Console.ReadLine());

            D2 = Math.Pow(y11,2) + ((0.5 * n + 4.8)/(Math.Sin(y11)));
            Console.WriteLine($"D2={D2}");


            Console.WriteLine("Практическая работа №12");

            double R, t4, y12;

            Console.WriteLine("Введите значение - t4");
            t4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y12");
            y12 = Convert.ToDouble(Console.ReadLine());

            R = (Math.Sin(Math.Pow(2*t4 + 1,2)) + 0.3)/(Math.Log(t4+y12));
            Console.WriteLine($"R={R}");


            Console.WriteLine("Практическая работа №13");

            double A, y13, h, e4;

            Console.WriteLine("Введите значение - y13");
            y13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - h");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e4");
            e4 = Convert.ToDouble(Console.ReadLine());

            A = (Math.Sin(2*y13 + h) + Math.Pow(h,2))/(Math.Pow(e4,h) + y13);
            Console.WriteLine($"A={A}");


            Console.WriteLine("Практическая работа №14");

            double P, e5, y14, h2;

            Console.WriteLine("Введите значение - e5");
            e5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y14");
            y14 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - h2");
            h2 = Convert.ToDouble(Console.ReadLine());

            P = (Math.Pow(e5,y14+2.5) + 7.1 * Math.Pow(h2,3))/(Math.Log(Math.Sqrt(y14+0.04 * h2)));
            Console.WriteLine($"P={P}");


            Console.WriteLine("Практическая работа №15");

            double F2, y15, j;

            Console.WriteLine("Введите значение - y15");
            y15 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - j");
            j = Convert.ToDouble(Console.ReadLine());

            F2 = (2*Math.Sin(0.354 * y15 + 1))/(Math.Log(y15 + 2 * j));
            Console.WriteLine($"F2={F2}");


            Console.WriteLine("Практическая работа №16");

            double W, t5, r, y16, e6;

            Console.WriteLine("Введите значение - t5");
            t5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - r");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y16");
            y16 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e6");
            e6 = Convert.ToDouble(Console.ReadLine());

            W = (4 * Math.Pow(t5,3) + Math.Log(r))/(Math.Pow(e6,y16+r)+7.2*Math.Sin(r));
            Console.WriteLine($"W={W}");


            Console.WriteLine("Практическая работа №17");

            double H, y17, n2;

            Console.WriteLine("Введите значение - y17");
            y17 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - n2");
            n2 = Convert.ToDouble(Console.ReadLine());

            H = (Math.Pow(y17,2)-0.8*y17+Math.Sqrt(y17))/(23.1*Math.Pow(n2,2) + Math.Cos(n2));
            Console.WriteLine($"H={H}");


            Console.WriteLine("Практическая работа №18");

            double R2, y18, k2;

            Console.WriteLine("Введите значение - y18");
            y18 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - k2");
            k2 = Convert.ToDouble(Console.ReadLine());

            R2 = (Math.Sqrt(Math.Pow(Math.Sin(y18),2) + 6.835))/(Math.Log(y18+k2) + 3 * Math.Pow(y18,2));
            Console.WriteLine($"R2={R2}");

            Console.WriteLine("Практическая работа №19");

            double E, y19, q;

            Console.WriteLine("Введите значение - y19");
            y19 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - q");
            q = Convert.ToDouble(Console.ReadLine());

            E = (Math.Log(0.7*y19 + 2 * q))/(Math.Sqrt(3*Math.Pow(y19,2)+0.5*y19 + 4));
            Console.WriteLine($"E={E}");


            Console.WriteLine("Практическая работа №20");

            double K, t6, l, y20, e7;

            Console.WriteLine("Введите значение - t6");
            t6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - l");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y20");
            y20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e7");
            e7 = Convert.ToDouble(Console.ReadLine());

            K = (2 * Math.Pow(t6, 2) + 3 * l + 7.2)/(Math.Log(y20 + Math.Pow(e7,2*l)));
            Console.WriteLine($"K={K}");


            Console.WriteLine("Практическая работа №21");

            double Q, k3, p, x, d2;

            Console.WriteLine("Введите значение - k3");
            k3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - p");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - d2");
            d2 = Convert.ToDouble(Console.ReadLine());

            Q = (Math.Sqrt(k3+2.6*p*Math.Sin(k3)))/(x-Math.Pow(d2,3));
            Console.WriteLine($"Q={Q}");


            Console.WriteLine("Практическая работа №22");

            double S, y21, t7;

            Console.WriteLine("Введите значение - y21");
            y21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - t7");
            t7 = Convert.ToDouble(Console.ReadLine());

            S = (4.351*Math.Pow(y21,3)+ 2 * t7 * Math.Log(t7))/(Math.Sqrt(Math.Cos(2*y)+4.351));
            Console.WriteLine($"S={S}");


            Console.WriteLine("Практическая работа №23");

            double R3, y22, d3, e8 ;

            Console.WriteLine("Введите значение - y22");
            y22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - d3");
            d3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e8");
            e8 = Convert.ToDouble(Console.ReadLine());

            R3 = (Math.Pow(Math.Sin(y),2)+0.3 * d3)/(Math.Pow(e8,y22) + Math.Log(d3));
            Console.WriteLine($"R3={R3}");


            Console.WriteLine("Практическая работа №24");

            double U2, k4, e9, y23;

            Console.WriteLine("Введите значение - k4");
            k4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e9");
            e9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y23");
            y23 = Convert.ToDouble(Console.ReadLine());

            U2 = (Math.Log(2*k4+4.3))/(Math.Pow(e9,k4+y23)+Math.Sqrt(y23));
            Console.WriteLine($"U2={U2}");


            Console.WriteLine("Практическая работа №25");

            double L2, c, t8;

            Console.WriteLine("Введите значение - c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - t8");
            t8 = Convert.ToDouble(Console.ReadLine());

            L2 = Math.Pow(Math.Cos(c),2) + (3*Math.Pow(t8,2)+4)/(Math.Sqrt(c+t8));
            Console.WriteLine($"L2={L2}");


            Console.WriteLine("Практическая работа №26");

            double T2, u, y24;

            Console.WriteLine("Введите значение - u");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y24");
            y24 = Convert.ToDouble(Console.ReadLine());

            T2 = (Math.Sin(2u))/(Math.Log(2*y24+u));
            Console.WriteLine($"T2={T2}");


            Console.WriteLine("Практическая работа №27");

            double Z2, p2, y25  ;

            Console.WriteLine("Введите значение - p2");
            p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y25");
            y25 = Convert.ToDouble(Console.ReadLine());

            Z2 = (Math.Pow(Math.Sin(p2+0.4),2))/(Math.Pow(y25,2)+7.325*p2);
            Console.WriteLine($"Z2={Z2}");


            Console.WriteLine("Практическая работа №28");

            double W2, v, e10, y26;

            Console.WriteLine("Введите значение - v");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e10");
            e10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y26");
            y26 = Convert.ToDouble(Console.ReadLine());

            W2 = (0.004*v + Math.Pow(e10,2*y26))/(Math.Pow(e10,y/2));
            Console.WriteLine($"W2={W2}");


            Console.WriteLine("Практическая работа №29");

            double T3, h3, e11, y27;

            Console.WriteLine("Введите значение - h3");
            h3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e11");
            e11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y27");
            y27 = Convert.ToDouble(Console.ReadLine());

            T3 = (0.355*Math.Pow(h3, 2)-4.355)/(Math.Pow(e11,y27+h3)+Math.Sqrt(2.7*y27));
            Console.WriteLine($"T3={T3}");


            Console.WriteLine("Практическая работа №30");

            double N2, y28, p3, e12;

            Console.WriteLine("Введите значение - y28");
            y28 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - p3");
            p3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e12");
            e12 = Convert.ToDouble(Console.ReadLine());

            N2 = (3*Math.Pow(y28,2)+Math.Sqrt(y28+1))/(Math.Log(p3 + y28)+Math.Pow(e12,p3));
            Console.WriteLine($"N2={N2}");

            //ВЫПОЛНИЛИ ЗАЙКА АРСЕНИЙ И МИХАИЛ КОСАЧЁВ 
        }
    }
}
