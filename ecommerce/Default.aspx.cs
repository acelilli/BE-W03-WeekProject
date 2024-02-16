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
                // Template Figure Nome = new Figure("Nome Personaggio", "Descrizione", 1, false, "Link img parziale", "link imng full");
                Figure NanaO = new Figure("Nana Osaki", "Debuted in July 2023 a detailed figure of one of the main character of the show Nana by author Ai Yazawa. 1/8 scale by brand HOBBY MAX JAPAN, shipping only to Japan, Taiwan and Hong Kong", 126.02, false, "https://img.amiami.com/images/product/review/223/FIGURE-142292_05.jpg", "https://img.amiami.com/images/product/main/223/FIGURE-142292.jpg");
                Figure NanaK = new Figure("Nana Komatsu", "Debuted in July 2023 a detailed figure of one of the main character of the show Nana by author Ai Yazawa. 1/8 scale by brand HOBBY MAX JAPAN, shipping only to Japan, Taiwan and Hong Kong", 112.78, false, "https://img.amiami.com/images/product/review/223/FIGURE-142291_05.jpg", "https://img.amiami.com/images/product/main/223/FIGURE-142291.jpg");
                Figure MickeyTo = new Figure("Manjiro Sano", "Debuted in April 2024 a detailed figure of one of the main character of the show Tokyo Revenger by author Wakui Ken. 1/7 scale by brand Good Smile COmpany and Orange Rouge", 138.57, false, "https://img.amiami.com/images/product/review/232/FIGURE-155130_11.jpg", "https://img.amiami.com/images/product/main/232/FIGURE-155130.jpg");
                Figure LuffyExc = new Figure("Luffy Exclusive", "Debuted in March 2024 a detailed figure of many phases of the life of globally famous One Piece's protagonist Luffy.By brand Mega House", 57.84, true, "https://img.amiami.com/images/product/review/234/FIGURE-161366_20.jpg", "https://img.amiami.com/images/product/main/234/FIGURE-161366.jpg");
                Figure GokuExc = new Figure("Son Goku Exclusive", "Debuted in September 2023 a detailed figure of many phases of the life of globally famous Dragon Ball's protagonist Goku. By brand Mega House", 51.04, true, "https://img.amiami.com/images/product/review/232/FIGURE-154202_11.jpg", "https://img.amiami.com/images/product/main/232/FIGURE-154202.jpg");
                Figure GojoS = new Figure("Satoru Gojo", "Debuted in April 2024 a detailed figure of one of the main character of the show Jujutsu Kaisen by author Akutami Gege. 1/7 scale by brand Desing COCO", 326.64, false, "https://img.amiami.com/images/product/review/234/FIGURE-163846_06.jpg", "https://img.amiami.com/images/product/main/234/FIGURE-163846.jpg");
                Figure ShikiI = new Figure("Shiki Ichinose", "Debuted in May 2018 a detailed figure of idol Shiki Ichinose from the game Idolmaster Cinderella Girls. 1/7 scale by brand Alter", 142.16, false, "https://img.amiami.com/images/product/review/173/FIGURE-033096_08.jpg", "https://img.amiami.com/images/product/main/173/FIGURE-033096.jpg");
                Figure FredeM = new Figure("Frederica Miyamoto", "Debuted in May 2018 a detailed figure of idol Frederica Miyamoto from the game Idolmaster Cinderella Girls. 1/7 scale by brand Alter", 96.51, false, "https://img.amiami.com/images/product/review/221/FIGURE-136640_05.jpg", "https://img.amiami.com/images/product/main/221/FIGURE-136640.jpg");

                //popolo la lista
                FigureList.Add(NanaO);
                FigureList.Add(NanaK);
                FigureList.Add(MickeyTo);
                FigureList.Add(LuffyExc);
                FigureList.Add(GokuExc);
                FigureList.Add(GojoS);
                FigureList.Add(ShikiI);
                FigureList.Add(FredeM);
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