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
    public partial class Frm_MouseCursor : Form
    {
        public Frm_MouseCursor()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                System.Threading.Thread.Sleep(1000);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
