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
using Decryptor_Library.Model;

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
