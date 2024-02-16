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
            // Verifica se la pagina è caricata per la prima volta
            if (!IsPostBack)
            {
                // Crea le figure (oggetti) e popola il repeater con le informazioni di ciascuna
                Figure.CreateFigures();
                FigureRepeater.DataSource = Figure.FigureList;
                FigureRepeater.DataBind();
            }
            else
            {  Response.Write("Non ci sono nuove figure.");}
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
                Figure NanaO = new Figure("Nana Osaki", "Debuted in July 2023 a detailed figure of the main character of the show <i>Nana</i> by author Ai Yazawa. 1/8 scale by brand HOBBY MAX JAPAN, shipping only to Japan, Taiwan and Hong Kong", 126.02, false, "https://img.amiami.com/images/product/review/223/FIGURE-142292_05.jpg", "https://img.amiami.com/images/product/main/223/FIGURE-142292.jpg");
                Figure NanaK = new Figure("Nana Komatsu", "Debuted in July 2023 a detailed figure of the main character of the show <i>Nana</i> by author Ai Yazawa. 1/8 scale by brand HOBBY MAX JAPAN, shipping only to Japan, Taiwan and Hong Kong", 112.78, false, "https://img.amiami.com/images/product/review/223/FIGURE-142291_05.jpg", "https://img.amiami.com/images/product/main/223/FIGURE-142291.jpg");

                //popolo la lista
                FigureList.Add(NanaO);
                FigureList.Add(NanaK);
            }

        }

        // Gestione degli eventi del bottone -> Redirect a dettagli
        }

}