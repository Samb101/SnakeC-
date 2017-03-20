using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SnakeProject
{
        [Serializable]
        public class Score
            {

            private static List<Score> scores = new List<Score>();
            private static XmlSerializer xs = new XmlSerializer(typeof(List<Score>));
            public String name { get; /*private*/ set; }
            public Int32 score { get; /*private*/ set; }

            public Score()
            {
                this.score = 0;
                this.name = null;
            }

            public Score(String name, int score)
            {
                this.score = score;
                this.name = name;
            }



            public static void LoadData(String filename)
                {
                   Debug.WriteLine("[LIBINFO] Reading file " + filename);

                   scores = null;

                    try
                    {
                        if (File.Exists(filename))
                        {
                            using (XmlReader xr = XmlReader.Create(filename))
                            {
                                scores = (List<Score>)xs.Deserialize(xr);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("[LIBERROR] Error reading the file " + filename);
                        Debug.WriteLine("           " + e.ToString());
                    }
                    finally
                    {
                        if (scores == null)
                        {
                            scores = new List<Score>();
                        }
                    }
                }

            public static void SaveData(String filename)
            {
                Debug.WriteLine("[LIBINFO] Writing file " + filename);

                try
                {
                    using (XmlWriter xw = XmlWriter.Create(filename))
                    {
                        xs.Serialize(xw, scores);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine("[LIBERROR] Error writing the file " + filename);
                    Debug.WriteLine("           " + e.ToString());
                }
            }

            public static void ResetData()
            {
                Debug.WriteLine("[LIBINFO] Reset data context");
                scores = new List<Score>();
            }

            public static void DebugDump()
            {
                foreach (Score student in scores)
                {
                    Debug.WriteLine(student.ToString());
                }
            }

            public static void ConsoleDump()
            {
                foreach (Score student in scores)
                {
                    Console.WriteLine(student.name.ToString());
                    Console.WriteLine(student.score.ToString());

            }
        }

            public static Score RegisterScore(Score NewScore)
            {
                scores.Add(NewScore);
                return NewScore;
            }

            public static Score RegisterScore(String firstname, int score)
            {
                return RegisterScore(new Score(firstname,  score));
            }

            public static List<Score> Scores
            {
                get { return scores; }
            }

        }
    

}
