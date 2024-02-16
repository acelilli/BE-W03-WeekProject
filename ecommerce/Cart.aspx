<%@ Page Title="Cart" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ecommerce.Cart" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">Il tuo carrello:</h2>
<!--ROW-->
<div class="row">
       <!--Col-->
    <!--Card-->
<div class="col mb-4">
    <div class="card text-white bg-dark mb-3" style="width: 18rem;">
        <img src="..." class="card-img-top" alt="ProductImg">
        <div class="card-body">
            <h5 class="card-title">NomeProdotto</h5>
            <!-- Da aggiungere! OnClick RemoveFromCart_Click-->
            <asp:Button ID="RemoveFromCart" runat="server" Text="Rimuovi dal carrello" CssClass="btn btn-dark" Style="background-color: #663d71;" />

        </div>
    </div>
    <!--Fine Card-->
</div><!-- Fine Col-->
    </div>
    </main>
</asp:Content>
