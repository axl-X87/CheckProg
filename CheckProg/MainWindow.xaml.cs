using CheckProg.Classes;
using CheckProg.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
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
using System.Xml.Linq;
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
        ImageSetterClass image;
        int thick = 0;
        int sizeIMG = 10;
        public MainWindow(string path, string name, int _thickness)
        {
            InitializeComponent();
            XmlParceClass xml = new XmlParceClass();
            xml.SetPath(path + "\\" + name);
            versionTemp = xml.XmlParceClassStart();
            thick = _thickness;
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
            image = new ImageSetterClass(board, _Path);
        }

        void WriteProbs()
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            foreach (var part in PartNGList)
            {
                try
                {
                    pairs.Add(part.RefNo, part.Step[0].NGReason);
                }
                catch { }
            }
            SendToAPI api = new SendToAPI();
            api.SetURL("");
            api.SendData(IdTbx.Text, pairs);
        }

        async void SetAllPic()
        {
            AllImageIb.Source = await image.DrawRectPos(PartNGList);
        }

        private async void PartsListLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (((ListBox)sender).SelectedItem != null)
                {
                    Parts selected = ((ListBox)sender).SelectedItem as Parts;
                    AllImageIb.Source = await image.DrawCrossPos(selected, thick);
                    StepsListLv.ItemsSource = selected.Step;
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

        private void AllImageIb_Loaded(object sender, RoutedEventArgs e)
        {
            SetAllPic();
        }

        private void FilterOptTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            PartsListLv.ItemsSource = PartNGList.Where(where => where.RefNo.Contains(((TextBox)sender).Text));
        }

        private void PlBtn_Click(object sender, RoutedEventArgs e)
        {
            sizeIMG += 1;
            AllImageIb.Height = 100 * sizeIMG;
            AllImageIb.Width = 100 * sizeIMG;
        }

        private void NgBtn_Click(object sender, RoutedEventArgs e)
        {
            sizeIMG -= 1;
            AllImageIb.Height = 100 * sizeIMG;
            AllImageIb.Width = 100 * sizeIMG;
        }

        private void SendProbBtn_Click(object sender, RoutedEventArgs e)
        {
            WriteProbs();
        }
    }
}
