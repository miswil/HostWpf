using Microsoft.Extensions.Logging;
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
using System.Windows.Shapes;

namespace WpfLibrary1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private ILogger<MainWindow> logger;

        public MainWindow(ILogger<MainWindow> logger)
        {
            this.logger = logger;
            InitializeComponent();
        }

        public string Message
        {
            get => this.message.Text;
            set => this.message.Text = value;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.logger.LogInformation("MainWindow was Closed. (Message: {0})", this.Message);
        }
    }
}
