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
                    <div style="max-width: 100%; max-height: 10rem; overflow: hidden;">
    <img src='<%# Eval("ImgPart") %>' class="card-img-top w-100 img-cover" style="height: auto; width: 100%;" alt="ProductImg">
</div>
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Name") %></h5>
                        <p>Prezzo: <i><%#Eval("Price") %>&euro;</i></p>
                        <!-- Da aggiungere! OnClick REDIRECT a DETAIL-->
                        <asp:LinkButton ID="ToDetail" runat="server" Text="Dettagli Prodotto" CssClass="btn btn-dark" Style="background-color: #663d71;" OnClick="Detail_Click" CommandArgument='<%# Eval("Name") %>' />
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
