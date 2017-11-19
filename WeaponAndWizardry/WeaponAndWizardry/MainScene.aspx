<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainScene.aspx.cs" Inherits="WeaponAndWizardry.MainMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />

    
    <div style="background:url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0;height:100% 0; background-position: right center;">
        <div class="wrapper">
            <div class="row">
                <asp:Panel ID="ImageDisplay" runat="server" style="min-height:600px; min-width:800px" >
            
                </asp:Panel>

                <div class="button_warpper" style="position:absolute; z-index: 10; left:50%; top:30%;">
                    <div class="row">
                        <asp:Button ID="ButtonChoice1" runat="server" Text="Choice1" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice2" runat="server" Text="Choice2" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice3" runat="server" Text="Choice3" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice4" runat="server" Text="Choice4" />
                    </div>
                </div>
            </div>
            <div class="row">
                <asp:TextBox ID="TextDisplay" runat="server" BackColor="Transparent" TextMode="MultiLine">
                    TESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTEST
                    TESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTEST
                    TESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTEST
                </asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>