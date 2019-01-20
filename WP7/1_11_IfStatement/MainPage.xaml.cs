using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace _1_11_IfStatement
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayGame(string input, int appRes)
        {
            string appResult;
            if (appRes == 1)
                appResult = "R";
            else if (appRes == 2)
                appResult = "P";
            else
                appResult = "S";

            if (input == "R" && appResult == "R")
                txt_show.Text = "Tie";
            if (input == "S" && appResult == "S")
                txt_show.Text = "Tie";
            if (input == "P" && appResult == "P")
                txt_show.Text = "Tie";

            if (input == "R" && appResult == "S")
                txt_show.Text = "Win";
            else if (input == "R" && appResult == "P")
                txt_show.Text = "Lose";

            if (input == "P" && appResult == "S")
                txt_show.Text = "Lose";
            else if (input == "P" && appResult == "R")
                txt_show.Text = "Win";

            if (input == "S" && appResult == "P")
                txt_show.Text = "Win";
            else if (input == "S" && appResult == "R")
                txt_show.Text = "Lose";

            txb_enemy.Text = appResult;
        }

        private void txb_input_Tap(object sender, GestureEventArgs e)
        {
            txb_input.Text = "";
        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int appResult = rnd.Next(1, 3);

            string input = (txb_input.Text).ToUpper();

            switch (input)
            {
                case "R":
                case "P":
                case "S":
                    PlayGame(input, appResult);
                    break;
                default:
                    txt_show.Text = "Nah, try again with R or P or S";
                    break;
            }
        }
    }
}