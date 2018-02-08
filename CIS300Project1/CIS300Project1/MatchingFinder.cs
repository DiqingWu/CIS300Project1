using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS300Project1
{
    /// <summary>
    /// MatchingFinder class
    /// get file location and get the match and format the match and print result.
    /// </summary>
    public static class  MatchingFinder
    {
        /// <summary>
        /// A private method to validate an input element
        /// </summary>
        /// <param name="input"></param>containing a single field from a line of input.
        /// <param name="limit"></param>giving an upper limit on a valid value contained in the field (i.e., the value should be strictly less than the limit).
        /// <param name="columnPosition"></param>giving the line number from which the element was taken.
        /// <param name="rowPosition"></param>containing the name of the field to be included in any exception that might need to be thrown (see the second bullet under "Exception Handling" above).
        /// <returns></returns>return an int containing the value represented by the first parameter.
        private static int ValiddateElement(string input, int limit, int columnPosition ,string rowPosition)
        {
            int value = Convert.ToInt32(input);
            if (value >= 0 && value < limit)
            {
                return value;
            }
            throw new IOException("Line "+ columnPosition +" "+ rowPosition);
        }
        /// <summary>
        /// A private method to get the allowable pairings from the input lines
        /// </summary>
        /// <param name="input"></param> a string[ ] whose elements are the lines from the input file
        /// <param name="tables"></param> an int giving the number of tables
        /// <returns></returns>return a Pairing[ ] containing the pairings from the input.
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
        /// <summary>
        /// A private method to find a matching
        /// </summary>
        /// <param name="input"></param>a Pairing[ ] containing all allowable pairings 
        /// <param name="tables"></param> an int giving the number of tables
        /// <returns></returns>return a Pairing[ ] containing the pairings in a matching
        private static Pairing[] GetMatching(Pairing[] input, int tables)
        {
            //A bool[ ] whose length is the number of players 
            bool[] playerInPosition = new bool[tables*2];
            //A Pairing[ ] whose length is the number of tables
            Pairing[] tableInPosition = new Pairing[tables];
            //A Stack<int> containing indices into the array of allowable pairings.
            Stack<int> backTracking = new Stack<int>();
            //An int giving the current location in the array of allowable pairings.
            int currentLocation = 0;

            while (backTracking.Count != 0 || input.Length > currentLocation)
            {
                if (backTracking.Count == tables)
                    return tableInPosition;
                else if (currentLocation >= input.Length)
                {
                    currentLocation = backTracking.Pop();
                    Pairing temp = input[currentLocation];
                    playerInPosition[temp._FirstPlayer] = false;
                    playerInPosition[temp._SecondPlayer] = false;
                    tableInPosition[temp._Table] = null;

                }
                else if (playerInPosition[input[currentLocation]._FirstPlayer] == false && playerInPosition[input[currentLocation]._SecondPlayer] == false && tableInPosition[input[currentLocation]._Table]==null)
                {

                        playerInPosition[input[currentLocation]._FirstPlayer] = true;
                        playerInPosition[input[currentLocation]._SecondPlayer] = true;
                        //if(tableInPosition[currentLocation]==null)
                        tableInPosition[input[currentLocation]._Table]= input[currentLocation];
                        backTracking.Push(currentLocation);
                    
                }
                currentLocation++;
            } 


            //if no matching found return null instead
            return null;
        }
        /// <summary>
        /// A private method to format the tournament round
        /// </summary>
        /// <param name="input"></param>a Pairing[ ] containing a matching.
        /// <returns></returns>return a string describing the corresponding tournament round as explained under "Output Format" above
        private static string FormatTournament(Pairing[] input)
        {
            if(input == null)
            {
                throw new IOException("Something wrong in the calclulation");
            }
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<input.Length;i++)
            {
                sb.Append("Table "+ input[i]._Table+" : "+input[i]._FirstPlayer+" vs. "+input[i]._SecondPlayer+Environment.NewLine);
            }
            return sb.ToString();
        }
        /// <summary>
        /// A public method to get a tournament round
        /// </summary>
        /// <param name="name"></param> a string giving the name of the input file as its only parameter.
        /// <returns></returns>return a string describing a valid tournament round. If no valid tournament round exists, it should return null
        public static string GetTournament(string name)
        {
            string[] lines = File.ReadAllLines(name);
            if (lines == null)
            {
                throw new IOException("Input file is empty!");
            }
            else if (Convert.ToInt32(lines[0]) <= 0)
            {
                throw new IOException("Input table on first line shows 0 or negative!");
            }
            int tables = Convert.ToInt32(lines[0]);
            string[] input = new string[lines.Length-1];
            for (int i = 1; i < lines.Length; i++)
                input[i-1] = lines[i];
            //return FormatTournament(GetAllowableParirings(input, tables));
            return FormatTournament(GetMatching(GetAllowableParirings(input,tables), tables));
        }

    }
}
