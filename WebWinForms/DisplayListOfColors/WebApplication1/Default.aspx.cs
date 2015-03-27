using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
            public int BrojBoja { 
                
                get{
                    if(Session["BrojBoja"] == null){
                        Session["BrojBoja"] = 0;
                }

                return (int)(Session["BrojBoja"]);
                }
                set{
                    Session["BrojBoja"] = value;
                }
           }

        protected void Page_Load(object sender, EventArgs e)
        {
            GenerirajKontroleZaUnosBoja();
        }

        protected void btnPrikaziPoljaZaUnosBoja_Click(object sender, EventArgs e)
        {
            ph.Controls.Clear();
            BrojBoja = int.Parse(txtBrojBoja.Text);
            GenerirajKontroleZaUnosBoja();
        }

        private void GenerirajKontroleZaUnosBoja()
        {
            if (BrojBoja > 0)
            {
                for (int i = 0; i < BrojBoja; i++)
                {
                    GenerirajPoljeZaUnosBoja(i);
                }
                PrikaziGumbZaIspisBoja();
            }
        }

        private void GenerirajPoljeZaUnosBoja(int i)
        {
            Label lbl = new Label();
            lbl.ID = "lblBoja" + (i + 1);
            lbl.Text = "Boja" + (i + 1) + ": ";

            ph.Controls.Add(lbl);

            TextBox txt = new TextBox();
            txt.ID = "txtBoja" + (i + 1);

            ph.Controls.Add(txt);

            ph.Controls.Add(new LiteralControl("<br/>"));
        }

        private void PrikaziGumbZaIspisBoja()
        {
            Button btn = new Button();
            btn.ID = "btnPrikaziUneseneBoje";
            btn.Text = "Prikaži unesene boje";

            btn.Click += btn_Click;
            ph.Controls.Add(btn);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in ph.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = ctrl as TextBox;
                    blUneseneBoje.Items.Add(txt.Text);
                }
            }
        }
    }
}
