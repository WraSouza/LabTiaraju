using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LabTiaraju.Model;
using MySql.Data.MySqlClient;

namespace LabTiaraju.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
           
        }        

        private void abrirPrincipalView(object sender, EventArgs e)
        {
            string nomeUsuario = entryUsuario.Text;
            
            string senhaUsuario = entrySenhaUsuario.Text;
            MySqlCommand comando = new MySqlCommand();
            comando = ContextoDB.CriaComando();

            if ((String.IsNullOrEmpty(nomeUsuario)) && (String.IsNullOrEmpty(senhaUsuario)))
            {
                DisplayAlert("Erro", "Informe Todos os Campos", "OK");

            }else if (String.IsNullOrEmpty(nomeUsuario))
            {
                DisplayAlert("Erro", "Informe Nome de Usuário", "OK");
            }
            else if(String.IsNullOrEmpty(senhaUsuario))
            {
                DisplayAlert("Erro", "Informe a Senha", "OK");
            }
            else
            {
                ContextoDB.ConexaoBanco();
                string verificaUsuario = ("select * from login");
                comando.ExecuteNonQuery();

                if(!(verificaUsuario == ""))
                {
                    DisplayAlert("Info", "Usuário Existe", "OK");
                }
                else
                {
                    DisplayAlert("Info", "Usuário Não Existe", "OK");
                }

                
            }
        }
    }
}