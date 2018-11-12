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
        
        struct Complex
        {
            #region Исходный код из методички
            public double im;
            public double re;
            //  в C# в структурах могут храниться также действия над данными
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            //  Пример произведения двух комплексных чисел
            public Complex Multi(Complex x)
            {
                Complex y;
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
            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }
            #endregion Реализация метода вычитания комплесных чисел

        }

        static void Task1()
        {

            string Welcome = "Вы выбрали задачу работы с комплексными числами\n";
            Welcome = Welcome + "Это так увлекательно!\n";
            Welcome = Welcome + "Давайте начнем.\n";

            ClassLibraryLesson3.PrintTaskWelcomeScreen(Welcome);

            Complex complexA = new Complex();
            complexA.im = 2;
            complexA.re = 2;

            Complex complexB = new Complex();
            complexB.im = 5;
            complexB.re = 7;

            Complex complexB_minus_A = complexB.Minus(complexA);

            ClassLibraryLesson3.Print($"Операция: комп. число: {complexB.ToString()} - комп. число: {complexA.ToString()} = {complexB_minus_A.ToString()}");

            ClassLibraryLesson3.Pause();

        }

    }

}