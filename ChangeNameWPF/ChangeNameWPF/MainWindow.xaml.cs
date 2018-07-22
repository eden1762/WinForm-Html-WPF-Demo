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
using WPFFolderBrowser;



namespace ChangeNameWPF
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string folderstring;
        private void ChooseFilebutton_Click(object sender, RoutedEventArgs e)
        {
            WPFFolderBrowserDialog wpffolderdialog = new WPFFolderBrowserDialog();
            wpffolderdialog.ShowDialog();
            //this.textBoxTiltleSetting.Text = wpffolderdialog.FileName;
            folderstring= wpffolderdialog.FileName;
        }

        private void Startbutton_Click(object sender, RoutedEventArgs e)
        {
            if (folderstring != null)
            {
                DirectoryInfo di = new DirectoryInfo(@"" + folderstring + "");
                Int32 count = 1;
                foreach (FileInfo fi in di.GetFiles())
                {
                    String NewFileNameStart = textBoxTiltleSetting.Text + count.ToString();
                    String NewFileNameEnd = count.ToString() + "." + textBoxTiltleSetting.Text;

                    //重新命名
                    if (checkBoxStart.IsChecked == true)
                    {
                        fi.MoveTo(System.IO.Path.Combine(fi.DirectoryName, NewFileNameStart + "." + System.IO.Path.GetFileNameWithoutExtension(fi.Name) + fi.Extension));
                        count++;
                    }
                    if (checkBoxEnd.IsChecked == true)
                    {
                        fi.MoveTo(System.IO.Path.Combine(fi.DirectoryName, NewFileNameEnd + System.IO.Path.GetFileNameWithoutExtension(fi.Name) + fi.Extension));
                        count++;
                    }
                }
                MessageBox.Show("修改完成");
            }
            else
            {
                MessageBox.Show("請選擇資料夾!");
            }
        }

        private void checkBoxStart_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxEnd.IsChecked = false;
        }

        private void checkBoxEnd_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxStart.IsChecked = false;
        }
    }
}
