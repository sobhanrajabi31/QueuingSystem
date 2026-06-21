using System.Drawing;

namespace Queuing_System_Alipour.Tool
{
    public class Img
    {
        public static Bitmap ConvertToBmp(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            bmp.MakeTransparent(Color.White);
            return bmp;
        }
    }
}
