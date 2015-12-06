<%@ Page Title="Kontrola dodržení lhůt tiketů" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Kontrola.aspx.cs" Inherits="Contact" %>

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
                    <center><asp:Button ID="priradBtn" runat="server" Text="Přiřadit" OnClick="priradBtn_Click" /></center>
                </div>
       </div> 
    
    </div>
    <br><br><br><br><br><br><br><br><br><br><br>
    <br><br><br><br><br><br><br><br><br><br><br><br>

</asp:Content>
