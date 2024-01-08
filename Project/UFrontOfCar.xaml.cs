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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// UFrontOfCar.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UFrontOfCar : UserControl
    {
        public UFrontOfCar()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            md.AddColorEventHandler += new AddColorEvent(md_AddColorEventHandler);
            md.AddSizeEventHandler += new AddSizeEvent(md_AddSizeEventHandler);
            md.FrontOfCarEventHandler += new FrontOfCarEvent(md_FrontOfCarEventHandler);
            md.FrontOfCarSpeedEventHandler += new FrontOfCarSpeedEvent(md_FrontOfCarSpeedEventHandler);
            md.Start1();
            md.Start2();
        }

        void md_FrontOfCarSpeedEventHandler(int speed)
        {
            t2.Content = speed.ToString() + "Km";
        }

        void md_FrontOfCarEventHandler(int distance)
        {
            t1.Content = distance.ToString() +"m";
        }

         void md_AddSizeEventHandler(int size)
        {
            size = size - 10;
            MyFontOfCar.FontSize = size;
            t1.FontSize = size;

            MyFontOfCarSpeed.FontSize = size;
            t2.FontSize = size;
        }

         void md_AddColorEventHandler(SolidColorBrush color)
         {
             MyFontOfCar.Foreground = color;
             t1.Foreground = color;

             MyFontOfCarSpeed.Foreground = color;
             t2.Foreground = color;
         }
    }
}
