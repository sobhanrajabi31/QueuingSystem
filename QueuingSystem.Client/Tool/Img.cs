namespace QueuingSystem.Client.Tool
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
