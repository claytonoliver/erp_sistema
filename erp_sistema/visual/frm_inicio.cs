using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp_sistema.visual
{
    public partial class frm_inicio : Form
    {
        calendario calendar = new calendario();
        trocaSenha altersenha = new trocaSenha();

        public frm_inicio()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            calendar.TopLevel = false;
            calendar.Dock = DockStyle.Fill;
            pnl_panelinicio.Controls.Add(calendar);
            calendar.Visible = true;
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altersenha.TopLevel = false;
            altersenha.Dock = DockStyle.Fill;
            pnl_panelinicio.Controls.Add(altersenha);
            altersenha.Visible = true;


        }
    }
}
