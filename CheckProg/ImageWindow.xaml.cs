using CheckProg.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace CheckProg
{
    /// <summary>
    /// Логика взаимодействия для ImageWindow.xaml
    /// </summary>
    public partial class ImageWindow : Window
    {
        string path = "";
        Step Step;
        public ImageWindow(Step step)
        {
            InitializeComponent();
            //string[] arr = new[] { "ImageNameM", "Parts3dName", "OptSlantName045", "OptSlantName135", "OptSlantName225", "OptSlantName315" };
            //ImageSelectCb.ItemsSource = arr;
            Step = step;
            try
            {
                Uri uriNG = new Uri("C:\\Users\\Привет!\\Pictures\\RS@ARKTUR-BOT-2.0@241113 160931 1 5@5@A@NG@20241113160931Image\\" + step.StepImage.NGName);
                BitmapImage bitmapNG = new BitmapImage(uriNG);
                ImageBx.Source = bitmapNG;
                Uri uriNGInsp = new Uri("C:\\Users\\Привет!\\Pictures\\RS@ARKTUR-BOT-2.0@241113 160931 1 5@5@A@NG@20241113160931Image\\" + step.StepImage.InspName);
                BitmapImage bitmapNGInsp = new BitmapImage(uriNG);
                ImageBx.Source = bitmapNGInsp;

            }
            catch { }
        }       
    }
}
