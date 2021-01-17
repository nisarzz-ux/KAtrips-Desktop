using System.Windows;
using TestWPPL.Login;
using TestWPPL.Register;
using Velacro.DataStructures;
using Velacro.UIElements.Basic;
using KATripsDesktop.InputPesan;
using KATripsDesktop.About;

namespace TestWPPL {
    public partial class MainWindow : MyWindow {
        private MyPage loginPage;
        private MyPage registerPage;
        private MyPage dashboardPage;
        private MyPage InputTiketPage;
        private MyPage AboutPage;
        public MainWindow() {
            InitializeComponent();
            registerPage = new RegisterPage();
            loginPage = new LoginPage();
            dashboardPage = new Dashboard.Dashboard();
            InputTiketPage = new InputPesan();
            AboutPage = new AboutUs();
        }

        private void dashboardButton_btn_Click(object sender, RoutedEventArgs e){
            mainFrame.Navigate(dashboardPage);
        }

        private void InputTiketButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(InputTiketPage);
        }

        private void loginButton_btn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(loginPage);
        }

        private void registerButton_btn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(registerPage);
        }

        private void logoutButton_btn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(loginPage);
        }

        private void aboutusButton_btn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(AboutPage);
        }


    }
}
