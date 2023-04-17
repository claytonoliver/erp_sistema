namespace erp_sistema.visual
{
    partial class frm_inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnl_panelinicio = new Panel();
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            operadoresToolStripMenuItem = new ToolStripMenuItem();
            novoOperadorToolStripMenuItem = new ToolStripMenuItem();
            trocarSenhaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(34, 340);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 179);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Produtos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 317);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 5;
            label3.Text = "Agenda";
            // 
            // pnl_panelinicio
            // 
            pnl_panelinicio.Location = new Point(205, 35);
            pnl_panelinicio.Name = "pnl_panelinicio";
            pnl_panelinicio.Size = new Size(583, 403);
            pnl_panelinicio.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { operadoresToolStripMenuItem, trocarSenhaToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(75, 24);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // operadoresToolStripMenuItem
            // 
            operadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoOperadorToolStripMenuItem });
            operadoresToolStripMenuItem.Name = "operadoresToolStripMenuItem";
            operadoresToolStripMenuItem.Size = new Size(224, 26);
            operadoresToolStripMenuItem.Text = "Operadores";
            // 
            // novoOperadorToolStripMenuItem
            // 
            novoOperadorToolStripMenuItem.Name = "novoOperadorToolStripMenuItem";
            novoOperadorToolStripMenuItem.Size = new Size(194, 26);
            novoOperadorToolStripMenuItem.Text = "Novo operador";
            // 
            // trocarSenhaToolStripMenuItem
            // 
            trocarSenhaToolStripMenuItem.Name = "trocarSenhaToolStripMenuItem";
            trocarSenhaToolStripMenuItem.Size = new Size(224, 26);
            trocarSenhaToolStripMenuItem.Text = "Trocar senha";
            trocarSenhaToolStripMenuItem.Click += trocarSenhaToolStripMenuItem_Click;
            // 
            // frm_inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_panelinicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_inicio";
            Text = "frm_inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnl_panelinicio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem operadoresToolStripMenuItem;
        private ToolStripMenuItem novoOperadorToolStripMenuItem;
        private ToolStripMenuItem trocarSenhaToolStripMenuItem;
    }
}