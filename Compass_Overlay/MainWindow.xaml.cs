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

namespace Compass_Overlay
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

        private void DragWindowWithLeftMouseButton(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetSizeLarge_Click(object sender, EventArgs e)
        {
            Application.Current.MainWindow.MaxHeight = 240;
            Application.Current.MainWindow.MaxWidth = 240;
        }
        private void SetSizeMedium_Click(object sender, EventArgs e)
        {
            Application.Current.MainWindow.MaxHeight = 128;
            Application.Current.MainWindow.MaxWidth = 128;
        }
        private void SetSizeSmall_Click(object sender, EventArgs e)
        {
            Application.Current.MainWindow.MaxHeight = 64;
            Application.Current.MainWindow.MaxWidth = 64;
        }
    }
}
