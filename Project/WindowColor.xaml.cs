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
    /// WindowColor.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WindowColor : UserControl
    {
        int cnt = 0;
        

        public WindowColor()
        {
            InitializeComponent();
        }


        private void fontcolor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TrueFalse tf = TrueFalse.Singleton;

            tf.ColorFlg = false;
           

            this.Visibility = Visibility.Hidden;
            MyDocument md = MyDocument.Singleton;
            md.CloseWindowColor();
        }

        public void CloseColor()
        {
            TrueFalse tf = TrueFalse.Singleton;

            tf.ColorFlg = false;


            this.Visibility = Visibility.Hidden;
            MyDocument md = MyDocument.Singleton;
            md.CloseWindowColor();
 
        }

        

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            cnt++;
            MyRun();
            
        }

        public void WinLeft()
        {
            cnt++;
            MyRun();
        }

        public void WinRight()
        {
            cnt--;
            MyRun();
        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            cnt--;
            MyRun();
           
        }

        private void MyRun()
        {
            MyDocument md = MyDocument.Singleton;
            int number = cnt;

            md.SaveNowColorDataRow(number);

            cnt = (cnt % 4);

            if (cnt == 0)
            {
                cnt = 4;
                switch (cnt)
                {
                    case 1: FontBlackColor(); FontBlack.Visibility = Visibility.Visible; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden;  break;
                    case 2: FontOrangeColor(); FontOrange.Visibility = Visibility.Visible; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden;  break;
                    case 3: FontGreenColor(); FontGreen.Visibility = Visibility.Visible; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden;  break;
                    case 4: FontVioletColor(); FontViolet.Visibility = Visibility.Visible; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden;  break;
                    case -4: FontBlackColor(); FontBlack.Visibility = Visibility.Visible; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden;  break;
                    case -3: FontOrangeColor(); FontOrange.Visibility = Visibility.Visible; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden;  break;
                    case -2: FontGreenColor(); FontGreen.Visibility = Visibility.Visible; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden;  break;
                    case -1: FontVioletColor(); FontViolet.Visibility = Visibility.Visible; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden;  break;
                    default: break;
                }

            }
            else 
            {
                switch (cnt)
                {
                    case 1: FontBlackColor(); FontBlack.Visibility = Visibility.Visible; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; break;
                    case 2: FontOrangeColor(); FontOrange.Visibility = Visibility.Visible; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; break;
                    case 3: FontGreenColor(); FontGreen.Visibility = Visibility.Visible; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; break;
                    case 4: FontVioletColor(); FontViolet.Visibility = Visibility.Visible; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; break;
                    case -4: FontBlackColor(); FontBlack.Visibility = Visibility.Visible; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; break;
                    case -3: FontOrangeColor(); FontOrange.Visibility = Visibility.Visible; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; break;
                    case -2: FontGreenColor(); FontGreen.Visibility = Visibility.Visible; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; break;
                    case -1: FontVioletColor(); FontViolet.Visibility = Visibility.Visible; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; break;
                    default: break;
                }
            }
        }

        void FontBlackColor()
        {
            MyDocument md = MyDocument.Singleton;
            FontBlack.Foreground = Brushes.Black;
            Brush black = FontBlack.Foreground;
            int i = 1;
            md.ColorChoice(i, black);

            MyPathleStrokeOnLeft.Stroke = black;
            MyPathleStrokeOnRight.Stroke = black;
            MyRectangleStrokeOnLeft.Stroke = black;
            MyRectangleStrokeOnRight.Stroke = black;


            SolidColorBrush color = Brushes.Black;
            md.AddColor(color);  

        }
        void FontOrangeColor()
        {
            MyDocument md = MyDocument.Singleton;
            FontOrange.Foreground = Brushes.Orange;
            Brush orange = FontOrange.Foreground;
            int i = 2;
            md.ColorChoice(i, orange);

            MyPathleStrokeOnLeft.Stroke = orange;
            MyPathleStrokeOnRight.Stroke = orange;
            MyRectangleStrokeOnLeft.Stroke = orange;
            MyRectangleStrokeOnRight.Stroke = orange;


            SolidColorBrush color = Brushes.Orange;
            md.AddColor(color);
          
        }
        void FontGreenColor()
        {
            MyDocument md = MyDocument.Singleton;
            FontGreen.Foreground = Brushes.Green;
            Brush green = FontGreen.Foreground;
            int i = 3;
            md.ColorChoice(i, green);

            MyPathleStrokeOnLeft.Stroke = green;
            MyPathleStrokeOnRight.Stroke = green;
            MyRectangleStrokeOnLeft.Stroke = green;
            MyRectangleStrokeOnRight.Stroke = green;

            SolidColorBrush color = Brushes.Green;
            md.AddColor(color);

           
        }
        void FontVioletColor()
        {
            MyDocument md = MyDocument.Singleton;
            FontViolet.Foreground = Brushes.Violet;
            Brush violet = FontViolet.Foreground;
            int i = 4;
            md.ColorChoice(i, violet);

            MyPathleStrokeOnLeft.Stroke = violet;
            MyPathleStrokeOnRight.Stroke = violet;
            MyRectangleStrokeOnLeft.Stroke = violet;
            MyRectangleStrokeOnRight.Stroke = violet;

            SolidColorBrush color = Brushes.Violet;
            md.AddColor(color);
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;


            md.AddColorEventHandler += new AddColorEvent(md_AddColorEventHandler);
            md.AddSizeEventHandler += new AddSizeEvent(md_AddSizeEventHandler);
            md.AddNowColorEventHandler += new AddNowColorEvent(md_AddNowColorEventHandler);
            md.Start();
            md.Start1();
            md.Start2();
        }

        void md_AddNowColorEventHandler(int number)
        {
            cnt = number;

            MyRun1();
        }

        private void MyRun1()
        {
            cnt = (cnt % 4);

            if (cnt == 0)
            {
                cnt = 4;
                switch (cnt)
                {
                    case 1: FontBlackColor(); FontBlack.Visibility = Visibility.Visible; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; break;
                    case 2: FontOrangeColor(); FontOrange.Visibility = Visibility.Visible; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; break;
                    case 3: FontGreenColor(); FontGreen.Visibility = Visibility.Visible; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; break;
                    case 4: FontVioletColor(); FontViolet.Visibility = Visibility.Visible; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; break;
                    case -4: FontBlackColor(); FontBlack.Visibility = Visibility.Visible; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; break;
                    case -3: FontOrangeColor(); FontOrange.Visibility = Visibility.Visible; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; break;
                    case -2: FontGreenColor(); FontGreen.Visibility = Visibility.Visible; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; break;
                    case -1: FontVioletColor(); FontViolet.Visibility = Visibility.Visible; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; break;
                    default: break;
                }

            }
            else
            {
                switch (cnt)
                {
                    case 1: FontBlackColor(); FontBlack.Visibility = Visibility.Visible; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; break;
                    case 2: FontOrangeColor(); FontOrange.Visibility = Visibility.Visible; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; break;
                    case 3: FontGreenColor(); FontGreen.Visibility = Visibility.Visible; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; break;
                    case 4: FontVioletColor(); FontViolet.Visibility = Visibility.Visible; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; break;
                    case -4: FontBlackColor(); FontBlack.Visibility = Visibility.Visible; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; break;
                    case -3: FontOrangeColor(); FontOrange.Visibility = Visibility.Visible; FontGreen.Visibility = Visibility.Hidden; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; break;
                    case -2: FontGreenColor(); FontGreen.Visibility = Visibility.Visible; FontViolet.Visibility = Visibility.Hidden; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; break;
                    case -1: FontVioletColor(); FontViolet.Visibility = Visibility.Visible; FontBlack.Visibility = Visibility.Hidden; FontOrange.Visibility = Visibility.Hidden; FontGreen.Visibility = Visibility.Hidden; break;
                    default: break;
                }
            }
        }

        void md_AddSizeEventHandler(int size)
        {
            fontcolor.FontSize = size;
        }

        void md_AddColorEventHandler(SolidColorBrush color)
        {
            fontcolor.Foreground = color;

            MyPathleStrokeOnLeft.Stroke = color;
            MyPathleStrokeOnRight.Stroke = color;
            MyRectangleStrokeOnLeft.Stroke = color;
            MyRectangleStrokeOnRight.Stroke = color;
        }
    }
}
