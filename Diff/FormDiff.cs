using System;
using System.IO;
using System.Windows.Forms;

namespace Diff
{
    public partial class FormDiff : Form
    {
        public FormDiff()
        {
            InitializeComponent();
        }

        private void BtnCalculateDiff_Click(object sender, EventArgs e)
        {
            string word1, word2;

            string path = Application.StartupPath + @"\diff.txt";
            StreamReader streamReader = new StreamReader(path);

            int pairsCount = Convert.ToInt32(streamReader.ReadLine());

            for (int i = 1; i <= pairsCount; i++)
            {
                word1 = streamReader.ReadLine();
                word2 = streamReader.ReadLine();
                TxtResult.Text += CalculateDifference(word1, word2) + Environment.NewLine;
            }
        }

        private int CalculateDifference(string word1, string word2)
        {
            string character1, character2 = "";
            int sameCount = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                character1 = word1.Substring(i, 1);

                if (i < word2.Length)
                {
                    character2 = word2.Substring(i, 1);
                }

                if (character1 != character2)
                {
                    break;
                }
                else
                {
                    sameCount++;
                }
            }
            return sameCount;
        }
    }
}
