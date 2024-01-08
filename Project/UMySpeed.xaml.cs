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
    /// UMySpeed.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UMySpeed : UserControl
    {
        double pre_latitude = 0;
        double pre_longitude = 0;

        int myspeed = 0;

        double i = 0;

        int cnt = 0;

        double speed = 0;
        private int time = 0;

        private DispatcherTimer _timer;


        bool speedover30flg = false;
        bool speedover40flg = false;
        bool speedover50flg = false;
        bool speedover80flg = false;
        bool speedover100flg = false;

        bool speedoverflg = false;

        public UMySpeed()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            md.AddColorEventHandler += new AddColorEvent(md_AddColorEventHandler);
            md.AddSizeEventHandler += new AddSizeEvent(md_AddSizeEventHandler);
            md.MyspeedEventHandler += new MyspeedEvent(md_MyspeedEventHandler);
            md.AndroidEventHandler += new AndroidEvent(md_AndroidEventHandler);

            md.StopSpeedEventHandler += new StopSpeedEvent(md_StopSpeedEventHandler);
            md.SpeedOver30EventHandler += new SpeedOver30Event(md_SpeedOver30EventHandler);
            md.SpeedOver40EventHandler += new SpeedOver40Event(md_SpeedOver40EventHandler);
            md.SpeedOver50EventHandler += new SpeedOver50Event(md_SpeedOver50EventHandler);
            md.SpeedOver80EventHandler += new SpeedOver80Event(md_SpeedOver80EventHandler);
            md.SpeedOver100EventHandler += new SpeedOver100Event(md_SpeedOver100EventHandler);
            md.Start1();
            md.Start2();
        }

        void md_SpeedOver100EventHandler()
        {
            SpeedOver100();
        }



        void md_SpeedOver80EventHandler()
        {
            SpeedOver80();
        }

        void md_SpeedOver50EventHandler()
        {
            SpeedOver50();
        }

        void md_SpeedOver40EventHandler()
        {
            SpeedOver40();
        }

        void md_SpeedOver30EventHandler()
        {
            SpeedOver30();
        }

        void md_StopSpeedEventHandler()
        {
            StopSpeed();
        }

        void md_AndroidEventHandler()
        {
            AutoRunEvet();
        }

        private void AutoRunEvet()
        {
            MyDocument md = MyDocument.Singleton;

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(1000);
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();
        }
        void _timer_Tick(object sender, EventArgs e)
        {
        //    ServiceReference1.Service1SoapClient se = new Project.ServiceReference1.Service1SoapClient();
            ServiceReference1.ServiceSoapClient se = new Project.ServiceReference1.ServiceSoapClient();

            MyDocument md = MyDocument.Singleton;
        

            GpsCalc gps = new GpsCalc();
            try
            {
                string latitude = string.Empty;
                string longitude = string.Empty;

                double Latitude = 0;
                double Longitude = 0;

                if (cnt == 0)
                {
                    latitude =  se.GetLatitude();
                    longitude = se.GetLongitude();




                     Latitude = double.Parse(latitude);
                     Longitude = double.Parse(longitude);

                     pre_latitude = Latitude;
                     pre_longitude = Longitude;
                    

                }
                else 
                {
                    latitude = se.GetLatitude();
                    longitude = se.GetLongitude();



                    Latitude = double.Parse(latitude);
                    Longitude = double.Parse(longitude);

                    double distance = 0;


                    i++; //같으면 그담에서 합쳐서 계산해서. 2개 속도 나옴 방지를 위함.

                    if (pre_latitude != Latitude || pre_longitude != Longitude)
                    {


                        distance = gps.distance(Latitude, Longitude, pre_latitude, pre_longitude);

                        speed = distance * ( 1.8/ i);

                        speed = Math.Round(speed);
                        myspeed = (int)speed;

                        

                        Run(myspeed);
                        i = 0;

                        md.SetSpeed(myspeed);

                    }


                    pre_latitude = Latitude;
                    pre_longitude = Longitude;

                }



                if (speed < 10) //속도가 10이하 이고
                {
                    ////10초동안 변화 없으면 0으로 속도함 
                    //if (i > 10)
                    //{
                    //    Run(0);
                    //}
 
                }
               
            }

            catch
            {
 
            }

            cnt++;
            Menu(myspeed);
           
        }

        void Menu(int myspeed)
        {
            MyDocument md = MyDocument.Singleton;

            if (myspeed > 35 && speedover30flg == true)
            {
                md.SpeedText(1);
                // MessageBox.Show("30km 구간입니다.");
               
              

            }

            if (myspeed > 45 && speedover40flg == true)
            {
                md.SpeedText(2);
              
               
                // MessageBox.Show("40km 구간입니다.");
            }

            if (myspeed > 55 && speedover50flg == true)
            {
                md.SpeedText(3);
              
              

                // MessageBox.Show("50km 구간입니다.");
            }

            if (myspeed > 90 && speedover80flg == true)
            {
                md.SpeedText(4);
             
              
                //  MessageBox.Show("80km 구간입니다.");
            }

            if (myspeed > 110 && speedover100flg == true)
            {
                md.SpeedText(5);
               

                // MessageBox.Show("100km 구간입니다.");
            }
        }

        //30km 구간
        void SpeedOver30() { speedover30flg = true; speedover40flg = false; speedover50flg = false; speedover80flg = false; speedover100flg = false; }

        //40km 구간
        void SpeedOver40() { speedover30flg = false; speedover40flg = true; speedover50flg = false; speedover80flg = false; speedover100flg = false; }


        //50km 구간
        void SpeedOver50() { speedover30flg = false; speedover40flg = false; speedover50flg = true; speedover80flg = false; speedover100flg = false; }


        //80km 구간
        void SpeedOver80() { speedover30flg = false; speedover40flg = false; speedover50flg = false; speedover80flg = true; speedover100flg = false; }

        //100km 구간
        void SpeedOver100() { speedover30flg = false; speedover40flg = false; speedover50flg = false; speedover80flg = false; speedover100flg = true; }



        void StopSpeed()
        {
            _timer.Stop();
        }

        void Run(int speed)
        {
           
            switch (speed)
            {
                case 0: MyCarSpeed.Content = speed; break;
                case 1: MyCarSpeed.Content = speed; break;
                case 2: MyCarSpeed.Content = speed; break;
                case 3: MyCarSpeed.Content = speed; break;
                case 4: MyCarSpeed.Content = speed; break;
                case 5: MyCarSpeed.Content = speed; break;
                case 6: MyCarSpeed.Content = speed; break;
                case 7: MyCarSpeed.Content = speed; break;
                case 8: MyCarSpeed.Content = speed; break;
                case 9: MyCarSpeed.Content = speed; break;

                case 10: MyCarSpeed.Content = speed; break;
                case 11: MyCarSpeed.Content = speed; break;
                case 12: MyCarSpeed.Content = speed; break;
                case 13: MyCarSpeed.Content = speed; break;
                case 14: MyCarSpeed.Content = speed; break;
                case 15: MyCarSpeed.Content = speed; break;
                case 16: MyCarSpeed.Content = speed; break;
                case 17: MyCarSpeed.Content = speed; break;
                case 18: MyCarSpeed.Content = speed; break;
                case 19: MyCarSpeed.Content = speed; break;

                case 20: MyCarSpeed.Content = speed; break;
                case 21: MyCarSpeed.Content = speed; break;
                case 22: MyCarSpeed.Content = speed; break;
                case 23: MyCarSpeed.Content = speed; break;
                case 24: MyCarSpeed.Content = speed; break;
                case 25: MyCarSpeed.Content = speed; break;
                case 26: MyCarSpeed.Content = speed; break;
                case 27: MyCarSpeed.Content = speed; break;
                case 28: MyCarSpeed.Content = speed; break;
                case 29: MyCarSpeed.Content = speed; break;

                case 30: MyCarSpeed.Content = speed; break;
                case 31: MyCarSpeed.Content = speed; break;
                case 32: MyCarSpeed.Content = speed; break;
                case 33: MyCarSpeed.Content = speed; break;
                case 34: MyCarSpeed.Content = speed; break;
                case 35: MyCarSpeed.Content = speed; break;
                case 36: MyCarSpeed.Content = speed; break;
                case 37: MyCarSpeed.Content = speed; break;
                case 38: MyCarSpeed.Content = speed; break;
                case 39: MyCarSpeed.Content = speed; break;


                case 40: MyCarSpeed.Content = speed; break;
                case 41: MyCarSpeed.Content = speed; break;
                case 42: MyCarSpeed.Content = speed; break;
                case 43: MyCarSpeed.Content = speed; break;
                case 44: MyCarSpeed.Content = speed; break;
                case 45: MyCarSpeed.Content = speed; break;
                case 46: MyCarSpeed.Content = speed; break;
                case 47: MyCarSpeed.Content = speed; break;
                case 48: MyCarSpeed.Content = speed; break;
                case 49: MyCarSpeed.Content = speed; break;


                case 50: MyCarSpeed.Content = speed; break;
                case 51: MyCarSpeed.Content = speed; break;
                case 52: MyCarSpeed.Content = speed; break;
                case 53: MyCarSpeed.Content = speed; break;
                case 54: MyCarSpeed.Content = speed; break;
                case 55: MyCarSpeed.Content = speed; break;
                case 56: MyCarSpeed.Content = speed; break;
                case 57: MyCarSpeed.Content = speed; break;
                case 58: MyCarSpeed.Content = speed; break;
                case 59: MyCarSpeed.Content = speed; break;


                case 60: MyCarSpeed.Content = speed; break;
                case 61: MyCarSpeed.Content = speed; break;
                case 62: MyCarSpeed.Content = speed; break;
                case 63: MyCarSpeed.Content = speed; break;
                case 64: MyCarSpeed.Content = speed; break;
                case 65: MyCarSpeed.Content = speed; break;
                case 66: MyCarSpeed.Content = speed; break;
                case 67: MyCarSpeed.Content = speed; break;
                case 68: MyCarSpeed.Content = speed; break;
                case 69: MyCarSpeed.Content = speed; break;


                case 70: MyCarSpeed.Content = speed; break;
                case 71: MyCarSpeed.Content = speed; break;
                case 72: MyCarSpeed.Content = speed; break;
                case 73: MyCarSpeed.Content = speed; break;
                case 74: MyCarSpeed.Content = speed; break;
                case 75: MyCarSpeed.Content = speed; break;
                case 76: MyCarSpeed.Content = speed; break;
                case 77: MyCarSpeed.Content = speed; break;
                case 78: MyCarSpeed.Content = speed; break;
                case 79: MyCarSpeed.Content = speed; break;

                case 80: MyCarSpeed.Content = speed; break;
                case 81: MyCarSpeed.Content = speed; break;
                case 82: MyCarSpeed.Content = speed; break;
                case 83: MyCarSpeed.Content = speed; break;
                case 84: MyCarSpeed.Content = speed; break;
                case 85: MyCarSpeed.Content = speed; break;
                case 86: MyCarSpeed.Content = speed; break;
                case 87: MyCarSpeed.Content = speed; break;
                case 88: MyCarSpeed.Content = speed; break;
                case 89: MyCarSpeed.Content = speed; break;

                case 90: MyCarSpeed.Content = speed; break;
                case 91: MyCarSpeed.Content = speed; break;
                case 92: MyCarSpeed.Content = speed; break;
                case 93: MyCarSpeed.Content = speed; break;
                case 94: MyCarSpeed.Content = speed; break;
                case 95: MyCarSpeed.Content = speed; break;
                case 96: MyCarSpeed.Content = speed; break;
                case 97: MyCarSpeed.Content = speed; break;
                case 98: MyCarSpeed.Content = speed; break;
                case 99: MyCarSpeed.Content = speed; break;

                case 100: MyCarSpeed.Content = speed; break;
                case 101: MyCarSpeed.Content = speed; break;
                case 102: MyCarSpeed.Content = speed; break;
                case 103: MyCarSpeed.Content = speed; break;
                case 104: MyCarSpeed.Content = speed; break;
                case 105: MyCarSpeed.Content = speed; break;
                case 106: MyCarSpeed.Content = speed; break;
                case 107: MyCarSpeed.Content = speed; break;
                case 108: MyCarSpeed.Content = speed; break;
                case 109: MyCarSpeed.Content = speed; break;

                case 110: MyCarSpeed.Content = speed; break;
                case 111: MyCarSpeed.Content = speed; break;
                case 112: MyCarSpeed.Content = speed; break;
                case 113: MyCarSpeed.Content = speed; break;
                case 114: MyCarSpeed.Content = speed; break;
                case 115: MyCarSpeed.Content = speed; break;
                case 116: MyCarSpeed.Content = speed; break;
                case 117: MyCarSpeed.Content = speed; break;
                case 118: MyCarSpeed.Content = speed; break;
                case 119: MyCarSpeed.Content = speed; break;

                case 120: MyCarSpeed.Content = speed; break;
                case 121: MyCarSpeed.Content = speed; break;
                case 122: MyCarSpeed.Content = speed; break;
                case 123: MyCarSpeed.Content = speed; break;
                case 124: MyCarSpeed.Content = speed; break;
                case 125: MyCarSpeed.Content = speed; break;
                case 126: MyCarSpeed.Content = speed; break;
                case 127: MyCarSpeed.Content = speed; break;
                case 128: MyCarSpeed.Content = speed; break;
                case 129: MyCarSpeed.Content = speed; break;

                case 130: MyCarSpeed.Content = speed; break;
                case 131: MyCarSpeed.Content = speed; break;
                case 132: MyCarSpeed.Content = speed; break;
                case 133: MyCarSpeed.Content = speed; break;
                case 134: MyCarSpeed.Content = speed; break;
                case 135: MyCarSpeed.Content = speed; break;
                case 136: MyCarSpeed.Content = speed; break;
                case 137: MyCarSpeed.Content = speed; break;
                case 138: MyCarSpeed.Content = speed; break;
                case 139: MyCarSpeed.Content = speed; break;


                case 140: MyCarSpeed.Content = speed; break;
                case 141: MyCarSpeed.Content = speed; break;
                case 142: MyCarSpeed.Content = speed; break;
                case 143: MyCarSpeed.Content = speed; break;
                case 144: MyCarSpeed.Content = speed; break;
                case 145: MyCarSpeed.Content = speed; break;
                case 146: MyCarSpeed.Content = speed; break;
                case 147: MyCarSpeed.Content = speed; break;
                case 148: MyCarSpeed.Content = speed; break;
                case 149: MyCarSpeed.Content = speed; break;


                case 150: MyCarSpeed.Content = speed; break;
                case 151: MyCarSpeed.Content = speed; break;
                case 152: MyCarSpeed.Content = speed; break;
                case 153: MyCarSpeed.Content = speed; break;
                case 154: MyCarSpeed.Content = speed; break;
                case 155: MyCarSpeed.Content = speed; break;
                case 156: MyCarSpeed.Content = speed; break;
                case 157: MyCarSpeed.Content = speed; break;
                case 158: MyCarSpeed.Content = speed; break;
                case 159: MyCarSpeed.Content = speed; break;


                case 160: MyCarSpeed.Content = speed; break;
                case 161: MyCarSpeed.Content = speed; break;
                case 162: MyCarSpeed.Content = speed; break;
                case 163: MyCarSpeed.Content = speed; break;
                case 164: MyCarSpeed.Content = speed; break;
                case 165: MyCarSpeed.Content = speed; break;
                case 166: MyCarSpeed.Content = speed; break;
                case 167: MyCarSpeed.Content = speed; break;
                case 168: MyCarSpeed.Content = speed; break;
                case 169: MyCarSpeed.Content = speed; break;


                case 170: MyCarSpeed.Content = speed; break;
                case 171: MyCarSpeed.Content = speed; break;
                case 172: MyCarSpeed.Content = speed; break;
                case 173: MyCarSpeed.Content = speed; break;
                case 174: MyCarSpeed.Content = speed; break;
                case 175: MyCarSpeed.Content = speed; break;
                case 176: MyCarSpeed.Content = speed; break;
                case 177: MyCarSpeed.Content = speed; break;
                case 178: MyCarSpeed.Content = speed; break;
                case 179: MyCarSpeed.Content = speed; break;

                case 180: MyCarSpeed.Content = speed; break;
                case 181: MyCarSpeed.Content = speed; break;
                case 182: MyCarSpeed.Content = speed; break;
                case 183: MyCarSpeed.Content = speed; break;
                case 184: MyCarSpeed.Content = speed; break;
                case 185: MyCarSpeed.Content = speed; break;
                case 186: MyCarSpeed.Content = speed; break;
                case 187: MyCarSpeed.Content = speed; break;
                case 188: MyCarSpeed.Content = speed; break;
                case 189: MyCarSpeed.Content = speed; break;

                case 190: MyCarSpeed.Content = speed; break;
                case 191: MyCarSpeed.Content = speed; break;
                case 192: MyCarSpeed.Content = speed; break;
                case 193: MyCarSpeed.Content = speed; break;
                case 194: MyCarSpeed.Content = speed; break;
                case 195: MyCarSpeed.Content = speed; break;
                case 196: MyCarSpeed.Content = speed; break;
                case 197: MyCarSpeed.Content = speed; break;
                case 198: MyCarSpeed.Content = speed; break;
                case 199: MyCarSpeed.Content = speed; break;
                case 200: MyCarSpeed.Content = speed; break;
            }
        }



        void md_MyspeedEventHandler(int speed)
        {
            MyDocument md = MyDocument.Singleton;

            md.SetMyspeed(speed);

            Menu(speed);



            switch (speed)
            {
                case 0: MyCarSpeed.Content = speed; break;
                case 1: MyCarSpeed.Content = speed; break;
                case 2: MyCarSpeed.Content = speed; break;
                case 3: MyCarSpeed.Content = speed; break;
                case 4: MyCarSpeed.Content = speed; break;
                case 5: MyCarSpeed.Content = speed; break;
                case 6: MyCarSpeed.Content = speed; break;
                case 7: MyCarSpeed.Content = speed; break;
                case 8: MyCarSpeed.Content = speed; break;
                case 9: MyCarSpeed.Content = speed; break;

                case 10: MyCarSpeed.Content = speed; break;
                case 11: MyCarSpeed.Content = speed; break;
                case 12: MyCarSpeed.Content = speed; break;
                case 13: MyCarSpeed.Content = speed; break;
                case 14: MyCarSpeed.Content = speed; break;
                case 15: MyCarSpeed.Content = speed; break;
                case 16: MyCarSpeed.Content = speed; break;
                case 17: MyCarSpeed.Content = speed; break;
                case 18: MyCarSpeed.Content = speed; break;
                case 19: MyCarSpeed.Content = speed; break;

                case 20: MyCarSpeed.Content = speed; break;
                case 21: MyCarSpeed.Content = speed; break;
                case 22: MyCarSpeed.Content = speed; break;
                case 23: MyCarSpeed.Content = speed; break;
                case 24: MyCarSpeed.Content = speed; break;
                case 25: MyCarSpeed.Content = speed; break;
                case 26: MyCarSpeed.Content = speed; break;
                case 27: MyCarSpeed.Content = speed; break;
                case 28: MyCarSpeed.Content = speed; break;
                case 29: MyCarSpeed.Content = speed; break;

                case 30: MyCarSpeed.Content = speed; break;
                case 31: MyCarSpeed.Content = speed; break;
                case 32: MyCarSpeed.Content = speed; break;
                case 33: MyCarSpeed.Content = speed; break;
                case 34: MyCarSpeed.Content = speed; break;
                case 35: MyCarSpeed.Content = speed; break;
                case 36: MyCarSpeed.Content = speed; break;
                case 37: MyCarSpeed.Content = speed; break;
                case 38: MyCarSpeed.Content = speed; break;
                case 39: MyCarSpeed.Content = speed; break;


                case 40: MyCarSpeed.Content = speed; break;
                case 41: MyCarSpeed.Content = speed; break;
                case 42: MyCarSpeed.Content = speed; break;
                case 43: MyCarSpeed.Content = speed; break;
                case 44: MyCarSpeed.Content = speed; break;
                case 45: MyCarSpeed.Content = speed; break;
                case 46: MyCarSpeed.Content = speed; break;
                case 47: MyCarSpeed.Content = speed; break;
                case 48: MyCarSpeed.Content = speed; break;
                case 49: MyCarSpeed.Content = speed; break;


                case 50: MyCarSpeed.Content = speed; break;
                case 51: MyCarSpeed.Content = speed; break;
                case 52: MyCarSpeed.Content = speed; break;
                case 53: MyCarSpeed.Content = speed; break;
                case 54: MyCarSpeed.Content = speed; break;
                case 55: MyCarSpeed.Content = speed; break;
                case 56: MyCarSpeed.Content = speed; break;
                case 57: MyCarSpeed.Content = speed; break;
                case 58: MyCarSpeed.Content = speed; break;
                case 59: MyCarSpeed.Content = speed; break;


                case 60: MyCarSpeed.Content = speed; break;
                case 61: MyCarSpeed.Content = speed; break;
                case 62: MyCarSpeed.Content = speed; break;
                case 63: MyCarSpeed.Content = speed; break;
                case 64: MyCarSpeed.Content = speed; break;
                case 65: MyCarSpeed.Content = speed; break;
                case 66: MyCarSpeed.Content = speed; break;
                case 67: MyCarSpeed.Content = speed; break;
                case 68: MyCarSpeed.Content = speed; break;
                case 69: MyCarSpeed.Content = speed; break;


                case 70: MyCarSpeed.Content = speed; break;
                case 71: MyCarSpeed.Content = speed; break;
                case 72: MyCarSpeed.Content = speed; break;
                case 73: MyCarSpeed.Content = speed; break;
                case 74: MyCarSpeed.Content = speed; break;
                case 75: MyCarSpeed.Content = speed; break;
                case 76: MyCarSpeed.Content = speed; break;
                case 77: MyCarSpeed.Content = speed; break;
                case 78: MyCarSpeed.Content = speed; break;
                case 79: MyCarSpeed.Content = speed; break;

                case 80: MyCarSpeed.Content = speed; break;
                case 81: MyCarSpeed.Content = speed; break;
                case 82: MyCarSpeed.Content = speed; break;
                case 83: MyCarSpeed.Content = speed; break;
                case 84: MyCarSpeed.Content = speed; break;
                case 85: MyCarSpeed.Content = speed; break;
                case 86: MyCarSpeed.Content = speed; break;
                case 87: MyCarSpeed.Content = speed; break;
                case 88: MyCarSpeed.Content = speed; break;
                case 89: MyCarSpeed.Content = speed; break;

                case 90: MyCarSpeed.Content = speed; break;
                case 91: MyCarSpeed.Content = speed; break;
                case 92: MyCarSpeed.Content = speed; break;
                case 93: MyCarSpeed.Content = speed; break;
                case 94: MyCarSpeed.Content = speed; break;
                case 95: MyCarSpeed.Content = speed; break;
                case 96: MyCarSpeed.Content = speed; break;
                case 97: MyCarSpeed.Content = speed; break;
                case 98: MyCarSpeed.Content = speed; break;
                case 99: MyCarSpeed.Content = speed; break;

                case 100: MyCarSpeed.Content = speed; break;
                case 101: MyCarSpeed.Content = speed; break;
                case 102: MyCarSpeed.Content = speed; break;
                case 103: MyCarSpeed.Content = speed; break;
                case 104: MyCarSpeed.Content = speed; break;
                case 105: MyCarSpeed.Content = speed; break;
                case 106: MyCarSpeed.Content = speed; break;
                case 107: MyCarSpeed.Content = speed; break;
                case 108: MyCarSpeed.Content = speed; break;
                case 109: MyCarSpeed.Content = speed; break;

                case 110: MyCarSpeed.Content = speed; break;
                case 111: MyCarSpeed.Content = speed; break;
                case 112: MyCarSpeed.Content = speed; break;
                case 113: MyCarSpeed.Content = speed; break;
                case 114: MyCarSpeed.Content = speed; break;
                case 115: MyCarSpeed.Content = speed; break;
                case 116: MyCarSpeed.Content = speed; break;
                case 117: MyCarSpeed.Content = speed; break;
                case 118: MyCarSpeed.Content = speed; break;
                case 119: MyCarSpeed.Content = speed; break;

                case 120: MyCarSpeed.Content = speed; break;
                case 121: MyCarSpeed.Content = speed; break;
                case 122: MyCarSpeed.Content = speed; break;
                case 123: MyCarSpeed.Content = speed; break;
                case 124: MyCarSpeed.Content = speed; break;
                case 125: MyCarSpeed.Content = speed; break;
                case 126: MyCarSpeed.Content = speed; break;
                case 127: MyCarSpeed.Content = speed; break;
                case 128: MyCarSpeed.Content = speed; break;
                case 129: MyCarSpeed.Content = speed; break;

                case 130: MyCarSpeed.Content = speed; break;
                case 131: MyCarSpeed.Content = speed; break;
                case 132: MyCarSpeed.Content = speed; break;
                case 133: MyCarSpeed.Content = speed; break;
                case 134: MyCarSpeed.Content = speed; break;
                case 135: MyCarSpeed.Content = speed; break;
                case 136: MyCarSpeed.Content = speed; break;
                case 137: MyCarSpeed.Content = speed; break;
                case 138: MyCarSpeed.Content = speed; break;
                case 139: MyCarSpeed.Content = speed; break;


                case 140: MyCarSpeed.Content = speed; break;
                case 141: MyCarSpeed.Content = speed; break;
                case 142: MyCarSpeed.Content = speed; break;
                case 143: MyCarSpeed.Content = speed; break;
                case 144: MyCarSpeed.Content = speed; break;
                case 145: MyCarSpeed.Content = speed; break;
                case 146: MyCarSpeed.Content = speed; break;
                case 147: MyCarSpeed.Content = speed; break;
                case 148: MyCarSpeed.Content = speed; break;
                case 149: MyCarSpeed.Content = speed; break;


                case 150: MyCarSpeed.Content = speed; break;
                case 151: MyCarSpeed.Content = speed; break;
                case 152: MyCarSpeed.Content = speed; break;
                case 153: MyCarSpeed.Content = speed; break;
                case 154: MyCarSpeed.Content = speed; break;
                case 155: MyCarSpeed.Content = speed; break;
                case 156: MyCarSpeed.Content = speed; break;
                case 157: MyCarSpeed.Content = speed; break;
                case 158: MyCarSpeed.Content = speed; break;
                case 159: MyCarSpeed.Content = speed; break;


                case 160: MyCarSpeed.Content = speed; break;
                case 161: MyCarSpeed.Content = speed; break;
                case 162: MyCarSpeed.Content = speed; break;
                case 163: MyCarSpeed.Content = speed; break;
                case 164: MyCarSpeed.Content = speed; break;
                case 165: MyCarSpeed.Content = speed; break;
                case 166: MyCarSpeed.Content = speed; break;
                case 167: MyCarSpeed.Content = speed; break;
                case 168: MyCarSpeed.Content = speed; break;
                case 169: MyCarSpeed.Content = speed; break;


                case 170: MyCarSpeed.Content = speed; break;
                case 171: MyCarSpeed.Content = speed; break;
                case 172: MyCarSpeed.Content = speed; break;
                case 173: MyCarSpeed.Content = speed; break;
                case 174: MyCarSpeed.Content = speed; break;
                case 175: MyCarSpeed.Content = speed; break;
                case 176: MyCarSpeed.Content = speed; break;
                case 177: MyCarSpeed.Content = speed; break;
                case 178: MyCarSpeed.Content = speed; break;
                case 179: MyCarSpeed.Content = speed; break;

                case 180: MyCarSpeed.Content = speed; break;
                case 181: MyCarSpeed.Content = speed; break;
                case 182: MyCarSpeed.Content = speed; break;
                case 183: MyCarSpeed.Content = speed; break;
                case 184: MyCarSpeed.Content = speed; break;
                case 185: MyCarSpeed.Content = speed; break;
                case 186: MyCarSpeed.Content = speed; break;
                case 187: MyCarSpeed.Content = speed; break;
                case 188: MyCarSpeed.Content = speed; break;
                case 189: MyCarSpeed.Content = speed; break;

                case 190: MyCarSpeed.Content = speed; break;
                case 191: MyCarSpeed.Content = speed; break;
                case 192: MyCarSpeed.Content = speed; break;
                case 193: MyCarSpeed.Content = speed; break;
                case 194: MyCarSpeed.Content = speed; break;
                case 195: MyCarSpeed.Content = speed; break;
                case 196: MyCarSpeed.Content = speed; break;
                case 197: MyCarSpeed.Content = speed; break;
                case 198: MyCarSpeed.Content = speed; break;
                case 199: MyCarSpeed.Content = speed; break;
                case 200: MyCarSpeed.Content = speed; break;
            }
        }

         void md_AddSizeEventHandler(int size)
        {
            size = size +10;
            MyCarSpeed.FontSize = size;
        }

         void md_AddColorEventHandler(SolidColorBrush color)
         {
             MyCarSpeed.Foreground = color;
         }
      
    }
}
