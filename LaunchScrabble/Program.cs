using System;
using System.Collections;

namespace LaunchScrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            //Have user input a list of comma separated words
            Console.WriteLine("Enter a comma-separated list of words: ");
            //Convert user input to an array of words
            string listOfWords = Console.ReadLine();
            string[] arrayOfWords = listOfWords.Split(',');

            //for each word...
            int score = 0;
            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                arrayOfWords[i] = arrayOfWords[i].ToLower().Trim();
            }
            //check if word starts with 'q'. If so, check if next letter is "u"
            //if it is not, return score of "0" 
            //if it is, add 10 to score
            //else add 1 to score
            foreach (string word in arrayOfWords)
            {
                char firstChar = word[0];
                char secondChar = word[1];

                if (firstChar == 'q')
                {
                    if (secondChar != 'u')
                    {
                        score = 0;
                        break;
                    }
                    else if(secondChar == 'u')
                    {
                        score = score + 10;
                    }
                }
                else
                {
                    score = score + 1;
                }
            }
            
            //return score
            Console.WriteLine(score);
            Console.ReadLine();
        }

        public static void JoinAndSplitArrayExample()
        {
            int[] numbers = { 1, 2, 2, 3, 6, 33 };
            string output = String.Join(',', numbers);
            Console.WriteLine(output);

            string someNumberString = "23,64,33,9,101";
            string[] someStringArray = someNumberString.Split(',');
            int[] someIntArray = new int[someNumberString.Length];

            for (int i = 0; i < someStringArray.Length; i++)
            {
                int number = Convert.ToInt32(someNumberString);
                someIntArray[i] = number;
            }
            Console.ReadLine();
        }

    }
}
