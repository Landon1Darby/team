using System.Diagnostics;

namespace team
{
    public partial class Form1 : Form
    {
        List<string> teams = new List<string>();
        List<int> wins = new List<int>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("Teams.txt");

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                teams.Add(line);
            }
            streamReader.Close();

            for(int i = 0; i < teams.Count; i++)
            {
                wins.Add(0);
            }

            calculateWins();
        }

        private void calculateWins()
        {
            StreamReader streamReader = new StreamReader("WorldSeriesWinners.txt");
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i] == line)
                    {
                        wins[i] += 1;
                    }
                }

            }
            streamReader.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            answerLabel.Text = wins[TeamsListBox.SelectedIndex].ToString();
        }
    }
}
