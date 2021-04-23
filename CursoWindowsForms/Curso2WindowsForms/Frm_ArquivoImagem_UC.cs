using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string fileName)
        {
            InitializeComponent();

            Lbl_ArquivoImagem.Text = fileName;

            Pic_Image.Load(fileName);
        }
    }
}
