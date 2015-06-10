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
using PlsCan_Run.ServiceReference3;
using System.Windows.Browser;

namespace PlsCan_Run
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
             
            Service1Client sclv = new Service1Client();
            sclv.Get_All_SalesCompleted += new EventHandler<Get_All_SalesCompletedEventArgs>(sclv_Get_All_SalesCompleted);
            sclv.Get_All_SalesAsync();

        }
        void sclv_Get_All_SalesCompleted(object sender, Get_All_SalesCompletedEventArgs e)
        {
            dgv.ItemsSource = e.Result;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Service1Client sclv = new Service1Client();
            sclv.Get_Find_DestinationCompleted += new EventHandler<Get_Find_DestinationCompletedEventArgs>(sclv_Get_Find_DestinationCompleted);
            sclv.Get_Find_DestinationAsync(txtsrch.Text.Trim());

        }
        void sclv_Get_Find_DestinationCompleted(object sender, Get_Find_DestinationCompletedEventArgs e)
        {
            dgv.ItemsSource = e.Result;
        
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HtmlPage.Window.Navigate(new Uri("RouteMenu.aspx", UriKind.Relative));
        }
        }



     
       
}

