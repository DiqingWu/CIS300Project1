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

        private static int ValiddateElement(string input, int limit, int columnPosition ,string rowPosition)
        {
            int value = Convert.ToInt32(input);
            if (value >= 0 && value < limit)
            {
                return value;
            }
            throw new IOException("Line "+ columnPosition +" "+ rowPosition);
        }
        private static Pairing[]  GetAllowableParirings(string[] input,int tables)
        {
            Pairing[] pairs = new Pairing[input.Length];
            string[] line;
            int limit = tables * 2;
            for(int i = 0; i < input.Length; i++) // part where differ array by 1;
            {
                line = input[i].Split(',');
                if (line[0] == line[1])
                {
                    throw new IOException("Line "+i+1+" First player and Second player are same.");
                }
                else
                pairs[i]= new Pairing(ValiddateElement(line[0],limit,i+1,"First Player not valid"), ValiddateElement(line[1], limit, i+1, "Second Player not valid"), ValiddateElement(line[2], tables, i+1, "Table not valid")); 
            }
            return pairs;
        }
        private static Pairing[] GetMatching(Pairing[] input, int tables)
        {
            bool[] playerInPosition = new bool[tables*2];
            Pairing[] tableInPosition = new Pairing[tables];
            Stack<int> backTracking = new Stack<int>();
            int currentLocation = 0;

            do//||ValiddateElement("1",1,1,"1")==0)
            {
                if (backTracking.Count == tables)
                    return tableInPosition;
                else if (backTracking.Count > tables)
                {
                    backTracking.Pop();
                    //backTracking.Push(currentLocation);
                    playerInPosition[currentLocation] = false;

                }
                else if (backTracking.Count < tables)
                {
                    if(playerInPosition[currentLocation]== false && playerInPosition[currentLocation + 1] == false)
                    {
                        playerInPosition[currentLocation] = true;
                        playerInPosition[currentLocation + 1] = true;
                        if(tableInPosition[currentLocation]==null)
                        tableInPosition[currentLocation]= input[currentLocation];
                        backTracking.Push(currentLocation);
                    }
                    currentLocation++;

                    /*
                    playerInPosition[i] = false;
                    playerInPosition[i + 1] = false;
                    tableInPosition[i] = null;
                    
                    if (tableInPosition[currentLocation] == null)
                        if (playerInPosition[currentLocation] == false && playerInPosition[currentLocation + 1] == false)
                        {
                            playerInPosition[currentLocation] = true;
                            playerInPosition[currentLocation + 1] = true;
                            tableInPosition[currentLocation] = new Pairing(currentLocation, currentLocation + 1, currentLocation);
                            backTracking.Push(currentLocation);
                            currentLocation++;
                        }
                     */


                }
            } while (backTracking.Count != 0 || tables * 2 > currentLocation);


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
            string[] lines = File.ReadAllLines(name);
            int tables = Convert.ToInt32(lines[0]);
            string[] input = new string[lines.Length-1];
            for (int i = 1; i < lines.Length; i++)
                input[i-1] = lines[i];
            return FormatTournament(GetAllowableParirings(input,tables));
        }

    }
}
