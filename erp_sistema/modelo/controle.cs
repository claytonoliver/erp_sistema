using erp_sistema.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_sistema.modelo
{
    public class controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(string login, string senha)
        {
            DAL_comandos logind = new DAL_comandos();
            tem = logind.verificarLogin(login, senha);
            if(logind.mensagem.Equals(""))
            {
                this.mensagem = logind.mensagem;
            }
            return tem;
        }

        public bool Tsenha(string login, string senha, string novasenha)
        {
            DAL_comandos alterSenha = new DAL_comandos();
            tem = alterSenha.trocaSenha(login, novasenha);

            return tem;
        }

    }
}
