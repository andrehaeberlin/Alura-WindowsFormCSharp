﻿using System;
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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Item do menu 1","key");
                var vToolTip001_01 = DesenhaItemMenu("Item do menu 1", "key");
                var vToolTip002 = DesenhaItemMenu("Item do menu 2", "Frm_ValidaSenha");
                ContextMenu.Items.Add(vToolTip001);
                vToolTip001.DropDownItems.Add(vToolTip001_01);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip001_01.Click += new System.EventHandler(vToolTip001_01_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
            }
        }
        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Selecionei a opção do menu 001");
        }
        void vToolTip001_01_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Selecionei a opção do menu 001_01");
        }
        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Selecionei a opção do menu 002");
        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;
            return vToolTip;
        }
    }
}
