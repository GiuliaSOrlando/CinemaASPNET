using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinemaASPNET
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static List<Sala> listaSale;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaSale = new List<Sala>(){
                    new Sala() { NomeSala = "Sala Nord", BigliettiRidotti = 0, BigliettiVenduti = 0 },
                    new Sala() { NomeSala = "Sala Est", BigliettiRidotti = 0, BigliettiVenduti = 0 },
                    new Sala() { NomeSala = "Sala Sud", BigliettiRidotti = 0, BigliettiVenduti = 0 }
                };
                Session["SaleList"] = listaSale;
            } else
            {
                listaSale = (List<Sala>)Session["SaleList"];
            }
        }
        protected void AcquistoBigliettoButton_Click(object sender, EventArgs e)
        {
            string nomeUtente = nome.Text;
            string cognomeUtente = cognome.Text;
            string sala = ddlRoom.SelectedValue;
            string tipoBiglietto = rblTicketType.SelectedValue;

            int indiceSala = listaSale.IndexOf(new Sala() { NomeSala = sala });

            listaSale[indiceSala].BigliettiVenduti++;
            if (tipoBiglietto == "Ridotto")
            {
                listaSale[indiceSala].BigliettiRidotti++;
            }

            Session["SaleList"] = listaSale;

            string messaggio = $"Hai prenotato un biglietto per {nomeUtente} {cognomeUtente} nella sala {sala} con il tipo di biglietto {tipoBiglietto}.";
            Response.Write(messaggio);
            for (int i = 0; i < listaSale.Count; i++)
            {
                Response.Write($"Biglietti venduti in {listaSale[i].NomeSala}: {listaSale[i].BigliettiVenduti} ({listaSale[i].BigliettiRidotti} ridotti)");
            }
        }
    }
}