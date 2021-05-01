using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca
{
    public class Cls_Classe
    {
        public static bool validaSenhaLogin(string senha)
        {
            if (senha == "curso")
            {
                return true;
            }
            return false;
        }
    }
}
