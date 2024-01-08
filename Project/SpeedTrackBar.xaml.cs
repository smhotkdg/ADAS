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
    /// SpeedTrackBar.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SpeedTrackBar : UserControl
    {
        byte color = 0;
        SolidColorBrush mySolidColorBrush = new SolidColorBrush();
        SolidColorBrush mySolidColorBrush2 = new SolidColorBrush();
        SolidColorBrush mySolidColorBrush3 = new SolidColorBrush();
        SolidColorBrush mySolidColorBrush4 = new SolidColorBrush();

        public SpeedTrackBar()
        {
            InitializeComponent();

            SetColor();

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            md.FrontOfCarEventHandler += new FrontOfCarEvent(md_FrontOfCarEventHandler);
        }

        private void SetColor()
        {
            mySolidColorBrush4.Color = Color.FromArgb(150, 103, 255, 66);
            grid3.Background = mySolidColorBrush4;

            mySolidColorBrush.Color = Color.FromArgb(200, 255, 0, 0);
            four1.Background = mySolidColorBrush;
            four2.Background = mySolidColorBrush;
            four3.Background = mySolidColorBrush;
            four4.Background = mySolidColorBrush;

         

            mySolidColorBrush2.Color = Color.FromArgb(200, 255, 248, 0);
            thrid1.Background = mySolidColorBrush2;
            thrid2.Background = mySolidColorBrush2;
            thrid3.Background = mySolidColorBrush2;
            thrid4.Background = mySolidColorBrush2;

           

            mySolidColorBrush3.Color = Color.FromArgb(200, 184, 181, 59);

            secon1.Background = mySolidColorBrush3;
            secon2.Background = mySolidColorBrush3;
            secon3.Background = mySolidColorBrush3;
            secon4.Background = mySolidColorBrush3;

         

        }
        void md_FrontOfCarEventHandler(int distance)
        {
            MyDocument md = MyDocument.Singleton;
             int myspeed = md.GetMySpeed();
             double mydistance = 0; 

            if (myspeed < 30)
             {
                 mydistance = (distance / 0.5);
             }

             else if   (myspeed > 30 || myspeed < 50)
             {
                 mydistance = (distance / 1);
             }

            else if (myspeed > 50 || myspeed < 60)
             {
                 mydistance = (distance / 1.5);
             }

            else if (myspeed > 60 || myspeed < 80)
            {
                mydistance = (distance / 2);
            }

            else if(myspeed > 100) 
            {
                mydistance = (distance / 2.5);
            }


            if (mydistance < 7)
            {
                four1.Visibility = Visibility.Visible;
                four2.Visibility = Visibility.Visible;
                four3.Visibility = Visibility.Visible;
                four4.Visibility = Visibility.Visible;

                thrid1.Visibility = Visibility.Visible;
                thrid2.Visibility = Visibility.Visible;
                thrid3.Visibility = Visibility.Visible;
                thrid4.Visibility = Visibility.Visible;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;
               
                int key = 1;
                md.TextMenu(key);

            }
            else if (mydistance < 9)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Visible;
                four3.Visibility = Visibility.Visible;
                four4.Visibility = Visibility.Visible;

                thrid1.Visibility = Visibility.Visible;
                thrid2.Visibility = Visibility.Visible;
                thrid3.Visibility = Visibility.Visible;
                thrid4.Visibility = Visibility.Visible;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;

                int key = 1;
                md.TextMenu(key);

            }
            else if (mydistance < 12)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Visible;
                four4.Visibility = Visibility.Visible;

                thrid1.Visibility = Visibility.Visible;
                thrid2.Visibility = Visibility.Visible;
                thrid3.Visibility = Visibility.Visible;
                thrid4.Visibility = Visibility.Visible;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;


                grid3.Visibility = Visibility.Visible;


                int key = 1;
                md.TextMenu(key);

            }
            else if (mydistance < 15)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Visible;

                thrid1.Visibility = Visibility.Visible;
                thrid2.Visibility = Visibility.Visible;
                thrid3.Visibility = Visibility.Visible;
                thrid4.Visibility = Visibility.Visible;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;

                int key = 1;
                md.TextMenu(key);
               
            }
            else if (mydistance < 17)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Visible;
                thrid2.Visibility = Visibility.Visible;
                thrid3.Visibility = Visibility.Visible;
                thrid4.Visibility = Visibility.Visible;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;
              

            }
            else if (mydistance < 19)
            {

                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Visible;
                thrid3.Visibility = Visibility.Visible;
                thrid4.Visibility = Visibility.Visible;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;
               
            }
            else if (mydistance < 22)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Visible;
                thrid4.Visibility = Visibility.Visible;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;


                grid3.Visibility = Visibility.Visible;

             


            }
            else if (mydistance < 25)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Visible;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;

            }


                //노란 경고
            else if (mydistance < 27)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Visible;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;
              
         

            }
            else if (mydistance < 29)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Hidden;
                secon2.Visibility = Visibility.Visible;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;

             

            }

            else if (mydistance < 32)
            {


                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Hidden;
                secon2.Visibility = Visibility.Hidden;
                secon3.Visibility = Visibility.Visible;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;
                
            

            }

            else if (mydistance < 35)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Hidden;
                secon2.Visibility = Visibility.Hidden;
                secon3.Visibility = Visibility.Hidden;
                secon4.Visibility = Visibility.Visible;

                grid3.Visibility = Visibility.Visible;
              
            

            }


                //
            else if (mydistance < 37)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Hidden;
                secon2.Visibility = Visibility.Hidden;
                secon3.Visibility = Visibility.Hidden;
                secon4.Visibility = Visibility.Hidden;

                grid3.Visibility = Visibility.Visible;

                mySolidColorBrush4.Color = Color.FromArgb(150, 103, 255, 66);
                grid3.Background = mySolidColorBrush4;
            

            }


            else if (mydistance < 39)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Hidden;
                secon2.Visibility = Visibility.Hidden;
                secon3.Visibility = Visibility.Hidden;
                secon4.Visibility = Visibility.Hidden;

                grid3.Visibility = Visibility.Visible;

                mySolidColorBrush4.Color = Color.FromArgb(180, 103, 255, 66);
                grid3.Background = mySolidColorBrush4;
               

            }

            else if (mydistance < 42)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Hidden;
                secon2.Visibility = Visibility.Hidden;
                secon3.Visibility = Visibility.Hidden;
                secon4.Visibility = Visibility.Hidden;

                grid3.Visibility = Visibility.Visible;

                mySolidColorBrush4.Color = Color.FromArgb(200, 103, 255, 66);
                grid3.Background = mySolidColorBrush4;
             

            }

            //안전 녹색
            else if (mydistance < 45)
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Hidden;
                secon2.Visibility = Visibility.Hidden;
                secon3.Visibility = Visibility.Hidden;
                secon4.Visibility = Visibility.Hidden;

                mySolidColorBrush4.Color = Color.FromArgb(200, 106, 206, 16);
                grid3.Background = mySolidColorBrush4;

                grid3.Visibility = Visibility.Visible;

            }
            else
            {
                four1.Visibility = Visibility.Hidden;
                four2.Visibility = Visibility.Hidden;
                four3.Visibility = Visibility.Hidden;
                four4.Visibility = Visibility.Hidden;

                thrid1.Visibility = Visibility.Hidden;
                thrid2.Visibility = Visibility.Hidden;
                thrid3.Visibility = Visibility.Hidden;
                thrid4.Visibility = Visibility.Hidden;

                secon1.Visibility = Visibility.Hidden;
                secon2.Visibility = Visibility.Hidden;
                secon3.Visibility = Visibility.Hidden;
                secon4.Visibility = Visibility.Hidden;

                mySolidColorBrush4.Color = Color.FromArgb(200, 121, 255, 0);
                grid3.Background = mySolidColorBrush4;

                grid3.Visibility = Visibility.Visible;
            }

        }
        
    }
}
