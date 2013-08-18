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
using Leap;
using System.Runtime.InteropServices;

namespace Touchless2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        [DllImport(@"user32.dll")]
        private static extern IntPtr FindWindow(string lp1, string lp2);
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        public MainWindow()
        {
            this.viewModel = new MainWindowViewModel();
            this.DataContext = this.viewModel;
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IntPtr hWnd = FindWindow("Notepad", "Untitled - Notepad");
            if (!hWnd.Equals(IntPtr.Zero))
            {
                // SW_SHOWMAXIMIZED to maximize the window
                // SW_SHOWMINIMIZED to minimize the window
                // SW_SHOWNORMAL to make the window be normal size
                ShowWindowAsync(hWnd, SW_SHOWMAXIMIZED);
            }
        }
    }
}
