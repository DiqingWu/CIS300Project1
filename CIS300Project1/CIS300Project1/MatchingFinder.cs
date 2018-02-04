using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS300Project1
{
    public static class  MatchingFinder
    {
        
        private static int ValiddateElement(string input, int limit, int positionTaken ,string exception)
        {
            int value = Convert.ToInt32(input);
            if (value >= 0 && value < limit)
            {
                return value;
            }
            throw new IOException(exception);
        }
        private static Pairing[]  GetAllowableParirings(string[] input)
        {
            Pairing[] pairs = new Pairing[input.Length];
            string[] line;
            for(int i = 1; i < input.Length; i++) // part where differ array by 1;
            {
                line = input[i].Split(',');
                if (line[0] == line[1])
                {
                    throw new IOException();
                }
                else
                pairs[i]= new Pairing(Convert.ToInt32(line[0]), Convert.ToInt32(line[1]), Convert.ToInt32(line[2])); 
            }
            return pairs;
        }
        private static Pairing[] GetMatching(Pairing[] input, int tables)
        {
            bool[] playerInPosition = new bool[tables*2];
            Pairing[] tableInPosition = new Pairing[tables];
            Stack<int> backTracking = new Stack<int>();
            int currentLocation = 0;
            for (int i = 0; i < tables*2; i++)
            {

                if (backTracking.Count == tables)
                    return tableInPosition;
                else if (backTracking.Count > tables)
                {
                    backTracking.Pop();
                }
                else if (backTracking.Count < tables)
                {
                    /*
                    playerInPosition[i] = false;
                    playerInPosition[i + 1] = false;
                    tableInPosition[i] = null;
                    */
                    if(tableInPosition[i]==null)
                    if (playerInPosition[i] == false && playerInPosition[i + 1] == false)
                    {
                        playerInPosition[i] = true;
                        playerInPosition[i + 1] = true;
                        tableInPosition[i] = new Pairing(i, i+1, i);
                        backTracking.Push(i);
                        currentLocation++;
                    }

                    
                }
            }

            //if no matching found return null instead
            return null;
        }
        private static string FormatTournament(Pairing[] input)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<input.Length;i++)
            {
                sb.Append("Table "+ input[i]._Table+" : "+input[i]._FirstPlayer+" vs. "+input[i]._SecondPlayer+Environment.NewLine);
            }
            return sb.ToString();
        }

        public static string GetTournament(string name)
        {
            string input =  File.ReadAllText(name);
            return "test ok";
        }

    }
}
