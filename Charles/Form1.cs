using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace Charles
{
    public partial class Form1 : Form
    {
        int threshold_value = 127;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Find a Tip of Rectangle Box
        /// </summary>
        /// <returns></returns>
        private Point Find_Center(Point[] rect)
        {
            Point Center = new Point(0,0);
            int index = 0,sum = 0;

            return Center;
        }
        /// <summary>
        /// Here, bounding rectangle is drawn with minimum area
        /// </summary>
        /// <param name="scr"></param>
        /// <returns></returns>
        private Point[] Find_Rectangle(Image<Bgr, byte> scr)
        {
            // Declare variable
            Point[] rect = new Point[4];
            double area=0;
            int index_contours=0;


            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();
            Image<Gray, byte> GrayImages = scr.Convert<Gray, byte>();
            Image<Gray, byte> ThresholdImages = new Image<Gray, byte>(GrayImages.Size);
            // Find contours
            CvInvoke.Threshold(GrayImages, ThresholdImages, threshold_value, 255,ThresholdType.Binary);
            CvInvoke.FindContours(ThresholdImages, contours, hierarchy, RetrType.External, ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < contours.Size; i++)
            {
                double s = CvInvoke.ContourArea(contours[i]);
                if (area < s)
                {
                    area = s;
                    index_contours = i;
                }
            }
            // Find Rectangle Box With 4 Points
            RotatedRect RectangleMin = CvInvoke.MinAreaRect(contours[index_contours]);
            PointF[] RectangleMin_Tip = CvInvoke.BoxPoints(RectangleMin);
            for (int i = 0; i<4; i++)
            {
                rect[i] = Point.Round(RectangleMin_Tip[i]);
            }
            // Clear memory
            GrayImages.Dispose();
            ThresholdImages.Dispose();
            contours.Dispose();
            hierarchy.Dispose();
            return rect;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Handling()
        {
            MyCamera camera = new MyCamera();
            Mat scr = camera.Capture_Frame();
            Image<Bgr, Byte> Bgr_Image = scr.ToImage<Bgr, byte>();

            Point[] p =  this.Find_Rectangle(Bgr_Image);
            
            //CvInvoke.Line(Bgr_Image, p[1], p[3], new MCvScalar(0, 0, 255),1);
            //log.Text = p[0].ToString() + p[1].ToString() + p[2].ToString() + p[3].ToString() ;
            imShow.Image = Bgr_Image.ToBitmap();
            Bgr_Image.Dispose();
            scr.Dispose();
        }
        private void tStartStop_Click(object sender, EventArgs e)
        {
            this.Handling();
        }

    }
}
