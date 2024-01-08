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
using System.Windows.Threading;

namespace Project
{
    /// <summary>
    /// UTrafficSign.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UTrafficSign : UserControl
    {

        bool flg30 = false;
        bool flg50 = false;
        bool flg80 = false;
        bool flg100 = false;
        bool autoflg = true;
        bool bottonautoflg = true;

        int number = 0;
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;

        int time = 0;
        int time1 = 0;
        int time2 = 0;
        int time3 = 0;
       

        private DispatcherTimer _timer;
        private DispatcherTimer testtimer;

        private DispatcherTimer _timer1;
        private DispatcherTimer testtimer1;


        private DispatcherTimer _timer2;
        private DispatcherTimer testtimer2;

        private DispatcherTimer _timer3;
        private DispatcherTimer testtimer3;



        public UTrafficSign()
        {
            InitializeComponent();
        }

        private void Caution_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (autoflg == true)
            {
                autoflg = false;
                if (number == 0)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    testtimer = new DispatcherTimer();
                    testtimer.Interval = TimeSpan.FromMilliseconds(10000);
                    testtimer.Tick += new EventHandler(testtimer_Tick);
                    testtimer.Start();

                    number++;
                    _timer = new DispatcherTimer();
                    _timer.Interval = TimeSpan.FromMilliseconds(1000);
                    _timer.Tick += new EventHandler(_timer_Tick);


                    _timer.Start();
                }
            }                
        }

        void testtimer_Tick(object sender, EventArgs e)
        {            
            number = 0;
            testtimer.Stop();
            autoflg = true;
            
        }

        void _timer_Tick(object sender, EventArgs e)
        {
           
                time++;

                if (time == 10)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    time = 0;
                    _timer.Stop();
                }

                if ((time % 2) == 0)
                {
                    Caution.Visibility = Visibility.Hidden;
                }
                else
                {
                    Caution.Visibility = Visibility.Visible;
                }
                        
            
          
        }

        private void crosswalk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (autoflg == true)
            {
                autoflg = false;
                if (number1 == 0)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    testtimer1 = new DispatcherTimer();
                    testtimer1.Interval = TimeSpan.FromMilliseconds(10000);
                    testtimer1.Tick += new EventHandler(testtimer1_Tick);
                    testtimer1.Start();

                    number1++;
                    _timer1 = new DispatcherTimer();
                    _timer1.Interval = TimeSpan.FromMilliseconds(1000);
                    _timer1.Tick += new EventHandler(_timer1_Tick);


                    _timer1.Start();
                }
            }
        }

        void _timer1_Tick(object sender, EventArgs e)
        {
            time1++;

            if (time1 == 10)
            {
                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();

                time1 = 0;
                _timer1.Stop();
            }

            if ((time1 % 2) == 0)
            {

                crosswalk.Visibility = Visibility.Hidden;
            }
            else
            {
                crosswalk.Visibility = Visibility.Visible;
            }
        }

        void testtimer1_Tick(object sender, EventArgs e)
        {
            number1 = 0;
            testtimer1.Stop();
            autoflg = true;
        }

        private void speed30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.InitSaveSpeed("30");

            if (flg30 == false)
            {
                flg30 = true;
                flg50 = false;
                flg80 = false;
                flg100 = false;



                md.NewSpeed("30");

                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();
            }
            
        }

        

        private void speed50_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.InitSaveSpeed("50");

            if (flg50 == false)
            {
                flg30 = false;
                flg50 = true;
                flg80 = false;
                flg100 = false;



                md.NewSpeed("50");

                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();
            }

        }

        private void speed80_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.InitSaveSpeed("80");

            if (flg80 == false)
            {
                flg30 = false;
                flg50 = false;
                flg80 = true;
                flg100 = false;



                md.NewSpeed("80");

                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();
            }
        }

        private void speed100_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.InitSaveSpeed("100");

            if (flg100 == false)
            {
                flg30 = false;
                flg50 = false;
                flg80 = false;
                flg100 = true;



                md.NewSpeed("100");

                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();
            }
        }

        private void u_traffic_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.Speed30EventHandler += new Speed30Event(md_Speed30EventHandler);
            md.Speed50EventHandler += new Speed50Event(md_Speed50EventHandler);
            md.Speed80EventHandler += new Speed80Event(md_Speed80EventHandler);
            md.Speed100EventHandler += new Speed100Event(md_Speed100EventHandler);
            md.SpeedEventHandler += new SpeedEvent(md_SpeedEventHandler);
            md.TopSignEventHandler += new TopSignEvent(md_TopSignEventHandler);
            md.BottonSignEventHandler += new BottonSignEvent(md_BottonSignEventHandler);
        }

        void md_BottonSignEventHandler(int key)
        {
            BottonSignMenu(key);
        }

        private void BottonSignMenu(int key)
        {
            switch (key)
            {
                case 1: DropsRun(); break;
                case 2: FailRun(); break;
                default: break;
            }
        }

        private void FailRun()
        {
            if (bottonautoflg == true)
            {
                bottonautoflg = false;

                if (number2 == 0)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    testtimer2 = new DispatcherTimer();
                    testtimer2.Interval = TimeSpan.FromMilliseconds(20000);
                    testtimer2.Tick += new EventHandler(testtimer2_Tick);
                    testtimer2.Start();

                    number2++;
                    _timer2 = new DispatcherTimer();
                    _timer2.Interval = TimeSpan.FromMilliseconds(700);
                    _timer2.Tick += new EventHandler(_timer2_Tick);


                    _timer2.Start();
                }
            }
        }

        private void DropsRun()
        {
            if (bottonautoflg == true)
            {
                bottonautoflg = false;
                if (number3 == 0)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    testtimer3 = new DispatcherTimer();
                    testtimer3.Interval = TimeSpan.FromMilliseconds(20000);
                    testtimer3.Tick += new EventHandler(testtimer3_Tick);
                    testtimer3.Start();

                    number3++;
                    _timer3 = new DispatcherTimer();
                    _timer3.Interval = TimeSpan.FromMilliseconds(700);
                    _timer3.Tick += new EventHandler(_timer3_Tick);


                    _timer3.Start();
                }
            }
        }

        void md_TopSignEventHandler(int key)
        {
            TopSignMenu(key);
        }

        private void TopSignMenu(int key)
        {
           
            switch (key)
            {
                case 1: CautionRun(); break;
                case 2: CrossWalk(); break;
                default : break;
            }
        }

        private void CrossWalk()
        {
            if (autoflg == true)
            {
                autoflg = false;
                if (number1 == 0)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    testtimer1 = new DispatcherTimer();
                    testtimer1.Interval = TimeSpan.FromMilliseconds(10000);
                    testtimer1.Tick += new EventHandler(testtimer1_Tick);
                    testtimer1.Start();

                    number1++;
                    _timer1 = new DispatcherTimer();
                    _timer1.Interval = TimeSpan.FromMilliseconds(1000);
                    _timer1.Tick += new EventHandler(_timer1_Tick);


                    _timer1.Start();
                }
            }
        }

        private void CautionRun()
        {
            if (autoflg == true)
            {
                autoflg = false;
                if (number == 0)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    testtimer = new DispatcherTimer();
                    testtimer.Interval = TimeSpan.FromMilliseconds(10000);
                    testtimer.Tick += new EventHandler(testtimer_Tick);
                    testtimer.Start();

                    number++;
                    _timer = new DispatcherTimer();
                    _timer.Interval = TimeSpan.FromMilliseconds(1000);
                    _timer.Tick += new EventHandler(_timer_Tick);


                    _timer.Start();
                }
            }         
        }

        void md_SpeedEventHandler(int speed)
        {
            SpeedMenuRun(speed);
        }

        private void SpeedMenuRun(int speed)
        {
            MyDocument md = MyDocument.Singleton;

            md.checkdMySpeed(speed);

            switch (speed)
            {
                case 30: Speed30(); break;
                case 50: Speed50(); break;
                case 80: Speed80(); break;
                case 100: Speed100(); break;
                default: break;
            }
        }

        private void Speed100()
        {
            speed30.Visibility = Visibility.Hidden;
            speed50.Visibility = Visibility.Hidden;
            speed80.Visibility = Visibility.Hidden;
            speed100.Visibility = Visibility.Visible;
        }

        private void Speed80()
        {
            speed30.Visibility = Visibility.Hidden;
            speed50.Visibility = Visibility.Hidden;
            speed80.Visibility = Visibility.Visible;
            speed100.Visibility = Visibility.Hidden;
        }

        private void Speed50()
        {
            speed30.Visibility = Visibility.Hidden;
            speed50.Visibility = Visibility.Visible;
            speed80.Visibility = Visibility.Hidden;
            speed100.Visibility = Visibility.Hidden;
        }

        private void Speed30()
        {
            speed30.Visibility = Visibility.Visible;
            speed50.Visibility = Visibility.Hidden;
            speed80.Visibility = Visibility.Hidden;
            speed100.Visibility = Visibility.Hidden;
        }

        void md_Speed100EventHandler()
        {
            speed30.Visibility = Visibility.Hidden;
            speed50.Visibility = Visibility.Hidden;
            speed80.Visibility = Visibility.Hidden;
            speed100.Visibility = Visibility.Visible;
        }

        void md_Speed80EventHandler()
        {
            speed30.Visibility = Visibility.Hidden;
            speed50.Visibility = Visibility.Hidden;
            speed80.Visibility = Visibility.Visible;
            speed100.Visibility = Visibility.Hidden;
        }

        void md_Speed50EventHandler()
        {
            speed30.Visibility = Visibility.Hidden;
            speed50.Visibility = Visibility.Visible;
            speed80.Visibility = Visibility.Hidden;
            speed100.Visibility = Visibility.Hidden;
        }

        void md_Speed30EventHandler()
        {
            speed30.Visibility = Visibility.Visible;
            speed50.Visibility = Visibility.Hidden;
            speed80.Visibility = Visibility.Hidden;
            speed100.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            speed30.Visibility = Visibility.Visible;
            speed50.Visibility = Visibility.Visible;
            speed80.Visibility = Visibility.Visible;
            speed100.Visibility = Visibility.Visible;
        }

        private void fallingrocks_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (bottonautoflg == true)
            {
                bottonautoflg = false;

                if (number2 == 0)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    testtimer2 = new DispatcherTimer();
                    testtimer2.Interval = TimeSpan.FromMilliseconds(20000);
                    testtimer2.Tick += new EventHandler(testtimer2_Tick);
                    testtimer2.Start();

                    number2++;
                    _timer2 = new DispatcherTimer();
                    _timer2.Interval = TimeSpan.FromMilliseconds(10000);
                    _timer2.Tick += new EventHandler(_timer2_Tick);


                    _timer2.Start();
                }
            }
        }

        void testtimer2_Tick(object sender, EventArgs e)
        {
            number2 = 0;
            testtimer2.Stop();
            bottonautoflg = true;
        }

        void _timer2_Tick(object sender, EventArgs e)
        {
            time2++;

            if (time2 == 26)
            {
                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();

                time2 = 0;
                _timer2.Stop();
            }

            if ((time2 %  2) == 0)
            {
                fallingrocks.Visibility = Visibility.Hidden;
            }
            else
            {
                fallingrocks.Visibility = Visibility.Visible;
            }
        }

        //추락 
        private void drop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (bottonautoflg == true)
            {
                bottonautoflg = false;
                if (number3 == 0)
                {
                    System.Media.SoundPlayer sp;
                    sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                    sp.Play();

                    testtimer3 = new DispatcherTimer();
                    testtimer3.Interval = TimeSpan.FromMilliseconds(20000);
                    testtimer3.Tick += new EventHandler(testtimer3_Tick);
                    testtimer3.Start();

                    number3++;
                    _timer3 = new DispatcherTimer();
                    _timer3.Interval = TimeSpan.FromMilliseconds(10000);
                    _timer3.Tick += new EventHandler(_timer3_Tick);


                    _timer3.Start();
                }
            }
        }

        void testtimer3_Tick(object sender, EventArgs e)
        {
            number3 = 0;
            testtimer3.Stop();
            bottonautoflg = true;
        }


        void _timer3_Tick(object sender, EventArgs e)
        {
            time3++;

            if (time3 == 26)
            {
                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();

                time3 = 0;
                _timer3.Stop();
            }

            if ((time3 % 2) == 0)
            {
                drop.Visibility = Visibility.Hidden;
            }
            else
            {
                drop.Visibility = Visibility.Visible;
            }
        }

       
    }
}
