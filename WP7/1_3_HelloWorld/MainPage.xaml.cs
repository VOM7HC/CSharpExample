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

namespace _1_3_HelloWorld
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_touch_Click(object sender, RoutedEventArgs e)
        {
            string eng_string_hello = "Hello world!!";
            if (txb_hello.Text != eng_string_hello)
                txb_hello.Text = eng_string_hello;
            else
                txb_hello.Text = "What do you think?";
        }
    }
}