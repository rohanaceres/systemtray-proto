using System.Windows;
using System.Windows.Forms;
using SystemTray.Proto.Three.MyService.Events;
using SystemTray.Proto.Three.MyService.TypeCode;

namespace SystemTray.Proto.Three
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

        private void CustomInitialize()
        {
            this.MyIcon = new NotifyIcon();
            this.MyIcon.Icon = Properties.Resources.Yellow;
            this.MyIcon.BalloonTipTitle = "Status";
            this.MyIcon.Visible = true;
        }

        internal void OnServiceStatusChanged(object sender, ServiceEventArguments e)
        {
            switch (e.ServiceStatus)
            {
                case RandomServiceStatus.Ok:
                    this.MyIcon.Icon = Properties.Resources.Green;
                    this.MyIcon.BalloonTipIcon = ToolTipIcon.None;
                    this.MyIcon.BalloonTipText = "Success!";
                    break;
                case RandomServiceStatus.Warning:
                    this.MyIcon.Icon = Properties.Resources.Yellow;
                    this.MyIcon.BalloonTipIcon = ToolTipIcon.Warning;
                    this.MyIcon.BalloonTipText = "Warning!";
                    break;
                default:
                    this.MyIcon.Icon = Properties.Resources.Red;
                    this.MyIcon.BalloonTipIcon = ToolTipIcon.Error;
                    this.MyIcon.BalloonTipText = "Error!";
                    break;
            }

            this.MyIcon.ShowBalloonTip(1000);
        }
    }
}
