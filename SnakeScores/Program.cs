using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeScores
{
    class Program
    {
        #region Constants

        private const string SCORES_FILENAME = @"../../data/scores.xml";

        #endregion Constants

        #region Entry point

        static void Main(string[] args)
        {
            // Deserialization from disk
            Score.LoadData(SCORES_FILENAME);

            // Enter the students
            for (;;)
            {

                Console.WriteLine("Enter a student firstname (empty to finish)");
                String userName = Console.ReadLine();
                if (String.IsNullOrEmpty(userName)) break;

                Console.WriteLine("Enter the student mark");
                Int32 userScore = Int32.Parse(Console.ReadLine());

                // Add student in the array
                Score.RegisterScore(userName, userScore);
            }

            // Dump the current student list
            Score.ConsoleDump();

            // Serialization on disk
            Score.SaveData(SCORES_FILENAME);

            Console.ReadLine();
        }

        #endregion Entry point
    }
}
