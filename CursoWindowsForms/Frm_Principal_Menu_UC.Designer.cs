namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu_UC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu_UC));
            this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarTabPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Principal = new System.Windows.Forms.TabControl();
            this.Iml_Principal = new System.Windows.Forms.ImageList(this.components);
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.açõesToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(800, 24);
            this.Mnu_Principal.TabIndex = 7;
            this.Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.apagarTabPageToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.helloWordToolStripMenuItem,
            this.mascaraToolStripMenuItem,
            this.validaCPFToolStripMenuItem,
            this.validaCPF2ToolStripMenuItem,
            this.validaSenhaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_DemonstracaoKey;
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração &Key";
            this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
            // 
            // helloWordToolStripMenuItem
            // 
            this.helloWordToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_HelloWorld;
            this.helloWordToolStripMenuItem.Name = "helloWordToolStripMenuItem";
            this.helloWordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.helloWordToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.helloWordToolStripMenuItem.Text = "Hello &Word";
            this.helloWordToolStripMenuItem.Click += new System.EventHandler(this.helloWordToolStripMenuItem_Click);
            // 
            // mascaraToolStripMenuItem
            // 
            this.mascaraToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_Mascara;
            this.mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
            this.mascaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.mascaraToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mascaraToolStripMenuItem.Text = "&Mascara";
            this.mascaraToolStripMenuItem.Click += new System.EventHandler(this.mascaraToolStripMenuItem_Click);
            // 
            // validaCPFToolStripMenuItem
            // 
            this.validaCPFToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF;
            this.validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
            this.validaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.validaCPFToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.validaCPFToolStripMenuItem.Text = "Valida &CPF";
            this.validaCPFToolStripMenuItem.Click += new System.EventHandler(this.validaCPFToolStripMenuItem_Click);
            // 
            // validaCPF2ToolStripMenuItem
            // 
            this.validaCPF2ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF2;
            this.validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
            this.validaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.validaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.validaCPF2ToolStripMenuItem.Text = "Valida C&PF 2";
            this.validaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.validaCPF2ToolStripMenuItem_Click);
            // 
            // validaSenhaToolStripMenuItem
            // 
            this.validaSenhaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaSenha;
            this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            this.validaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.validaSenhaToolStripMenuItem.Text = "Valida &Senha";
            this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
            // 
            // apagarTabPageToolStripMenuItem
            // 
            this.apagarTabPageToolStripMenuItem.Name = "apagarTabPageToolStripMenuItem";
            this.apagarTabPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarTabPageToolStripMenuItem.Text = "Apagar TabPage";
            this.apagarTabPageToolStripMenuItem.Click += new System.EventHandler(this.apagarTabPageToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem});
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.açõesToolStripMenuItem.Text = "Ações";
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // Tbc_Principal
            // 
            this.Tbc_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Principal.ImageList = this.Iml_Principal;
            this.Tbc_Principal.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Principal.Name = "Tbc_Principal";
            this.Tbc_Principal.SelectedIndex = 0;
            this.Tbc_Principal.Size = new System.Drawing.Size(800, 426);
            this.Tbc_Principal.TabIndex = 8;
            // 
            // Iml_Principal
            // 
            this.Iml_Principal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iml_Principal.ImageStream")));
            this.Iml_Principal.TransparentColor = System.Drawing.Color.Transparent;
            this.Iml_Principal.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.Iml_Principal.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.Iml_Principal.Images.SetKeyName(2, "Frm_Mascara.png");
            this.Iml_Principal.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.Iml_Principal.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.Iml_Principal.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            this.Iml_Principal.Images.SetKeyName(6, "Folder_Icon.png");
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // Frm_Principal_Menu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Principal);
            this.Controls.Add(this.Mnu_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal_Menu_UC";
            this.Text = "Principal";
            this.Mnu_Principal.ResumeLayout(false);
            this.Mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Principal;
        private System.Windows.Forms.ImageList Iml_Principal;
        private System.Windows.Forms.ToolStripMenuItem apagarTabPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
    }
}