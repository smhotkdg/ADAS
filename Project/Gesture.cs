using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCvSharp;

namespace Project
{    
    class Gesture
    {
        CvCapture cv_cap; // 비디오 캡쳐        
        IplImage src;


        GesturesLib.Gestures myg = new GesturesLib.Gestures();
        Timer timer = null;

        public Gesture()
        {

        }
        public void StartGesture()
        {
            if (timer != null)
            {
                timer.Enabled = false;
                timer = null;
            }
            timer = new Timer();

            cv_cap = new CvCapture(CaptureDevice.DShow, 0);
            timer.Interval = 200;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        public void EndGesture()
        {
            timer.Enabled = false;
            timer.Stop();
            cv_cap.Dispose();
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            src = cv_cap.QueryFrame();
            myg.Convexty(src);
        }
    }
}
