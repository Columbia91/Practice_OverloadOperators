using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped parallelepiped_1 = new Parallelepiped(10,15,20);
            Parallelepiped parallelepiped_2 = new Parallelepiped(5, 15, 40);

            parallelepiped_1.Show("Параллелепипед 1");
            parallelepiped_2.Show("Параллелепипед 2");

            Console.WriteLine("Эти фигуры равны: " + 
                (parallelepiped_1 == parallelepiped_2));
            Console.WriteLine("Эти фигуры не равны: " +
                (parallelepiped_1 != parallelepiped_2));

            const int ARRAY_SIZE = 10;

            Array_ firstArray = new Array_(ARRAY_SIZE);
            Array_ secondArray = new Array_(ARRAY_SIZE);
            Random rnd = new Random();

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                firstArray[i] = rnd.Next(10);
                secondArray[i] = rnd.Next(10);
            }
            Console.Write("--------------------------------------\n");
            firstArray.Show("Массив I: ");
            secondArray.Show("Массив II: ");

            Console.WriteLine("\nМассив I больше чем Массив II: " +
                (firstArray > secondArray));
            Console.WriteLine("Массив I меньше чем Массив II: " +
                (firstArray < secondArray));
            Console.ReadLine();
        }
    }
}
