using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCvSharp;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project
{
    class Class2
    {
        CvColor[] colors = new CvColor[]
            {
                new CvColor(0,0,255),
                new CvColor(0,128,255),
                new CvColor(0,255,255),
                new CvColor(0,255,0),
                new CvColor(255,128,0),
                new CvColor(255,255,0),
                new CvColor(255,0,0),
                new CvColor(255,0,255),
            };
        const double Scale = 1.25;
        const double ScaleFactor = 2.5;
        const int MinNeigbors = 2;
        CvCapture cap;

        public Image OnTest()
        {

            using (IplImage img = cap.QueryFrame())
            {
                using (IplImage smallImg = new IplImage(new CvSize(Cv.Round(img.Width / Scale),
                        Cv.Round(img.Height / Scale)), BitDepth.U8, 1))
                {
                    using (IplImage gray = new IplImage(img.Size, BitDepth.U8, 1))
                    {
                        Cv.CvtColor(img, gray, ColorConversion.BgrToGray);
                        Cv.Resize(gray, smallImg, Interpolation.Linear);
                        Cv.EqualizeHist(smallImg, smallImg);
                    }
                    using (CvHaarClassifierCascade cascade = CvHaarClassifierCascade.FromFile("sign.xml"))
                    using (CvMemStorage storage = new CvMemStorage())
                    {
                        storage.Clear();
                        Stopwatch watch = Stopwatch.StartNew();
                        CvSeq<CvAvgComp> face = Cv.HaarDetectObjects(smallImg, cascade, storage, ScaleFactor, MinNeigbors, 0, new CvSize(30, 30));
                        watch.Stop();
                        Console.WriteLine("detection time  = {0}msn", watch.ElapsedMilliseconds);

                        for (int i = 0; i < face.Total; i++)
                        {
                            CvRect r = face[i].Value.Rect;
                            CvPoint center = new CvPoint
                            {
                                X = Cv.Round((r.X + r.Width * 0.5) * Scale),
                                Y = Cv.Round((r.Y + r.Height * 0.5) * Scale)

                            };
                            if (true)
                            {
                                int radius = Cv.Round((r.Width + r.Height) * 0.25 * Scale);
                                img.Circle(center, radius, colors[i % 8], 3, LineType.AntiAlias, 0);
                                MessageBox.Show("Message"); break;
                            }
                        }
                    }
                }
                Image hp = img.ToBitmap();
                return hp;
            }

        }
        public void initCamstaus()
        {
            cap = CvCapture.FromCamera(0); //웹캠장치번호
            cap.FrameWidth = 300; //화면크기 설정
            cap.FrameHeight = 300;

        }

    }
}
