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
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Windows.Threading;

namespace Project
{
    /// <summary>
    /// UFollowMe.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

    public delegate void GetDistance(double a);
    public partial class UFollowMe : System.Windows.Controls.UserControl
    {

      
        string caution1 = string.Empty;

       // SafetyEngineLib.SafetyEngine safe = new SafetyEngineLib.SafetyEngine();
        private int time = 0;
        public event GetDistance GetDistanceEventHandler = null;
        private DispatcherTimer _timer;

        string lastimage = string.Empty;

        public UFollowMe()
        {
            InitializeComponent();
        }


        //미디어
        private void mymedia_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {         
        }

        public void MyMediaPlay()
        {
            
            string media = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".wmv";
            ofd.Filter = "동영상 파일(.wmv)|*.wmv";
            ////ofd.ShowDialog();


           // safe.StartEngine();
            media = "C:\\FollowMeFile\\Movie\\시연\\시연.wmv";

            if (string.IsNullOrEmpty(media))
            {
                return;
            }

            mymedia.Source = new Uri(media);

            mymedia.Play();
           
        }

        public void MyMediaStop()
        {
            mymedia.Stop();
           // safe.EndEngine();
        }

        private void MyPicturePlay()
        {
            //Bitmap img = Project.Properties.Resources.Turtle;
            //MemoryStream imgStream = new MemoryStream();
            //img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Bmp);
            //imgStream.Seek(0, SeekOrigin.Begin);
            //BitmapFrame newimg = BitmapFrame.Create(imgStream);
            //myimage.Source = newimg;
            
        }

        //이미지
        private void myimage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            md.AddColorEventHandler += new AddColorEvent(md_AddColorEventHandler);
           
            md.RunMediaEventHandler += new RunMediaEvent(md_RunMediaEventHandler);
            md.RunPictureEventHandler += new RunPictureEvent(md_RunPictureEventHandler);
            md.TestEventHandler += new TestEvent(md_TestEventHandler);
            md.AutoRunEvetHandler += new AutoRunEvet(md_AutoRunEvetHandler);
            md.StopFollowMeEventHandler += new StopFollowMeEvent(md_StopFollowMeEventHandler);


            //safe.GetDistanceEventHandler +=new SafetyEngineLib.GetDistance(safe_GetDistanceEventHandler);
            //safe.GetCautionEventHandler += new SafetyEngineLib.GetCaution(safe_GetCautionEventHandler);
            //safe.GetDistanceEventHandler += new SafetyEngineLib.GetDistance(safe_GetDistanceEventHandler);

            md.Start();

            md.DistanceEventHandler += new DistanceEvent(md_DistanceEventHandler);
            md.CautionEventHandler += new CautionEvent(md_CautionEventHandler);
            
        
        }

        void md_CautionEventHandler(string caution)
        {
            caution1 = caution;
        }

        void md_DistanceEventHandler(double distance1)
        {
            int pre_distance = 0;
            int now_distance = 0;

            MyDocument md = MyDocument.Singleton;

            if (distance1 != 0)
            {


                double distance = distance1;
                double dis = Math.Round(distance);
                int num = (int)dis;
                if (cnt2 == 0)
                {
                    cnt2++;
                    md.SetDistance(num);
                    md.FrontOfCarDistance(num);

                }
                else
                {
                    if (num != md.getdistance())
                    {
                        md.FrontOfCarDistance(num);
                        md.SetDistance(num);
                    }
                }
                if (cnt == 0)
                {
                    cnt++;
                    md.SetPrevDistance(num);
                }

                else
                {
                    if (md.GetPri_Distance() == md.GetNow_Distance())
                    {
                        md.FrontOfCarSpeed(md.GetSpeed());

                        md.SetPrevDistance(num);
                    }
                    else
                    {

                        double speed = 0;

                        int myspeed = 0;
                        int sec = int.Parse(md.GetSec().ToString());

                        speed = (md.GetMoveDistance() + (md.GetNow_Distance() - md.GetPri_Distance())) * (1.8 / sec);

                        speed = Math.Round(speed);
                        myspeed = (int)speed;
                        if (myspeed < 100 && myspeed > 0)
                        {
                            md.FrontOfCarSpeed(myspeed);
                        }
                        md.SetPrevDistance(num);
                    }
                }

                md.SetDistance(num);
            }
        }

        //void safe_GetCautionEventHandler()
        //{
        //    if (safe.caution_str != null)
        //    {

        //    }
        //}

        void md_AddColorEventHandler(SolidColorBrush color)
        {
            djtextbox.Foreground = color;

        }




        int cnt = 0;
        int cnt2 = 0;
        //void safe_GetDistanceEventHandler()
        //{
        //    int pre_distance = 0;
        //    int now_distance = 0;

        //    MyDocument md = MyDocument.Singleton;

        //    if (safe.distance_double != 0)
        //    {


        //        double distance = safe.distance_double;
        //        double dis = Math.Round(distance);
        //        int num = (int)dis;
        //        if (cnt2 == 0)
        //        {
        //            cnt2++;
        //            md.SetDistance(num);
        //            md.FrontOfCarDistance(num);

        //        }
        //        else
        //        {
        //            if (num != md.getdistance())
        //            {
        //                md.FrontOfCarDistance(num);
        //                md.SetDistance(num);
        //            }
        //        }
        //        if (cnt == 0)
        //        {
        //            cnt++;
        //            md.SetPrevDistance(num);
        //        }

        //        else
        //        {
        //            if (md.GetPri_Distance() == md.GetNow_Distance())
        //            {
        //                md.FrontOfCarSpeed(md.GetSpeed());

        //                md.SetPrevDistance(num);
        //            }
        //            else
        //            {

        //                double speed = 0;

        //                int myspeed = 0;
        //                int sec = int.Parse(md.GetSec().ToString());

        //                speed = (md.GetMoveDistance() + (md.GetNow_Distance() - md.GetPri_Distance())) * (1.8 / sec);

        //                speed = Math.Round(speed);
        //                myspeed = (int)speed;
        //                if (myspeed < 100 && myspeed > 0)
        //                {
        //                    md.FrontOfCarSpeed(myspeed);
        //                }
        //                md.SetPrevDistance(num);
        //            }
        //        }

        //        md.SetDistance(num);
        //    }


        //}
       

        void md_StopFollowMeEventHandler()
        {
            StopFollome();
        }

        void md_AutoRunEvetHandler()
        {
            AutoRun();
        }


        void md_TestEventHandler(string image, string text)
        {
            Test(image, text);
        }

        private void Test(string image, string text)
        {
            if (image != "")
            {
                myimage.Visibility = Visibility.Visible;
                djtextbox.Visibility = Visibility.Visible;
                myimage.Source = new BitmapImage(new Uri(image));
                djtextbox.Text = text;
                lastimage = image;
            }
            else
            {
                myimage.Visibility = Visibility.Hidden;
                djtextbox.Visibility = Visibility.Hidden;
            }

           
               

          //  image1.Source = new BitmapImage(new Uri(image));
          //  label1.Content = text;
        }



        void md_RunPictureEventHandler()
        {
            MyPicturePlay();
        }

       
        //그림이랑 사진이랑 같이 해야함 따로 델리게이트 할경우 안됨 정지화면 가능!!
        void md_RunMediaEventHandler()
        {
            MyMediaPlay();
            MyPicturePlay();
        }

        private void AutoRun()
        {
            MyDocument md = MyDocument.Singleton;

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(500);
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();
        }

        private void testyo_Click(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(500);
            _timer.Tick += new EventHandler(_timer_Tick);
            //_timer.Start();
        }


        //문제점
        void _timer_Tick(object sender, EventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            md.Load2();
            md.Start3();
            md.AllClear();
        }

        void StopFollome()
        {
            _timer.Stop();
            MyMediaStop(); //정지 동영상
        }
    }
}
