using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class GameProperties
    {
        public string[] questions = {"Thing without which people can't alive.", "Which chemic element has name Aurum.", "Star of our sun system.", "How much meters in one kilometer" };
        public string[] answers = {"water", "gold", "sun", "thousand" };
        public string[,] HangMan = { {"          ",
                               "          ",
                               "         |",
                               "         |",
                               "         |"}, 
                               {
                               "        -|",
                               "         |",
                               "         |",
                               "         |",
                               "         |"
                                },
                               {
                               "    -----|",
                               "         |",
                               "         |",
                               "         |",
                               "         |"
                               },
                               {
                               "    -----|",
                               "    |    |",
                               "    O    |",
                               "         |",
                               "         |"
                               },
                               {
                               "    -----|",
                               "    |    |",
                               "    O    |",
                               "   /|\\   |",
                               "         |"
                               },
                               {
                               "    -----|",
                               "    |    |",
                               "    O    |",
                               "   /|\\   |",
                               "   / \\   |"
                               }};
        public int Score = 0;
        public int levelHang = 1;

    }
}
