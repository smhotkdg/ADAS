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
    /// WindowPosition.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WindowPosition : UserControl
    {


        public WindowPosition()
        {
            InitializeComponent();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TrueFalse tf = TrueFalse.Singleton;

            tf.PositionFlg = false;

            MyDocument md = MyDocument.Singleton;
            md.CloseUser();
        }

        public void ClosePosition()
        {
            TrueFalse tf = TrueFalse.Singleton;

            tf.PositionFlg = false;

            MyDocument md = MyDocument.Singleton;
            md.CloseUser();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;


            md.AddColorEventHandler += new AddColorEvent(md_AddColorEventHandler);
            md.AddSizeEventHandler += new AddSizeEvent(md_AddSizeEventHandler);
            md.Start();
            md.Start1();
        }

        void md_AddSizeEventHandler(int size)
        {
            viewposition.FontSize = size;
            viewup.FontSize = size;
            viewdown.FontSize = size;
            viewleft.FontSize = size;
            viewright.FontSize = size;
        }

        void md_AddColorEventHandler(SolidColorBrush color)
        {
            viewposition.Foreground = color;
            viewup.Foreground = color;
            viewdown.Foreground = color;
            viewleft.Foreground = color;
            viewright.Foreground = color;

        }
        

        private void viewup_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.Top();
        }

        private void viewdown_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.Down();
        }

        private void viewleft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.left();
        }

        private void viewright_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.Right();
        }


       public void WinLeft()
       {
           MyDocument md = MyDocument.Singleton;
           md.left();
       }
       public void  WinRight()
       {
           MyDocument md = MyDocument.Singleton;
           md.Right();
       }
       public void WinUp()
       {
           MyDocument md = MyDocument.Singleton;
           md.Top();
       }
       public void WinDown()
       {
           MyDocument md = MyDocument.Singleton;
           md.Down();
       }
    }
}
