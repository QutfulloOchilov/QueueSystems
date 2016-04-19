using QueuSystems.ViewModel;
using SQLite.Net.Platform.Win32;
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

namespace Windows.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        ViewModel viewModel;
        String databasePath = "Database.db";
        public MainWindow()
        {
            SQLitePlatformWin32 litePlatform = new SQLitePlatformWin32();
            viewModel = new ViewModel(litePlatform, databasePath, File.Exists(databasePath));
            InitializeComponent();

        }

        private void UIElement_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
