using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TesteT2S
{
    public class BancoDAO
    {
        MySqlCommand comando;
        MySqlConnection conexao;
        MySqlDataReader lerDado;
        public BancoDAO() 
        {
            conexao = new MySqlConnection("Server=localhost;Database=bd_T2S;Uid=root;");
        }
        public String VerificarBanco(String sql)
        {
            try
            {
                comando = null;
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                return "<br /><div class='alert alert-success' role='alert'><b>Ação realizada com sucesso...</b></ div >";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }
        public DataTable ProcurarConteiner(String sql)
        {
            DataTable valores = new DataTable();
            valores.Columns.Add("ID", typeof(String));
            valores.Columns.Add("Cliente", typeof(String));
            valores.Columns.Add("Conteiner", typeof(String));
            valores.Columns.Add("Tipo", typeof(String));
            valores.Columns.Add("Status", typeof(String));
            valores.Columns.Add("Categoria", typeof(String));
            try
            {
                comando = null;
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                lerDado = comando.ExecuteReader();
                while (lerDado.Read())
                {
                    valores.Rows.Add(
                        lerDado["cd_Conteiner"].ToString(), 
                        lerDado["nm_Cliente_Conteiner"].ToString(), 
                        lerDado["nm_Numero_Conteiner"].ToString(), 
                        lerDado["nm_Tipo_Conteiner"].ToString(),
                        lerDado["nm_Status_Conteiner"].ToString() == "C"?"Cheio":"Vazio", 
                        lerDado["nm_Categoria_Conteiner"].ToString() == "I"?"Importação":"Exportação");
                }
                conexao.Close();
                return valores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conexao.Close(); }
        }
        public DataTable ProcurarMovimentacao(String sql)
        {
            DataTable valores = new DataTable();
            valores.Columns.Add("ID", typeof(String));
            valores.Columns.Add("Movimentação", typeof(String));
            valores.Columns.Add("Início", typeof(String));
            valores.Columns.Add("Fim", typeof(String));
            valores.Columns.Add("Conteiner", typeof(String));
            try
            {
                comando = null;
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                lerDado = comando.ExecuteReader();
                while (lerDado.Read())
                {
                    valores.Rows.Add(
                        lerDado["cd_Movimentacao"].ToString(), 
                        lerDado["nm_Tipo_Movimentacao"].ToString(), 
                        lerDado["nm_DHInicio_Movimentacao"].ToString(), 
                        lerDado["nm_DHFim_Movimentacao"].ToString(), 
                        lerDado["nm_Numero_Conteiner"].ToString());

                }
                return valores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                conexao.Close(); 
            }
        }
        public DataTable ListarRelatorio(String sql)
        {
            DataTable valores = new DataTable();
            try
            {
                comando = null;
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                lerDado = comando.ExecuteReader();
                valores.Columns.Add("ID", typeof(String));
                valores.Columns.Add("Cliente", typeof(String));
                valores.Columns.Add("Conteiner", typeof(String));
                valores.Columns.Add("Categoria", typeof(String));
                valores.Columns.Add("Tipo", typeof(String));
                while (lerDado.Read())
                {

                    valores.Rows.Add(
                        lerDado["cd_Movimentacao"].ToString(),
                        lerDado["nm_Tipo_Movimentacao"].ToString(),
                        lerDado["nm_Cliente_Conteiner"].ToString(), 
                        lerDado["nm_Numero_Conteiner"].ToString() == "C" ? "Cheio" : "Vazio",
                        lerDado["nm_Categoria_Conteiner"].ToString() == "I" ? "Importação" : "Exportação");
                }
                return valores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                conexao.Close(); 
            }

        }
    }
}