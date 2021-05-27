using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LabTiaraju.Model
{    
    public class ContextoDB
    {               

        public static void ConexaoBanco()
        {
            string stringConexao = "Server=localhost;Database=labtiaraju;Uid=root;Pwd=root";
            MySqlConnection con = new MySqlConnection(stringConexao);

            try
            {                
                con.Open();
                
            }
            catch (MySqlException e)
            {                
                Console.Write(e.Message.ToString());
            }             

        }

        public static void FechaConexao()
        {
            string stringConexao = "Server=localhost;Database=labtiaraju;Uid=root;Pwd=root";
            MySqlConnection con = new MySqlConnection(stringConexao);

            try
            {
                con.Close();
            }catch(Exception)
            {
                throw;
            }
        }

        public static MySqlCommand CriaComando()
        {
            string stringConexao = "Server=localhost;Database=labtiaraju;Uid=root;Pwd=root";
            MySqlConnection con = new MySqlConnection(stringConexao);

           return con.CreateCommand();
        }
    }
}
