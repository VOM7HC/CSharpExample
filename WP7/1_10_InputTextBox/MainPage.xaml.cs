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

namespace _1_10_InputTextBox
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void txt_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            txb_show.Text = txt_input.Text;
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txb_show.Text = "Show here!!";
            txt_input.Text = "";

            txt_input.Focus();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            txt_input.Focus();
        }
    }
}