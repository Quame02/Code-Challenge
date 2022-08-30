using System;
using System.Linq;

namespace Code_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a paragraph");
            string paragraph = Console.ReadLine();
            Console.WriteLine(Paragraph(paragraph));

            Console.WriteLine("Enter array of integers");
            int[] array =int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnYesorNo(array));
        }

        static string Paragraph(string paragraph)
        {
            
            var count = 0;
            string bannedWords = string.Empty;
            
            for (int i = 0; i < paragraph.Length; i++)
            {
                if (paragraph[i].Equals("Unique"))
                {
                    bannedWords = bannedWords.Remove(i, 1);
                    count++;
                    break;
                }
            }
            return count;
        }

        static bool ReturnYesorNo(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int halfArray = (array.Length/2);
                for  (int j = 0; j < halfArray; j++)
                {
                    if (array.Length[i].Sum() == halfArray[j].Sum())
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
            }
        }
    }

}
