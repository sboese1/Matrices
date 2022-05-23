using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project2_starter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                string[] lines = File.ReadAllLines(fileName);

                MatrixOneText.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    foreach (string part in parts)
                    {
                        MatrixOneText.AppendText(part + " ");
                    }
                    MatrixOneText.AppendText(Environment.NewLine);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                string[] lines = File.ReadAllLines(fileName);

                MatrixTwoText.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    foreach (string part in parts)
                    {
                        MatrixTwoText.AppendText(part + " ");
                    }
                    MatrixTwoText.AppendText(Environment.NewLine);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ResultingMatrixText.Clear();
            string temp1 = MatrixOneText.Text.Trim();
            string temp2 = MatrixTwoText.Text.Trim();
            string[] temp3 = temp1.Split('\n');
            string[] temp4 = temp2.Split('\n');
            List<string> MatrixOneParts = new List<string>();
            List<string> MatrixTwoParts = new List<string>();
            int countOne = 0;
            int countTwo = 0;

            foreach (string s in temp3)
            {
                string temp5 = s.Trim();
                string[] temp6 = temp5.Split(' ');
                foreach (string part in temp6)
                {
                    MatrixOneParts.Add(part);
                }
                countOne++;
            }

            foreach (string s in temp4)
            {
                string temp5 = s.Trim();
                string[] temp6 = temp5.Split(' ');
                foreach (string part in temp6)
                {
                    MatrixTwoParts.Add(part);
                }
                countTwo++;
            }

            int col1 = MatrixOneParts.Count / countOne;
            int col2 = MatrixTwoParts.Count / countTwo;
            int rowCount1 = MatrixOneParts.Count / col1;
            int rowCount2 = MatrixTwoParts.Count / col2;

            if (MatrixOneParts.Count != MatrixTwoParts.Count || col1 != col2)
            {
                ResultingMatrixText.Text = "Error: invalid matrix format";
            }
            else
            {
                SparseMatrix s1 = new SparseMatrix(rowCount1, col1);
                int Count3 = 0;

                foreach (string part in MatrixOneParts)
                {
                    try
                    {
                        if (Convert.ToInt32(part) > 0)
                        {
                            s1.AddEntry(Convert.ToInt32(part), Count3 / rowCount1, Count3 % col1);
                        }
                    }
                    catch { break; } 
                    Count3++;
                }

                SparseMatrix s2 = new SparseMatrix(rowCount2, col2);
                Count3 = 0;

                foreach (string part in MatrixTwoParts)
                {
                    try
                    {
                        if (Convert.ToInt32(part) > 0)
                        {
                            s2.AddEntry(Convert.ToInt32(part), Count3 / rowCount2, Count3 % col2);
                        }
                    }
                    catch { break; }
                    Count3++;
                }
                SparseMatrix s = s1.Plus(s2);
                ResultingMatrixText.Text = s.ToString();
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            ResultingMatrixText.Clear();

            string[] MatrixOneParts = MatrixOneText.Text.Split(' ');
            string[] MatrixTwoParts = MatrixTwoText.Text.Split(' ');

            int countOne = 0;

            foreach (string part in MatrixOneParts)
            {
                for (int i = 0; i < part.Length; i++)
                {
                    if (part[i] == '\n')
                    {
                        countOne++;
                    }
                }
            }

            int countTwo = 0;

            foreach (string part in MatrixTwoParts)
            {
                for (int i = 0; i < part.Length; i++)
                {
                    if (part[i] == '\n')
                    {
                        countTwo++;
                    }
                }
            }

            if ((((MatrixOneParts.Length-1) / countOne) != countTwo) && (((MatrixTwoParts.Length-1) / countTwo) != countOne))
            {
                ResultingMatrixText.Text = "Error: matrix dimensions don't match";
            }
        }

    }
}
