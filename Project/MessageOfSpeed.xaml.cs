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
    /// MessageOfSpeed.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MessageOfSpeed : UserControl
    {
        private DispatcherTimer _timer30;
        private DispatcherTimer testtimer30;

        private DispatcherTimer _timer40;
        private DispatcherTimer testtimer40;


        private DispatcherTimer _timer50;
        private DispatcherTimer testtimer50;


        private DispatcherTimer _timer80;
        private DispatcherTimer testtimer80;


        private DispatcherTimer _timer100;
        private DispatcherTimer testtimer100;



        bool autoflg = true;

        int number30 = 0;
        int time30 = 0;

        int number40 = 0;
        int time40 = 0;

        int number50 = 0;
        int time50 = 0;

        int number80 = 0;
        int time80 = 0;

        int number100 = 0;
        int time100 = 0;

        public MessageOfSpeed()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            md.SpeedOver30Event1Handler += new SpeedOver30Event1(md_SpeedOver30Event1Handler);
            md.SpeedOver40Event1Handler += new SpeedOver40Event1(md_SpeedOver40Event1Handler);
            md.SpeedOver50Event1Handler += new SpeedOver50Event1(md_SpeedOver50Event1Handler);
            md.SpeedOver80Event1Handler += new SpeedOver80Event1(md_SpeedOver80Event1Handler);
            md.SpeedOver100Event1Handler += new SpeedOver100Event1(md_SpeedOver100Event1Handler);
        
        }

        void md_SpeedOverEvent1Handler()
        {
            overspeed30.Visibility = Visibility.Hidden;
            overspeed40.Visibility = Visibility.Hidden;
            overspeed50.Visibility = Visibility.Hidden;
            overspeed80.Visibility = Visibility.Hidden;
            overspeed100.Visibility = Visibility.Hidden;
        }

        void md_SpeedOver100Event1Handler()
        {
            SpeedOver100();
        }

        private void SpeedOver100()
        {
            if (autoflg == true)
            {
                autoflg = false;

                if (number100 == 0)
                {
                    testtimer100 = new DispatcherTimer();
                    testtimer100.Interval = TimeSpan.FromMilliseconds(3000);
                    testtimer100.Tick += new EventHandler(testtimer100_Tick);
                    testtimer100.Start();

                    number100++;
                    _timer100 = new DispatcherTimer();
                    _timer100.Interval = TimeSpan.FromMilliseconds(500);
                    _timer100.Tick += new EventHandler(_timer100_Tick);


                    _timer100.Start();

                }
            }
        }

        void _timer100_Tick(object sender, EventArgs e)
        {
            time100++;

            if (time100 == 5)
            {
                time100 = 0;
                _timer100.Stop();
            }

            if ((time100 % 2) == 0)
            {
                overspeed100.Visibility = Visibility.Hidden;
            }
            else
            {
                overspeed100.Visibility = Visibility.Visible;
            }
        }

        void testtimer100_Tick(object sender, EventArgs e)
        {
            number100 = 0;
            testtimer100.Stop();
            autoflg = true;
        }



        void md_SpeedOver80Event1Handler()
        {
            SpeedOver80();
        }

        private void SpeedOver80()
        {
            if (autoflg == true)
            {
                autoflg = false;

                if (number80 == 0)
                {
                    testtimer80 = new DispatcherTimer();
                    testtimer80.Interval = TimeSpan.FromMilliseconds(3000);
                    testtimer80.Tick += new EventHandler(testtimer80_Tick);
                    testtimer80.Start();

                    number80++;
                    _timer80 = new DispatcherTimer();
                    _timer80.Interval = TimeSpan.FromMilliseconds(500);
                    _timer80.Tick += new EventHandler(_timer80_Tick);


                    _timer80.Start();

                }
            }
           
        }

        void _timer80_Tick(object sender, EventArgs e)
        {
            time80++;

            if (time80 == 5)
            {
                time80 = 0;
                _timer80.Stop();
            }

            if ((time80 % 2) == 0)
            {
                overspeed80.Visibility = Visibility.Hidden;
            }
            else
            {
                overspeed80.Visibility = Visibility.Visible;
            }
        }

        void testtimer80_Tick(object sender, EventArgs e)
        {
            number80 = 0;
            testtimer80.Stop();
            autoflg = true;
        }

        void md_SpeedOver50Event1Handler()
        {
            SpeedOver50();
        }

        private void SpeedOver50()
        {
            if (autoflg == true)
            {
                autoflg = false;

                if (number50 == 0)
                {
                    testtimer50 = new DispatcherTimer();
                    testtimer50.Interval = TimeSpan.FromMilliseconds(3000);
                    testtimer50.Tick += new EventHandler(testtimer50_Tick);
                    testtimer50.Start();

                    number50++;
                    _timer50 = new DispatcherTimer();
                    _timer50.Interval = TimeSpan.FromMilliseconds(500);
                    _timer50.Tick += new EventHandler(_timer50_Tick);


                    _timer50.Start();

                }
            }
        }

        void _timer50_Tick(object sender, EventArgs e)
        {
            time50++;

            if (time50 == 5)
            {
                time50 = 0;
                _timer50.Stop();
            }

            if ((time50 % 2) == 0)
            {
                overspeed50.Visibility = Visibility.Hidden;
            }
            else
            {
                overspeed50.Visibility = Visibility.Visible;
            }
        }

        void testtimer50_Tick(object sender, EventArgs e)
        {
            number50 = 0;
            testtimer50.Stop();
            autoflg = true;
        }

        void md_SpeedOver40Event1Handler()
        {
            SpeedOver40();
        }

        private void SpeedOver40()
        {
            if (autoflg == true)
            {
                autoflg = false;

                if (number40 == 0)
                {
                    testtimer40 = new DispatcherTimer();
                    testtimer40.Interval = TimeSpan.FromMilliseconds(3000);
                    testtimer40.Tick += new EventHandler(testtimer40_Tick);
                    testtimer40.Start();

                    number40++;
                    _timer40 = new DispatcherTimer();
                    _timer40.Interval = TimeSpan.FromMilliseconds(500);
                    _timer40.Tick += new EventHandler(_timer40_Tick);


                    _timer30.Start();

                }
            }
          
        }

        void _timer40_Tick(object sender, EventArgs e)
        {
            time40++;

            if (time40 == 5)
            {
                time40 = 0;
                _timer40.Stop();
            }

            if ((time40 % 2) == 0)
            {
                overspeed40.Visibility = Visibility.Hidden;
            }
            else
            {
                overspeed40.Visibility = Visibility.Visible;
            }
        }

        void testtimer40_Tick(object sender, EventArgs e)
        {
            number40 = 0;
            testtimer40.Stop();
            autoflg = true;
        }

        void md_SpeedOver30Event1Handler()
        {
            SpeedOver30();
        }

        private void SpeedOver30()
        {
            if (autoflg == true)
            {
                autoflg = false;

                if (number30 == 0)
                {
                    testtimer30 = new DispatcherTimer();
                    testtimer30.Interval = TimeSpan.FromMilliseconds(3000);
                    testtimer30.Tick += new EventHandler(testtimer30_Tick);
                    testtimer30.Start();

                    number30++;
                    _timer30 = new DispatcherTimer();
                    _timer30.Interval = TimeSpan.FromMilliseconds(500);
                    _timer30.Tick += new EventHandler(_timer30_Tick);


                    _timer30.Start();

                }
            }
        }

        void _timer30_Tick(object sender, EventArgs e)
        {
            time30++;

            if (time30 == 5)
            {
                time30 = 0;
                _timer30.Stop();
            }

            if ((time30 % 2) == 0)
            {
                overspeed30.Visibility = Visibility.Hidden;
            }
            else
            {
                overspeed30.Visibility = Visibility.Visible;
            }
        }

        void testtimer30_Tick(object sender, EventArgs e)
        {
            number30 = 0;
            testtimer30.Stop();
            autoflg = true;
        }
    }
}
