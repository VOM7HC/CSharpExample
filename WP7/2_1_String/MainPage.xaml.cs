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
using System.Text;

namespace _2_1_String
{
    public partial class MainPage : PhoneApplicationPage
    {
        string[] mystring = new string[5];
        StringBuilder mystring2 = new StringBuilder(); 

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            AddStringToArray();
            AddStringToBuilder();
        }

        public void AddStringToArray()
        {
            string temp;
            temp = String.Format("{0:C}", 123.45);
            mystring[0] = temp;
            temp = String.Format("{0:N}", 1234567890);
            mystring[1] = temp;
            temp = String.Format("{0:D}", 1234567890);
            mystring[2] = temp;
            temp = String.Format("{0:P}", .127);
            mystring[3] = temp;
            temp = String.Format("{0:(###) ###-####}", 1234567890);
            mystring[4] = temp;
        }

        public void AddStringToBuilder()
        {
            for (int i = 0; i < 5; i++)
            {
                mystring2.Append("-");
                mystring2.Append(i);
            }
        }

        private void btn_touch_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                txt_show.Text += mystring[i] + System.Environment.NewLine;
            }
            txt_show2.Text = mystring2.ToString();
        }
    }
}