<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainScene.aspx.cs" Inherits="WeaponAndWizardry.MainMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />

    
    <div style="background:url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0;height:100% 0; background-position: right center;">
        <div class="wrapper" style="display:table">
            <div style="background-color:floralwhite; min-height:50%; min-width:80%;">
                <div>
                    <asp:Panel ID="ImageDisplay" runat="server" min-height="600px" min-width="800px">
            
                    </asp:Panel>
                </div>
                
                <div class="button_warpper" style="position:absolute; z-index: 10">
                    <asp:Button ID="ButtonChoice1" runat="server" Text="Choice1" />
                    <asp:Button ID="ButtonChoice2" runat="server" Text="Choice2" />
                    <asp:Button ID="ButtonChoice3" runat="server" Text="Choice3" />
                    <asp:Button ID="ButtonChoice4" runat="server" Text="Choice4" />
            </div>  
                Picture
            </div>
            <div>
                <asp:TextBox ID="TextDisplay" runat="server" Height="100px" TextMode="MultiLine" Width="800px"></asp:TextBox>
            </div>


        </div>
    </div>
</asp:Content>
