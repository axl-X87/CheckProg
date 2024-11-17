﻿using CheckProg.Classes.DataClasses;
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

namespace CheckProg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Classes.DataClasses.Block> block = new List<Classes.DataClasses.Block>();
        Board board = new Board();
        public MainWindow()
        {
            InitializeComponent();
            XmlParceClass xml = new XmlParceClass();
            block = xml.XmlParceClassStart().Block;
            board = xml.XmlParceClassStart().Board;
            BlockSelectCb.ItemsSource = block;           
        }


        private void BlockSelectCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Parts> parts = (((ComboBox)sender).SelectedItem as Classes.DataClasses.Block).Parts;
            PartsListLv.ItemsSource = parts;
        }

        private void PartsListLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (((ListBox)sender).SelectedItem != null)
                {
                    Parts selected = ((ListBox)sender).SelectedItem as Parts;
                    StepsListLv.ItemsSource = selected.Step;
                    int fixX = (int)Convert.ToDouble(selected.X.Replace('.', ','));
                    int fixY = (int)Convert.ToDouble(selected.Y.Replace('.', ','));
                    int fixSizeX = (int)Convert.ToDouble(selected.SizeX.Replace('.', ','));
                    int fixSizeY = (int)Convert.ToDouble(selected.SizeY.Replace('.', ','));
                    DrawPos(fixX, fixY, fixSizeX > 1 ? fixSizeX : 1, fixSizeY > 1 ? fixSizeY : 1);
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
                    ImageWindow imageWindow = new ImageWindow(step);
                    imageWindow.Show();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DrawPos(int x, int y, int sizex, int sizey)
        {
            int fixTotalSizeX = (int)Convert.ToDouble(board.Info.Length.Replace('.', ','));
            int fixTotalSizeY = (int)Convert.ToDouble(board.Info.Width.Replace('.', ','));
            Bitmap bitmap = new Bitmap(fixTotalSizeX, fixTotalSizeY, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Red, 1);
            graphics.DrawRectangle(pen, new System.Drawing.Rectangle(x, y, sizex, sizey));
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