using CheckProg.Classes.ForPIPAction;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CheckProg
{
    /// <summary>
    /// Логика взаимодействия для BoardSelectWindow.xaml
    /// </summary>
    public partial class BoardSelectWindow : Window
    {
        private string selectedPath {  get; set; }
        public BoardSelectWindow()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(selectedPath , ((string)SelectBoardCbx.SelectedItem), Convert.ToInt32(LineTbx.Text));
            main.Show();
        }

        private void BrowseBtn_Click(object sender, RoutedEventArgs e)
        {
            using (FolderBrowserDialog  dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = @"C:\";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    selectedPath = dialog.SelectedPath;
                    PathTbx.Text = dialog.SelectedPath;
                    FillComboBox(dialog.SelectedPath);
                }
            }
        }

        void FillComboBox(string path)
        {
            string[] arr = Directory.GetFiles(path, "*.xml");
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = (arr[i].Split('\\')).Last();
            }
            if (arr.Length > 0) 
            {
                SelectBoardCbx.ItemsSource = arr;
            }
        }

        private void LineTbx_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if ((e.Key < Key.D0 || e.Key > Key.D9) && e.Key != Key.Back)
            {
                e.Handled = true;
            }
        }

        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {
            var x = File.ReadAllLines(selectedPath + "//test.txt");
            string[][] strings = new string[x.Length][];
            for (int i = 0; i < x.Length; i++)
            {
                strings[i] = x[i].Split('\t');
            }
            PIPConvertClass pIP = new PIPConvertClass();
            PIPWindow pip = new PIPWindow(pIP.CreateFromFile(strings), selectedPath, Convert.ToInt32(LineTbx.Text), Convert.ToInt32(XSize.Text), Convert.ToInt32(YSize.Text));
            pip.Show();
        }
    }
}
