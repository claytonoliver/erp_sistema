using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_sistema.DAL
{
    class DAL_comandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        DAL_acesso con = new DAL_acesso();
        SqlDataReader dr;

        public bool verificarLogin(string login, string senha)
        {
            //comando sql validar o banco
            cmd.CommandText = "select * from Clientes where Nome = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o bano de dados";
            }

            return tem;
        }

        public bool trocaSenha(string login, string novasenha)
        {
            cmd.CommandText = "UPDATE  Clientes SET senha= @noavasenha WHERE Nome= @login";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@novasenha", novasenha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o bano de dados";
            }

            return tem;

        }
    }
}
