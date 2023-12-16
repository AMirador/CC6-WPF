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

namespace Journi_IT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Journal entry properties
        public DateTime Date { get; set; }
        public string EntryText { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Date = DateTime.Today; // Set initial date
            DataContext = this; // Bind properties to UI
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
