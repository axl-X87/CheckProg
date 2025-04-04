using CheckProg.Classes;
using CheckProg.Classes.DataClasses;
using CheckProg.Classes.ForPIPAction;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace CheckProg
{
    /// <summary>
    /// Логика взаимодействия для PIPWindow.xaml
    /// </summary>
    public partial class PIPWindow : Window
    {
        int thick = 0;
        int sX = 0;
        int sY = 0;
        int sizeIMG = 10;
        ImageSetterClass image;
        string _Path { get; set;}
        internal PIPWindow(List<PIPConvertClass> pips, string ph, int th, int sX, int sY)
        {
            InitializeComponent();
            PIPListLv.ItemsSource = pips;
            thick = th;
            _Path = ph;
            this.sX = sX;
            this.sY = sY;
        }

        private async void PIPListLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PIPConvertClass selected = ((PIPConvertClass)PIPListLv.SelectedItem);
            AllImageIb.Source = await image.DrawCrossPosPIP(selected, thick);
        }

        private async void AllImageIb_Loaded(object sender, RoutedEventArgs e)
        {
            image = new ImageSetterClass(_Path, sX, sY);
            AllImageIb.Source = await image.DrawNonRectPos();
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
    }
}
