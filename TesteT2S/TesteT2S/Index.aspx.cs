using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TesteT2S
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCrudConteiner_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CrudConteiner.aspx");
        }

        protected void BtnCrudMovimentacao_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CrudMovimentacao.aspx");
        }

        protected void BtnRelatorio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Relatorio.aspx");
        }
    }
}