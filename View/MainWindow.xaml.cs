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
using Model;
using Model.Database;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;

            InitData();
        }

        private void InitData() {

            viewModel = new ViewModel();

            Connection connection = null;
            if (!HelperDatabase.ConnectionToDataBase(ref connection))
            {
                MessageBox.Show("I can't connect to database");
            }


        }

        
    }
}
