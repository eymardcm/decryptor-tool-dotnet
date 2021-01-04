using Decryptor_Library.Model;
using System.Windows;

namespace Decryptor_WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Decipher_Button_Click(object sender, RoutedEventArgs e)
        {
            SecuredData.Clear();

            SecuredData.CipherText = text_securedData.Text;
            SecuredData.Base64EncodedAESWrappingKey = text_wrappingKey.Text;

            MessageBox.Show(SecuredData.Decrypt(), "Deciphered Value", MessageBoxButton.OK, MessageBoxImage.Information);

            SecuredData.Clear();
            text_securedData.Text = SecuredData.CipherText;
            text_wrappingKey.Text = SecuredData.Base64EncodedAESWrappingKey;
        }
    }
}
