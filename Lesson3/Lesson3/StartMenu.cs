namespace Lesson3
{
    using System;
    using ClassLibraryLesson3;

    partial class Lesson3
    {

        static void StartMenu()
        {

            string Welcome = "Добрый день, пользователь!\n";
            Welcome = Welcome + "Выберите чем бы Вы хотели заняться:\n";
            Welcome = Welcome + "Меню на сегодня:\n";
            Welcome = Welcome + "1 - Работа с комплексными числами\n";
            Welcome = Welcome + "2 - Подсчет числа знаков в числе\n";
            Welcome = Welcome + "3 - Сумма положительных нечетных чисел в ряду\n";

            Welcome = Welcome + "0 - Выход из программы\n";

            while (true)
            {

                ClassLibraryLesson3.PrintTaskWelcomeScreen(Welcome);

                ConsoleKeyInfo userChooseKey = Console.ReadKey(true);

                switch (userChooseKey.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Task1();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //Task2();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //Task3();
                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        Environment.Exit(0); // на выход
                        break;

                }
            }

        }

    }

}