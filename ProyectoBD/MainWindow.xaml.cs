using ProyectoBD.Vistas;
using ProyectoBD.Model;
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

namespace ProyectoBD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person selectedPerson = new Person();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            showInfo();
            sp_info.Visibility = Visibility.Visible;
        }

        private void btn_insert_Click(object sender, RoutedEventArgs e)
        {
            InsertPerson insert = new InsertPerson();
            insert.Owner = this;
            insert.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            UpdatePerson update = new UpdatePerson(selectedPerson);
            update.Owner = this;
            update.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
        }

        private void showInfo()
        {
            // Personal information
            lbl_title.Content = selectedPerson.Title;
            lbl_firstName.Content = selectedPerson.FirstName;
            lbl_middleName.Content = selectedPerson.MiddleName;
            lbl_lastName.Content = selectedPerson.LastName;
            lbl_suffix.Content = selectedPerson.Suffix;
            // Contact information

            // Credit card information

        }
    }
}
