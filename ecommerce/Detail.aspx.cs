using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ecommerce._Default;

namespace ecommerce
{
    public partial class Detail : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se la pagina è caricata per la prima volta = se aggiorno non aggiunge altre card
            if (!IsPostBack) // inutile perchè non ho nomi doppi o altro ma ok
            {
                // Crea l'oggetto FIGURE e popola la card di conseguenza (nel foreach)
                Figure.CreateFigures();
            }
            // Controlla se è presente un parametro "Name" nella query string
            if (!string.IsNullOrEmpty(Request.QueryString["Name"]))
            {
                string productName = Request.QueryString["Name"];
                // Ciclo della lista in Figure (in cui fig è l'oggetto singolo nb)
                foreach (Figure fig in Figure.FigureList)
                {
                    if (productName == fig.Name)
                    {
                        // Stampa i dettagli del singolo prodotto nella pagina
                        ImageDetail.ImageUrl = fig.ImgFull;
                        LabelCardTitle.Text = fig.Name;
                        LabelCardDescription.Text = fig.About;
                        LabelCardPrezzo.Text = fig.Price.ToString("c2");
                        ImageCart.ImageUrl = fig.ImgPart;
                        ImageCart.Visible = false; // nascondo l'immagine parziale, la porto solo per passarla al carrello

                        break; // Esce dal ciclo una volta trovato il prodotto corrispondente
                    }
                }
            }
        }

        // Bottone per aggiungere al carrello
        protected void AddToCart_Click(object sender, EventArgs e)
        {
            // Creazione del cookie:
            // 1. Recupero il nome della Figure dalla query (request)
            string productName = Request.QueryString["Name"];
            // 2. Ritrovo il nome ciclando la lista:
            Figure selectedF = null; // inizialmente null
                    // Cerca il prodotto corrispondente nella lista di Figure ciclando la lista
            foreach (Figure fig in Figure.FigureList)
            {
                if (fig.Name == productName)
                {
                    selectedF = fig;
                    break;
                }
            }
            if (selectedF != null) // SE selectedF NON è null allora:
            {
                // Creo cookie con le varie proprietà del selectedF
                HttpCookie cartCookie = new HttpCookie("MyCart");
                cartCookie.Values["ProductName"] = selectedF.Name;
                cartCookie.Values["ProductDescription"] = selectedF.About;
                cartCookie.Values["ProductPrice"] = selectedF.Price.ToString();
                cartCookie.Values["ProductImage"] = selectedF.ImgPart;

                // Impostazione della data di scadenza del cookie (opzionale)
                cartCookie.Expires = DateTime.Now.AddDays(3); // Il cookie scadrà tra un giorno

                // Aggiunta del cookie alla risposta
                Response.Cookies.Add(cartCookie);
            }
            // rimando alla pagina carrello
            Response.Redirect("Cart.aspx");
        }
    }
    
}
