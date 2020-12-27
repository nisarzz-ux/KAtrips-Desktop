using System.Windows;
using TestWPPL.Login;
using TestWPPL.Register;
using Velacro.DataStructures;
using Velacro.UIElements.Basic;
using KATripsDesktop.InputPesan;

namespace TestWPPL {
    public partial class MainWindow : MyWindow {
        private MyPage loginPage;
        private MyPage registerPage;
        private MyPage dashboardPage;
        private MyPage InputTiketPage;
        public MainWindow() {
            InitializeComponent();
            registerPage = new RegisterPage();
            loginPage = new LoginPage();
            dashboardPage = new Dashboard.Dashboard();
            InputTiketPage = new InputPesan();
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



    }
}
