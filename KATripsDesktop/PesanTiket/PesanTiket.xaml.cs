using System;
using System.Windows.Controls;
using Velacro.DataStructures;
using Velacro.UIElements.Basic;
using Velacro.UIElements.Button;
using Velacro.UIElements.TextBlock;
using Velacro.UIElements.TextBox;
using TestWPPL.Login;
using TestWPPL.Dashboard;


namespace KATripsDesktop.PesanTiket
{
    /// <summary>
    /// Interaction logic for PesanTiket.xaml
    /// </summary>
    public partial class PesanTiket : MyPage
    {
        public PesanTiket()
        {
            InitializeComponent();
            this.KeepAlive = true;
            setController(new PesanTiketController(this));
            initUIBuilders();
            initUIElements();
        }

        private BuilderButton buttonBuilder;
        private BuilderTextBox txtBoxBuilder;
        private BuilderTextBlock txtBlockBuilder;

        private void initUIBuilders()
        {
            buttonBuilder = new BuilderButton();
            txtBoxBuilder = new BuilderTextBox();
            txtBlockBuilder = new BuilderTextBlock();
        }

        private IMyButton TambahButton;
        private IMyTextBox kelaskeretaDropDwn;
        private IMyTextBox waktuberangkatTxtBox;
        private IMyTextBox waktutibaTxtBox;
        private IMyTextBox stasiunawalDropDwn;
        private IMyTextBox stasiuntibaDropDwn;
        private IMyTextBox kodegerbangTxtBox;
        private IMyTextBox jumlahkursiTxtBox;
        private IMyTextBox hargatiketTxtBox;
        private IMyTextBlock tambahStatusTxtBlock;

        private void initUIElements()
        {
            TambahButton = buttonBuilder.activate(this, "btn_tambah")
                .addOnClick(this, "onTambahButtonClick");
            //kelaskeretaDropDwn = txtBoxBuilder.activate(this, "namakelaskereta");
            waktuberangkatTxtBox = txtBoxBuilder.activate(this, "waktuberangkat");
            waktutibaTxtBox = txtBoxBuilder.activate(this, "waktutiba");
            //stasiunawalDropDwn = txtBoxBuilder.activate(this, "stasiunawal");
            //stasiuntibaDropDwn = txtBoxBuilder.activate(this, "stasiuntiba");
            kodegerbangTxtBox = txtBoxBuilder.activate(this, "kodegerbang");
            jumlahkursiTxtBox = txtBoxBuilder.activate(this, "jumlahkursi");
            hargatiketTxtBox = txtBoxBuilder.activate(this, "hargatiket");
            tambahStatusTxtBlock = txtBlockBuilder.activate(this, "tambahStatus");
        }

        public void onTambahButtonClick()
        {
            getController().callMethod("pesantiket",
                waktuberangkatTxtBox.getText(),
                waktutibaTxtBox.getText(),
                kodegerbangTxtBox.getText(),
                jumlahkursiTxtBox.getText(),
                hargatiketTxtBox.getText());
        }

        public void setTambahStatus(string _status)
        {
            this.Dispatcher.Invoke(() => {
                TambahButton.setText(_status);
                this.NavigationService.Navigate(new Dashboard());
            });

        }

        private void btn_kembali_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void stasiunawal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void stasiuntiba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
