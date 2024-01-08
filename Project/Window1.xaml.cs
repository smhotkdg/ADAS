using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using OpenCvSharp;


namespace Project
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    
    public partial class Window1 : Window
    {
        Gesture gs = new Gesture();

        System.Windows.Forms.Timer videotimer = new System.Windows.Forms.Timer();
        IplImage src;
        CvCapture cap;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SafetyEngineLib.SafetyEngine safe = new SafetyEngineLib.SafetyEngine();
        SignsDetectLib.SignsDetect sign = new SignsDetectLib.SignsDetect();

     //   SafetyEngineLib.SafetyEngine safe = new SafetyEngineLib.SafetyEngine();

        //타이머 예외처리 위함

        bool timerFlg = false;

       
        int myspeed = 0;

        //오디오 예외처리
        int num = 0;
        int audionum = 1;
        int airconnum = 1;
        int optionnum = 1;


        int hope = 0;
         bool ColorFlg = false;
         bool  PositionFlg = false;
         bool SizeFlg = false;

        bool audioflg = false;
        bool airconflg = false;
        bool optionflg = false;
        bool followflg = false;

        bool mainflg = false;
        
        bool option3flg = false;
        bool optionsizeflg = false;
        bool opptinpositionflg = false;
        bool optioncolorflg = false;
        bool mainendflg = false;
        bool endflg = false;

        bool backflg = false;

        bool mainback = false;
        bool optinback = false;

        //제스처
        bool audioFlg = false;
        bool airconFlg = false;
        
        //미디어 재생
        bool mediaFlg = false;

        //텍스트 
        bool textautoflg = true;

        //end

        bool endflg1 = false;

        bool newmainmenu = false;

        bool exitflg = false;

        //모든것 종료하기 위함
        bool endallthingsflg = false;

        //윈도우 좌표
        double leftpoint = -50;
        double rightpoint = +50;
        double toppoint = -50;
        double downpoint = +50;


        //거리
        int frontdistance = 0;

        int onlyfollome = 0;
        int onlyfollomestart = 0;
        int newfollome = 0;

        //기록

        Window2 window2 = null;

        Form1 form1 = null;

        private int time = 0;
        private int time2 = 0;
        private int time3 = 0;


        private DispatcherTimer _timer;
        private DispatcherTimer _timer2;
        private DispatcherTimer _timer3;

        private DispatcherTimer testtimer;
        private DispatcherTimer testtimer2;
        private DispatcherTimer testtimer3;

        int number = 0;
        int number2 = 0;
        int number3 = 0;

        WindowPosition winposition = new WindowPosition();
        WindowFontSize winfontsize = new WindowFontSize();
        WindowColor windowcolor = new WindowColor();
        SpeachDll.Speach MySpeach = null;

        int followme = 0;

        int runmedia = 0;
        

        public Window1()
        {
            InitializeComponent();
        }


        //메뉴 클릭
        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (form1 == null)
            {
                form1 = new Form1();

                form1.FormClosed += new FormClosedEventHandler(form1_FormClosed);
                form1.Show();
            }

            gs.EndGesture();
           // safe.StartEngine();

            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = false;
            tf.PositionFlg = false;
            tf.SizeFlg = false;
            audioFlg = false;
            airconFlg = false;
          
            
            
            uc_windowcolor.Visibility = Visibility.Hidden;


            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;

            settings.Visibility = Visibility.Visible;
            MYAirCon.Visibility = Visibility.Visible;
            MyAudio.Visibility = Visibility.Visible;

            MyNavigation.Visibility = Visibility.Visible;
           


            S_size.Visibility = Visibility.Hidden;
            S_color.Visibility = Visibility.Hidden;
            S_position.Visibility = Visibility.Hidden;

            u_followme.Visibility = Visibility.Hidden;

            mygridWinPo.Children.Clear();

            MyDocument md = MyDocument.Singleton;
           // md.Runmedia();
            md.Sign_speed();
            md.AutoRunPlz();

         //   md.MyCarSpeed();
           

          
            if (window2 == null)
            {
                window2 = new Window2();

                window2.Closed += new EventHandler(AAClosed);
                window2.Show();
            }

            Followme.Visibility = Visibility.Visible;

            if(System.IO.File.Exists("C:\\Documents and Settings\\admin\\바탕 화면\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xml"))
            {
            try
            {
                 System.IO.File.Delete("C:\\Documents and Settings\\admin\\바탕 화면\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xml");
                 System.IO.File.Delete("C:\\Documents and Settings\\admin\\바탕 화면\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xsd");
            }
            catch
            {

            }
            }
            
        }

        void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1 = null;
        }

        

        private void Label_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            MyCheckedBackCar.Visibility = Visibility.Visible;
        }

        private void MyAudio_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gs.StartGesture();

            audioFlg = true;
            airconFlg = false;

            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAudios.Visibility = Visibility.Visible;

            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;
            MyNavigation.Visibility = Visibility.Hidden;
     
        }


        //설정 옵션
        private void MyNavigation_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;


            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;
            MyNavigation.Visibility = Visibility.Hidden;
            Followme.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;


            //셋팅
            S_size.Visibility = Visibility.Visible;
            S_color.Visibility = Visibility.Visible;
            S_position.Visibility = Visibility.Visible;
        }

       

        private void MYAirCon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gs.StartGesture();
            
            audioFlg = false;
            airconFlg = true;

            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Visible;

            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;
            MyNavigation.Visibility = Visibility.Hidden;
           
            MyAudios.Visibility = Visibility.Hidden;
        }


        private void MyDisplay_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            settings.Visibility = Visibility.Visible;

            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;
            MyNavigation.Visibility = Visibility.Hidden;
           
            MyAudios.Visibility = Visibility.Hidden;
        }

        private void MyCheckedBackCar_Loaded(object sender, RoutedEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            MySpeach = new SpeachDll.Speach();
            MySpeach.StartSpeach();
            MySpeach.SpeachResultReturnEventHandler += new SpeachDll.SpeachResultReturn(MySpeach_SpeachResultReturnEventHandler);
            md.AddMemberEventHandler += new AddMemberEvent(OnAddMember);
            md.WindowSizeEventHandler += new Window1SizeEvent(OnChangeSize);
           

            md.TopEventHandler += new TopEvent(md_TopEventHandler);
            md.DownEventHandler += new DownEvent(md_DownEventHandler);
            md.RightEventHandler += new RightEvent(md_RightEventHandler);
            md.LeftEventHandler += new LeftEvent(md_LeftEventHandler);

            //유저
            md.CloseUserEventHandler += new CloseUserEvent(md_CloseUserEventHandler);
            md.CloseUserFontSizeEventHandler += new CloseUserFontSizeEvent(md_CloseUserFontSizeEventHandler);
            md.CloseUserColorEventEventHandler += new CloseUserColorEvent(md_CloseUserColorEventEventHandler);
       
            //경고메시지
            md.TextEventHandler += new TextEvent(md_TextEventHandler);
        
            //색깔 
            md.AddColorEventHandler += new AddColorEvent(md_AddColorEventHandler);
            md.AddSizeEventHandler += new AddSizeEvent(md_AddSizeEventHandler);




         
            md.Start();
            md.Start1();


            gs.StartGesture();


           


             gs.EndGesture();
            
            
           
            //CameraOn();

            //if (window2 == null)
            //{
            //    window2 = new Window2();

            //    window2.Closed += new EventHandler(AAClosed);
            //    window2.Show();
            //}

             safe.GetCautionEventHandler += new SafetyEngineLib.GetCaution(safe_GetCautionEventHandler);
             safe.GetDistanceEventHandler += new SafetyEngineLib.GetDistance(safe_GetDistanceEventHandler);
             //safe.GetSrcEventHandler += new SafetyEngineLib.GetSrc(safe_GetSrcEventHandler);

             sign.GestSingCautionEventHandler += new SignsDetectLib.GetSignsCaution(sign_GestSingCautionEventHandler);
             sign.GetSignsSpeedEventHandler += new SignsDetectLib.GetSignsSpeed(sign_GetSignsSpeedEventHandler);

             
             openFileDialog.DefaultExt = ".avi";
             openFileDialog.Filter = "동영상 파일(.avi)|*.avi";
             openFileDialog.ShowDialog();
             if (openFileDialog.FileName != "")
             {
                 cap = CvCapture.FromFile(openFileDialog.FileName);
                 videotimer.Tick += new EventHandler(videotimer_Tick);
                 videotimer.Interval = (int)(500 / cap.Fps);
                 videotimer.Enabled = true;
             }

             
        }

        void safe_GetCautionEventHandler()
        {
            if (safe.caution_str != null)
            {
                TextSleep(3);
                //위험 띄워 주는곳 
            }
           
        }

        void videotimer_Tick(object sender, EventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            
            src = cap.QueryFrame();
            safe.Recognition(src);
            sign.Recognition(src);    
        }        

        void sign_GetSignsSpeedEventHandler()
        {
            MyDocument md = MyDocument.Singleton;
            md.AutoSpeed(30); 
        }

        void sign_GestSingCautionEventHandler()
        {
            MyDocument md = MyDocument.Singleton;
            md.TopSign(1);
        }


        int cnt = 0;
        int cnt2 = 0;


        void safe_GetDistanceEventHandler()
        {
            if (safe.distance_double != 0)
            {
                MyDocument md = MyDocument.Singleton;

                md.Distance(safe.distance_double);
            }
         

           
            //int pre_distance = 0;
            //int now_distance = 0;

            //MyDocument md = MyDocument.Singleton;

            //if (safe.distance_double != 0)
            //{


            //    double distance = safe.distance_double;
            //    double dis = Math.Round(distance);
            //    int num = (int)dis;
            //    if (cnt2 == 0)
            //    {
            //        cnt2++;
            //        md.SetDistance(num);
            //        md.FrontOfCarDistance(num);

            //    }
            //    else
            //    {
            //        if (num != md.getdistance())
            //        {
            //            md.FrontOfCarDistance(num);
            //            md.SetDistance(num);
            //        }
            //    }
            //    if (cnt == 0)
            //    {
            //        cnt++;
            //        md.SetPrevDistance(num);
            //    }

            //    else
            //    {
            //        if (md.GetPri_Distance() == md.GetNow_Distance())
            //        {
            //            md.FrontOfCarSpeed(md.GetSpeed());

            //            md.SetPrevDistance(num);
            //        }
            //        else
            //        {

            //            double speed = 0;

            //            int myspeed = 0;
            //            int sec = int.Parse(md.GetSec().ToString());

            //            speed = (md.GetMoveDistance() + (md.GetNow_Distance() - md.GetPri_Distance())) * (1.8 / sec);

            //            speed = Math.Round(speed);
            //            myspeed = (int)speed;
            //            if (myspeed < 100 && myspeed > 0)
            //            {
            //                md.FrontOfCarSpeed(myspeed);
            //            }
            //            md.SetPrevDistance(num);
            //        }
            //    }

            //    md.SetDistance(num);
            //}
        }

     

     
       

        

      

        void MySpeach_SpeachResultReturnEventHandler()
        {
            //System.Windows.MessageBox.Show(MySpeach.Result);
            string temp = MySpeach.Result;

            if (temp == "Start" && mainflg == false)
            {
                
                endflg = true;
                mainflg = true;
             

                airconflg = true;
                audioflg = true;
                followflg = true;
                optionflg = true;
                
                VoiceStart();
            }

            
             if (temp == "Go" && followflg == true)
            {
                newfollome =1;

                onlyfollome = 1;
              
                mainendflg = false;
                endflg = false;
                airconflg = false;
                audioflg = false;
                
                optionflg = false;
                exitflg = true;
                FolloMe();
            }

            if (temp == "Audio" && audioflg == true )
            {
                mainendflg = false;
                endflg = false;
                airconflg = false;
                audioflg = false;
                followflg = false;
                optionflg = false;
                exitflg = true;
                VoiceAudio();
            }

            if (temp == "Aircon" && airconflg== true )
            {
                mainendflg = false;
                endflg = false;
                airconflg = false;
                audioflg = false;
                followflg = false;
                optionflg = false;
                exitflg = true;
                VoiceAircon();
            }

            if (temp == "Exit" && exitflg == true &&   onlyfollome ==0)
            {
                mainendflg = true;

                endflg = false;
                exitflg = false;

                audioflg = true;
                airconflg = true;
                optionflg = true;
                followflg = true;
                SizeFlg = false;
                ColorFlg = false;
                PositionFlg = false;
                endflg = true;

                endflg = true;

                onlyfollome =0;
                onlyfollomestart = 1;

                gs.EndGesture();
                //GoMenu();
                ExitMenu();
            }


            if (temp == "Option" && optionflg ==true  && endflg == true)
            {
                mainendflg = false;
                endflg = false;
                audioflg = false;
                airconflg = false;
                optionflg = false;
                followflg = false;

                exitflg = true;


                SizeFlg = true;
                ColorFlg = true;
                PositionFlg = true;
                endflg = false;
                VoiceOption();
      
            }





            if (temp == "Size" && SizeFlg == true)
         {
             mainendflg = false;
             endflg = false;
             ColorFlg = false;
             PositionFlg = false;
             SizeFlg = false;
             exitflg = true;

             SizeFlg = false;
             Optin_Size();
         }


            if (temp == "Color" && ColorFlg == true)
         {
             mainendflg = false;
             endflg = false;
             ColorFlg = false;
             PositionFlg = false;
             SizeFlg = false;
             exitflg = true;

             Optin_Color();

         }
            if (temp == "Position" && PositionFlg == true)
         {
             mainendflg = false;
             endflg = false;
             ColorFlg = false;
             PositionFlg = false;
             SizeFlg = false;
             exitflg = true;

             PositionFlg = false;
             Optin_Position();
         }


            


            if (temp == "Exit" && onlyfollome == 1 && newfollome == 1  )
         {
             if (mds.GetRunMedia() == 1)
             {
                 mds.SetRunMedia(0);

                 newfollome = 0;
                 onlyfollomestart = 1;
                 onlyfollome = 0;
                 StopAllThings();
             }
             else 
             {
                 mds.SetRunMedia(0);

                 newfollome = 0;
                 onlyfollomestart = 1;
                 onlyfollome = 0;

                 VoiceExit();
             }
            
           //  ExitMenu();
         }

            if (temp == "Start" && onlyfollomestart == 1)
            {
                

                newfollome = 1;
                onlyfollome = 1;
                onlyfollomestart = 0;

                MyDocument md = MyDocument.Singleton;
                // u_followme.Visibility = Visibility.Visible;
                md.Runmedia();
                md.Sign_speed();
                md.AutoRunPlz();

              //  md.MyCarSpeed();

                
            }

         if (temp == "End" &&  mainflg == true && mainendflg == true)
         {
             onlyfollome = 0;
             mainflg = false;
             audioflg = false;
             airconflg = false;
             optionflg = false;
             followflg = false;
             SizeFlg = false;
             ColorFlg = false;
             PositionFlg = false;
             endflg = false;
             endflg1 = false;
             mainendflg = false;
             exitflg = false;
             onlyfollomestart = 0;


             EndMenu();
             StopEndAllThings();
              
             
         }

        }

        private void VoiceExit()
        {
            mainendflg = true;

            endflg = false;
            exitflg = false;

            audioflg = true;
            airconflg = true;
            optionflg = true;
            followflg = true;
            SizeFlg = false;
            ColorFlg = false;
            PositionFlg = false;
            endflg = true;

            endflg = true;

            onlyfollome = 0;
            onlyfollomestart = 1;

            gs.EndGesture();
            //GoMenu();
            ExitMenu(); 
        }

        MyDocument mds = MyDocument.Singleton;

        private void ExitMenu()
        {
            Followme.Visibility = Visibility.Visible;

            if (System.IO.File.Exists("C:\\Documents and Settings\\admin\\바탕 화면\\시연회연습\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xml"))
            {
                try
                {
                    System.IO.File.Delete("C:\\Documents and Settings\\admin\\바탕 화면\\시연회연습\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xml");
                    System.IO.File.Delete("C:\\Documents and Settings\\admin\\바탕 화면\\시연회연습\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xsd");
                }
                catch
                {

                }
            }


            //StopAllThings();
            gs.EndGesture();
            // safe.StartEngine();

            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = false;
            tf.PositionFlg = false;
            tf.SizeFlg = false;
            audioFlg = false;
            airconFlg = false;



            uc_windowcolor.Visibility = Visibility.Hidden;


            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;

            settings.Visibility = Visibility.Visible;
            MYAirCon.Visibility = Visibility.Visible;
            MyAudio.Visibility = Visibility.Visible;
            Followme.Visibility = Visibility.Visible;

            MyNavigation.Visibility = Visibility.Visible;



            S_size.Visibility = Visibility.Hidden;
            S_color.Visibility = Visibility.Hidden;
            S_position.Visibility = Visibility.Hidden;

          

            mygridWinPo.Children.Clear();

            MyDocument md = MyDocument.Singleton;
           
            md.Sign_speed();
            md.AutoRunPlz();

           // md.MyCarSpeed();

            u_followme.Visibility = Visibility.Hidden;
            
            
        }

        private void EndMenu()
        {


            uc_windowcolor.Visibility = Visibility.Hidden;


            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;

            settings.Visibility = Visibility.Hidden;
            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;


            MyNavigation.Visibility = Visibility.Hidden;



            S_size.Visibility = Visibility.Hidden;
            S_color.Visibility = Visibility.Hidden;
            S_position.Visibility = Visibility.Hidden;

            Followme.Visibility = Visibility.Hidden;
            u_followme.Visibility = Visibility.Hidden;

            mygridWinPo.Children.Clear();

        }

        private void FolloMe()
        {
             Followme.Visibility = Visibility.Hidden;
            u_followme.Visibility = Visibility.Visible;

            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = false;
            tf.PositionFlg = false;
            tf.SizeFlg = false;
            audioFlg = false;
            airconFlg = false;

            uc_windowcolor.Visibility = Visibility.Hidden;


            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;

            settings.Visibility = Visibility.Hidden;
            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;

            MyNavigation.Visibility = Visibility.Hidden;



            S_size.Visibility = Visibility.Hidden;
            S_color.Visibility = Visibility.Hidden;
            S_position.Visibility = Visibility.Hidden;

          

            mygridWinPo.Children.Clear();

            MyDocument md = MyDocument.Singleton;
            if (followme  == 0)
            {
                followme = 1;
            //    md.Runmedia();
            }
       
            md.Sign_speed();
            md.AutoRunPlz();

         //   md.MyCarSpeed();
        }
       

        private void StartMenu()
        {
            audioflg = true;
            airconflg = true;
            optionflg = true;
            mainback = true;
            mainendflg = true;

            u_followme.Visibility = Visibility.Hidden;

            uc_windowcolor.Visibility = Visibility.Hidden;


            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;

            settings.Visibility = Visibility.Hidden;

            MYAirCon.Visibility = Visibility.Visible;
            MyAudio.Visibility = Visibility.Visible;
            MyNavigation.Visibility = Visibility.Visible;


            S_size.Visibility = Visibility.Hidden;
            S_color.Visibility = Visibility.Hidden;
            S_position.Visibility = Visibility.Hidden;



            mygridWinPo.Children.Clear();
        }

        //에어콘
        private void VoiceAircon()
        {
            Followme.Visibility = Visibility.Hidden;

            gs.StartGesture();

            audioFlg = false;
            airconFlg = true;

            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Visible;

            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;
            MyNavigation.Visibility = Visibility.Hidden;

            MyAudios.Visibility = Visibility.Hidden;
            u_followme.Visibility = Visibility.Hidden;
            Followme.Visibility = Visibility.Hidden;
        }

     

        private void StartPicture()
        {
            MyDocument md = MyDocument.Singleton;
            md.RunPicture();
        }

        private void StartMedia()
        {

            MyDocument md = MyDocument.Singleton;
            md.Runmedia();
        }


        
        

        private void CloseWindow()
        {
            MyDocument md = MyDocument.Singleton;
            md.Save();
            window2 = null;   
        }

        void MainMenu(string temp)
        {
            switch (temp)
            {
                case "Audio":  VoiceAudio();  break;
                case "Option": VoiceOption();  break;
                case "Aircon": VoiceAircon();  break;
                default: break;   
            
            }
        }
        
        //시작
        private void VoiceStart()
        {

         

            gs.EndGesture();

            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = false;
            tf.PositionFlg = false;
            tf.SizeFlg = false;
            audioFlg = false;
            airconFlg = false;



            uc_windowcolor.Visibility = Visibility.Hidden;


            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;

            settings.Visibility = Visibility.Visible;
            MYAirCon.Visibility = Visibility.Visible;
            MyAudio.Visibility = Visibility.Visible;
            MyNavigation.Visibility = Visibility.Visible;
            Followme.Visibility = Visibility.Visible;

            S_size.Visibility = Visibility.Hidden;
            S_color.Visibility = Visibility.Hidden;
            S_position.Visibility = Visibility.Hidden;

           // u_followme.Visibility = Visibility.Visible;

            mygridWinPo.Children.Clear();

            MyDocument md = MyDocument.Singleton;
            md.Runmedia();
            md.Sign_speed();
            md.AutoRunPlz();
           // md.MyCarSpeed();

            Followme.Visibility = Visibility.Visible;

            if (System.IO.File.Exists("C:\\Documents and Settings\\admin\\바탕 화면\\시연회연습\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xml"))
            {
                try
                {
                    System.IO.File.Delete("C:\\Documents and Settings\\admin\\바탕 화면\\시연회연습\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xml");
                    System.IO.File.Delete("C:\\Documents and Settings\\admin\\바탕 화면\\시연회연습\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xsd");
                }
                catch
                {

                }
            }

        

        }

        //옵션
        private void VoiceOption()
        {
            Followme.Visibility = Visibility.Hidden;
            u_followme.Visibility = Visibility.Hidden;

            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;



            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;
            MyNavigation.Visibility = Visibility.Hidden;
            Followme.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;


            //셋팅
            S_size.Visibility = Visibility.Visible;
            S_color.Visibility = Visibility.Visible;
            S_position.Visibility = Visibility.Visible;

         

        }
        //오디오
        private void VoiceAudio()
        {
            Followme.Visibility = Visibility.Hidden;
            gs.StartGesture();

            audioFlg = true;
            airconFlg = false;

            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAudios.Visibility = Visibility.Visible;

            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;
            MyNavigation.Visibility = Visibility.Hidden;
            u_followme.Visibility = Visibility.Hidden;
        }

        void md_AddSizeEventHandler(int size)
        {
            MyMainMenu.FontSize = size;
            
           
            MyMeasure.FontSize = size;
            MyCheckedBackCar.FontSize = size;

            //윈도우 옵션
            S_size.FontSize = size;
            S_color.FontSize = size;
            S_position.FontSize = size;

            //메인 
           
            MyNavigation.FontSize = size;
            MYAirCon.FontSize = size;
            MyAudio.FontSize = size;
            Followme.FontSize = size;
        }

        void md_AddColorEventHandler(SolidColorBrush color)
        {
            MyMainMenu.Foreground = color;
          
           
            MyMeasure.Foreground = color;
            MyCheckedBackCar.Foreground = color;



            //윈도우 옵션
            S_size.Foreground = color;
            S_color.Foreground = color;
            S_position.Foreground = color;

            //메인 
           
            MyNavigation.Foreground = color;
            MYAirCon.Foreground = color;
            MyAudio.Foreground = color;
            Followme.Foreground = color;
 
        }


        void md_CloseUserColorEventEventHandler()
        {
            CloseUserControl();
        }

        void md_CloseUserFontSizeEventHandler()
        {
            CloseUserControl();
        }

      
        void md_CloseUserEventHandler()
        {
            CloseUserControl();
        }

        void md_LeftEventHandler() { aa.Left += leftpoint; }

        void md_RightEventHandler(){aa.Left += rightpoint;}

        void md_DownEventHandler() { aa.Top += downpoint; }

        void md_TopEventHandler() { aa.Top += toppoint; }

        void OnChangeSize(double size)
        {
            settings.FontSize = size;
            MYAirCon.FontSize = size;
            MyAudio.FontSize = size;
            MyNavigation.FontSize = size;
           
            MyAudios.FontSize = size;

            MyMainMenu.FontSize = size;
           
           
            MyMeasure.FontSize = size;
            MyCheckedBackCar.FontSize = size;
        }
        

        void OnAddMember(Brush color)
        {
            MyCheckedBackCar.Foreground = color;
           
            MyMeasure.Foreground = color;
           
            MyMainMenu.Foreground = color;

            MYAirCon.Foreground = color;
            MyAudio.Foreground = color;
            MyNavigation.Foreground = color;
            MYAirCon.Foreground = color;
            
        }


        private void Button_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            AddMemberEvent ad = new AddMemberEvent(OnAddMember);

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
            }  
         
        }


        private void AAClosed(object sender, EventArgs e)
        {
            MyDocument md = MyDocument.Singleton;
            md.Save();
            window2 = null;   
        }


        //윈도우 설정 옵션 사이즈 색상 윈도우 
        private void S_size_MouseDoubleClick(object sender, MouseButtonEventArgs e) 
        {
            SilverColor.Visibility = Visibility.Hidden;
            VioletColor.Visibility = Visibility.Hidden;
            gs.StartGesture();

            TrueFalse tf = TrueFalse.Singleton;
            tf.SizeFlg = true;
            tf.PositionFlg = false;
            tf.ColorFlg = false;

            CloseOptionSizeColorPosition();
            mygridWinPo.Children.Add(winfontsize); 
        }

        public void Optin_Size()
        {
            SilverColor.Visibility = Visibility.Hidden;
            VioletColor.Visibility = Visibility.Hidden;
            gs.StartGesture();

            TrueFalse tf = TrueFalse.Singleton;
            tf.SizeFlg = true;
            tf.PositionFlg = false;
            tf.ColorFlg = false;

            CloseOptionSizeColorPosition();
            mygridWinPo.Children.Add(winfontsize); 
        }
        
        private void S_color_MouseDoubleClick(object sender, MouseButtonEventArgs e) 
        {
            SilverColor.Visibility = Visibility.Hidden;
            VioletColor.Visibility = Visibility.Hidden;
            gs.StartGesture();

            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = true;
            tf.PositionFlg = false;
            tf.SizeFlg = false;
           
            CloseOptionSizeColorPosition(); 
            MyDocument md = MyDocument.Singleton;
            md.Start2(); 
            uc_windowcolor.Visibility = Visibility.Visible; 
        }

        public void Optin_Color()
        {
            SilverColor.Visibility = Visibility.Hidden;
            VioletColor.Visibility = Visibility.Hidden;
            gs.StartGesture();

            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = true;
            tf.PositionFlg = false;
            tf.SizeFlg = false;

            CloseOptionSizeColorPosition();
            MyDocument md = MyDocument.Singleton;
            md.Start2();
            uc_windowcolor.Visibility = Visibility.Visible; 
        }
        private void S_position_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SilverColor.Visibility = Visibility.Hidden;
            VioletColor.Visibility = Visibility.Hidden;
            gs.StartGesture();

            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = false;
            tf.SizeFlg = false;
            tf.PositionFlg = true;

            CloseOptionSizeColorPosition(); 
            mygridWinPo.Children.Add(winposition); 
        }
        public void Optin_Position()
        {

            gs.StartGesture();
            SilverColor.Visibility = Visibility.Hidden;
            VioletColor.Visibility = Visibility.Hidden;
            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = false;
            tf.SizeFlg = false;
            tf.PositionFlg = true;

            CloseOptionSizeColorPosition();
            mygridWinPo.Children.Add(winposition); 
        }


        void CloseOptionSizeColorPosition()
        {
            S_size.Visibility = Visibility.Hidden;
            S_color.Visibility = Visibility.Hidden;
            S_position.Visibility = Visibility.Hidden;     
        }

        void CloseUserControl()
        {
            S_size.Visibility = Visibility.Visible;
            S_color.Visibility = Visibility.Visible;
            S_position.Visibility = Visibility.Visible;
            mygridWinPo.Children.Clear();
        }



        ////위험 이벤트 구현

        private void TextDanger(int key)
        {
            if (textautoflg == true)
            {
                textautoflg = false;
                if (number == 0)
                {
                    testtimer = new DispatcherTimer();
                    testtimer.Interval = TimeSpan.FromMilliseconds(7000);
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
            textautoflg = true;
            
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            time++;

            if (time == 5)
            {
                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();

                time = 0;
                _timer.Stop();
            }

            if ((time % 2) == 0)
            {
                danger.Visibility = Visibility.Hidden;
            }
            else
            {
                danger.Visibility = Visibility.Visible;
            }
        }

       


        private void TextOil(int key)
        {
            if (textautoflg == true)
            {
                textautoflg = false;
                if (number2 == 0)
                {
                    testtimer2 = new DispatcherTimer();
                    testtimer2.Interval = TimeSpan.FromMilliseconds(7000);
                    testtimer2.Tick += new EventHandler(testtimer2_Tick);
                    testtimer2.Start();

                    number2++;
                    _timer2 = new DispatcherTimer();
                    _timer2.Interval = TimeSpan.FromMilliseconds(1000);
                    _timer2.Tick += new EventHandler(_timer2_Tick);


                    _timer2.Start();
                }
            }
            
        }
        void testtimer2_Tick(object sender, EventArgs e)
        {
            number2 = 0;
            testtimer2.Stop();
            textautoflg = true;
        }

        void _timer2_Tick(object sender, EventArgs e)
        {
            time2++;

            if (time2 == 5)
            {
                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();

                time2 = 0;
                _timer2.Stop();
            }

            if ((time2 % 2) == 0)
            {
                oil.Visibility = Visibility.Hidden;
            }
            else
            {
                oil.Visibility = Visibility.Visible;
            }
        }

       

        private void TextSleep(int key)
        {
            if (textautoflg == true)
            {
                textautoflg = false;
                if (number3 == 0)
                {
                    testtimer3 = new DispatcherTimer();
                    testtimer3.Interval = TimeSpan.FromMilliseconds(7000);
                    testtimer3.Tick += new EventHandler(testtimer3_Tick);
                    testtimer3.Start();

                    number3++;
                    _timer3 = new DispatcherTimer();
                    _timer3.Interval = TimeSpan.FromMilliseconds(1000);
                    _timer3.Tick += new EventHandler(_timer3_Tick);


                    _timer3.Start();
                }
            }
            
        }
        void testtimer3_Tick(object sender, EventArgs e)
        {
            number3 = 0;
            testtimer3.Stop();
            textautoflg = true;
        }

        void _timer3_Tick(object sender, EventArgs e)
        {
            time3++;

            if (time3 == 7)
            {
                System.Media.SoundPlayer sp;
                sp = new System.Media.SoundPlayer(Project.Properties.Resources.airhorn);
                sp.Play();

                time3 = 0;
                _timer3.Stop();
            }

            if ((time3 % 2) == 0)
            {
                sleep.Visibility = Visibility.Hidden;
            }
            else
            {
                sleep.Visibility = Visibility.Visible;
            }
        }

      



      



        void md_TextEventHandler(int key)
        {
            switch (key)
            {
                case 1: TextDanger(key); break;
                case 2: TextOil(key); break;
                case 3: TextSleep(key); break;
                default: break;

            }
            
        }

        private void aa_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            TrueFalse tf = TrueFalse.Singleton;
            bool trueflase =  tf.ColorFlg;
            bool trueflase2 = tf.PositionFlg;
            bool trueflase3 = tf.SizeFlg;

            bool trueflase4 = airconFlg;
            bool trueflase5 = audioFlg;

            //윈도우 색상
            if (trueflase == true)
            {
                string key = e.Key.ToString();
                if (key == "Left")
                {
                    uc_windowcolor.WinLeft();
                    return;
                }

                else if (key == "Right")
                {
                    uc_windowcolor.WinRight();
                    return; 
                }
            }


            //윈도우 위치
            if (trueflase2 == true)
            {
                string key = e.Key.ToString();

                if (key == "Right")
                {
                    uc_windowposition.WinLeft();
                    return;
                }

                else if (key == "Left")
                {
                    uc_windowposition.WinRight();
                    return;
                }

                else if (key == "Up")
                {
                    uc_windowposition.WinUp();
                    return;
                }

                else if (key == "Down")
                {
                    uc_windowposition.WinDown();
                    return;
                }
            }

                 //윈도우 글자 사이즈
                //윈도우 색상
            if (trueflase3 == true)
            {
                string key = e.Key.ToString();
                if (key == "Left")
                {
                    uc_windowfontsize.WinUp();
                    return;
                }

                else if (key == "Right")
                {
                    uc_windowfontsize.WinDown();
                    return;
                }
            }

            //에어콘
            if (trueflase4 == true)
            {                
                if (e.Key.ToString() == "Left")
                {
                    MyAircons.WinUp();
                    return;
                }

                else if (e.Key.ToString() == "Right")
                {
                    MyAircons.WinDown();
                    return;
                }
            }


            //오디오
            if (trueflase5 == true)
            {
                string key = e.Key.ToString();
                if (key == "Left")
                {
                   
                    MyAudios.WinUp();
                    return;
                }

                if (key == "Right")
                {
                    MyAudios.WinDown();
                    return;
                }
            }
        }

  


        public void MyFrontCar()
        {
           
        }

        private void u_frontofcar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MyDocument md = MyDocument.Singleton;


            //int distance = 0;
            //distance = frontdistance;
            //md.FrontOfCarDistance(distance);
            //frontdistance--;


            
        }


        //자동차 속도 올리기
        private void MyMeasure_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            MyDocument md = MyDocument.Singleton;

            int speed = 0;
            speed = myspeed;
            md.MySpeed(speed);
            myspeed++;

        }

        //앞차와 거리 
        private void u_frontofcar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;


            int distance = 0;
            distance = frontdistance;
            md.FrontOfCarDistance(distance);
            frontdistance++;


           
        }

        private void MyMeasure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            int speed = 0;
            speed = myspeed;
            md.MySpeed(speed);
            myspeed++;
        }


        //교통표지판 이벤트

        private void Caution_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //_timer = new DispatcherTimer();
            //_timer.Interval = TimeSpan.FromMilliseconds(1000);
            //_timer.Tick += new EventHandler(timer_Tick);
            //_timer.Start();
        }

        private void speed30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //_timer2 = new DispatcherTimer();
            //_timer2.Interval = TimeSpan.FromMilliseconds(1000);
            //_timer2.Tick += new EventHandler(timer_Tick2);
            //_timer2.Start();
        }

        private void crosswalk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //_timer3 = new DispatcherTimer();
            //_timer3.Interval = TimeSpan.FromMilliseconds(1000);
            //_timer3.Tick += new EventHandler(timer_Tick3);
            //_timer3.Start();
        }


        
        ////파일 열기
        //private void FileOpenButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string media = string.Empty;
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.DefaultExt = ".wmv";
        //    ofd.Filter = "동영상 파일(.wmv)|*.wmv";
        //    ofd.ShowDialog();

            
        //    media = ofd.FileName;

        //    if (string.IsNullOrEmpty(media))
        //    {
        //        return;
        //    }

        //    mymedia.Source = new Uri(media);
        //}

        ////동영상 재생버튼
        //private void playButton_Click(object sender, RoutedEventArgs e)
        //{
        //    mymedia.Visibility = Visibility.Visible;
        //    mymedia.Play();
        //}


        ////정지버튼
        //private void stopButton_Click(object sender, RoutedEventArgs e)
        //{
        //   // mymedia.Stop();
        //    mymedia.Close();
        //    mymedia.Visibility = Visibility.Hidden;
        //}

        //private void cameraButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Form1 form = new Form1();
        //    form.Show();
        //}

        //private void CameraOn()
        //{
        //    Form1 form = new Form1();
        //    form.Show();
        //}

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    mymedia.Visibility = Visibility.Visible;
        //}

        //private void button2_Click(object sender, RoutedEventArgs e)
        //{
        //    mymedia.Visibility = Visibility.Hidden;
        //}


        //타이머 정지 및 모든 프로그램 종료. 사진 , 동영상
        private void SilverColor_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyDocument md = MyDocument.Singleton;

            md.StopAllThings();

        }

        private void StopEndAllThings()
        {
            u_followme.Visibility = Visibility.Hidden;

            MyDocument md = MyDocument.Singleton;

            md.StopAllThings();

        }

        private void StopAllThings()
        {
            u_followme.Visibility = Visibility.Visible;

            MyDocument md = MyDocument.Singleton;

            md.StopAllThings();

           

        }

        private void Followme_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Followme.Visibility = Visibility.Hidden;
            u_followme.Visibility = Visibility.Visible;

            TrueFalse tf = TrueFalse.Singleton;
            tf.ColorFlg = false;
            tf.PositionFlg = false;
            tf.SizeFlg = false;
            audioFlg = false;
            airconFlg = false;

            uc_windowcolor.Visibility = Visibility.Hidden;


            VioletColor.Visibility = Visibility.Hidden;
            SilverColor.Visibility = Visibility.Hidden;

            MyAircons.Visibility = Visibility.Hidden;
            MyAudios.Visibility = Visibility.Hidden;

            settings.Visibility = Visibility.Hidden;
            MYAirCon.Visibility = Visibility.Hidden;
            MyAudio.Visibility = Visibility.Hidden;

            MyNavigation.Visibility = Visibility.Hidden;



            S_size.Visibility = Visibility.Hidden;
            S_color.Visibility = Visibility.Hidden;
            S_position.Visibility = Visibility.Hidden;

          

            mygridWinPo.Children.Clear();

            MyDocument md = MyDocument.Singleton;
            if (followme  == 0)
            {
                followme = 1;
                md.Runmedia();
            }
       
            md.Sign_speed();
            md.AutoRunPlz();

         //   md.MyCarSpeed();
        }


    }

}
