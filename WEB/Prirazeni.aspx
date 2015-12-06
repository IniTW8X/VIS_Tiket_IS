<%@ Page Title="Přiřazení tiketů skupině" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Prirazeni.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <br>
    <div style="width:500px">
        
    
        <asp:Button ID="zkontrolovatBtn" runat="server" Text="Zkontrolovat nyní" OnClick="zkontrolovatBtn_Click" />
        <br />
        <br />
        
        
        
        <div>
            <div style="float:left">
                        <asp:ListBox ID="listBox1" runat="server" Height="440px" Width="400px"></asp:ListBox>
                </div>
                <div style="float:right">
                    <span>Skupina:</span>
                        <br>
                    <asp:DropDownList ID="skupinaCombo" runat="server">
                    </asp:DropDownList>

                    <br><br>
                    <center><asp:Button ID="priradBtn" runat="server" Text="Přiřadit" OnClick="priradBtn_Click" /></center>
                </div>
       </div> 
    
    </div>
    <br><br><br><br><br><br><br><br><br><br><br>
    <br><br><br><br><br><br><br><br><br><br><br><br>


</asp:Content>
