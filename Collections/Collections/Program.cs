using System;
using System.Collections.Generic

namespace LatihanList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNilai = new list<int>();

            listNilai.Add(70);
            listNilai.Add(100);
            listNilai.Add(85);

            int nilaiElement1 = listNilai[1];

            Console.WriteLine(nilaiElement1);
            Console.WriteLine();

            foreach (int nilai in listNilai)
            {
                Console.WriteLine(nilai);
            }

            Console.ReadKey();
        }
    }
}