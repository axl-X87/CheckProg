using CheckProg.Classes.DataClasses;
using CheckProg.Classes.ForPIPAction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CheckProg.Classes
{
    public class ImageSetterClass
    {
        private Bitmap _bitmap;
        private Bitmap _bitmapRendered;
        private Graphics _graphics;
        private int fixTotalSizeX = 0;
        private int fixTotalSizeY = 0;
        private string _path = "";

        public ImageSetterClass(Board board, string path) 
        {
            fixTotalSizeX = (int)(Convert.ToDouble(board.Info.Length.Replace('.', ',')) * 10);
            fixTotalSizeY = (int)(Convert.ToDouble(board.Info.Width.Replace('.', ',')) * 10);
            //_bitmap = new Bitmap((int)(Convert.ToDouble(board.Info.Length.Replace('.', ',')))
            //, (int)(Convert.ToDouble(board.Info.Width.Replace('.', ',')))
            //, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            _path = path; 
            _bitmap = new Bitmap(path + "\\" + "Picall.jpg");
        }
        public ImageSetterClass(string path, int sX, int sY)
        {
            fixTotalSizeX = sX * 10;
            fixTotalSizeY = sY * 10;
            _path = path;
            _bitmap = new Bitmap(path + "\\" + "Picall.jpg");
        }

        private void Refresh()
        {
            _bitmap = new Bitmap(_path + "\\" + "Picall.jpg");
        }

        private BitmapImage SetImage(Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Jpeg);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();

                return bitmapImage;
            }
        }

        public async Task<BitmapImage> DrawRectPos(List<Parts> parts)
        {
            List<Task> tasks = new List<Task>();
            _bitmapRendered = _bitmap;
            Refresh();
            _graphics = Graphics.FromImage(_bitmapRendered);
            foreach (var part in parts) 
            {
                tasks.Add(Render(part));
            }
            await Task.WhenAll(tasks);
            return SetImage(_bitmapRendered);
        }

        public async Task<BitmapImage> DrawNonRectPos()
        {
            return SetImage(_bitmap);
        }

        private async Task Render(Parts part)
        {
            int x = (int)(Convert.ToDouble(part.X.Replace('.', ',')) * 10);
            int y = (int)(Convert.ToDouble(part.Y.Replace('.', ',')) * 10);
            int sizex = (int)(Convert.ToDouble(part.SizeX.Replace('.', ',')) * 10);
            int sizey = (int)(Convert.ToDouble(part.SizeY.Replace('.', ',')) * 10);
            y = fixTotalSizeY - y;
            Pen pen = new Pen(Color.Red, 10);
            _graphics.DrawRectangle(pen, new Rectangle((x - (sizex / 2)), (y - (sizey / 2)), sizex, sizey));
        }

        public async Task<BitmapImage> DrawCrossPos(Parts part, int thick)
        {
            _bitmap = null;
            Refresh();
            var temp = _bitmap;
            _graphics = Graphics.FromImage(temp);
            int x = (int)(Convert.ToDouble(part.X.Replace('.', ',')) * 10);
            int y = (int)(Convert.ToDouble(part.Y.Replace('.', ',')) * 10);
            y = fixTotalSizeY - y;
            int sizex = (int)(Convert.ToDouble(part.SizeX.Replace('.', ',')) * 10);
            int sizey = (int)(Convert.ToDouble(part.SizeY.Replace('.', ',')) * 10);
            Pen penG = new Pen(Color.Red, thick);
            _graphics.DrawLine(penG, x, 0, x, fixTotalSizeY);
            _graphics.DrawLine(penG, 0, y, fixTotalSizeX, y);
            return SetImage(temp);
        }

        internal async Task<BitmapImage> DrawCrossPosPIP(PIPConvertClass pip, int thick)
        {
            var temp = (Bitmap)_bitmapRendered.Clone();
            _graphics = Graphics.FromImage(temp);
            int x = (int)(pip.CenterX * 10);
            int y = (int)(pip.CenterY * 10);
            y = fixTotalSizeY - y;
            int sizex = (int)(pip.CenterX * 10);
            int sizey = (int)(pip.CenterY * 10);
            Pen penG = new Pen(Color.Red, thick);
            _graphics.DrawLine(penG, x, 0, x, fixTotalSizeY);
            _graphics.DrawLine(penG, 0, y, fixTotalSizeX, y);
            return SetImage(temp);
        }
    }
}
