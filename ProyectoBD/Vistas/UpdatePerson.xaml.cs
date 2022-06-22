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
using System.Windows.Shapes;

namespace ProyectoBD.Vistas
{
    /// <summary>
    /// Lógica de interacción para UpdatePerson.xaml
    /// </summary>
    public partial class UpdatePerson : Window
    {
        Person person;
        public UpdatePerson(Person personSelected)
        {
            InitializeComponent();
            person = personSelected;
            showInfo();
        }

        private void showInfo()
        {
            // Personal information
            txt_type.Text = person.PersonType;
            txt_title.Text = person.Title;
            txt_name.Text = person.FirstName;
            txt_middleName.Text = person.MiddleName;
            txt_lastName.Text = person.LastName;
            txt_suffix.Text = person.Suffix;
            // Contact information
 
            // Credit card information
            
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
