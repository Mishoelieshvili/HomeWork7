using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine($"Task 2");
        Console.WriteLine("...........\n");
        JackpotFound();
        Console.WriteLine("\n...........");

        Console.WriteLine($"Task 3");
        Console.WriteLine("...........\n");
        int totalPoints = CalculatePoints(3, 1, 1);
        Console.WriteLine("Total points: " + totalPoints);
        Console.WriteLine("\n...........");

        Console.WriteLine($"Task 5");
        Console.WriteLine("...........\n");
        Performances();
        Console.WriteLine("\n...........");

    }

    static void JackpotFound()
    {
        Console.Write("Enter jackpot characters: ");
        string[] input = Console.ReadLine().Split();

        // Check if all characters are the same
        bool jackpotFound = input.Length > 0 && input.All(c => c == input[0] && !string.IsNullOrWhiteSpace(c));

        if (jackpotFound)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    public static int CalculatePoints(int wins, int draws, int losses)
    {
        Console.Write("Enter the Wins, Draws, Losses: ");
        string[] input = Console.ReadLine().Split();

        int[] performances = Array.ConvertAll(input, int.Parse);
        int totalPoints = (wins * 3) + (draws * 1) + (losses * 0);

        return totalPoints;
    }

    static void Performances()
    { 
                Console.Write("Enter the daily performances separated by commas: ");
                string[] input = Console.ReadLine().Split(',');

                int[] performances = Array.ConvertAll(input, int.Parse);
                int count = 0;
       
                for (int i = 1; i < performances.Length; i++)
                {
                    if (performances[i] > performances[i - 1])
                    {
                        count++;
                    }
                }

         Console.WriteLine("The number of days Giorgi improved his performance is: " + count);
    }
}

