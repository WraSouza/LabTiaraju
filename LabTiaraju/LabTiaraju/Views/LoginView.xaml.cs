using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LabTiaraju.Model;

namespace LabTiaraju.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

            ConectaBanco();
        }

        private void ConectaBanco()
        {
            bool verificaConexao = ContextoDB.ConexaoBanco();
            if (verificaConexao)
            {
                Application.Current.MainPage.DisplayAlert("Sucesso", "Conexão Feita", "OK");
            }
        }
    }
}