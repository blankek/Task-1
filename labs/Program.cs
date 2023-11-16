using System;
using System.Collections.Generic;

namespace labs
{
    internal class Program
    {
        public static void Main()
        {
            Prowerka();
        }
        public static void Prowerka()
        {
            List<float> numbers = new List<float>();
            while (true)
            {
                Console.WriteLine("Введите число");
                string str = Console.ReadLine();
                if (str == "q" || str.Length == 0)
                {
                    break;
                }
                if (int.TryParse(str, out int intNumber))
                {
                    if (intNumber >= 0)
                    {
                        Console.WriteLine("+");
                        numbers.Add(intNumber);
                    }
                    else
                    {
                        Console.WriteLine("-");
                        numbers.Add(intNumber);
                    }
                }
                else if (float.TryParse(str, out float floatNumber))
                {
                    if (floatNumber == numbers.Last())
                    {
                        break;
                    }
                    else
                    {
                        numbers.Add(floatNumber);
                    }
                }
            }
        }
    }
}