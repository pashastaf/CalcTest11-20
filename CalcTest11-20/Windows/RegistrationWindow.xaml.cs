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

namespace CalcTest11_20.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePassword(pswd.Text) && ValidateLogin(log.Text))
            {
                CalcWindow calcWindow = new CalcWindow();
                this.Close();
                calcWindow.Show();
            }
        }

        public static bool ValidateLogin(string login)
        {
            if (!login.EndsWith(".calc"))
            {
                return false;
            }

            if (login.Replace(".calc", "").Length < 10 || login.Length > 35)
            {
                return false;
            }

            if (!login.Any(Char.IsLower))
            {
                return false;
            }

            if (!login.Any(Char.IsUpper))
            {
                return false;
            }

            if (!login.Any(Char.IsDigit))
            {
                return false;
            }

            if (login.Replace(".calc", "").Intersect("!@#$%^&*?()").Count() == 0)
            {
                return false;
            }

            return true;
        }
        public bool ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 32)
            {
                return false;
            }

            if (!password.Any(Char.IsLower))
            {
                return false;
            }

            if (!password.Any(Char.IsUpper))
            {
                return false;
            }

            if (!password.Any(Char.IsDigit))
            {
                return false;
            }

            if (password.Intersect("!@#$%^&*?").Count() == 0)
            {
                return false;
            }
            return true;
        }

       
    }
}
