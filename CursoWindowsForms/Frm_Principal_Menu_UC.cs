﻿using CursoWindowsForms.Curso1WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int controleDemonstracaoKey = 0;
        int controleHelloWorld = 0;
        int controleMascara = 0;
        int controleValidaCPF = 0;
        int controleValidaCPF2 = 0;
        int controleValidaSenha = 0;
        int controleArquivoImagem = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarTabPageToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleDemonstracaoKey += 1;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = $"Demonstração Key {controleDemonstracaoKey}";
            TB.Text = $"Demonstração Key {controleDemonstracaoKey}";
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Principal.TabPages.Add(TB);
            TB.Select();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleHelloWorld += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = $"Hello World {controleHelloWorld}";
            TB.Text = $"Hello World {controleHelloWorld}";
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Principal.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleMascara += 1;
            Frm_Mascara_UC U = new Frm_Mascara_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = $"Mascara {controleMascara}";
            TB.Text = $"Mascara {controleMascara}";
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Principal.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaCPF += 1;
            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = $"Valida CPF {controleValidaCPF}";
            TB.Text = $"Valida CPF {controleValidaCPF}";
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Principal.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaCPF2 += 1;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = $"Valida CPF 2.{controleValidaCPF2}";
            TB.Text = $"Valida CPF 2.{controleValidaCPF2}";
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Principal.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleValidaSenha += 1;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = $"Valida Senha {controleValidaSenha}";
            TB.Text = $"Valida Senha {controleValidaSenha}";
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Principal.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apagarTabPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tbc_Principal.SelectedTab != null)
            {
                Tbc_Principal.TabPages.Remove(Tbc_Principal.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\Users\\andre\\source\\repos\\Alura-WindowsFormCSharp\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeDoArquivoImagem = Db.FileName;

                controleArquivoImagem += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeDoArquivoImagem);
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = $"Arquivo Imagem.{controleArquivoImagem}";
                TB.Text = $"Arquivo Imagem.{controleArquivoImagem}";
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                Tbc_Principal.TabPages.Add(TB);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                string senha = F.senha;
                string login = F.login;

                if (CursoWindowsFormsBiblioteca.Cls_Classe.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarTabPageToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;
                    

                    MessageBox.Show("Bem vindo " + login + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bem inválida !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Db = new Frm_Questao("icons8_question_mark_961", "você deseja se desconectar ?");
            Db.ShowDialog();

            // if(MessageBox.Show("Você deseja realmente validar o CPF", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            if (Db.DialogResult == DialogResult.Yes)
            {
                for (int i = Tbc_Principal.TabPages.Count -1; i >= 0; i+= -1)
                {
                    Tbc_Principal.TabPages.Remove(Tbc_Principal.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarTabPageToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
            }

        }
    }
}
