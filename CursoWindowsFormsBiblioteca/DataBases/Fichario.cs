using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsBiblioteca.DataBases
{
    public class Fichario
    {
        public string Diretorio;
        public string Mensagem;
        public bool Status;

        public Fichario(string diretorio)
        {
            Status = true;
            try
            {
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }
                Diretorio = diretorio;
                Mensagem = "Conexão com o Fichario criada com sucesso.";
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = "Conexão com o Fichario com erro." + ex.Message;
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            Status = true;

            try
            {
                if (File.Exists(Diretorio + "\\" + Id + ".json"))
                {
                    Status = true;
                    Mensagem = "Inclusão não permitida porque o identificador já existe: " + Id;
                }
                else
                {
                    File.WriteAllText(Diretorio + "\\" + Id + ".json", jsonUnit);
                    Status = true;
                    Mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;
                }
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
        }
    }
}
