using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        //SafetyEngineLib.SafetyEngine safe = new SafetyEngineLib.SafetyEngine();
        

        Class2 c2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //c2 = new Classs2();
            //c2.initCamstaus();
            //timer1.Enabled = true;

              //  safe.GetDistanceEventHandler += new SafetyEngineLib.GetDistance(safe_GetDistanceEventHandler);
              //  safe.GetSrcEventHandler += new SafetyEngineLib.GetSrc(safe_GetSrcEventHandler);
              //  safe.StartEngine();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //pictureBox1.Image = c2.OnTest();
        }

        public void Test()
        {
            //afe.EndEngine();
        }

        private void PlayVideo_Click(object sender, EventArgs e)
        {
           // safe.StartEngine();
        }

        private void VideoStop_Click(object sender, EventArgs e)
        {
           // safe.EndEngine();
        }


        //void safe_GetSrcEventHandler()
        //{
        //    if (safe.src_ipl != null)
        //    {
        //        pictureBoxIpl1.ImageIpl = safe.src_ipl;
        //    }
        //}

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


  //      }
    }
}
