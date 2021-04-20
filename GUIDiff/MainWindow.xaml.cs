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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DiffPlex.Wpf.Controls;
using System.IO;
using Microsoft.Win32;

namespace GUIDiff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            GUIDiff.OldText = "Select File 1";
            GUIDiff.NewText = "Select File 2";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int fileNum = ((Button)sender).Name == "BtnFile1" ? 1 : 2;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                if (fileNum == 1)
                {
                GUIDiff.OldText = File.ReadAllText(openFileDialog.FileName);

                }else
                {
                    GUIDiff.NewText = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }
    }
}
