using System;

namespace С_String1
{
    public class Logic
    {
        public static double PercentageLetters(string inputSentence)
        {
            var sentence = inputSentence;
            if (string.IsNullOrEmpty(sentence))
            {
                return -1; // будет кодом ошибки: путое предложение
            }

            var letterCount = 0;
            var lengthSentence = 0;
            foreach (char symbolChar in sentence)
            {
                if (char.IsLetter(symbolChar))
                {
                    letterCount += 1;
                }
                lengthSentence += 1;
            }

            double percentage = ((double)letterCount / (double)lengthSentence) * 100;
            // Console.WriteLine($"Количество букв = : {letterCount}");
            // Console.WriteLine($"Длинна предложения  = : {lengthSentence}");
            return percentage;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            var inputSentence = Console.ReadLine();

            var percentage = Logic.PercentageLetters(inputSentence);

            Console.WriteLine($"Доля букв в предложении: {percentage} %");
        }
    }
}
