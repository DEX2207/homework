using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace задачи
{
    internal class Program
    {
        static void Main(string[] args)
        {//1
         //Write("Введите предложение: ");
         //string a=ReadLine();
         //int b = 0;
         //int c = 1;
         //char[] chars = a.ToCharArray();
         //for (int i=0; i<a.Length; i++)
         //{

            //    if (c <= a.Length && b < a.Length) 
            //    {
            //        string mass = a.Replace(chars[b], chars[c]);
            //        StringBuilder sb = new StringBuilder(mass, c, 1, 100);
            //        Write(sb);
            //        mass = a.Replace(chars[c], chars[b]);
            //        StringBuilder sb2 = new StringBuilder(mass, b, 1, 100);
            //        Write(sb2);
            //        b += 2;
            //        c += 2;

            //    }

            //}

            //2
            Write("Введите предложение: ");
            string a=ReadLine();
            string[] mass = a.Split(new char[] { });
            int i;
            int lenght=1;
            for(i=1;i<mass.Length; i++)
            {
                if (mass[0].Length > mass[i].Length) 
                {
                    mass[0] = mass[i];
                }
                if (mass[lenght].Length > mass[i].Length) 
                {
                    mass[lenght] = mass[i];
                    lenght++;
                }
            }
            Write($"Самые короткие слова: {mass[0]} и {mass[lenght]}");
            Read();
        }
    }
}
