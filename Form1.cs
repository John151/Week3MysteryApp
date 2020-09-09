using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3MysteryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<double> listOfScores = convertInputToList();

            HighLowAvg(listOfScores);

            List<string> listOfGrades = new List<string>();

            ConvertToLetterGrades(listOfScores, listOfGrades);

        }

        private void ConvertToLetterGrades(List<double> listOfScores, List<string> listOfGrades)
        {
            foreach (double score in listOfScores)
            {
                string abcdf = "";

                if (score >= 90)
                {
                    abcdf = "A";
                }
                else if (score >= 80)
                {
                    abcdf = "B";
                }
                else if (score >= 70)
                {
                    abcdf = "C";
                }
                else if (score >= 60)
                {
                    abcdf = "D";
                }
                else
                {
                    abcdf = "F-";
                }
                listOfGrades.Add(abcdf);
            }

            txtLetter1.Text = listOfGrades[0];
            txtLetter2.Text = listOfGrades[1];
            txtLetter3.Text = listOfGrades[2];
            txtLetter4.Text = listOfGrades[3];
            txtLetter5.Text = listOfGrades[4];
        }

        private void HighLowAvg(List<double> listOfScores)
        {
            double HighScore = listOfScores.Max();
            txtHigh.Text = HighScore.ToString();

            double LowScore = listOfScores.Min();
            txtLow.Text = LowScore.ToString();

            double Average = listOfScores.Average();
            txtAvg.Text = Average.ToString();
        }

        private List<double> convertInputToList()
        {
            double Student1Score = Convert.ToDouble(txtScore1.Text);
            double Student2Score = Convert.ToDouble(txtScore2.Text);
            double Student3Score = Convert.ToDouble(txtScore3.Text);
            double Student4Score = Convert.ToDouble(txtScore4.Text);
            double Student5Score = Convert.ToDouble(txtScore5.Text);

            List<double> listOfScores = new List<double>()
                {
                Student1Score,
                Student2Score,
                Student3Score,
                Student4Score,
                Student5Score
                };
            return listOfScores;
        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            List<double> listOfScores = convertInputToList();

            HighLowAvg(listOfScores);

            List<string> listOfGrades = new List<string>();

            int newA = Convert.ToInt32(listOfScores.Max());
            int newB = newA - 20;
            int newC = newB - 10;
            int newD = newC - 10;

            foreach (double score in listOfScores)
            {
                string abcdf = "";

                if (score >= newA)
                {
                    abcdf = "A";
                }
                else if (score >= newB)
                {
                    abcdf = "B";
                }
                else if (score >= newC)
                {
                    abcdf = "C";
                }
                else if (score >= newD)
                {
                    abcdf = "D";
                }
                else
                {
                    abcdf = "F-";
                }
                listOfGrades.Add(abcdf);
            }

            txtLetter1.Text = listOfGrades[0];
            txtLetter2.Text = listOfGrades[1];
            txtLetter3.Text = listOfGrades[2];
            txtLetter4.Text = listOfGrades[3];
            txtLetter5.Text = listOfGrades[4];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLetter1.Text = string.Empty;
            txtLetter2.Text = string.Empty;
            txtLetter3.Text = string.Empty;
            txtLetter4.Text = string.Empty;
            txtLetter5.Text = string.Empty;

            txtScore1.Text = string.Empty;
            txtScore2.Text = string.Empty;
            txtScore3.Text = string.Empty;
            txtScore4.Text = string.Empty;
            txtScore5.Text = string.Empty;

            txtHigh.Text = string.Empty;
            txtLow.Text = string.Empty;
            txtAvg.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
