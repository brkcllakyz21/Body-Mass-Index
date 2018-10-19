using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_Mass_Index
{
    class Program
    {
        static void Main(string[] args)
        {

            //Boyu ile kilosu girilen kişinin vücut kitle endeksine göre hangi kategoride olduğunu gösteren programın algoritmasını tasarlayınız.

            double boy = 0, kilo = 0, indeks = 0;

            Console.WriteLine("Boyunuzu Giriniz(metre cinsinden) : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilonuzu Giriniz(kilogram cinsinden) : ");
            kilo = Convert.ToDouble(Console.ReadLine());

            indeks = kilo / (Math.Pow(boy, 2));

            if (0 == indeks || indeks <= 18.4)
            {
                Console.WriteLine("Zayıfsınız.");
            }
            else if (18.5 == indeks || indeks <= 24.9)
            {
                Console.WriteLine("Normalsiniz.");
            }
            else if (25 == indeks || indeks <= 29.9)
            {
                Console.WriteLine("Fazla Kilolusunuz.");
            }
            else if (30 == indeks || indeks <= 34.9)
            {
                Console.WriteLine("1.Sınıf Obezsiniz.");
            }
            else if (35 == indeks || indeks <= 44.9)
            {
                Console.WriteLine("2.Sınıf Obezsiniz.");
            }
            else
            {
                Console.WriteLine("3.Sınıf Obezsiniz.");
            }

        }
    }
}
