using HashPasswords;
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

namespace wpf3rab.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autho.xaml
    /// </summary>
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client(null));
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            int unsuccesfull = 0;
            string login = txtbLogin.Text.Trim();
            string password = pswbPassword.Password.Trim();
            string hashPassword = HashPassvords.HashPassword(password);
            Models.Entities db = Helper.getContext();
            if (login.Length > 0 && password.Length > 0)
            {
               if(unsuccesfull < 1)
                {
                    var user = Helper.getContext().Autorizacia.Where(u => u.Login == login && u.Parol == hashPassword).FirstOrDefault();
                    if (user != null)
                    {
                        var dolj = Helper.getContext().Autorizacia.Where(u => u.Login == login && u.Parol == hashPassword).Select(u => u.ID_Sotrudnik).FirstOrDefault();
                        var str = Helper.getContext().Sotrudnik.Where(u => u.ID_Sotrudnik == dolj).Select(u => u.ID_Doljnost).FirstOrDefault();
                        MessageBox.Show(dolj.ToString(), str.ToString(), MessageBoxButton.OK);
                        switch (str)
                        {        case 1:
                                GridAuth.Visibility = Visibility.Hidden;
                                FrmAutho.Navigate(new Buhg());  
                                break;
                            case 2:
                                GridAuth.Visibility = Visibility.Hidden;
                                FrmAutho.Navigate(new Admin());
                                break;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином не найден", "Внимание!", MessageBoxButton.OK);
                        unsuccesfull++;
                        GetCapthca();
                       
                    }
                }
                else 
                {
                    string capthca = txtboxCaptcha.Text;
                    var user = Helper.getContext().Autorizacia.Where(u => u.Login == login && u.Parol == hashPassword).FirstOrDefault();
                    if (user != null)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином не найден", "Внимание!", MessageBoxButton.OK);
                        unsuccesfull++;
                        GetCapthca();
                    }
                }
            }

            else
            {
                MessageBox.Show("Не все обязательные поля заполнены!");
            }
        }
        private void GetCapthca()
        {
            txtBlockCaptcha.Visibility = Visibility.Visible;
            txtboxCaptcha.Visibility = Visibility.Visible;
            txtBlockCaptcha.TextDecorations = TextDecorations.Strikethrough;
            Random random = new Random();
            switch(random.Next(0,3))
            {
                case 1:
                    txtBlockCaptcha.Text = "uT5g";
                    break;
                case 2:
                    txtBlockCaptcha.Text = "gffe";
                    break;
                case 3:
                    txtBlockCaptcha.Text = "GfFe";
                    break;
            }
        }
        private void FrmAutho_ContentRendered(object sender, EventArgs e)
        {
        
        }
    }
}
