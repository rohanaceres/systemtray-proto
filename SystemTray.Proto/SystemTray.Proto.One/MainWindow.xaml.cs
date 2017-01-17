using System;
using System.Windows;
using System.Windows.Forms;
using SystemTray.Proto;

namespace SystemTray.Proto.One
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public NotifyIcon MyIcon { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();
            this.CustomInitialize();
        }

        // initialize icon:
        private void CustomInitialize()
        {
            this.MyIcon = new NotifyIcon();
            this.MyIcon.Icon = Properties.Resources.JakeIcon;
            this.MyIcon.DoubleClick += this.OnIconDoubleClick;
        }

        // event catchers:
        private void OnIconDoubleClick(object sender, EventArgs e)
        {
            this.WindowState = WindowState.Normal;
            this.Visibility = Visibility.Visible;
            this.MyIcon.Visible = false;
        }
        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                this.MyIcon.Visible = true;
                this.Visibility = Visibility.Hidden;
            }
            else
            {
                this.MyIcon.Visible = false;
                this.Visibility = Visibility.Visible;
            }
        }
    }
}
