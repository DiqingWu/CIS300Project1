using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS300Project1
{
    class Pairing
    {
        public int _FirstPlayer { get; private set; }
        public int _SecondPlayer { get; private set; }
        public int _Table { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FirstPlayer"></param>
        /// <param name="SecondPlayer"></param>
        /// <param name="Table"></param>
        public Pairing(int FirstPlayer,int SecondPlayer,int Table)
        {
            _FirstPlayer = FirstPlayer;
            _SecondPlayer = SecondPlayer;
            _Table = Table;

        }

    }
}
