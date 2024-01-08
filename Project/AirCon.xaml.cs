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
    /// AirCon.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

    public partial class AirCon : UserControl
    {
        int nowtemp = 0;

        

        public AirCon()
        {
            InitializeComponent();
        }

        private void MyMax_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.AirConColorEventHandler += new AirConColorEvent(OnAddMember);
            md.AirconSizeEventHandler += new AirconSizeEvent(OnChangeSize);


            md.AddColorEventHandler += new AddColorEvent(md_AddColorEventHandler);
            md.AddSizeEventHandler += new AddSizeEvent(md_AddSizeEventHandler);
            md.Start();
            md.Start1();
        }

        void md_AddSizeEventHandler(int size)
        {
            MyMax.FontSize = size;
            MyMin.FontSize = size;

            MyTemp18.FontSize = size;
            MyTemp19.FontSize = size;
            MyTemp20.FontSize = size;
            MyTemp21.FontSize = size;
            MyTemp22.FontSize = size;
            MyTemp23.FontSize = size;
            MyTemp24.FontSize = size;
            MyTemp25.FontSize = size;
            MyTemp26.FontSize = size;
            MyTemp27.FontSize = size;
            MyTemp28.FontSize = size;
            MyTemp29.FontSize = size;
            MyTemp30.FontSize = size;
            MyTemp31.FontSize = size;
            MyTemp32.FontSize = size;
        }

        void md_AddColorEventHandler(SolidColorBrush color)
        {
            MyMax.Foreground = color;
            MyMin.Foreground = color;

            MyTemp18.Foreground = color;
            MyTemp19.Foreground = color;
            MyTemp20.Foreground = color;
            MyTemp21.Foreground = color;
            MyTemp22.Foreground = color;
            MyTemp23.Foreground = color;
            MyTemp24.Foreground = color;
            MyTemp25.Foreground = color;
            MyTemp26.Foreground = color;
            MyTemp27.Foreground = color;
            MyTemp28.Foreground = color;
            MyTemp29.Foreground = color;
            MyTemp30.Foreground = color;
            MyTemp31.Foreground = color;
            MyTemp32.Foreground = color;
        }

        void OnAddMember(Brush color)
        {
            MyMax.Foreground = color;
            MyMin.Foreground = color;

            MyTemp18.Foreground = color;
            MyTemp19.Foreground = color;
            MyTemp20.Foreground = color;
            MyTemp21.Foreground = color;
            MyTemp22.Foreground = color;
            MyTemp23.Foreground = color;
            MyTemp24.Foreground = color;
            MyTemp25.Foreground = color;
            MyTemp26.Foreground = color;
            MyTemp27.Foreground = color;
            MyTemp28.Foreground = color;
            MyTemp29.Foreground = color;
            MyTemp30.Foreground = color;
            MyTemp31.Foreground = color;
            MyTemp32.Foreground = color;

        }

        void OnChangeSize(double size)
        {
            MyMax.FontSize = size;
            MyMin.FontSize = size;

            MyTemp18.FontSize = size;
            MyTemp19.FontSize = size;
            MyTemp20.FontSize = size;
            MyTemp21.FontSize = size;
            MyTemp22.FontSize = size;
            MyTemp23.FontSize = size;
            MyTemp24.FontSize = size;
            MyTemp25.FontSize = size;
            MyTemp26.FontSize = size;
            MyTemp27.FontSize = size;
            MyTemp28.FontSize = size;
            MyTemp29.FontSize = size;
            MyTemp30.FontSize = size;
            MyTemp31.FontSize = size;
            MyTemp32.FontSize = size;
        }

        void MyRun()
        {       
            switch (nowtemp)
            {

                case 18: My18(); break;
                case 19: My19(); break;
                case 20: My20(); break;
                case 21: My21(); break;
                case 22: My22(); break;
                case 23: My23(); break;
                case 24: My24(); break;
                case 25: My25(); break;
                case 26: My26(); break;
                case 27: My27(); break;
                case 28: My28(); break;
                case 29: My29(); break;
                case 30: My30(); break;
                case 31: My31(); break;
                case 32: My32(); break;
                default:break; 
            }
        }


        
        
        private void MyMax_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tempreture tempreture = Tempreture.Singleton;
            nowtemp = --tempreture.NowTempreture;

            MyRun();
        }

        private void MyMin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tempreture tempreture = Tempreture.Singleton;

            if (nowtemp == 0)
            {
                nowtemp = 18;
                My18();
                return;
            }
            nowtemp =++tempreture.NowTempreture;
            MyRun();
        }

        void My18() { MyTemp18.Visibility = Visibility.Visible; MyTemp32.Visibility = Visibility.Hidden; MyTemp19.Visibility = Visibility.Hidden; }
        void My19() { MyTemp19.Visibility = Visibility.Visible; MyTemp18.Visibility = Visibility.Hidden; MyTemp20.Visibility = Visibility.Hidden; }
        void My20() { MyTemp20.Visibility = Visibility.Visible; MyTemp19.Visibility = Visibility.Hidden; MyTemp21.Visibility = Visibility.Hidden; }
        void My21() { MyTemp21.Visibility = Visibility.Visible; MyTemp20.Visibility = Visibility.Hidden; MyTemp22.Visibility = Visibility.Hidden; }
        void My22() { MyTemp22.Visibility = Visibility.Visible; MyTemp21.Visibility = Visibility.Hidden; MyTemp23.Visibility = Visibility.Hidden; }
        void My23() { MyTemp23.Visibility = Visibility.Visible; MyTemp22.Visibility = Visibility.Hidden; MyTemp24.Visibility = Visibility.Hidden; }
        void My24() { MyTemp24.Visibility = Visibility.Visible; MyTemp23.Visibility = Visibility.Hidden; MyTemp25.Visibility = Visibility.Hidden; }
        void My25() { MyTemp25.Visibility = Visibility.Visible; MyTemp24.Visibility = Visibility.Hidden; MyTemp26.Visibility = Visibility.Hidden; }
        void My26() { MyTemp26.Visibility = Visibility.Visible; MyTemp25.Visibility = Visibility.Hidden; MyTemp27.Visibility = Visibility.Hidden; }
        void My27() { MyTemp27.Visibility = Visibility.Visible; MyTemp26.Visibility = Visibility.Hidden; MyTemp28.Visibility = Visibility.Hidden; }
        void My28() { MyTemp28.Visibility = Visibility.Visible; MyTemp27.Visibility = Visibility.Hidden; MyTemp29.Visibility = Visibility.Hidden; }
        void My29() { MyTemp29.Visibility = Visibility.Visible; MyTemp28.Visibility = Visibility.Hidden; MyTemp30.Visibility = Visibility.Hidden; }
        void My30() { MyTemp30.Visibility = Visibility.Visible; MyTemp29.Visibility = Visibility.Hidden; MyTemp31.Visibility = Visibility.Hidden; }
        void My31() { MyTemp31.Visibility = Visibility.Visible; MyTemp30.Visibility = Visibility.Hidden; MyTemp32.Visibility = Visibility.Hidden; }
        void My32() { MyTemp32.Visibility = Visibility.Visible; MyTemp31.Visibility = Visibility.Hidden;  }



        internal void WinUp()
        {
            Tempreture tempreture = Tempreture.Singleton;

            if (nowtemp == 0)
            {
                nowtemp = 18;
                My18();
                return;
            }
            nowtemp = ++tempreture.NowTempreture;
            MyRun();
        }

        internal void WinDown()
        {
           


            Tempreture tempreture = Tempreture.Singleton;

            if (nowtemp == 0)
            {
                return;
            }
            nowtemp = --tempreture.NowTempreture;

            MyRun();
        }
    }
}
