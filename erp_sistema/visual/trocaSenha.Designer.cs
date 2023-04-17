namespace erp_sistema.visual
{
    partial class trocaSenha
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
            btn_salvar = new Button();
            txb_cnewsenha = new TextBox();
            txb_newsenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txb_login = new TextBox();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(317, 277);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(94, 29);
            btn_salvar.TabIndex = 0;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += button1_Click;
            // 
            // txb_cnewsenha
            // 
            txb_cnewsenha.Location = new Point(392, 212);
            txb_cnewsenha.Name = "txb_cnewsenha";
            txb_cnewsenha.Size = new Size(125, 27);
            txb_cnewsenha.TabIndex = 1;
            // 
            // txb_newsenha
            // 
            txb_newsenha.Location = new Point(392, 167);
            txb_newsenha.Name = "txb_newsenha";
            txb_newsenha.Size = new Size(125, 27);
            txb_newsenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 167);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 3;
            label1.Text = "Digite a nova senha";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 215);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 4;
            label2.Text = "Confirme a senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 124);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 6;
            label3.Text = "Digite seu login";
            // 
            // txb_login
            // 
            txb_login.Location = new Point(392, 124);
            txb_login.Name = "txb_login";
            txb_login.Size = new Size(125, 27);
            txb_login.TabIndex = 5;
            // 
            // trocaSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txb_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txb_newsenha);
            Controls.Add(txb_cnewsenha);
            Controls.Add(btn_salvar);
            Name = "trocaSenha";
            Text = "trocaSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private TextBox txb_cnewsenha;
        private TextBox txb_newsenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txb_login;
    }
}