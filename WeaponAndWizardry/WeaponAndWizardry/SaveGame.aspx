<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SaveGame.aspx.cs" Inherits="WeaponAndWizardry.SaveGame" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />

    <div style="background:url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0;height:100% 0; background-position: right center; min-height:650px;">
        <div>
            <div class ="row center">
                <img alt="logo" longdesc="MA's Weapons&amp;Wizardry" src="Content/Images/ui/logo_3.png" style="width: 100%;" />
            </div>
        </div>

        <table style="width: 100%">
            <tr><td><div class="row"></div></td></tr>
            <tr><td><div class="row"></div></td></tr>
            <tr><td align="center" colspan="2">
                <div class="row">
                <h4 style="color:#ffffff">
                    Please Type the save data code to load
                </h4>
                </div>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:TextBox ID="TextBox_SaveDataCode" runat="server" style="font-size:x-large"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td aligh="center">
                    <asp:Button ID="Button_Load_Back" CssClass="image_button_back" runat="server" style="margin-left: 30%; margin-top:10%; width: 230px;" Text="Back" PostBackUrl="~/MainMenu.aspx"/>
                </td>
                <td aligh="center">
                    <asp:Button ID="Button_Load_Game" CssClass="image_button_load" runat="server" style="margin-left: 30%; margin-top:10%; width: 230px" Text="Load Game"/>
                </td>
            </tr>
            <tr><td><div class="row"><br /><br /><br /><br /><br /><br /><br /></div></td></tr>
        </table>
    </div>
</asp:Content>
