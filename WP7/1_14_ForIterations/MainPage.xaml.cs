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

namespace _1_14_ForIterations
{
    public partial class MainPage : PhoneApplicationPage
    {
        private string startStr = "Show number: ";
        private int num;
        // Constructor
        public MainPage()
        {
            InitializeComponent();            
            txt_show.Text = startStr;
        }

        private void txb_input_Tap(object sender, GestureEventArgs e)
        {
            txb_input.Text = "";
        }

        private void btn_touch_Click(object sender, RoutedEventArgs e)
        {
            string resStr = "";
            for (int i = num; i < num + 3; i++)
            {
                resStr += startStr + i.ToString() + System.Environment.NewLine;
            }
            txt_show.Text = resStr;
        }

        private void txb_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txb_input.Text == "" || txb_input.Text == "Input number here")
                num = 0;
            else
                num = int.Parse(txb_input.Text);
        }
    }
}