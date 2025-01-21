

using System;
using System.Data.SqlTypes;
using System.Xml;

namespace lecture_19_1
{
    internal class Program
    {

        //1
        static void firstmethod(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }

        //2

        static void secondmethod(int s)
        {
            double s1 = 0.6213711922;
            double s3 = s + s1;
            Console.WriteLine(s3);
        }

        //3
        static void thirdmethod(int t1, int t2)
        {
            int t3 = 60;
            int t4 = (t1 * t3) + t2;
            Console.WriteLine($"Total:{t4}");
        }
        //4
        static void fourthmethod(int m)
        {
            int m1 = 60;
            int m2 = m / m1;
            int m3 = m % m1;
            Console.WriteLine($"{m2}Hours,{m3}Minutes");
        }

        //5
        static void fifthmethod(double f1, double f2)
        {
            if (f1 == f2)
            {
                Console.WriteLine("Equal");
            }
            else if (f1 > f2)
            {
                Console.WriteLine("Greater");
            }
            else if (f2 > f1)
            {
                Console.WriteLine("Smaller");
            }
        }
        //6
        static void smethod(double s1, double s2, double s3)
        {
            double sum = s1 + s2 + s3;
            Console.WriteLine($"Sum of digits:{sum}");
        }

        //7
        static void semethod(int se, int see)
        {
            if (se % see == 0)
            {
                Console.WriteLine("Divisible");
            }
        }
        //8
        static void vmethod(int v1, int v2, int v3)
        {
            if (v1 > v2 && v1 < v3)
            {
                Console.WriteLine($"The middle value is:{v1}");
            }
            else if (v2 > v1 && v2 < v3)
            {
                Console.WriteLine($"The middle value is:{v2}");



            }
            else if (v3 > v1 && v3 < v2)
            {
                Console.WriteLine($"The middle value is:{v3}");

            }
        }




        static void Main(string[] args)
        {

            //string greeting = "Hello";
            //Console.WriteLine(greeting);



            //string firstName = "John ";
            //string lastName = "Doe";
            //string name = firstName + lastName;
            //Console.WriteLine(name);

            //string fn = "John ";
            //string ln = "Doe";
            //string n = string.Concat(fn, ln);
            //Console.WriteLine(n);


            //string str1 = "GeeksForGeeks";
            //string upper = str1.ToUpper();
            //Console.WriteLine(upper);

            //string str2 = "GeeksForGeeks";
            //string upper2 = str2.ToLower();
            //Console.WriteLine(upper2);


            //double x = double.Parse("123")+ 4;

            //string y = 7 + "890";
            //Console.WriteLine(x);
            //Console.WriteLine(y);





            //1
            //double x =Convert.ToDouble (Console.ReadLine());
            //Console.WriteLine(x);
            ////Convert.ToInt32(x);
            //Console.WriteLine(Convert.ToInt32(x));


            ////2
            //int y = Convert.ToInt32 (Console.ReadLine());
            //string y1 = $"Your number is:{y}";
            //Console.WriteLine(y1);

            ////3
            //string z = "c# is fun!";
            //Console.WriteLine(z.ToUpper());
            //Console.WriteLine(z.ToLower());

            ////4  we allways said that console does read only string remmember

            //string fn = Console.ReadLine();
            //string ln = Console.ReadLine();
            //string full = fn + ln;
            ////Console.WriteLine(string.Concat(fn,ln));
            //Console.WriteLine(full);
            //Console.WriteLine(full.Length);

            //5  is up there becouse i do it as method

            //int a = Convert.ToInt32( Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //firstmethod(a, b);

            //6

            //int s =Convert.ToInt32( Console.ReadLine());
            //secondmethod(s);


            //7
            //int t1 =Convert.ToInt32( Console.ReadLine());
            //int t2 =Convert.ToInt32( Console.ReadLine());
            //thirdmethod(t1,t2);

            //8

            //int m = Convert.ToInt32 (Console.ReadLine());
            //fourthmethod(m);

            //9
            //double f1 = Convert.ToDouble(Console.ReadLine());
            //double f2 = Convert.ToDouble(Console.ReadLine());
            //fifthmethod(f1,f2);


            //10
            //double s1 =Convert.ToDouble(Console.ReadLine());
            //double s2 = Convert.ToDouble(Console.ReadLine());
            //double s3 = Convert.ToDouble(Console.ReadLine());
            //smethod(s1, s2, s3);

            //11

            //int[] l = { 1, 2, 3, 4, 5, 6 };
            //for (int i = l.Length-1; i >=0 ; i--)
            //{
            //    Console.Write(l[i]);
            //}

            //12
            //int se = Convert.ToInt32(Console.ReadLine());
            //int see = Convert.ToInt32(Console.ReadLine());
            //semethod(se, see);


            //13

            //int v1 = Convert.ToInt32(Console.ReadLine());
            //int v2 = Convert.ToInt32(Console.ReadLine());
            //int v3 = Convert.ToInt32(Console.ReadLine());

            //vmethod(v1, v2, v3);
        }
    }
            //14

            //        string v = Console.ReadLine();
            //        for (int i = 0; i > v.Length; i++)
            //        {
            //            int count = 0;
            //            if (v[i] == 'a' || v[i] == 'i' || v[i] == 'e' || v[i] == 'o' || v[i] == 'u')
            //            {


            //                int c = count();
            //                count++;

            //            }
            //            Console.WriteLine(c);
            //        }

            //    }
            //}
        }



