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

namespace _1_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mainLbl.Content.ToString().Length < 12)
                mainLbl.Content += ((Button)sender).Content.ToString();
        }
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            String editedStr = mainLbl.Content.ToString();
            if (editedStr.Length > 0) 
            {
                editedStr = editedStr.Remove(editedStr.Length - 1);
            }
            mainLbl.Content = editedStr;
        }
    }
}
