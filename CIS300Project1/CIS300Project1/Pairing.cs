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
        public int _FirstPlayer { get; private set; }
        /// <summary>
        ///  gets an int giving the second player.
        /// </summary>
        public int _SecondPlayer { get; private set; }
        /// <summary>
        /// gets an int giving the table.
        /// </summary>
        public int _Table { get; private set; }
        /// <summary>
        /// constructor of pairing class
        /// </summary>
        /// <param name="FirstPlayer"></param>an int giving the first player.
        /// <param name="SecondPlayer"></param>an int giving the second player.
        /// <param name="Table"></param>an int giving the table.
        public Pairing(int FirstPlayer,int SecondPlayer,int Table)
        {
            _FirstPlayer = FirstPlayer;
            _SecondPlayer = SecondPlayer;
            _Table = Table;

        }

    }
}
