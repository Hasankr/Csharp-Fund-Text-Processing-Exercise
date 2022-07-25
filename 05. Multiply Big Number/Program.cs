using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string reallyBigNUm = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sb = new StringBuilder();
            int remainder = 0;
            for (int i = reallyBigNUm.Length -1; i >= 0; i--)
            {
                char lastNum = reallyBigNUm[i];
                int lastNumAsDigit = int.Parse(lastNum.ToString());
                int result = num * lastNumAsDigit + remainder;
                sb.Append(result % 10);
                remainder = result / 10;
            }
            if (remainder != 0)
            {
                sb.Append(remainder);
            }
            StringBuilder reversedString = new StringBuilder();
            for (int i = sb.Length -1; i >= 0; i--)
            {
                reversedString.Append(sb[i]);
            }
            Console.WriteLine(reversedString);
        }
    }
}
