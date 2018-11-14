using System;
using System.Text.RegularExpressions;

namespace ClassLibraryLesson3
{
    public class ClassLibraryLesson3
    {

        public static void Pause()
        {

            Console.ReadKey();

        }

        public static void Pause(string message)
        {

            Console.WriteLine(message);
            Console.ReadKey();

        }
        
        public static void Print(string Text, bool EndOfString = true)
        {

            if (EndOfString)
            {
                Console.WriteLine(Text);
            }
            else
            {
                Console.Write(Text);
            }

        }

        public static void Print(string Text, params object[] arg)
        {

            Console.WriteLine(Text, arg);

        }

        public static string MakeQuestion(string questionText)
        {

            Print("Введите " + questionText + " : ", false);

            return Console.ReadLine();

        }

        public static void ClearScreen()
        {

            Console.Clear();

        }

        public static string[] SplitString(string s, string splitter = " ")
        {

            return Regex.Split(s, splitter);

        }

        public static void PrintTaskWelcomeScreen(string textMessage = "")
        {

            ClearScreen();
            Print(textMessage);

        }
    }

}
