<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ecommerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="container mt-5">
        <div class="row">
                <!--Col-->
                <!--Card-->
            <asp:Repeater ID="FigureRepeater" runat="server">
    <ItemTemplate>
            <div class="col mb-4">
                <div class="card text-white bg-dark mb-3 border border-1 border-white" style="width: 18rem;">
                    <img src='<%# Eval("ImgPart") %>' class="card-img-top w-100" alt="ProductImg">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Name") %></h5>
                        <p>Prezzo: <i><%#Eval("Price") %>&euro;</i></p>
                        <!-- Da aggiungere! OnClick REDIRECT a DETAIL-->
                        <asp:Button ID="ToDetail" runat="server" Text="Dettagli Prodotto" CssClass="btn btn-dark" Style="background-color: #663d71;" />

                    </div>
                </div>
                <!--Fine Card-->
            </div><!-- Fine Col-->
        </ItemTemplate>
         </asp:Repeater>
       </div>

        </div>
    </main>

</asp:Content>
