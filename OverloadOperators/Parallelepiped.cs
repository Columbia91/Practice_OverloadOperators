using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Parallelepiped
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public static int Count { get; set; }
        
        public Parallelepiped(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Count++;
        }
        public void Show(string str)
        {
            Console.WriteLine(str +
                "\nСторона А: " + SideA +
                "\nСторона B: " + SideB +
                "\nСторона C: " + SideC +
                "\nОбъем тела: " + Volume() + "\n");
        }
        public int Volume()
        {
            return SideA * SideB * SideC;
        }
        public static bool operator !=(Parallelepiped object_1, Parallelepiped object_2)
        {
            if(object_1.Volume() != object_2.Volume())
                return true;
            return false;
        }
        public static bool operator == (Parallelepiped object_1, Parallelepiped object_2)
        {
            if (object_1.Volume() == object_2.Volume())
                return true;
            return false;
        }
    }
}
