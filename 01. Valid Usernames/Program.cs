using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            List<string> validUsernames = new List<string>();
            foreach (var userName in input)
            {
                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    bool isValid = true;
                    for (int i = 0; i < userName.Length; i++)
                    {

                        char currentChar = userName[i];
                        if (!(currentChar == '-' || currentChar == '_' || char.IsDigit(currentChar) || char.IsLetter(currentChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        validUsernames.Add(userName);
                    }
                    
                }
                
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }
    }
}
