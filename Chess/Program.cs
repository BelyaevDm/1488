using System;

namespace Chess
{
    class Program
    {
        public static void CheckInput()
        {
            Console.Write("Введите начальную координату: ");
            string aStartPlace = Console.ReadLine();
            Console.Write("Введите конченую координату: ");
            string aFinishPlace = Console.ReadLine();
            bool aErrors = false;
            if (aStartPlace.Length !=2 || aFinishPlace.Length != 2)
            {
                aErrors = true;
            }
            else
            {
                for (int i = 0; i < aStartPlace.Length; i++)
                {
                    if (aStartPlace[0] > 'H' || aStartPlace[0] < 'A' || aFinishPlace[0] > 'H' || aFinishPlace[0] < 'A')
                    {
                        aErrors = true;
                    }
                    if (aStartPlace[1] > 8 || aStartPlace[1] < 1 || aFinishPlace[1] > 8 || aFinishPlace [1] < 1)
                    {
                        aErrors = true;
                    }
                }
            }
            if (aErrors)
            {
                Console.WriteLine("Ошибка в координатах");
            }
        }

        static void Main(string[] args)
        {
            char[] board; 
        }
    }
}
