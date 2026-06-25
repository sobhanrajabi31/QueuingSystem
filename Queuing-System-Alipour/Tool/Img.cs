namespace Queuing_System_Alipour.Tool
{
    public static class Img
    {
        public static Bitmap ConvertToBmp(Image img)
        {
            var bmp = new Bitmap(img);
            bmp.MakeTransparent(Color.White);
            return bmp;
        }
    }
}
