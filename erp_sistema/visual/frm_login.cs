using erp_sistema.visual;
using erp_sistema.modelo;
using erp_sistema.DAL;

namespace erp_sistema
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            controle new_controle = new controle();

            new_controle.acessar(tb_login.Text, tb_senha.Text);

            if (new_controle.tem)
            {
                frm_inicio inicio = new frm_inicio();
                inicio.Show();

            }
            else
            {
                MessageBox.Show("login n�o encontrado", "erro!", MessageBoxButtons.OK);
            }



        }
    }


}