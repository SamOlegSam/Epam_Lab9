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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string filename;
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данное риложение позволяет редактировать и соханять зменения  текстовом файле.");
        }
        
        public void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            //------------------------------------------------------
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                      
            if (openFileDialog.ShowDialog() == true)
            {                    
                filename = openFileDialog.FileName;  
                //-------------------------------------------------------
                //TexBox1.Text = File.ReadAllText(filename);
                TexBox1.Text = TextFile.OpenFile(filename);
                
                //-------------------------------------------------------
            }
            else
            {
                MessageBox.Show("Файл не выбран!", "Информация", MessageBoxButton.YesNo, MessageBoxImage.Information);
                return;
            }
                
    }
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            
             MessageBox.Show(TextFile.SaveFile(TexBox1.Text, filename));
            
        }
    }
}
