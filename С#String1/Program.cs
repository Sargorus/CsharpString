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

            for (int i = 0; i < sentence.Length; i++)
            {
                char symbolChar = sentence[i];
                if (char.IsLetter(symbolChar))
                {
                    letterCount += 1;
                }
                lengthSentence += 1;
            }

            double percentage = ((double)letterCount / (double)lengthSentence) * 100;
            percentage = Math.Round(percentage, 2);
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
