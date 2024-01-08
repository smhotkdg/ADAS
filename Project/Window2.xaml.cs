using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Window2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

    

        private void Button_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            int key = 1;
            md.TextMenu(key);
            
        }

        private void Button_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            int key = 2;
            md.TextMenu(key);
        }

        private void Button_MouseDoubleClick_3(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            int key = 3;
            md.TextMenu(key);


        }

        private void speed30_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.AutoSpeed(30);
        }

        private void speed50_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.AutoSpeed(50);
        }

        private void speed80_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.AutoSpeed(80);
        }
        private void speed100_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.AutoSpeed(100);
        }

        private void Aheadof_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.TopSign(1);
        }


        private void crosswalk_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.TopSign(2);
        }

        private void failrocks_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.BottonSign(1);
        }

        private void drop_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.BottonSign(2);
        }

       
       

       
        
       

        

        
    }
}
