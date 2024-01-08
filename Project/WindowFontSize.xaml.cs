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
    /// WindowFontSize.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WindowFontSize : UserControl
    {
        int key;
        int key1;
        public WindowFontSize()
        {
            InitializeComponent();
        }

        private void fontsize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            TrueFalse tf = TrueFalse.Singleton;
            tf.SizeFlg = false;
            
            MyDocument md = MyDocument.Singleton;
            md.CloseUserFontSize();
        }

        public void CloseFontSize()
        {
            TrueFalse tf = TrueFalse.Singleton;
            tf.SizeFlg = false;

            MyDocument md = MyDocument.Singleton;
            md.CloseUserFontSize();
        }

        private void font20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            TextSizeSmall.FontSize = 20;
            double size = TextSizeSmall.FontSize;
            int i = 1;
            md.TextSizeChoice(i, size);

            int a = 20;
            md.AddSize(a);
        }

        private void font30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            TextSizeMiddle.FontSize = 30;
            double size = TextSizeMiddle.FontSize;
            int i = 2;
            md.TextSizeChoice(i, size);

            int a = 30;
            md.AddSize(a);
        }

        private void font50_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            TextSizeBig.FontSize = 45;
            double size = TextSizeBig.FontSize;
            int i = 3;
            md.TextSizeChoice(i, size);

            int a = 45;
            md.AddSize(a);
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
            fontsize.FontSize = size;
            TextSizeSmall.FontSize = size;
            TextSizeMiddle.FontSize = size;
            TextSizeBig.FontSize = size;

            key = size; 
        }

        void md_AddColorEventHandler(SolidColorBrush color)
        {
            fontsize.Foreground = color;
            TextSizeSmall.Foreground = color;
            TextSizeMiddle.Foreground = color;
            TextSizeBig.Foreground = color; 
        }


        public void Small()
        {
            key = 1;
            MyDocument md = MyDocument.Singleton;

            TextSizeSmall.FontSize = 20;
            double size = TextSizeSmall.FontSize;
            int i = 1;
            md.TextSizeChoice(i, size);

            int a = 20;
            md.AddSize(a);
        }

        public void Middle()
        {
            key = 2;
            MyDocument md = MyDocument.Singleton;

            TextSizeMiddle.FontSize = 30;
            double size = TextSizeMiddle.FontSize;
            int i = 2;
            md.TextSizeChoice(i, size);

            int a = 30;
            md.AddSize(a);
        }

        public void Big()
        {
            key = 3;
            MyDocument md = MyDocument.Singleton;

            TextSizeBig.FontSize = 45;
            double size = TextSizeBig.FontSize;
            int i = 3;
            md.TextSizeChoice(i, size);

            int a = 45;
            md.AddSize(a);
        }
        internal void WinUp()
        {

            if (key == 0)
            {
                key1 = 2;
                Small();
                return;
            }
            if (key == 20)
            {
                key1 = 2;
                Small();
            }
            else if (key == 30)
            {
                key1 = 3;
                Middle();
            }
            else if (key == 45)
            {
                key1 = 1;
                Big();
            }
            MyRun(key1);
          


        }

        internal void WinDown()
        {
            if (key == 20)
            {
                key1 = 3;
                Small();
            }
            else if (key == 30)
            {
                key1 = 1;
                Middle();
            }
            else if (key == 45)
            {
                key1 = 2;
                Big();
            }

            MyRun(key1);
        }

        private void MyRun(int key1)
        {


            switch (key1)
            {
                case 1: Small(); break;
                case 2: Middle(); break;
                case 3: Big(); break;
                default: break;
              
            }
        }
    }
}
