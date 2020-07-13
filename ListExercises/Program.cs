using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            
            Console.WriteLine(SumOfEven(numbersList));


            List<string> wordList = new List<string> { "hello", "food", "outdoors", "earth", "tacos" };
            fiveLetters(wordList);
            
        }

        static int SumOfEven(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    
                    sum += numbers[i];

                }
                
            }
            return sum;

        }

        static void fiveLetters(List<string> words)
        {
            Console.WriteLine("Enter a length: ");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            foreach (string word in words)
            {
                if (word.Length == length)
                {
                    
                    Console.WriteLine(word);
                }
            } 
        }

    }
}
