using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Array_
    {
        private int[] array;

        public Array_(int sizeOfArray)
        {
            array = new int[sizeOfArray];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void Show(string str)
        {
            Console.Write("\n" + str);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine("\b\b \nСумма элементов: " + SumOfElements());
        }
        public int SumOfElements()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static bool operator > (Array_ object_1, Array_ object_2)
        {
            if (object_1.SumOfElements() > object_2.SumOfElements())
                return true;
            return false;
        }
        public static bool operator <(Array_ object_1, Array_ object_2)
        {
            if (object_1.SumOfElements() < object_2.SumOfElements())
                return true;
            return false;
        }
    }
}
