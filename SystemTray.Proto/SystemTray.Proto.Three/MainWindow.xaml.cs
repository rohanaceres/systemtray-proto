using System.Windows;
using System.Windows.Forms;

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
            this.MyIcon.Visible = true;
        }
    }
}
