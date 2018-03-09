using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//descrypt
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedText = Console.ReadLine();
            encryptedText = encryptedText.ToUpper();

            Console.WriteLine(encryptedText);

            for(int i =0;i < 26; i++)
            {

            
            string output = "";
            foreach(char letter in encryptedText)
            {
                if(letter == ' ')
                {
                        output += " ";
                        continue;
                        
                }

                int letCode = ((int)(letter) + i - 65 )%26 + 65;
                char let = (char)letCode;
                output += let.ToString();
                
            }
            Console.WriteLine(i + " "+ output);

            }

            Console.Read();

        }
    }
}
