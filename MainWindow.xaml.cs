using pr33savichev.Models;
using System.Windows;
using System.Windows.Controls;

namespace pr33savichev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public Users LoginUser = null;

        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            OpenPages(new Pages.Login());
        }

        public void OpenPages(Page pages) =>
            frame.Navigate(pages);
    }
}