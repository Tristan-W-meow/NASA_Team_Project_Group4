using System.Collections.Generic;
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
            int[] intRank = new int[14];
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
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(rank[i] + ". " + array[i]);
            }
           // Writes down the array and ranks given. 
        }
    }
}

