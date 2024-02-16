using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce
{
    public partial class Cart : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Controlla se esiste un cookie con il nome "Carrello"
                if (Request.Cookies["MyCart"] != null)
                {
                    // Recupera i dati dal cookie
                    HttpCookie cartCookie = Request.Cookies["MyCart"];
                    string productName = cartCookie["ProductName"];
                    // string productDescription = cartCookie["ProductDescription"];
                    string productPrice = cartCookie["ProductPrice"];
                    string productImage = cartCookie["ProductImage"]; /// Quale sei?
                    
                    // Popola i dettagli del prodotto sulla pagina
                    LabelCardTitle.Text = productName;
                    // LabelCardDescription.Text = productDescription; Non mi passo la descrizione
                    LabelCardPrezzo.Text = productPrice;

                }
                else
                {
                    //Messaggio "Non c'è  niente nel carrello!"
                }
            }
        }
    }
}