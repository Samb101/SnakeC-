using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeProject
{
    public partial class ScoreTab : Form
    {

        private List<Score> mesScores;

        private const string SCORES_FILENAME = @"../../data/scores.xml";

        public ScoreTab()
        {
            InitializeComponent();

            listView1.Columns.Add("Classement", (listView1.Width-3) / 3);
            listView1.Columns.Add("Pseudo", (listView1.Width-3) / 3);
            listView1.Columns.Add("Score", (listView1.Width-3) / 3);

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            Score.LoadData(SCORES_FILENAME);
            mesScores = Score.Scores;

            mesScores.ForEach((score) =>
            {

                string[] arr = new string[3];
                ListViewItem itm;
                arr[0] = (listView1.Items.Count + 1).ToString();
                arr[1] = score.name;
                arr[2] = (score.score).ToString();
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            });


        }
    }
}
