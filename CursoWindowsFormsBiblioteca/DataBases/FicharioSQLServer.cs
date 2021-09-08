﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioSQLServer
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public SQLServerClass db;

        public FicharioSQLServer(string Tabela)
        {
            status = true;
            try
            {
                db = new SQLServerClass();
                tabela = Tabela;
                mensagem = "Conexão com a Tabela criada com sucesso.";

            }
            catch (Exception ex)
            {

                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;

                throw new Exception(ex.Message);
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {

                // INSERT INTO CLIENTE (ID, JSON) VALUES ('000001', '{...}')

                var SQL = "INSERT INTO " + tabela + "(Id, JSON) VALUES('" + Id + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);
                mensagem = "Inclusão efetuada com sucesso.";

            }
            catch (Exception ex)
            {

                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;

                throw new Exception(ex.Message);
            }
        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {

                // SELECT ID, JSON FROM CLIENTE WHERE ID =  '000001'
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    mensagem = "Busca efetuada com sucesso. Identificador: " + Id;
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Id;
                    return string.Empty;
                }
            }

            catch (Exception ex)
            {

                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;

                throw new Exception(ex.Message);
            }
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();

            try
            {
                // SELECT ID, JSON FROM CLIENTE WHERE ID =  '000001'
                var SQL = "SELECT Id, JSON FROM " + tabela;
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        List.Add(conteudo);
                    }
                }
                else
                {
                    status = false;
                    mensagem = "Usuários não encontrados";
                    List = null;
                }

                return List;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;

                throw new Exception(ex.Message);
            }
        }

        public void Apagar(string Id)
        {
            status = true;
            try
            {

                // SELECT ID, JSON FROM CLIENTE WHERE ID =  '000001'
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //DELETE FROM CLIENTE WHERE ID =  '000001'
                    SQL = "DELETE FROM " + tabela + " WHERE ID = '" + Id + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Usuário apagado com sucesso. Identificador: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
            }

            catch (Exception ex)
            {

                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;

                throw new Exception(ex.Message);
            }
        }

        public void Alterar(string Id, string jsonUnit)
        {

            status = true;
            try
            {

                // SELECT ID, JSON FROM CLIENTE WHERE ID =  '000001'
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE ID = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //UPDATE CLIENTE SET JSON = '{...}' WHERE ID =  '000001'
                    SQL = "UPDATE " + tabela + " SET JSON = '" + jsonUnit + "' WHERE ID = '" + Id + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    mensagem = "Usuário alterado com sucesso. Identificador: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
            }

            catch (Exception ex)
            {

                status = false;
                mensagem = "Conexão com a Tabela com erro: " + ex.Message;

                throw new Exception(ex.Message);
            }

        }
    }
}
