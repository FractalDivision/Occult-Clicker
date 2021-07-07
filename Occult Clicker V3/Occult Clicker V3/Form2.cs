using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Occult_Clicker_V3
{
    public partial class Form2 : Form
    {

        int playerPoints = 0;

        // auto clickers
        int _50pAmount = 0;
        int _100pAmount = 0;
        int _250pAmount = 0;
        int _1000pAmount = 0;


        //timer value
        int timerCount = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void label_points_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerPoints += 1;
            label_points.Text = playerPoints.ToString() + " SOULS";
        }

        private void button_50_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 50)
            {
                _50pAmount += 1;
                playerPoints -= 50;
                label_points.Text = playerPoints.ToString() + " SOULS";

            }

            else
                MessageBox.Show("Not enough points chief");
        }

        private void button_100_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 100)
            {
                _100pAmount += 1;
                playerPoints -= 100;
                label_points.Text = playerPoints.ToString() + " SOULS";

            }

            else
                MessageBox.Show("Not enough points chief");
        }

        private void button_250_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 250)
            {
                _250pAmount += 1;
                playerPoints -= 250;
                label_points.Text = playerPoints.ToString() + " SOULS";

            }

            else
                MessageBox.Show("Not enough points chief");
        }

        private void button_1000_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 1000)
            {
                _1000pAmount += 1;
                playerPoints -= 1000;
                label_points.Text = playerPoints.ToString() + " SOULS";

            }

            else
                MessageBox.Show("Not enough points chief");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount += 1;
            playerPoints += _1000pAmount;

            if (timerCount % 4 == 0)
                playerPoints += _250pAmount;

            if (timerCount % 10 == 0)
                playerPoints += _100pAmount;

            if (timerCount % 20 == 0)
                playerPoints += _50pAmount;

            label_points.Text = playerPoints.ToString() + " SOULS";


        }







        private void button2_Click(object sender, EventArgs e)
        {


            // Write file using StreamWriter  
            using (StreamWriter writer = new StreamWriter(@"C:\Users\\Lucy\source\repos\Occult Clicker V3\Saves\saves.txt"))
            {
                writer.WriteLine("" + playerPoints);
                
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {

            TextReader reader = new StreamReader(@"C:\Users\\Lucy\source\repos\Occult Clicker V3\Saves\saves.txt");
            label_points.Text = reader.ReadToEnd();
                reader.Close();


            }

        private void label_points_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_points_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
    