using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace sosukiiHOMEWORKforCpdeBlog_if_else__switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hello, how old are u honey ? Text me ur age, please... ");
            Console.ResetColor();
            int answerAGE = int.Parse(Console.ReadLine());
            
            if (answerAGE > 17) 
            {
                Console.WriteLine("Oh~ u are a biggy-piggy boyy ! Lets get started, press any key... ");
            }
            else
            {
                Console.WriteLine("Oh honey u are just a little sweetie-poo, doesn't it? <3 ");

            }
            //Console.ReadKey();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Well, thanks, now give me the random number. You'r number is...");
            Console.ResetColor();
            int answerRandomNumber = int.Parse(Console.ReadLine ());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You'r number is " + answerRandomNumber + ", okay, text me you'r plates number, please... ");
            Console.ResetColor();
            int answerPlateNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("We got three numbers of you: " + answerAGE+", " + answerRandomNumber+", " + answerPlateNumber + ". Lets compare them...");
            Thread.Sleep(3500);

            int[] array = { answerAGE, answerRandomNumber, answerPlateNumber};
            int maxValue = array.Max();
            Console.WriteLine();
            Console.WriteLine("So, our largest number is: "+maxValue);
            Thread.Sleep(2500);


            Console.WriteLine();
            Console.WriteLine(" ~ odd or even ~ ");
            Console.WriteLine();
            Thread.Sleep(1000);

            switch (answerAGE %2)
            {
                case 1:
                    Console.WriteLine("Number "+answerAGE + " is odd.");
                    break;
                default:
                    Console.WriteLine("Number "+answerAGE+ " is even.");
                    break;
            }

            switch (answerRandomNumber%2)
            {
                case 1:
                    Console.WriteLine("Number " + answerRandomNumber + " is odd.");
                    break;
                default:
                    Console.WriteLine("Number " + answerRandomNumber+ " is even.");
                    break;
            }
            
            switch (answerPlateNumber%2)
            {
                case 1:
                    Console.WriteLine("Number " + answerPlateNumber + " is odd.");
                    break;
                default:
                    Console.WriteLine("Number " + answerPlateNumber + " is even.");
                    break;

            }
            Thread.Sleep(2000);


            Console.WriteLine();
            string moreorlessthen100 = answerAGE < 100 ? "And you'r age-number ("+answerAGE+") less then 100" : "And you'r age-number More then 100";
            Console.WriteLine(moreorlessthen100);
            Thread.Sleep(1000);


            Console.WriteLine();
            Console.WriteLine("Thanks for Our cooperation <3 !");


        }
    }
}
