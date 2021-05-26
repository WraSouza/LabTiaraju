using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LabTiaraju.Model
{
    public class ContextoDB
    {

        public static bool ConexaoBanco()
        {
            bool resultadoConexao = false;
            var stringConexao = "Server=localhost;Database=labtiaraju;Uid=root;Pwd=root";
            //var stringConexao = "Server=localhost;Database=labtiaraju;Uid=root;Pwd=root;SslMode=Preferred";
            MySqlConnection con = new MySqlConnection(stringConexao);
            //string connection = "Server=localhost;Database=labtiaraju;Uid=root;Pwd= root";


            try
            {
                con.Open();
                resultadoConexao = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro = " + e.Message.ToString());
            }
            
            return resultadoConexao;

        }
    }
}
