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

            #region поля
            private int numerator;      //числитель
            private int denominator;    //знаменатель
            #endregion поля

            #region конструктор
            public RationalFraction(int Num, int Denom)
            {

                if (Denom == 0)
                {
                    ThrowDenomError();
                }
                else
                {

                    this.numerator = Num;
                    this.denominator = Denom;

                }

            }
            #endregion конструктор

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

                    if (value == 0)
                    {

                        ThrowDenomError();

                    }
                    else
                    {

                        this.denominator = value;
                    }

                }

            }
            #endregion свойства

            #region методы
            private static void ThrowDenomError()
            {

                throw new ArgumentException("Знаменатель дроби не может быть равен 0!");

            }

            //приведение к общему знаменателю
            public static void ReductionDenominator(RationalFraction rfA, RationalFraction rfB, out RationalFraction rfC, out RationalFraction rfD)
            {

                if (!(rfA.denominator == rfB.denominator))
                {

                    rfC = new RationalFraction(rfA.numerator * rfB.denominator, rfA.denominator * rfB.denominator);
                    rfD = new RationalFraction(rfB.numerator * rfA.denominator, rfA.denominator * rfB.denominator);

                }
                else
                {

                    rfC = new RationalFraction(rfA.numerator, rfA.denominator);
                    rfD = new RationalFraction(rfB.numerator, rfB.denominator);
                    
                }

            }

            //НОД по Евклиду
            private static int GetNOD(int a, int b)
            {

                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {

                        a = a % b;

                    }
                    else
                    {

                        b = b % a;

                    }

                }

                return a + b;

            }

            //упрощение дроби через НОД
            public static RationalFraction Simplification(RationalFraction fr)
            {

                int nod = GetNOD(fr.numerator, fr.denominator);

                return new RationalFraction(fr.numerator / nod, fr.denominator / nod);

            }

            public string ToString(bool simlification = false)
            {

                RationalFraction value;

                if (simlification)
                {

                    value = Simplification(this);

                }
                else
                {

                    value = this;

                }

                return ($"{value.numerator} / {value.denominator}");

            }

            public RationalFraction Plus(RationalFraction b)
            {

                RationalFraction reducedFractionA, reducedFractionB; //дроби приведенные к знаменателю

                ReductionDenominator(this, b, out reducedFractionA, out reducedFractionB);

                return new RationalFraction(reducedFractionA.numerator + reducedFractionB.numerator, reducedFractionA.denominator);

            }

            public RationalFraction Minus(RationalFraction b)
            {

                RationalFraction reducedFractionA, reducedFractionB; //дроби приведенные к знаменателю

                ReductionDenominator(this, b, out reducedFractionA, out reducedFractionB);

                return new RationalFraction(reducedFractionA.numerator - reducedFractionB.numerator, reducedFractionA.denominator);

            }

            public RationalFraction Multi(RationalFraction b)
            {

                return new RationalFraction(this.numerator * b.numerator, this.denominator * b.denominator);

            }

            public RationalFraction Dev(RationalFraction b)
            {

                return new RationalFraction(this.numerator * b.denominator, this.denominator * b.numerator);

            }
            #endregion методы

        }

        static void Task3()
        {

            string Welcome = "Вы выбрали задачу работы с комплексными числами\n";
            Welcome = Welcome + "Это так весело!\n";
            Welcome = Welcome + "Давайте начнем.\n";
            Welcome = Welcome + "1 - Сложение дробей\n";
            Welcome = Welcome + "2 - Вычитание дробей\n";
            Welcome = Welcome + "3 - Умножение дробей\n";
            Welcome = Welcome + "4 - Деление дробей\n";
            Welcome = Welcome + "0 - Выход в предыдущее меню\n";

            ClassLibraryLesson3.PrintTaskWelcomeScreen(Welcome);

            bool menuExit = false;

            #region инициализация переменных
            RationalFraction frA = new RationalFraction(6, 3);
            RationalFraction frB = new RationalFraction(3, 4);
            #endregion инициализация переменных

            while (!(menuExit))
            {

                ClassLibraryLesson3.PrintTaskWelcomeScreen(Welcome);

                ConsoleKeyInfo userChooseKey = Console.ReadKey(true);

                switch (userChooseKey.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        ClassLibraryLesson3.Print($"Операция: дробь: <{frA.ToString()}> + дробь: <{frB.ToString()}> = <{frA.Plus(frB).ToString(true)}>");
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        ClassLibraryLesson3.Print($"Операция: дробь: <{frA.ToString()}> - дробь: <{frB.ToString()}> = <{frA.Minus(frB).ToString(true)}>");
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        ClassLibraryLesson3.Print($"Операция: дробь: <{frA.ToString()}> * дробь: <{frB.ToString()}> = <{frA.Multi(frB).ToString(true)}>");
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        ClassLibraryLesson3.Print($"Операция: дробь: <{frA.ToString()}> / дробь: <{frB.ToString()}> = <{frA.Dev(frB).ToString(true)}>");
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