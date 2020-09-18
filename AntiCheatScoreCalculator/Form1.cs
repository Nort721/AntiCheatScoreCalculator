using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiCheatScoreCalculator
{
    public partial class AntiCheatScoreCalculator : Form
    {
        public AntiCheatScoreCalculator()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (RatingCountTxt.Text.Length == 0 || RatingAverageTxt.Text.Length == 0)
            {
                MessageBox.Show("Please fill all fields", "Error");
                return;
            }
            else
            {
                if (ContainsNotDigits(0, RatingCountTxt.Text) || ContainsNotDigits(0, RatingAverageTxt.Text))
                {
                    MessageBox.Show("Wrong arguments, please write numbers only", "Error");
                    return;
                }
            }
            OutPutTxt.Text = "" + (10 * 3 + float.Parse(RatingAverageTxt.Text) * int.Parse(RatingCountTxt.Text)) / (10 + int.Parse(RatingCountTxt.Text));
        }

        private bool ContainsNotDigits(int i, String txt)
        {
            if (txt.Length == i) return false;
            if (!Char.IsDigit(txt[i]) && txt[i] != '.') return true;
            return ContainsNotDigits(i+=1, txt);
        }
    }
}
