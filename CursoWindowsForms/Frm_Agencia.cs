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
    public partial class Frm_Agencia : Form
    {

        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelect { get; set; }

        public Frm_Agencia(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Cadastro de Agência";
            Tls_Principal.Items[0].ToolTipText = "Fechar a caixa de diâlogo";
            PreencherLista();
            Lst_Busca.Sorted = true;
        }

        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();
            for (int i = 0; i <= _ListaBusca.Count - 1; i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBusca[i][0];
                X.nome = _ListaBusca[i][1];
                Lst_Busca.Items.Add(X);
            }
        }

        class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }
    }
}
