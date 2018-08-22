using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userKey;
            Console.WriteLine("Enter Data to be Encrypted");
            userInput = Console.ReadLine();
            Console.WriteLine("Enter the key");
            userKey = Console.ReadLine();

            int key = Convert.ToInt32(userKey);


            for (int i = 0; i < userInput.Length; i++)
            {

                if (userInput[i] != ' ')
                {
                    if ((int)userInput[i] >= 97)
                    {
                        int value = ((int)(userInput[i] - 'a' + key)) % 26;
                        Console.Write((char)(value + 'a'));
                    }
                    else
                    {
                        int value = ((int)(userInput[i] - 'A' + key)) % 26;
                        Console.Write((char)(value + 'A'));
                    }
                }
                else
                {
                    Console.Write("Please enter something");
                }
            }
            Console.ReadLine();
        }
    }
}