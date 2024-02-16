<%@ Page Title="Detail" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="ecommerce.Detail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">Dettagli prodotto:</h2>
        <!--ROW-->
        <div class="row justify-content-center">
            <!--CARD-->
            <div id="Details" runat="server" class="card text-white bg-dark border border-1 border-white mb-3 p-0 w-100">
                <div class="row g-0">
                    <div class="col-md-6 py-0">
                        <asp:Image ID="ImageDetail" runat="server" CssClass="card-img-top w-100" />
                        <asp:Image ID="ImageCart" runat="server" CssClass="card-img-top w-100" />
                    </div>
                    <!-- Colonna per il blocco con titolo, descrizione, prezzo e bottone -->
                    <div class="col-md-6">
                        <div class="card-body">
                            <h5 class="card-title"><asp:Label ID="LabelCardTitle" runat="server" /></h5>
                            <p class="card-text"><asp:Label ID="LabelCardDescription" runat="server" /></p>
                            <p class="card-text"><asp:Label ID="LabelCardPrezzo" runat="server" /></p>
                            <!-- Bottone per aggiungere al carrello -->
                            <asp:Button ID="AddToCart" runat="server" Text="Aggiungi e vai al carrello" CssClass="btn btn-dark" Style="background-color: #663d71;" OnClick="AddToCart_Click"/>
                        </div>
                    </div>
                </div>
            </div>
            <!--FINE CARD -->
        </div>
        <!-- FINE CARD-->
    </main>
</asp:Content>

