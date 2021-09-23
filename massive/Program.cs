using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tables = { 5, 6, 5, 2, 10 };
            bool isOpen = true;

            while (isOpen==true)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine("За столом " + (i + 1) + " свободно " + tables[i] + " мест");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Администрирование зала:");
                Console.WriteLine("1 - Забронировать места");
                Console.WriteLine("2 - Выйти из приложения");
                Console.Write("Выберите действие: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userTable, userPlace;
                        Console.Write("Выберите стол: ");
                        userTable = (Convert.ToInt32(Console.ReadLine())-1);
                        if (userTable < 0 || userTable >= tables.Length)
                        {
                            Console.WriteLine("Такого стола нет!");
                            break;
                        }
                        Console.Write("Выберите количество мест: ");
                        userPlace = Convert.ToInt32(Console.ReadLine());
                        if (userPlace <0 || userPlace>tables[userTable])
                        {
                            Console.WriteLine("Недостаточно мест");
                            break;
                        }
                        tables[userTable] -= userPlace;
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
