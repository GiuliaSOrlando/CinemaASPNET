using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinemaASPNET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["AuthCookie"] != null)
                {
                    string username = Request.Cookies["AuthCookie"]["username"];
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e) {
            string usernameInserito = usernameInput.Text;
            string passwordInserito = passwordInput.Text;

            string usernameDaInserire = WebConfigurationManager.AppSettings["username"];
            string passwordDaInserire = WebConfigurationManager.AppSettings["password"];

            if (usernameInserito == usernameDaInserire && passwordInserito == passwordDaInserire)
            {
                Response.Redirect("AcquistoBiglietto.aspx");
            }
            else
            {
                string script = "alert('Credenziali non valide. Riprova.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

        protected void CreateCookie(string username) { 
        HttpCookie authCookie = new HttpCookie(username);
            authCookie.Values["username"] = username;
            authCookie.Expires = DateTime.Now.AddMinutes(15);
            Response.Cookies.Add(authCookie);
        }
    }
}