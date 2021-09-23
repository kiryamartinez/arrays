using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books = { {"Пушкин","Лермонтов","Глуховский" },{"Кинг","Лавкрафт","Стокер" },{"Донцова","Карр", "Толстой"} };

            while (isOpen==true)
            {
                Console.WriteLine("Добро пожаловать в библиотеку!");
                Console.WriteLine("\n1 - узнать что за книга по индексу \n2 - найти книгу по автору \n3 - вывести список всех книг\n4 - Выход");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int rows;
                        int cols;
                        Console.Write("Введите номер полки:");
                        rows = Convert.ToInt32(Console.ReadLine())-1;
                        Console.Write("\nВведите номер книги:");
                        cols = Convert.ToInt32(Console.ReadLine())-1;
                        Console.WriteLine("Это книга:" + books[rows,cols]);
                        break;
                    case 2:
                        string author;
                        Console.Write("Введите автора:");
                        author=Console.ReadLine();
                        bool authorFind = false;
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author==books[i,j])
                                {
                                    Console.WriteLine("Это книга находится по адресу " + (i + 1) + "|" + (j + 1));
                                    authorFind = true;
                                }

                            }
                        }
                        if (authorFind==false)
                        {
                            Console.WriteLine("Такой книги нет");
                        }

                        break;
                    case 3:
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i,j]+ "\n");
                            }
                        }
                        break;
                    case 4:
                        isOpen = false;
                        break;

                        
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
