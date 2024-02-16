using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se le figure in figure list == 0 allora:
            if (Figure.FigureList.Count == 0) // nb: inizialmente utilizziato !IsPostBack ma stampava ad ogni a
            {
                // Crea le figure (oggetti) se la lista == 0
                Figure.CreateFigures();
            }
                // Popola la lista
                FigureRepeater.DataSource = Figure.FigureList;
                FigureRepeater.DataBind();
            }

        // Definizione dei prodotti con:
        //    1. Classe
        //    2. Lista
        //    3. Costruttore
        // 1: Classe -> che contiene TUTTO 
        public class Figure
        {
            public string Name { get; set; }
            public string About { get; set; }
            public double Price { get; set; }
            public bool Exclusive { get; set; }
            public string ImgPart { get; set; }
            public string ImgFull { get; set; }

            // 2. Prima istanza della lista STATIC, basata sulla class figure
            public static List<Figure> FigureList { get; set; } = new List<Figure>();

            //3. Costruttore della classe Figure
            public Figure(string name, string about, double price, bool excl, string imgpart, string imgfull)
            {
                Name = name;
                About = about;
                Price = price;
                Exclusive = excl;
                ImgPart = imgpart;
                ImgFull = imgfull;
            }

            // METODO: crea prodotti(col costruttore) + Popola la lista
            public static void CreateFigures()
            {
                // creo col costruttore
                Figure NanaO = new Figure("Nana Osaki", "Debuted in July 2023 a detailed figure of one of the main character of the show Nana by author Ai Yazawa. 1/8 scale by brand HOBBY MAX JAPAN, shipping only to Japan, Taiwan and Hong Kong", 126.02, false, "https://img.amiami.com/images/product/review/223/FIGURE-142292_05.jpg", "https://img.amiami.com/images/product/main/223/FIGURE-142292.jpg");
                Figure NanaK = new Figure("Nana Komatsu", "Debuted in July 2023 a detailed figure of one of the main character of the show Nana by author Ai Yazawa. 1/8 scale by brand HOBBY MAX JAPAN, shipping only to Japan, Taiwan and Hong Kong", 112.78, false, "https://img.amiami.com/images/product/review/223/FIGURE-142291_05.jpg", "https://img.amiami.com/images/product/main/223/FIGURE-142291.jpg");

                //popolo la lista
                FigureList.Add(NanaO);
                FigureList.Add(NanaK);
            }

        }
        // fuori dalla classe
        // Gestione degli eventi del LinkButton che ha come evento OnClick il Redirect a dettagli
        protected void Detail_Click(object sender, EventArgs e)
        {
            // Otteniamo il nome del prodotto associato
            string productName = ((LinkButton)sender).CommandArgument;
            // Reindirizziamo alla pagina dei dettagli aggiungendo al link il nome del prodotto nella query string
            HttpContext.Current.Response.Redirect("Detail.aspx?Name=" + productName);
        }
    }

}