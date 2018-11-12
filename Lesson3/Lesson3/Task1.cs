/*
 
Shemelin Pavel

1.
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.

*/

namespace Lesson3
{
    using System;
    using ClassLibraryLesson3;

    partial class Lesson3
    {
        //вводим имя типа т.к. в проекте есть одноименный класс
        struct StruComplex
        {
            #region Исходный код из методички
            public double im;
            public double re;
            //  в C# в структурах могут храниться также действия над данными
            public StruComplex Plus(StruComplex x)
            {
                StruComplex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            //  Пример произведения двух комплексных чисел
            public StruComplex Multi(StruComplex x)
            {
                StruComplex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public override string ToString()
            {
                return re + "+" + im + "i";
            }
            #endregion Исходный код из методички

            #region Реализация метода вычитания комплесных чисел
            public StruComplex Minus(StruComplex x)
            {

                StruComplex y;

                y.im = im - x.im;
                y.re = re - x.re;
                return y;

            }
            #endregion Реализация метода вычитания комплесных чисел

        }

        class ClassComplex
        {

            #region Исходный код из методички
            // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
            public double im;
            public double re;

            public ClassComplex Plus(ClassComplex x2)
            {

                ClassComplex x3 = new ClassComplex();

                x3.im = this.im + x2.im;
                x3.re = this.re + x2.re;

                return x3;

            }

            public override string ToString()
            {
                return re + "+" + im + "i";
            }
            #endregion Исходный код из методички

            #region Реализация метода вычитания и произведения комплесных чисел

            public ClassComplex Minus(ClassComplex x2)
            {

                ClassComplex x3 = new ClassComplex();

                x3.im = this.im - x2.im;
                x3.re = this.re - x2.re;

                return x3;

            }

            public ClassComplex Multu(ClassComplex x2)
            {

                ClassComplex x3 = new ClassComplex();

                /*
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                */

                x3.im = this.re * x2.im + this.im * x2.re;
                x3.re = this.re * x2.re - this.im * x2.im;

                return x3;

            }

            #endregion Реализация метода вычитания и произведения комплесных чисел

        }

        static void Task1()
        {

            string Welcome = "Вы выбрали задачу работы с комплексными числами\n";
            Welcome = Welcome + "Это так увлекательно!\n";
            Welcome = Welcome + "Давайте начнем.\n";
            Welcome = Welcome + "1 - Сложение комплесных чисел\n";
            Welcome = Welcome + "2 - Вычитание комплесных чисел\n";
            Welcome = Welcome + "3 - Умножение комплесных чисел\n";
            Welcome = Welcome + "0 - Выход в предыдущее меню\n";

            ClassLibraryLesson3.PrintTaskWelcomeScreen(Welcome);

            #region работа структуры 
            /*
            StruComplex complexA = new StruComplex();
            complexA.im = 2;
            complexA.re = 2;

            StruComplex complexB = new StruComplex();
            complexB.im = 5;
            complexB.re = 7;

            ClassLibraryLesson3.Print($"Операция: комп. число: {complexB.ToString()} - комп. число: {complexA.ToString()} = {complexB.Minus(complexA)}");
            */
            #endregion работа структуры 

            bool menuExit = false;

            //инициализация переменных
            ClassComplex complexA = new ClassComplex();
            complexA.im = 2;
            complexA.re = 3;

            ClassComplex complexB = new ClassComplex();
            complexB.im = 5;
            complexB.re = 7;

            while (!(menuExit))
            {

                ClassLibraryLesson3.PrintTaskWelcomeScreen(Welcome);

                ConsoleKeyInfo userChooseKey = Console.ReadKey(true);

                switch (userChooseKey.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        ClassLibraryLesson3.Print($"Операция: комп. число: {complexA.ToString()} + комп. число: {complexB.ToString()} = {complexA.Plus(complexB)}");
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        ClassLibraryLesson3.Print($"Операция: комп. число: {complexA.ToString()} - комп. число: {complexB.ToString()} = {complexA.Minus(complexB)}");
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        ClassLibraryLesson3.Print($"Операция: комп. число: {complexA.ToString()} * комп. число: {complexB.ToString()} = {complexA.Multu(complexB)}");
                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        menuExit = true; // на выход
                        break;

                }

                if (!(menuExit)) ClassLibraryLesson3.Pause("Нажмите люубую клавишу.");

            }

        }
                    
    }

}