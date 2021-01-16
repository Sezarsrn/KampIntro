using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlama başlangıç kursu";
            string kurs3 = "java kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);

            //arya -dizi

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "Programlama başlangıç kursu", "java kursu" };


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
