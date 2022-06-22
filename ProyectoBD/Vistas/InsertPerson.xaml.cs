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
    /// Lógica de interacción para InsertPerson.xaml
    /// </summary>
    public partial class InsertPerson : Window
    {
        public InsertPerson()
        {
            InitializeComponent();
        }
        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txt_title_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_title.Text = "";
        }

        private void txt_name_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_name.Text = "";
        }

        private void txt_middleName_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_middleName.Text = "";
        }

        private void txt_lastName_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_lastName.Text = "";
        }

        private void txt_suffix_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_suffix.Text = "";
        }

        private void txt_type_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_type.Text = "";
        }

        private void txt_phoneNumer_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_phoneNumer.Text = "";
        }

        private void txt_email_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_email.Text = "";
        }

        private void txt_cardNumer_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_cardNumer.Text = "";
        }

        private void txt_cardType_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_cardType.Text = "";
        }

        private void txt_expMonth_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_expMonth.Text = "";
        }

        private void txt_expYear_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txt_expYear.Text = "";
        }
    }
}
