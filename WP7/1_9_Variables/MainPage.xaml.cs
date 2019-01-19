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

namespace _1_9_Variables
{
    public partial class MainPage : PhoneApplicationPage
    {
        private int var_a = 10;
        private int var_b = 10;
        private int var_c = 10;

        private string result = "0";
        private string current_answer_1;
        private string current_answer_2;
        private string current_question;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            current_answer_1 = txb_answer_1.Text;
            current_answer_2 = txb_answer_2.Text;
            current_question = txb_question_math_2.Text;

            txb_question_math_1.Text += (var_a.ToString() + " + " + var_b.ToString() + "?");
            txb_question_math_2.Text += (" Question 1 (currently: " + result + ") + " + var_c.ToString() + "?");
        }

        private void btn_touch_1_Click(object sender, RoutedEventArgs e)
        {
            result = (var_a + var_b).ToString();
            txb_answer_1.Text = current_answer_1 + result;
            txb_question_math_2.Text = current_question + (" Question 1 (currently: " + result + ") + " + var_c.ToString() + "?");
        }

        private void btn_touch_2_Click(object sender, RoutedEventArgs e)
        {
            txb_answer_2.Text = current_answer_2 + (int.Parse(result) + var_c).ToString();
        }
    }
}