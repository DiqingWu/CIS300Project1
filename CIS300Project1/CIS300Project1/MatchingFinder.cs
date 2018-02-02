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
            //Ceate a array 
            char[] chars = input.ToCharArray();
            int value = (int)(chars[0]); // if bugged try int value = Convert.Toint32(chars[0]);
            if (value > 0 && value < limit)
            {
                return value;
            }
            throw new IOException(exception);
        }
        private static Pairing[]  GetAllowableParirings(string[] input)
        {
            Pairing[] pairs = new Pairing[input.Length];
            string[] line;
            for(int i = 1; i < input.Length; i++)
            {
                line = input[i].Split(',');
                if (line[0] == line[1] || line[1] == line[2])
                {
                    throw new IOException();
                }
                //pairs[i].; 
            }
            return pairs;
        }
        private static void GetMatching()
        {

        }
        private static string FormatTournament(Pairing[] input)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
        public static string GetTournament()
        {
            return null;
        }

    }
}
