using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise04
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            stats.UpdatedStats += Stats_UpdatedStats;
            InitializeComponent();
        }

        private void Stats_UpdatedStats(object sender, EventArgs e)
        {
            correctLabel.Text = "Correct: " + stats.Correct.ToString();
            missedLabel.Text = "Missed: " + stats.Missed.ToString();
            accurancyLabel.Text = "Accurancy: " + stats.Accuracy.ToString() + " %";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameListBox.Items.Count > 6)
            {
                timer1.Stop();
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game Over!");
            }
            else
            {
                gameListBox.Items.Add((Keys)random.Next(65, 91));
                gameListBox.Refresh();
            }
            
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (gameListBox.Items.Contains(e.KeyCode))
            {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();
                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 60;
                }
                else if (timer1.Interval > 250)
                {
                    timer1.Interval -= 15;
                }
                else if (timer1.Interval > 150)
                {
                    timer1.Interval -= 8;
                }
                difficultProgressBar.Value = timer1.Interval;
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }
          

           
        }
    }
}