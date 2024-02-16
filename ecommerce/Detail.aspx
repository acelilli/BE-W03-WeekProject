<%@ Page Title="Detail" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="ecommerce.Detail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">Dettagli prodotto:</h2>
        <!--ROW-->
        <div class="row">
            <!--CARD-->
            <div class="card text-white bg-dark mb-3" style="max-width: 540px;">
                <div class="row g-0">
                    <div class="col">
                        <img src="..." class="img-fluid rounded-start" alt="ProductImg">
                    </div>
                    <div class="col-md-8">
                        <div class="card-body">
                            <h5 class="card-title">Nome prodotto</h5>
                            <p class="card-text">Descrizione prodotto</p>
                            <!-- DA AGGIUNGERE: onClick="AddToCart_Click" -->
                            <asp:Button ID="Button1" runat="server" Text="Aggiungi al carrello" CssClass="btn btn-dark" Style="background-color: #663d71;" />
                        </div>
                    </div>
                </div>
            </div>
            <!--FINE CARD -->
        </div>
        
        <!-- FINE CARD-->
    </main>
</asp:Content>
