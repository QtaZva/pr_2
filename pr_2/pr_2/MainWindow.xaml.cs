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

namespace pr_2
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

        private void addPersonbtn(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Введите корректное имя");

            }
            else if (surnameTextBox.Text == "")
            {
                MessageBox.Show("Введите корректную фамилию");

            }
            else 
            { 
            Person.Name = nameTextBox.Text.Trim();
            Person.Surname = surnameTextBox.Text.Trim();
            Person.Birthday = birthdayDatePicker.Text.Trim();
            Person.getInformation();
            }
        }
    }
}
