using ConsoleApp1.models;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Math(); vurma cedveline aiddir.
            //1.  a massivinin (a[0],a[1] ....
            //a[n])  |a[i]| < c sertini odeyen elementlerini cap etmek
            //(c deyisheninin qiymeti istifadeciden sorushulur,hemcinin a massivinin elementleri de)

            //int c = Readint("c ededini daxil edin");

            //int len = Readint("daxil olunacaq massivde nece element olsun?: ");

            //int[] a = new int[len];



            //for (int i = 0; i < len; i++)
            //{


            //    a[i] = Readint($"massivin {i + 1}-ci elementini daxil edin");


            //}
            //for (int j = 0; j < len; j++)
            //{
            //    if (a[j] < c)
            //    {
            //        Console.Write(a[j]);
            //    }
            //}

            //static int Readint(string caption)
            //{
            //l1:
            //    Console.WriteLine(caption);
            //    string cStr = Console.ReadLine();
            //    bool state = int.TryParse(cStr, out int c);
            //    if (!state)
            //    {
            //        Console.WriteLine("tam eded daxil edin");
            //        goto l1;
            //    }
            //    return c;
            //}

            //static void Math()
            //{

            //    string text = "";
            //    int left = 0;


            //    for (int i = 2; i <= 9; i++)
            //    {
            //        for (int j = 1; j <= 10; j++)
            //        {
            //            text = ($"{i} x {j.ToString().PadLeft(2)} = {(i * j).ToString().PadLeft(2)}");

            //            Console.Write(text);

            //            Console.SetCursorPosition(left, Console.GetCursorPosition().Top + 1);
            //        }
            //        left = (text.Length + 5) * ((i - 1) % 4);
            //        Console.SetCursorPosition(left, i >= 5 ? 12 : 0);
            //    }
            //    Console.ReadKey();
            //}

            Console.WriteLine("Ad daxil edin");

            string name = Console.ReadLine();

            Console.WriteLine("Soyad daxil edin");
            string surname = Console.ReadLine();

            Console.WriteLine("Yas daxil edin");
            string age = Console.ReadLine();

            student student1 = new();
            student1.Name = name;
            student1.Surname = surname;
            student1.Age = age;


            //Adi soyadi age readline
            //age 18 yuxari olsun

            student[] studentmassiv = Array.Empty<student>();


        }
    }
}