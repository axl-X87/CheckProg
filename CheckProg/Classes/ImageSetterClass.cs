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
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CheckProg.Classes
{
    public class ImageSetterClass
    {
        private Graphics _graphics;
        private int fixTotalSizeX = 0;
        private int fixTotalSizeY = 0;
        private string _path = "";

        public ImageSetterClass(Board board, string path) 
        {
            fixTotalSizeX = (int)(Convert.ToDouble(board.Info.Length.Replace('.', ',')) * 20);
            fixTotalSizeY = (int)(Convert.ToDouble(board.Info.Width.Replace('.', ',')) * 20);
            _path = path; 
        }
        public ImageSetterClass(string path, int sX, int sY)
        {
            fixTotalSizeX = sX * 20;
            fixTotalSizeY = sY * 20;
            _path = path;
        }

        private Bitmap Refresh()
        {
            return new Bitmap(_path + "\\" + "Picall.jpg");
        }

        private Bitmap RefreshDraw()
        {
            return new Bitmap(_path + "\\" + "tempImg.jpg");
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

        private void SaveDraw(Bitmap image)
        {
            image.Save(_path + "\\" + "tempImg.jpg", ImageFormat.Jpeg);
        }

        public async Task<BitmapImage> DrawRectPos(List<Parts> parts, int border)
        {
            List<Task> tasks = new List<Task>();
            var temp = Refresh();
            _graphics = Graphics.FromImage(temp);
            foreach (var part in parts) 
            {
                tasks.Add(Render(part, border));
            }
            await Task.WhenAll(tasks);
            SaveDraw(temp);
            return SetImage(temp);
        }

        public async Task<BitmapImage> DrawNonRectPos()
        {
            return SetImage(RefreshDraw());
        }

        private async Task Render(Parts part, int border)
        {
            int x = (int)(Convert.ToDouble(part.X.Replace('.', ',')) * 20);
            int y = (int)(Convert.ToDouble(part.Y.Replace('.', ',')) * 20);
            int sizex = (int)(Convert.ToDouble(part.SizeX.Replace('.', ',')) * 20);
            int sizey = (int)(Convert.ToDouble(part.SizeY.Replace('.', ',')) * 20);
            y = fixTotalSizeY - y;
            Pen pen = new Pen(Color.Red, border);
            _graphics.DrawRectangle(pen, new Rectangle((x - (sizex / 2)), (y - (sizey / 2)), sizex, sizey));
        }

        public async Task<BitmapImage> DrawCrossPos(Parts part, int thick)
        {
            Bitmap temp = RefreshDraw();
            _graphics = Graphics.FromImage(temp);
            int x = (int)(Convert.ToDouble(part.X.Replace('.', ',')) * 20);
            int y = (int)(Convert.ToDouble(part.Y.Replace('.', ',')) * 20);
            y = fixTotalSizeY - y;
            int sizex = (int)(Convert.ToDouble(part.SizeX.Replace('.', ',')) * 20);
            int sizey = (int)(Convert.ToDouble(part.SizeY.Replace('.', ',')) * 20);
            Pen penG = new Pen(Color.Red, thick);
            _graphics.DrawLine(penG, x, 0, x, fixTotalSizeY);
            _graphics.DrawLine(penG, 0, y, fixTotalSizeX, y);
            return SetImage(temp);
        }

        internal async Task<BitmapImage> DrawCrossPosPIP(PIPConvertClass pip, int thick, double ofsX, double ofsY, int rotate)
        {
            Bitmap temp = Refresh();
            switch (rotate)
            {
                case 0:
                    {
                        temp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    }
                case 90:
                    {
                        temp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    }
                case 180:
                    {
                        temp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                    }
                case 270:
                    {
                        temp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                        break;
                    }
                default: break;
            }
            _graphics = Graphics.FromImage(temp);
            int x = (int)(pip.CenterX * 20);
            int y = (int)(pip.CenterY * 20);
            y = fixTotalSizeY - y;
            int sizex = (int)(pip.CenterX * 20);
            int sizey = (int)(pip.CenterY * 20);
            Pen penG = new Pen(Color.Red, thick);
            _graphics.DrawLine(penG, x + ((int)ofsX * 20), 0, x, fixTotalSizeY);
            _graphics.DrawLine(penG, 0, y + ((int)ofsY * 20), fixTotalSizeX, y);
            return SetImage(temp);
        }

        internal BitmapImage RotatePos(ref int rad)
        {
            Bitmap temp = Refresh();
            switch (rad)
            {
                case 0:
                    {
                        temp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        rad = 90;
                        break;
                    }
                case 90:
                    {
                        temp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        rad = 180;
                        break;
                    }
                case 180:
                    {
                        temp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        rad = 270;
                        break;
                    }
                case 270:
                    {
                        temp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                        rad = 0;
                        break;
                    }
            }
            return SetImage(temp);
        }
    }
}
