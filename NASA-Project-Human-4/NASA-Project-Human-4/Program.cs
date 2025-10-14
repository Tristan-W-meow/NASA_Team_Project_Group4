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
            // array declarations

            WriteArray(stringItem, intRank);

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
                Console.WriteLine(rank[i] + ". " + array[i]);
            }
            // Writes down the array and ranks given. 
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

        }
    }
}

