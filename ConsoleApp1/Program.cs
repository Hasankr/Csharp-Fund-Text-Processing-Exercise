using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                double number = double.Parse(item.Substring(1, item.Length - 2));
                double result = 0;
                
                
                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    int firstLtterPositionInTheAlphabet = firstLetter - 64;
                    result = number / firstLtterPositionInTheAlphabet;
                }
                else
                {
                     int firstLtterPositionInTheAlphabet = firstLetter - 96;
                    result = number * firstLtterPositionInTheAlphabet;
                }
                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int lastLtterPositionInTheAlphabet = lastLetter - 64;
                    sum += result - lastLtterPositionInTheAlphabet;
                }
                else
                {
                    int lastLtterPositionInTheAlphabet = lastLetter - 96;
                    sum += result + lastLtterPositionInTheAlphabet;
                }
            }
            Console.WriteLine($"{sum:f2}");
        
        
        }
    }
}
