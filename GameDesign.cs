using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class GameDesign
    {
        public GameProperties proper = new GameProperties();
        public void WriteHangMan(int levelHang)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(proper.HangMan[levelHang - 1, i]);
            }
        }
    }
}
