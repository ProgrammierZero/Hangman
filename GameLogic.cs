using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hangman
{
    class GameLogic
    {
        GameDesign design = new GameDesign();
        Random rand = new Random();
        string ansString;
        int questionPos;
        string question;
        string[] ansStringLetters;
        string[] ansStringHideLetters;
        bool isGame = true;
        int chosenLetterPosition = 0;

        int lengthOfAnswer;

        public GameLogic()
        {
            InitGame();
        }
        private void InitGame()
        {
            InitQuestion();
            InitAnswerString(questionPos);
            InitAnswerStringLetters();
            InitAnswerStringHideLetters();
            while (isGame)
            {
                design.WriteHangMan(design.proper.levelHang);
                WriteQuestion();
                WriteScore();
                DrawHideLetters();
                checkForLose();
                checkForWin();
                Console.Clear();
            }
        }
        private void InitQuestion()
        {
            int randomQuest = rand.Next(1, design.proper.questions.Length);
            questionPos = randomQuest;
            question = design.proper.questions[questionPos];
        }
        private void Reset()
        {
            InitQuestion();
            InitAnswerString(questionPos);
            InitAnswerStringLetters();
            InitAnswerStringHideLetters();
        }
        private void InitAnswerString(int PositionOfAnswer)
        {
            ansString = design.proper.answers[PositionOfAnswer];
        }
        private void InitAnswerStringLetters()
        {
            
            foreach (char i in ansString)
            {
                lengthOfAnswer++;
            }
            ansStringLetters = new string[lengthOfAnswer];
            int counter = 0;
            foreach (char i in ansString)
            {
                ansStringLetters[counter] = i.ToString();
                counter++;
            }
        }
        private void InitAnswerStringHideLetters()
        {
            ansStringHideLetters = new string[lengthOfAnswer + 1];
            for(int i = 0; i < lengthOfAnswer; i++)
            {
                ansStringHideLetters[i] = "_";
            }
        }
        private void DrawHideLetters()
        {
            Console.WriteLine();
            
            for (int i = 0; i < ansStringHideLetters.Length; i++)
            {
                
                Console.Write(ansStringHideLetters[i] + " ");

            }
            string key = Console.ReadKey().Key.ToString();
            Console.Write(key);
            if (key.ToLower() == ansStringLetters[chosenLetterPosition])
            {
                ansStringHideLetters[chosenLetterPosition] = key;
                chosenLetterPosition++;
            }
            else
            {
                design.proper.levelHang++;
            }
            
        }

        private void checkForLose()
        {
            if(design.proper.levelHang == 6)
            {
                isGame = false;
            }
        }
        private void checkForWin()
        {
            int countRight = 0;
            for(int i = 0; i < lengthOfAnswer; i++)
            {
                if(ansStringLetters[i] == ansStringHideLetters[i].ToLower())
                {
                    countRight++;
                }
            }

            if (countRight == lengthOfAnswer)
            {
                design.proper.Score++;
                design.proper.levelHang = 1;
                lengthOfAnswer = 0;
                chosenLetterPosition = 0;
                Reset();
            }
        }
        private void WriteScore()
        {
            Console.WriteLine();
            Console.Write("Your Score: " + design.proper.Score);
        }
        private void WriteQuestion()
        {
            Console.WriteLine();
            Console.Write(question);
        }
    }
}
