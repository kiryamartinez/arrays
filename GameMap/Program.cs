using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int userX = 4, userY = 6;
            Console.CursorVisible = false;
            char[] bag = new char[0];
            char[,] map =
            {   {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#','$',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#'},
                {'#',' ',' ','$',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ','#',' ',' ','$',' ','#',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ','$','$','#'},
                {'#',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#'},
                {'#',' ','$',' ',' ','#',' ',' ','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ','$','#'},
                {'#',' ',' ',' ',' ','#','$',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ','#',' ',' ','$',' ','#',' ',' ',' ','#'},
                {'#',' ',' ','$',' ','#',' ',' ',' ',' ','#',' ','$',' ','#'},
                {'#',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };
            while (true)
            {
                Console.SetCursorPosition(0,20);
                Console.Write("Cумка: ");
                for (int i  = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i]+" ");
                }

                Console.SetCursorPosition(0,0);
                for (int i = 0 ; i< map.GetLength(0); i++)
                {
                    for (int j = 0; j< map.GetLength(1); j++)
                    {
                        Console.Write(map[i,j]);
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write('W');
                
                ConsoleKeyInfo charKey = Console.ReadKey();

                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX-1,userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                }
                if (map[userX,userY] == '$')
                {
                    map[userX,userY] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length;i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = '$';
                    bag = tempBag;
                }
                Console.Clear();
            }
        }
    }
}
