﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using LAB_3_Bulygina;

namespace LAB_3_Bulygina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3");

            Console.Title = "Булыгина Светлана, ИУ5Ц-51Б";


            // Объект класса Rectangle
            Rectangle rect = new Rectangle(2, 4);
            rect.Print();

            // Объект класса 
            Square square = new Square(5);
            square.Print();

            // Объект класса 
            Circle circle = new Circle(3);
            circle.Print();

            //коллекция класса ArrayList
            ArrayList figures = new ArrayList();
            figures.Add(circle);
            figures.Add(rect);
            figures.Add(square);
            Console.WriteLine("\nДо сортировки для ArrayList");
            foreach (var i in figures)
            {
                Console.WriteLine(i);
            }
            figures.Sort();
            Console.WriteLine("\nПосле сортировки для ArrayList");
            foreach (var i in figures)
            {
                Console.WriteLine(i);
            }

            //коллекция класса List<Figure>
            List<Figure> figures1 = new List<Figure>();
            figures1.Add(circle); //добавление в коллекцию
            figures1.Add(rect);
            figures1.Add(square);
            Console.WriteLine("\n\nДо сортировки для List<Figure>:");
            foreach (var i in figures1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nПосле сортировки для List<Figure>:");
            figures1.Sort();
            foreach (var i in figures1)
            {
                Console.WriteLine(i);
            }

            //создание разреженной матрицы
            Console.WriteLine("\n\nМатрица:");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0] = rect;
            matrix[1, 1] = square;
            matrix[2, 2] = circle;
            Console.WriteLine(matrix.ToString());

            //использование коллекции SimpleList
            SimpleList<Figure> list = new SimpleList<Figure>();
            list.Add(circle);
            list.Add(rect);
            list.Add(square);
            Console.WriteLine("\n\nПеред сортировкой (SimpleList):");
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
            list.Sort();
            Console.WriteLine("\n\nПосле сортировки (SimpleList):");
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }

            //использование собственного стека
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(circle);
            stack.Push(rect);
            stack.Push(square);
            Console.WriteLine("\n\nИспользование стека:");
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadKey();
        }
    }
}

