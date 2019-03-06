using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
namespace Charles
{
    class MyCamera
    {
        public Mat Capture_Frame()
        {
            Mat scr = CvInvoke.Imread(@"G:\Thieu\Internet of Things\Project\Locate_Label\images\label.jpg");
            return scr;
        }
    }
}
