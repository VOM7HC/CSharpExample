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
using System.Windows.Threading;

namespace _2_2_DateTime
{
    public partial class MainPage : PhoneApplicationPage
    {
        public DateTime time;
        public DispatcherTimer dt;
        // Constructor
        public MainPage()
        {
            InitializeComponent();            
            dt = new DispatcherTimer();
            time = DateTime.Now;
            txt_showDate.Text = time.ToLongDateString();
        }

        private void btn_touch_Click(object sender, RoutedEventArgs e)
        {
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += new EventHandler(dt_Tick);
            dt.Start();
        }

        private void dt_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            txt_show.Text = time.ToLongTimeString();
        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            txt_showDate.Text = time.AddDays(1).ToLongDateString();
        }

        private void btn_prev_Click(object sender, RoutedEventArgs e)
        {
            txt_showDate.Text = time.AddDays(-1).ToLongDateString();
        }
    }
}