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

        public string Buscar(string Id)
        {
            Status = true;

            try
            {
                if (!(File.Exists(Diretorio + "\\" + Id + ".json")))
                {
                    Status = false;
                    Mensagem = "Identificador não existente: " + Id;
                }
                else
                {
                    string _conteudo = File.ReadAllText(Diretorio + "\\" + Id + ".json");
                    Status = true;
                    Mensagem = "Busca efetuada com sucesso. Identificador: " + Id;
                    return _conteudo;
                }
            }
            catch (Exception ex)
            {
                Status = false;     
                Mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;                
            }

            return "";
        }

        public List<string> BuscarTodos()
        {
            Status = true;

            List<string> List = new List<string>();
            try
            {
                var Arquivos = Directory.GetFiles(Diretorio, "*.json");
                for (int i = 0; i <= Arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);
                }
                return List;                               
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }

            return List;
        }

        public void Apagar(string Id)
        {
            Status = true;

            try
            {
                if (!(File.Exists(Diretorio + "\\" + Id + ".json")))
                {
                    Status = false;
                    Mensagem = "Identificador não existente: " + Id;
                }
                else
                {
                    File.Delete(Diretorio + "\\" + Id + ".json");
                    Status = true;
                    Mensagem = "Exclusão efetuada com sucesso. Identificador: " + Id;
                    
                }
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
        }
        public void Alterar(string Id, string jsonUnit)
        {
            Status = true;

            try
            {
                if (!(File.Exists(Diretorio + "\\" + Id + ".json")))
                {
                    Status = false;
                    Mensagem = "Alteração não permitida porque o identificador não existe: " + Id;
                }
                else
                {
                    File.Delete(Diretorio + "\\" + Id + ".json");
                    File.WriteAllText(Diretorio + "\\" + Id + ".json", jsonUnit);
                    Status = true;
                    Mensagem = "Alteração efetuada com sucesso. Identificador: " + Id;

                }
            }
            catch (Exception ex)
            {
                Status = false;
                Mensagem = "Conexão com o fichário com Erro. Identificador: " + ex.Message;
            }
        }


    }
}
