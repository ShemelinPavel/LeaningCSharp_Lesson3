/*
 
Shemelin Pavel

3.
*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей.
*/

namespace Lesson3
{
    using System;
    using ClassLibraryLesson3;

    partial class Lesson3
    {

        class RationalFraction
        {

            private int numerator;      //числитель
            private int denominator;    //знаменатель

            #region Приведение двух дробей к знаменателю
            #endregion Приведение двух дробей к знаменателю

            #region свойства
            public int Numerator
            {

                get
                {

                    return this.numerator;

                }

                set
                {

                    this.numerator = value;

                }

            }

            public int Denominator
            {

                get
                {

                    return this.denominator;

                }

                set
                {

                    this.denominator = value;

                }
                
            }
            #endregion свойства

            #region методы
            public static void ReductionDenominator(RationalFraction rfA, RationalFraction rfB, out RationalFraction rfC, out RationalFraction rfD)
            {
                rfC = rfA;
                rfD = rfB;

                if (!(rfC.denominator == rfD.denominator))
                {
                    
                    rfC.numerator = rfC.numerator * rfD.denominator;
                    rfD.numerator = rfD.numerator * rfC.denominator;

                }

            }

            public override string ToString()
            {

                return ($"{this.numerator} / {this.denominator}");

            }

            public RationalFraction Plus(RationalFraction b)
            {

                RationalFraction reducedFractionA, reducedFractionB; //дроби приведенные к знаменателю

                ReductionDenominator(this, b, out reducedFractionA, out reducedFractionB);

                RationalFraction newRationalFraction = new RationalFraction();
                newRationalFraction.Numerator = reducedFractionA.Numerator + reducedFractionB.Numerator;
                newRationalFraction.Denominator = reducedFractionA.Denominator;

                return newRationalFraction;

            }
            #endregion методы
            
        }

        static void Task3()
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

            #region инициализация переменных
            ClassComplex complexA = new ClassComplex();
            complexA.im = 2;
            complexA.re = 3;

            ClassComplex complexB = new ClassComplex();
            complexB.im = 5;
            complexB.re = 7;
            #endregion инициализация переменных

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

                if (!(menuExit)) ClassLibraryLesson3.Pause("Нажмите любую клавишу.");

            }

        }

    }

}