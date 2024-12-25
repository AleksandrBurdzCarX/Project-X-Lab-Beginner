using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_X_Lab_Beginner
{
    internal class Program
    {
        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                Console.WriteLine($"{street} {number}");
            }
        }
        static void Main(string[] args)
        {
            {
                House tower = new House();
                tower.street = "Красная";
                tower.number = 50;

                tower.Print();
            }
            //int a = 5;
            //int b = 7;
            //int c = 10;
            //if (b > a)
            //{
            //    Console.WriteLine($"число {b} больше числа {a}");
            //}
            //else if (b < a)
            //{
            //    Console.WriteLine($"число {b} меньше числа {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"число {b} равно числу {a}");
            //}


            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int i = 0;
            //while (i <= 10)
            //{
            //        Console.WriteLine(i);
            //}


            //{
            //    int[] numbers = new int[5];
            //    int[] numbers2 = { 5, 6, 7, 8, 9 };
            //    numbers2[4] = 15;
            //    Console.WriteLine(numbers2[4]);
            //}


            //{
            //    void Helloworld()
            //    {
            //        Console.WriteLine("Helloworld");
            //    }
            //    void Sum(int a, int b)
            //    {
            //        int sum = a + b;
            //        Console.WriteLine(sum);
            //    }
            //    void Human(string name, int age)
            //    { 
            //        Console.WriteLine($"{name} {age}");
            //    }
            //    Human("Aleksandr", 35);
            //}

        }
    }
}