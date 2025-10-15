using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace NASA_Project_Human_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringItem = new string[] { "Box of matches", "Food concentrate", "50 feet of nylon rope", "Parachute silk",
            "Portable heating unit", "Two .45 caliber pistols", "One case of dehydrated milk", "Two 100 lb. tanks of oxygen",
            "Stellar map", "Self-inflating life raft", "Magnetic compass", "20 liters of water", "Signal flares",
            "First aid kit with injection needle", "Solar-powered FM receiver-transmitter"};
            int[] intRank = new int[15];

            int[] nasaRanking = { 15, 4, 6, 8, 13, 11, 12, 1, 3, 9, 14, 2, 10, 7, 5 };

            string[] nasaReasoning = new string[]
            {
                "Virtually worthless – no oxygen to sustain combustion.",
                "Efficient means of supplying energy requirements.",
                "Useful in scaling cliffs and tying injured together.",
                "Protection from the sun’s rays.",
                "Not needed unless on the dark side.",
                "Possible means of self-propulsion.",
                "Bulky duplication of food concentrate.",
                "Most pressing survival need – oxygen supply.",
                "Primary means of navigation – star patterns visible.",
                "CO2 bottle can be used for propulsion.",
                "Worthless – the Moon’s magnetic field isn’t polarized.",
                "Needed to replace fluid loss on light side.",
                "For distress signaling when mother ship is sighted.",
                "For treating injuries and medical needs.",
                "For short-range communication with mother ship."
            };
            
            bool intWhileLoopBool = false;
            int intUserInput = 0;
            int intItemRank;

            // array and variable declarations

            Console.WriteLine("Hello welcome to the NASA moon survival test. Please rank the given items in order of priority.");

            do
            {
                WriteArray(stringItem, intRank);
                if (DistinctRankCheck(intRank) == false)
                {
                    
                    Console.WriteLine("Which entry do you want to change? (Numbered 1-15)");

                    intUserInput = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (intUserInput > 0 && intUserInput < 15)
                    {
                        Console.WriteLine("Enter what rank you want for: " + stringItem[intUserInput]);
                        intItemRank = Convert.ToInt32(Console.ReadLine());
                        if (intItemRank > 0 && intItemRank < 16)
                        {
                            intRank[intUserInput] = intItemRank;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input >:(");
                            Console.Beep(400,1000);
                        }
                        // Displays list, grabs user input, and adds it to ranking. 
                    }
                    else
                    {
                        Console.WriteLine("Invalid input :(");
                        Console.Beep(200, 1000);
                    }
                    Console.Clear();
                }
                else
                {
                    intWhileLoopBool = true;
                    Console.WriteLine("Yipee!");
                    // unfinished. Will be used to compare user scores with NASA scores. 
                }
            }
            while (intWhileLoopBool == false);
            // loops until all ranks in list are different


        }

        static string ItemRank(int[] rank)
        {
            int[] intRank = new int[16];
            Console.WriteLine("1: Box of matches" + intRank[1] + "\n");
            return rank.ToString();
            // prototype Method. Currently nonfunctional
        }
        static void WriteArray(string[] array, int[] rank)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(i+1 + ": " + rank[i] + ". " + array[i]);
            }
            // Writes down the array and ranks given. 
        }
        static bool DistinctRankCheck (int[] rank)
            // Checks to see if any of the numbers in an array match eachother and returns as false if they do
        {
            bool boolCheck = true;
            if (boolCheck == true)
            {
                for (int i = 0; i < 15; i++)
                {
                    for (int n = 0; n < 15; n++)
                    {
                        if (i != n)
                        {
                            if (rank[i] == rank[n] || rank[i] <= 0)
                            {
                                boolCheck = false;
                            }
                        }
                    }
                }
            }
            return boolCheck;
        }
    }
}

