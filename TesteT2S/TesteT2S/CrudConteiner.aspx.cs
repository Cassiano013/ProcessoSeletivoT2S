using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TesteT2S
{
    public partial class CrudConteiner : System.Web.UI.Page
    {
        int retorno = 1;
        BancoDAO BD = new BancoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region Botõtes Crud Contêiner
        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Enabled = false;
            BtnConsultar.Enabled = true;
            BtnAtualizar.Enabled = true;
            BtnExcluir.Enabled = true;
            LblCliente.Visible = true;
            TxtCliente.Visible = true;
            LblTipo.Visible = true;
            RbtTipo20.Visible = true;
            RbtTipo40.Visible = true;
            LblStatus.Visible = true;
            DpdStatus.Visible = true;
            LblCategoria.Visible = true;
            DpdCategoria.Visible = true;
            GridConsultarConteiner.Visible = false;
            TxtCliente.Text = "";
            TxtNumeroConteiner.Text = "";
            LblAviso.Text = "";
            DpdCategoria.SelectedValue = "0";
            DpdStatus.SelectedValue = "0";
            BtnCadastrarConteiner.Text = "Cadastrar Contêiner";
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Enabled = true;
            BtnConsultar.Enabled = false;
            BtnAtualizar.Enabled = true;
            BtnExcluir.Enabled = true;
            LblCliente.Visible = false;
            TxtCliente.Visible = false;
            LblTipo.Visible = false;
            RbtTipo20.Visible = false;
            RbtTipo40.Visible = false;
            LblStatus.Visible = false;
            DpdStatus.Visible = false;
            LblCategoria.Visible = false;
            DpdCategoria.Visible = false;
            GridConsultarConteiner.Visible = true;
            TxtCliente.Text = "";
            TxtNumeroConteiner.Text = "";
            LblAviso.Text = "";
            BtnCadastrarConteiner.Text = "Consultar Contêiner";
        }

        protected void BtnAtualizar_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Enabled = true;
            BtnConsultar.Enabled = true;
            BtnAtualizar.Enabled = false;
            BtnExcluir.Enabled = true;
            LblCliente.Visible = true;
            TxtCliente.Visible = true;
            LblTipo.Visible = true;
            RbtTipo20.Visible = true;
            RbtTipo40.Visible = true;
            LblStatus.Visible = true;
            DpdStatus.Visible = true;
            LblCategoria.Visible = true;
            DpdCategoria.Visible = true;
            GridConsultarConteiner.Visible = false;
            TxtCliente.Text = "";
            TxtNumeroConteiner.Text = "";
            LblAviso.Text = "";
            DpdCategoria.SelectedValue = "0";
            DpdStatus.SelectedValue = "0";
            BtnCadastrarConteiner.Text = "Atualizar Contêiner";
        }

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {
            BtnCadastrar.Enabled = true;
            BtnConsultar.Enabled = true;
            BtnAtualizar.Enabled = true;
            BtnExcluir.Enabled = false;
            LblCliente.Visible = false;
            TxtCliente.Visible = false;
            LblTipo.Visible = false;
            RbtTipo20.Visible = false;
            RbtTipo40.Visible = false;
            LblStatus.Visible = false;
            DpdStatus.Visible = false;
            LblCategoria.Visible = false;
            DpdCategoria.Visible = false;
            GridConsultarConteiner.Visible = false;
            TxtCliente.Text = "";
            TxtNumeroConteiner.Text = "";
            LblAviso.Text = "";
            DpdCategoria.SelectedValue = "0";
            BtnCadastrarConteiner.Text = "Excluir Contêiner";
        }
        #endregion
        #region Botão Voltar para Index
        protected void BtnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }
        #endregion
        protected void BtnCadastrarConteiner_Click(object sender, EventArgs e)
        {
            char[] array = TxtNumeroConteiner.Text.ToCharArray();
            bool val = true;
            if (array.Length == 11)
            {
                for (int x = 0; x < array.Length; x++)
                {
                    if (x >= 0 && x <= 3)
                    {
                        if (!Char.IsLetter(array[x]))
                        {
                            val = false;
                            LblAviso.Text = "<div class='alert alert-danger'><b>Número do Contêiner está inválido...</b></div>";
                        }
                    }
                    else if (x >= 4 && x <= 10)
                    {
                        if (!Char.IsDigit(array[x]))
                        {
                            val = false;
                            LblAviso.Text = "<div class='alert alert-danger'><b>Número do Contêiner está inválido...</b></div>";
                        }
                    }
                }
            }
            else
            {
                val = false;
                LblAviso.Text = "<div class='alert alert-danger'><b>Número do Contêiner está inválido...</b></div>";
            }
            if (val)
            {
                if (!BtnCadastrar.Enabled)
                {
                    retorno = 1;
                }
                else if (!BtnConsultar.Enabled)
                {
                    retorno = 2;
                }
                else if (!BtnAtualizar.Enabled)
                {
                    retorno = 3;
                }
                else if (!BtnExcluir.Enabled)
                {
                    retorno = 4;
                }
                switch (retorno)
                {
                    case 1:
                        CadastrarConteiner();
                        break;
                    case 2:
                        ConsultarConteiner();
                        break;
                    case 3:
                        AtualizarConteiner();
                        break;
                    case 4:
                        ExcluirConteiner();
                        break;
                }
            }
        }
        public void CadastrarConteiner() 
        {
            string cliente = TxtCliente.Text;
            string controle = TxtNumeroConteiner.Text;
            string tipo = RbtTipo20.Checked ? "20" : "40";
            string status = DpdStatus.Text;
            string categoria = DpdCategoria.Text;
            if (status != "0" && categoria != "0")
            {
                try
                {
                    DataTable resultado = BD.ProcurarConteiner($"SELECT * FROM tb_Conteiner where nm_Numero_Conteiner = '{controle}'");
                    if (resultado.Rows.Count == 0)
                    {
                        LblAviso.Text = BD.VerificarBanco($"INSERT INTO tb_Conteiner(nm_Cliente_Conteiner, nm_Numero_Conteiner, nm_Tipo_Conteiner, nm_Status_Conteiner, nm_Categoria_Conteiner ) VALUES ('{cliente}', '{controle}', '{tipo}', '{status}', '{categoria}')");
                    }
                    else
                    {
                        LblAviso.Text = "<br /><div class='alert alert-danger' role='alert'><b>Erro, esses dados já se encontram cadastrados...</b></div>";
                    }
                }
                catch (Exception ex)
                {
                    LblAviso.Text = ex.Message;
                }
            }
            else 
            {
                LblAviso.Text = "<br /><div class='alert alert-danger' role='alert'> Selecione um valor... </ div >";
            }
        }
        public void ConsultarConteiner()
        {
            String controle = TxtNumeroConteiner.Text.Trim();
            try
            {
                DataTable resultado = BD.ProcurarConteiner($"SELECT * FROM tb_Conteiner where nm_Numero_Conteiner = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    GridConsultarConteiner.DataSource = resultado;
                    GridConsultarConteiner.DataBind();
                    LblAviso.Text = null;
                }
                else
                {
                    GridConsultarConteiner.DataSource = null;
                    GridConsultarConteiner.DataBind();
                    LblAviso.Text = "<br /><div class='alert alert-danger' role='alert'> Erro, conteiner não cadastrado... </ div >";
                }
            }
            catch (Exception ex)
            {
                LblAviso.Text = ex.Message;
            }
        }
        public void AtualizarConteiner()
        {
            String cliente = TxtCliente.Text;
            String controle = TxtNumeroConteiner.Text;
            String tipo = RbtTipo20.Checked ? "20" : "40";
            string status = DpdStatus.Text;
            string categoria = DpdCategoria.Text;
            try
            {
                var resultado = BD.ProcurarConteiner($"SELECT * FROM tb_Conteiner where nm_Numero_Conteiner = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    LblAviso.Text = BD.VerificarBanco($"UPDATE tb_Conteiner SET nm_Cliente_Conteiner = '{cliente}', nm_Tipo_Conteiner = '{tipo}', nm_Status_Conteiner = '{status}', nm_Categoria_Conteiner = '{categoria}' WHERE nm_Numero_Conteiner = '{controle}'");
                }
                else
                {

                    LblAviso.Text = "<br /><div class='alert alert-danger' role='alert'> Erro, conteiner não cadastrado... </ div >";
                }
            }
            catch (Exception ex)
            {
                LblAviso.Text = ex.Message;
            }
        }
        public void ExcluirConteiner()
        {
            String controle = TxtNumeroConteiner.Text.Trim();

            try
            {
                DataTable resultado = BD.ProcurarConteiner($"SELECT * FROM tb_Conteiner where nm_Numero_Conteiner = '{controle}'");
                if (resultado.Rows.Count > 0)
                {
                    LblAviso.Text = BD.VerificarBanco($"DELETE FROM tb_Conteiner WHERE nm_Numero_Conteiner = '{controle}'");
                }
                else
                {
                    LblAviso.Text = "<br /><div class='alert alert-danger' role='alert'> Erro, conteiner não cadastrado... </ div >";
                }
            }
            catch (Exception ex)
            {
                LblAviso.Text = ex.Message;
            }
        }
    }
}