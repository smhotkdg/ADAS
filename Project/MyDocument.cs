using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Media;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace Project
{
    //색깔
    delegate void AddMemberEvent(Brush color);
    delegate void TestMemberEvent(Brush color);
    delegate void AirConColorEvent(Brush color);
    delegate void NavigationColorEvent(Brush color);
    
    //사이즈
    delegate void Window1SizeEvent(double size);
    delegate void AudioSizeEvent(double size);
    delegate void AirconSizeEvent(double size);
    delegate void NavigationSizeEvent(double size);

    //윈도우 위치설정
    delegate void LeftEvent();
    delegate void RightEvent();
    delegate void TopEvent();
    delegate void DownEvent();

    //유저 윈도우 닫기
    delegate void CloseUserEvent();
    delegate void CloseUserFontSizeEvent();
    delegate void CloseUserColorEvent();

    delegate void TTEvent();
    delegate void TTEvent1();


    //경고메세지
    delegate void TextEvent(int key);

    //xml저장 delegate
    delegate void AddColorEvent(SolidColorBrush color);
    delegate void AddSizeEvent(int size);
    delegate void AddNowColorEvent(int size);


    //속도
    delegate void MyspeedEvent(int speed);
    //앞차와의 거리
    delegate void FrontOfCarEvent(int distance);
    //앞차의 속도
    delegate void FrontOfCarSpeedEvent(int speed);



    //follow me시스템
    //미디어 재생
    delegate void RunMediaEvent();
    //사진
    delegate void RunPictureEvent();


    //신호등 스피드
    delegate void Speed30Event();
    delegate void Speed50Event();
    delegate void Speed80Event();
    delegate void Speed100Event();

    //이미지, 텍스트
    delegate void TestEvent(string image, string text);

    //자동으로 이미지테스트시작
    delegate void AutoRunEvet();

    //속도 신호 델리게이트
    delegate void SpeedEvent(int speed);

    //짧은 신호 맨위에것
    delegate void TopSignEvent(int key);

    //긴 신호 맨아래것
    delegate void BottonSignEvent(int key);


    //안드로이드
    delegate void AndroidEvent();

    //자동차 속도 중지
    delegate void StopSpeedEvent();

    //팔로우미 중지
    delegate void StopFollowMeEvent();

    //구간별 속도
    delegate void SpeedOver30Event();
    delegate void SpeedOver40Event();
    delegate void SpeedOver50Event();
    delegate void SpeedOver80Event();
    delegate void SpeedOver100Event();

    //구간별 속도 테스트
    delegate void SpeedOver30Event1();
    delegate void SpeedOver40Event1();
    delegate void SpeedOver50Event1();
    delegate void SpeedOver80Event1();
    delegate void SpeedOver100Event1();


    delegate void DistanceEvent(double distance);
    delegate void CautionEvent(string caution);

    

    class MyDocument
    {

        int nowspeed = 0;
        int prispeed = 0;

        int runmedia = 0;

        string nowspeedsss = string.Empty;

        //신호등 스피드
        public event Speed30Event Speed30EventHandler = null;
        public event Speed50Event Speed50EventHandler = null;
        public event Speed80Event Speed80EventHandler = null;
        public event Speed100Event Speed100EventHandler = null;



        //색깔
        public event AddMemberEvent AddMemberEventHandler = null;
        public event TestMemberEvent TestMemberEventHandler = null;
        public event AirConColorEvent AirConColorEventHandler = null;
       

        //사이즈
        public event Window1SizeEvent WindowSizeEventHandler = null;
        public event AudioSizeEvent AudioSizeEventHandler = null;
        public event AirconSizeEvent AirconSizeEventHandler = null;
        

        public event TTEvent EventHandler = null;
        public event TTEvent1 EventHandler1 = null;

      

        //윈도우 위치지정
        public event LeftEvent LeftEventHandler = null;
        public event RightEvent RightEventHandler = null;
        public event TopEvent TopEventHandler = null;
        public event DownEvent DownEventHandler = null;

        //유저 윈도우 닫기
        public event CloseUserEvent CloseUserEventHandler = null;
        public event  CloseUserFontSizeEvent CloseUserFontSizeEventHandler = null;
        public event CloseUserColorEvent CloseUserColorEventEventHandler = null;


        //자동차 스피드 
        public event MyspeedEvent MyspeedEventHandler = null;
        //앞에차와의 거리
        public event FrontOfCarEvent FrontOfCarEventHandler = null;

        //앞에차 속도

        public event FrontOfCarSpeedEvent FrontOfCarSpeedEventHandler = null;



        //경고 메세지
        public event TextEvent TextEventHandler = null;

        //미디어 재생
        public event RunMediaEvent RunMediaEventHandler = null;
        //사진
        public event RunPictureEvent RunPictureEventHandler = null;

        //이미지 테스트
        public event TestEvent TestEventHandler = null;


        //자동으로 이미지테스트시작
        public event AutoRunEvet AutoRunEvetHandler = null;


        //속도 신호 델리게이트
        public event SpeedEvent SpeedEventHandler = null;

        //짧은 신호 맨위에것
        public event TopSignEvent TopSignEventHandler = null;

        //긴 신호 맨아래것
        public event BottonSignEvent BottonSignEventHandler = null;



        //안드로이드
        public event AndroidEvent AndroidEventHandler = null;


        //자동차 속도 중지
        public event StopSpeedEvent StopSpeedEventHandler = null;


        //팔로우미 중지
        public event StopFollowMeEvent StopFollowMeEventHandler = null;

        //구간별 속도
        public event SpeedOver30Event SpeedOver30EventHandler = null;
        public event SpeedOver40Event SpeedOver40EventHandler = null;
        public event SpeedOver50Event SpeedOver50EventHandler = null;
        public event SpeedOver80Event SpeedOver80EventHandler = null;
        public event SpeedOver100Event SpeedOver100EventHandler = null;

        //속도 제한 테스트
        public event SpeedOver30Event1 SpeedOver30Event1Handler = null;
        public event SpeedOver40Event1 SpeedOver40Event1Handler = null;
        public event SpeedOver50Event1 SpeedOver50Event1Handler = null;
        public event SpeedOver80Event1 SpeedOver80Event1Handler = null;
        public event SpeedOver100Event1 SpeedOver100Event1Handler = null;
   

        //속도

        public event DistanceEvent DistanceEventHandler = null;
        public event CautionEvent CautionEventHandler = null;

        
        //색깔, 글자크기 테이블 xml저장을 위함
        
        string orange = Brushes.Orange.ToString();
        string green = Brushes.Green.ToString();
        string violoet = Brushes.Violet.ToString();
        string black = Brushes.Black.ToString();

        public event AddColorEvent AddColorEventHandler = null;
        public event AddSizeEvent AddSizeEventHandler = null;
        public event AddNowColorEvent AddNowColorEventHandler = null;

        DataTable dt = new DataTable("색테이블");
        DataTable wt = new DataTable("글자크기");
        DataTable fc = new DataTable("글자색상");
        DataTable st = new DataTable("속도테이블");
        DataTable fmt = new DataTable("팔로우미");


        string fname = string.Empty;
        string sfname = string.Empty;
        string fname1 = string.Empty;
        string sfname1 = string.Empty;
        string fname2 = string.Empty;
        string sfname2 = string.Empty;
        string fname3 = string.Empty;
        string sfname3 = string.Empty;

        string fname4 = string.Empty;
        string sfname4 = string.Empty;
      
      


        private static List <string> sing_list = new List<string>();

        static public MyDocument Singleton
        {
            get;
            private set;
        }

        static MyDocument()
        {
            Singleton = new MyDocument();

        }

        private MyDocument()
        {
            SetDirectory();

            if (File.Exists(fname) == false)
            {
                DesignDataTable();
                DesignDataTable2();
                DesignDataTable3();
                DesignDataTable4();
            }

            else
            {
                Load();
            }
        }

        private void DesignDataTable4()
        {
            DataColumn dc_seq = new DataColumn("일련번호", typeof(int));
            dc_seq.AutoIncrement = true;
            dc_seq.AutoIncrementSeed = 1;
            dc_seq.AutoIncrementStep = 1;
            DataColumn dc_speed = new DataColumn("속도", typeof(string));

            st.Columns.Add(dc_seq);
            st.Columns.Add(dc_speed);

            DataColumn[] pkey = new DataColumn[1];
            pkey[0] = dc_speed;
            st.PrimaryKey = pkey;


        }


        internal void InitSaveSpeed(string speed)
        {
            if (st.Rows.Find(speed) != null)
            {
                DataRow da = st.Rows.Find(speed);
                st.Rows.Remove(da);

                DataRow dr = st.NewRow();
                dr["속도"] = speed;
                st.Rows.Add(dr);
            }
            else
            {
                DataRow dr = st.NewRow();
                dr["속도"] = speed;
                st.Rows.Add(dr);
            }

        }

       
        internal bool AddColor(SolidColorBrush color)
        {
            try
            {
                AddColorEventHandler(color);


                SaveColorDataRow(color);

                return true;
            }
            catch { }
            return false;
        }


        internal bool AddSize(int size)
        {
            try
            {
                AddSizeEventHandler(size);

                SaveSizeDataRow(size);

                return true;
            }
            catch { }
            return false;
        }

        internal bool AddNowColor(int size)
        {
            try
            {
                AddNowColorEventHandler(size);
                SaveNowColorDataRow(size);
                return true;
            }
            catch { }
            return false;
        }

        internal void SaveNowColorDataRow(int size)
        {
            if (fc.Rows.Find(size) != null)
            {
                DataRow da = fc.Rows.Find(size);
                fc.Rows.Remove(da);

                DataRow dr = fc.NewRow();
                dr["색번호"] = size;

                fc.Rows.Add(dr);
            }
            else
            {
                DataRow dr = fc.NewRow();
                dr["색번호"] = size;
                fc.Rows.Add(dr);
            }
           
        }

        internal void SaveSizeDataRow(int size)
        {
            if (wt.Rows.Find(size) != null)
            {
                DataRow da = wt.Rows.Find(size);
                wt.Rows.Remove(da);

                DataRow dr = wt.NewRow();
                dr["글자크기"] = size;

                wt.Rows.Add(dr);
            }
            else
            {
                DataRow dr = wt.NewRow();
                dr["글자크기"] = size;
                wt.Rows.Add(dr);
            }
        }


        internal void SaveColorDataRow(SolidColorBrush color)
        {
            if (dt.Rows.Find(color) != null)
            {
                DataRow da = dt.Rows.Find(color);
                dt.Rows.Remove(da);

                DataRow dr = dt.NewRow();
                dr["색상"] = color;
                dt.Rows.Add(dr);

            }
            else 
            {
                DataRow dr = dt.NewRow();
                dr["색상"] = color;
                dt.Rows.Add(dr);
            }
        }


        private void DesignDataTable()
        {
            DataColumn dc_seq = new DataColumn("일련번호", typeof(int));
            dc_seq.AutoIncrement = true;
            dc_seq.AutoIncrementSeed = 1;
            dc_seq.AutoIncrementStep = 1;
            DataColumn dc_color = new DataColumn("색상", typeof(string));
          

            dt.Columns.Add(dc_seq);
            dt.Columns.Add(dc_color);
          

            DataColumn[] pkey = new DataColumn[1];
            pkey[0] = dc_color;
            dt.PrimaryKey = pkey;
        }

        private void DesignDataTable2()
        {
            DataColumn dc_seq = new DataColumn("일련번호", typeof(int));
            dc_seq.AutoIncrement = true;
            dc_seq.AutoIncrementSeed = 1;
            dc_seq.AutoIncrementStep = 1;
          
            DataColumn dc_size = new DataColumn("글자크기", typeof(int));

            wt.Columns.Add(dc_seq);
            wt.Columns.Add(dc_size);

            DataColumn[] pkey = new DataColumn[1];
            pkey[0] = dc_size;

            wt.PrimaryKey = pkey;
        }

        private void DesignDataTable3()
        {
            DataColumn dc_seq = new DataColumn("일련번호", typeof(int));
            dc_seq.AutoIncrement = true;
            dc_seq.AutoIncrementSeed = 1;
            dc_seq.AutoIncrementStep = 1;

            DataColumn dc_colornumber = new DataColumn("색번호", typeof(int));

            fc.Columns.Add(dc_seq);
            fc.Columns.Add(dc_colornumber);

            DataColumn[] pkey = new DataColumn[1];
            pkey[0] = dc_colornumber;

            fc.PrimaryKey = pkey;
        }

        public string ImageDir
        {
            get;
            private set;
        }
        
        private void SetDirectory()
        {
            
            ImageDir = string.Format(@"{0}\{1}", Directory.GetCurrentDirectory(),"Colorss");
 
            fname = string.Format(@"{0}\data.xml", ImageDir);
            sfname = string.Format(@"{0}\data.xsd", ImageDir);
            fname1 = string.Format(@"{0}\data1.xml", ImageDir);
            sfname1 = string.Format(@"{0}\data1.xsd", ImageDir);
            fname2 = string.Format(@"{0}\data2.xml", ImageDir);
            sfname2 = string.Format(@"{0}\data2.xsd", ImageDir);
            fname3 = string.Format(@"{0}\data3.xml", ImageDir);
            sfname3 = string.Format(@"{0}\data3.xsd", ImageDir);

         

            if (Directory.Exists(ImageDir) == false)
            {
                Directory.CreateDirectory(ImageDir);
            }
        }

        internal void SetDirectory2()
        {
            fname4 = "C:\\Documents and Settings\\admin\\바탕 화면\\시연회연습\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xml";
            sfname4 = "C:\\Documents and Settings\\admin\\바탕 화면\\시연회연습\\김동중(최신)\\FollowMeProgram\\FollowMeProgram\\bin\\Debug\\hanwool\\data.xsd";
        }

        private void Load()
        {
            dt.ReadXmlSchema(sfname);
            dt.ReadXml(fname);
            wt.ReadXmlSchema(sfname1);
            wt.ReadXml(fname1);
            fc.ReadXmlSchema(sfname2);
            fc.ReadXml(fname2);
            st.ReadXmlSchema(sfname3);
            st.ReadXml(fname3);  
        }

        internal void Load2()
        {
            SetDirectory2();
            try
            {
                fmt.ReadXmlSchema(sfname4);
                fmt.ReadXml(fname4);
            }
           
            catch
            {
            }
        }

        internal void Save()
        {
            dt.WriteXmlSchema(sfname);
            dt.WriteXml(fname);
            wt.WriteXmlSchema(sfname1);
            wt.WriteXml(fname1);
            fc.WriteXmlSchema(sfname2);
            fc.WriteXml(fname2);
            st.WriteXmlSchema(sfname3);
            st.WriteXml(fname3);

            
        }

        internal void Save2()
        {
            fmt.WriteXmlSchema(sfname4);
            fmt.WriteXml(fname4);
        }

        internal void Start()
        {       
            string temp = string.Empty;
           
          
            foreach (DataRow dr in dt.Rows)
            {
                
                temp = dr["색상"] as String;
                CheckColor(temp);                
            }
        }

        internal void Start1()
        {
            

            int size = 0;

            foreach (DataRow dr in wt.Rows)
            {
                
                size = (int)dr["글자크기"];
                AddSizeEventHandler(size);
                
            }
        }

        internal void Start2()
        {
            int number = 0;
            foreach (DataRow dr in fc.Rows)
            {
                number = (int)dr["색번호"];
                AddNowColorEventHandler(number);
            }

        }

        

        internal void Start3()
        {
            string temp = string.Empty;
            string image = string.Empty;
          

            foreach (DataRow dr in fmt.Rows)
            {
                    image = dr["이미지"] as string;
                    temp = dr["텍스트"] as string;
                    
                    TestEventHandler(image, temp);                    
            }
            TestEventHandler(image, temp); 
            
        }


        internal void AllClear()
        {
            fmt.Clear();
        }

        private void CheckColor(string temp)
        {
            if (temp == orange)
            {
                SolidColorBrush solidred = Brushes.Orange;
                AddColorEventHandler(solidred);

            }
            else if (temp == green)
            {
                SolidColorBrush solidred = Brushes.Green;
                AddColorEventHandler(solidred);
            }

            else if (temp == black)
            {
                SolidColorBrush solidred = Brushes.Black;
                AddColorEventHandler(solidred);
            }

            else if (temp == violoet)
            {
                SolidColorBrush solidred = Brushes.Violet;
                AddColorEventHandler(solidred);
            }
        }
      


        //컬러
        internal void ColorChoice(int i, Brush color)
        {
            switch (i)
            {
                case 1: AddMemberEventHandler(color); TestMemberEventHandler(color); AirConColorEventHandler(color);break;
                case 2: AddMemberEventHandler(color); TestMemberEventHandler(color); AirConColorEventHandler(color);break;
                case 3: AddMemberEventHandler(color); TestMemberEventHandler(color); AirConColorEventHandler(color);break;
                default: AddMemberEventHandler(color); TestMemberEventHandler(color); AirConColorEventHandler(color);break;
            }
        }


        //사이즈
        internal void TextSizeChoice(int i, double size)
        {
            switch (i)
            {
                case 1: WindowSizeEventHandler(size); AudioSizeEventHandler(size); AirconSizeEventHandler(size);  break;
                case 2: WindowSizeEventHandler(size); AudioSizeEventHandler(size); AirconSizeEventHandler(size);  break;
                default: WindowSizeEventHandler(size); AudioSizeEventHandler(size); AirconSizeEventHandler(size);  break;
            }
        }

  

        //윈도우 시작위치
        internal void left() { LeftEventHandler(); }
        internal void Right() { RightEventHandler(); }
        internal void Top() { TopEventHandler(); }
        internal void Down() { DownEventHandler(); }


        //유저 윈도우 컨트롤 닫기 
        internal void CloseUser(){CloseUserEventHandler();}
        //유저 폰트 사이즈 컨트롤 닫기
        internal void CloseUserFontSize() {CloseUserFontSizeEventHandler();}
        //유저 윈도우 폰트 색깔 컨트롤 닫기
        internal void CloseWindowColor() { CloseUserColorEventEventHandler(); }


        //스피드
        internal void MySpeed(int speed)
        {
            MyspeedEventHandler(speed);
        }

        internal void FrontOfCarDistance(int distance)
        {
            FrontOfCarEventHandler(distance);
        }

        internal void FrontOfCarSpeed(int speed)
        {
            FrontOfCarSpeedEventHandler(speed);
        }

        //경고메제지 
        internal void TextMenu(int key)
        {
            switch (key)
            {
                case 1: TextEventHandler(key); break;
                case 2: TextEventHandler(key); break;
                case 3: TextEventHandler(key); break;
                default: break;
            }
        }


        //동영상
        internal void Runmedia()
        {
            runmedia = 1;
            RunMediaEventHandler();
        }

        internal void SetRunMedia(int p)
        {
            runmedia = 0;
        }

        internal int GetRunMedia()
        {
            return runmedia;
        }

       

        //사진
        internal void RunPicture()
        {
            RunPictureEventHandler();
        }


        public void Speed()
        {
            int key = 0;

            switch (key)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                default: break;
            }

        }

        //속도 구현 표지판 30
        internal void Sign_speed()
        {
            sing_list.Add("30kmh");
           

            foreach (string a in sing_list)
            {
                if(a.ToString() != "30kmh") 
                {
                    MessageBox.Show("30kmh실행");
                }
            }
        }

        internal void Sign_speed2()
        {
            
            sing_list.Add("40kmh");
          

            foreach (string a in sing_list)
            {
                if (a.ToString() != "40kmh")
                {
                    MessageBox.Show("40kmh실행");
                }
            }
        }

        internal void Sign_speed3()
        {

            sing_list.Add("50kmh");


            foreach (string a in sing_list)
            {
                if (a.ToString() != "50kmh")
                {
                    MessageBox.Show("50kmh실행");
                }
            }
        }



        private void NewRun(string nowspeedsss)
        {

            switch (nowspeedsss)
            {
                case "30": Speed30EventHandler(); break;
                case "50": Speed50EventHandler(); break;
                case "80": Speed80EventHandler(); break;
                case "100": Speed100EventHandler(); break;
                default: break;
            }
        }

        public void NewSpeed(string speed)
        {
            string now = string.Empty;
            nowspeedsss = speed;
            NowSpeedChecked();
        }

        internal void NowSpeedChecked()
        {
            string temp = string.Empty;

            foreach (DataRow dr in st.Rows)
            {
                temp = dr["속도"] as string;
                if (temp == nowspeedsss)
                {
                    NewRun(nowspeedsss);

                }

            }
        }

        internal void AutoRunPlz()
        {
            AutoRunEvetHandler();
        }


        //스피드 이벤트
        internal void AutoSpeed(int speed)
        {
            SpeedEventHandler(speed);
        }

        //짧은 이벤트 요철, 횡단보드

        internal void TopSign(int key)
        {
            TopSignEventHandler(key);
        }

        internal void BottonSign(int key)
        {
            BottonSignEventHandler(key);
        }


        internal void MyCarSpeed()
        {
            AndroidEventHandler();
        }

        internal void StopAllThings()
        {
            //StopSpeedEventHandler();
            StopFollowMeEventHandler();
        }

        internal void checkdMySpeed(int speed)
        {

            switch (speed)
            {
                case 30: SpeedOver30EventHandler(); break;
                case 40: SpeedOver40EventHandler(); break;
                case 50: SpeedOver50EventHandler(); break;
                case 80: SpeedOver80EventHandler(); break;
                case 100: SpeedOver100EventHandler(); break;
                default: break;

            }
        }

        internal void SpeedText(int key)
        {
            switch (key)
            {
                case 1: SpeedOver30Event1Handler(); break;
                case 2: SpeedOver40Event1Handler(); break;
                case 3: SpeedOver50Event1Handler(); break;
                case 4: SpeedOver80Event1Handler(); break;
                case 5: SpeedOver100Event1Handler(); break;

                default: ; break;

            }
            
        }

        int pri_distance = 0;
        int now_distance = 0;

        internal void SetDistance(int num)
        {
            now_distance = num;
        }

        internal void SetPrevDistance(int pri_num)
        {
            pri_distance = pri_num;
        }

        internal int GetPri_Distance()
        {
            return pri_distance;
        }

        internal int GetNow_Distance()
        {
            return now_distance;
        }

        int nowfrontofcarspeed = 0;
        internal int GetSpeed()
        {
            return nowfrontofcarspeed;
        }

        double distancesec = 0;

        double movedistance = 0;

        internal double GetSec()
        {
            return distancesec;
        }

        internal double GetMoveDistance()
        {
            return movedistance;
        }


        internal void SetSpeed(int myspeed)
        {
            nowfrontofcarspeed = myspeed;
        }

        internal int getdistance()
        {
            return now_distance;
        }

        internal void Caution(string p)
        {
            CautionEventHandler( p);
        }

        internal void Distance(double p)
        {
            DistanceEventHandler(p);
        }

        int myspeed = 0;
        internal void SetMyspeed(int speed)
        {
            myspeed = speed;
        }



        internal int GetMySpeed()
        {
            return myspeed;
        }

        
    }
}
