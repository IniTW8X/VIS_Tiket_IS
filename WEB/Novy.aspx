<%@ Page Title="Nový tiket" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Novy.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <br>
        <div style="width:500px">

            <div>
                <span>ID:</span><br>
                <asp:TextBox ID="idTxt" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <br />
            <div>
                <span>Kategorie:</span><br>
                <asp:DropDownList ID="kategorieCombo" runat="server">
                    <asp:ListItem>Software</asp:ListItem>
                    <asp:ListItem>Hardware</asp:ListItem>
                    <asp:ListItem>Ostatní</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <div>
                <span>Priorita:</span><br>
                <asp:DropDownList ID="prioritaCombo" runat="server" OnSelectedIndexChanged="prioritaCombo_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="1">1 - vysoká</asp:ListItem>
                    <asp:ListItem Value="2">2 - střední</asp:ListItem>
                    <asp:ListItem Value="3">3 - nízká</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <div>
                <span>Název:</span><br>
            <asp:TextBox ID="nazevTxt" runat="server" Width="800px"></asp:TextBox>
            </div>
            <br />
            <div>
                <span>Popis:</span><br>
                <asp:TextBox ID="popisTxt" runat="server" Height="150px" TextMode="MultiLine" Width="800px"></asp:TextBox>
            </div>
            <br />
            <div>
                <div style="float:left">
                    <span>Vytvořeno:</span>
                        <br><asp:TextBox ID="vytvorenoTxt" runat="server"></asp:TextBox>
                </div>

                <div style="float:right">
                    <span>Lhůta:</span>
                        <br><asp:TextBox ID="lhutaTxt" runat="server"></asp:TextBox>
                </div>
            </div> 
            <br><br><br><br>
            <center>
                <asp:Button ID="vytvorBtn" runat="server" Text="Vytvořit" OnClick="vytvorBtn_Click" />
            </center>
            <br>          
        </div>



</asp:Content>
