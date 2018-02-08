using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS300Project1
{
/// <summary>
/// data stucture pairing 
/// </summary>
    class Pairing
    {
        /// <summary>
        /// gets an int giving the first player.
        /// </summary>
        public int FirstPlayer { get; private set; }
        /// <summary>
        ///  gets an int giving the second player.
        /// </summary>
        public int SecondPlayer { get; private set; }
        /// <summary>
        /// gets an int giving the table.
        /// </summary>
        public int Table { get; private set; }
        /// <summary>
        /// constructor of pairing class
        /// </summary>
        /// <param name="FirstPlayer"></param>an int giving the first player.
        /// <param name="SecondPlayer"></param>an int giving the second player.
        /// <param name="Table"></param>an int giving the table.
        public Pairing(int FirstPlayer1,int SecondPlayer1,int Table1)
        {
            FirstPlayer = FirstPlayer1;
            SecondPlayer = SecondPlayer1;
            Table = Table1;

         
        }

    }
}
