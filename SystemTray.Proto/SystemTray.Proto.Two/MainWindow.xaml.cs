using System.Windows;
using System.Windows.Forms;

namespace SystemTray.Proto.Two
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public NotifyIcon MyStatusIcon { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();
            this.CustomInitialize();
        }

        private void CustomInitialize()
        {
            this.MyStatusIcon = new NotifyIcon();
            this.MyStatusIcon.Icon = Properties.Resources.Yellow;
            this.MyStatusIcon.BalloonTipTitle = "Status";
            this.MyStatusIcon.Visible = true;
        }

        // event catchers:
        private void OnOkStatus(object sender, RoutedEventArgs e)
        {
            this.MyStatusIcon.Icon = Properties.Resources.Green;
            this.MyStatusIcon.BalloonTipText = "Everything is OK! :-)";
            this.MyStatusIcon.ShowBalloonTip(2000);
        }
        private void OnWarningStatus(object sender, RoutedEventArgs e)
        {
            this.MyStatusIcon.Icon = Properties.Resources.Yellow;
            this.MyStatusIcon.BalloonTipText = "Warning!";
            this.MyStatusIcon.BalloonTipIcon = ToolTipIcon.Warning;
            this.MyStatusIcon.ShowBalloonTip(2000);
        }
        private void OnErrorStatus(object sender, RoutedEventArgs e)
        {
            this.MyStatusIcon.Icon = Properties.Resources.Red;
            this.MyStatusIcon.BalloonTipText = "Error!";
            this.MyStatusIcon.BalloonTipIcon = ToolTipIcon.Error;
            this.MyStatusIcon.ShowBalloonTip(2000);
        }
    }
}
