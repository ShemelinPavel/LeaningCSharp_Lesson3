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
        #region Исходный код из методички
        struct Complex
        {
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


        }

        static void Task1()
        {

            string Welcome = "Вы выбрали задачу работы с комплексными числами\n";
            Welcome = Welcome + "Это так увлекательно!\n";
            Welcome = Welcome + "Давайте начнем.\n";

            ClassLibraryLesson3.PrintTaskWelcomeScreen(Welcome);

            string userAnwerAsString = ClassLibraryLesson3.MakeQuestion("ряд чисел разделенные пробелом");

            ClassLibraryLesson3.Pause();

        }

    }

}