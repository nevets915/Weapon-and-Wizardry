<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainScene.aspx.cs" Inherits="WeaponAndWizardry.MainScene" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />

    <div style="background: url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0; height: 100% 0; background-position: right center;">
        <div class="wrapper">
            <div class="row">
                <asp:Panel ID="ImageDisplay" runat="server" Style="min-height: 600px; min-width: 800px">
                </asp:Panel>

                <div class="button_warpper" style="position: absolute; z-index: 10; left: 50%; top: 30%;">
                    <div class="row">
                        <asp:Button ID="ButtonChoice1" runat="server" Text="Choice1" OnClick="ButtonChoice1_Click" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice2" runat="server" Text="Choice2" OnClick="ButtonChoice2_Click" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice3" runat="server" Text="Choice3" OnClick="ButtonChoice3_Click" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice4" runat="server" Text="Choice4" OnClick="ButtonChoice4_Click" />
                    </div>
                </div>
            </div>
            <div class="row">
                <asp:TextBox ID="TextDisplay" runat="server" BackColor="Transparent" TextMode="MultiLine">
                    TESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTEST
                    TESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTEST
                    TESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTESTTEST
                </asp:TextBox>
                <script type="text/javascript">
                    window.onload = function () {
                        var textarea = document.getElementById('<%=TextDisplay.ClientID %>');
                        textarea.scrollTop = textarea.scrollHeight - 1;
                    }
                </script>
            </div>
        </div>
    </div>
</asp:Content>