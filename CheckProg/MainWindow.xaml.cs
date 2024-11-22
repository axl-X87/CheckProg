using CheckProg.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace CheckProg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Parts> PartNGList = new List<Parts>();
        Board board = new Board();
        DataVersion versionTemp = new DataVersion();
        private string _Path { get; set; }
        public MainWindow(string path, string name)
        {
            InitializeComponent();
            XmlParceClass xml = new XmlParceClass();
            xml.SetPath(path + "\\" + name);
            versionTemp =  xml.XmlParceClassStart();
            board = versionTemp.Board;
            foreach (var block in versionTemp.Block)
            {
                foreach (var part in block.Parts)
                {
                    PartNGList.Add(part);
                }
            }
            PartsListLv.ItemsSource = PartNGList;
            _Path = path;
            SetAllPic(path + "\\" + "Picall.jpg");
        }

        void SetAllPic(string path)
        {
            try
            {
                Uri uriNG = new Uri(path);
                BitmapImage bitmapNG = new BitmapImage(uriNG);
                AllImageIb.Source = bitmapNG;

            }
            catch (Exception ex) { var x = ex.ToString(); }
        }


        //private void BlockSelectCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    List<Parts> parts = (((ComboBox)sender).SelectedItem as Classes.DataClasses.Block).Parts;
        //    PartsListLv.ItemsSource = parts;
        //}

        private void PartsListLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (((ListBox)sender).SelectedItem != null)
                {
                    Parts selected = ((ListBox)sender).SelectedItem as Parts;
                    StepsListLv.ItemsSource = selected.Step;
                    int fixX = (int)(Convert.ToDouble(selected.X.Replace('.', ',')) * 10);
                    int fixY = (int)(Convert.ToDouble(selected.Y.Replace('.', ',')) * 10);
                    int fixSizeX = (int)(Convert.ToDouble(selected.SizeX.Replace('.', ',')) * 10);
                    int fixSizeY = (int)(Convert.ToDouble(selected.SizeY.Replace('.', ',')) * 10);
                    DrawPos(fixX, fixY, fixSizeX > 10 ? fixSizeX : 10, fixSizeY > 10 ? fixSizeY : 10);
                }
            }
            catch { }
        }

        private void StepsListLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Step step = ((ListBox)sender).SelectedItem as Step;
                if (step != null)
                {
                    ImageWindow imageWindow = new ImageWindow(step, _Path + "\\" + board.NGImage.Folder);
                    imageWindow.Show();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DrawPos(int x, int y, int sizex, int sizey)
        {
            int fixTotalSizeX = (int)(Convert.ToDouble(board.Info.Length.Replace('.', ','))) * 10;
            int fixTotalSizeY = (int)(Convert.ToDouble(board.Info.Width.Replace('.', ','))) * 10;
            y = fixTotalSizeY - y;
            Bitmap bitmap = new Bitmap(fixTotalSizeX, fixTotalSizeY, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Red, 5);
            System.Drawing.Pen penG = new System.Drawing.Pen(System.Drawing.Color.Red, 5f);
            graphics.DrawRectangle(pen, new System.Drawing.Rectangle((x - (sizex / 2)), (y - (sizey / 2)), sizex, sizey));
            graphics.DrawLine(penG, x, 0, x, fixTotalSizeY);
            graphics.DrawLine(penG, 0, y, fixTotalSizeX, y);
            PosImageIb.Source = BitmapToBitmapImage(bitmap);
        }

        public BitmapImage BitmapToBitmapImage(Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
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
    }
}
