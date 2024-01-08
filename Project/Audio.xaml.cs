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
    /// Audio.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 


    public partial class Audio : UserControl
    {
        int num = 0;

        public Audio()
        {
            InitializeComponent();
        }

        private void MyMin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AudioSound audiosound = AudioSound.Singleton;

            num = ++audiosound.NowSound;
            

            switch (num)
            {
                case 1: Volum1.Visibility = Visibility.Visible; ; break;
                case 2: Volum2.Visibility = Visibility.Visible; ; break;
                case 3: Volum3.Visibility = Visibility.Visible; ; break;
                case 4: Volum4.Visibility = Visibility.Visible; ; break;
                case 5: Volum5.Visibility = Visibility.Visible; break;
                default: break;
            }

        }

        private void MyMax_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AudioSound audiosound = AudioSound.Singleton;

            num = audiosound.NowSound--;

            switch (num)
            {
                case 1: Volum1.Visibility = Visibility.Hidden; ; break;
                case 2: Volum2.Visibility = Visibility.Hidden; ; break;
                case 3: Volum3.Visibility = Visibility.Hidden; ; break;
                case 4: Volum4.Visibility = Visibility.Hidden;; break;
                case 5: Volum5.Visibility = Visibility.Hidden; ; break;
                default: break;
            }

        }

        private void MyMin_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            md.TestMemberEventHandler += new TestMemberEvent(OnAddMember);
            md.AudioSizeEventHandler += new AudioSizeEvent(OnChangeSize);

         


            md.AddColorEventHandler += new AddColorEvent(md_AddColorEventHandler);
            md.AddSizeEventHandler += new AddSizeEvent(md_AddSizeEventHandler);
            md.Start();
            md.Start1();

          

          
            
        }

        void md_AddSizeEventHandler(int size)
        {
            MyMax.FontSize = size;
            MyMin.FontSize = size;
        }

        void md_AddColorEventHandler(SolidColorBrush color)
        {
            MyMax.Foreground = color;
            MyMin.Foreground = color;
            Volum1.Fill = color;
            Volum2.Fill = color;
            Volum3.Fill = color;
            Volum4.Fill = color;
            Volum5.Fill = color;
        }

        void OnAddMember(Brush color)
        {
            MyMax.Foreground = color;
            MyMin.Foreground = color;
            Volum1.Fill = color;
            Volum2.Fill = color;
            Volum3.Fill = color;
            Volum4.Fill = color;
            Volum5.Fill = color;
        }

        void OnChangeSize(double size)
        {
            MyMax.FontSize = size;
            MyMin.FontSize = size;
        }


        internal void WinUp()
        {
            AudioSound audiosound = AudioSound.Singleton;

            num = ++audiosound.NowSound;

            switch (num)
            {
                case 1: Volum1.Visibility = Visibility.Visible; num++; break;
                case 2: Volum2.Visibility = Visibility.Visible; num++; break;
                case 3: Volum3.Visibility = Visibility.Visible; num++; break;
                case 4: Volum4.Visibility = Visibility.Visible; num++; break;
                case 5: Volum5.Visibility = Visibility.Visible; break;
                default: break;
            }
        }

        internal void WinDown()
        {
            AudioSound audiosound = AudioSound.Singleton;

            num = audiosound.NowSound--;

            switch (num)
            {
                case 1: Volum1.Visibility = Visibility.Hidden; ; break;
                case 2: Volum2.Visibility = Visibility.Hidden; num--; break;
                case 3: Volum3.Visibility = Visibility.Hidden; num--; break;
                case 4: Volum4.Visibility = Visibility.Hidden; num--; break;
                case 5: Volum5.Visibility = Visibility.Hidden; num--; break;
                default: break;
            }
        }
    }
}
