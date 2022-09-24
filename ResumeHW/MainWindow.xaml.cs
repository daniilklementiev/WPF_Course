using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
using System.Windows.Threading;

namespace ResumeHW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResumeHW_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void ResumeHW_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("C++ certified programmist\n");
            sb.Append(" - Object oriented programming using C++\n");
            sb.Append(" - WinApi using C++\n");
            sb.Append("C# programmist\n");
            sb.Append(" - Object oriented programming using C#\n");
            sb.Append(" - WinForms applications using C#\n");
            sb.Append(" - WPF applications using C#\n");
            sb.Append("Web Programming skills\n");
            sb.Append(" - HTML language\n");
            sb.Append(" - CSS language\n");
            sb.Append(" - SASS library\n");
            MessageBox.Show(sb.ToString(), "Skills", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
