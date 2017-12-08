<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainScene.aspx.cs" Inherits="WeaponAndWizardry.MainScene" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />

    <div style="background: url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0; height: 100% 0; background-position: right center;">
        <div class="wrapper">
            <div class="row">
                <div class="col-md-8">
                    <asp:Panel ID="ImageDisplay" runat="server" Style="max-height: 500px; height: 500px; min-width: 800px">
                    </asp:Panel>
                </div>
                <div class="col-md-4" style="height: 500px; min-height: 500px; background-color: rgba(255, 255, 255, 0.9)">
                    <asp:Label ID="Label_Status" runat="server" Text="Status" Font-Size="Large" Style="font-weight: bold"></asp:Label>
                    <br />
                    <asp:Label ID="Label_HP" runat="server" Text="HP: " Font-Size="Medium"></asp:Label>
                    <br />
                    <asp:Label ID="Label_Str" runat="server" Text="Str: " Font-Size="Medium"></asp:Label>
                    <br />
                    <asp:Label ID="Label_Dex" runat="server" Text="Dex: " Font-Size="Medium"></asp:Label>
                    <br />
                    <asp:Label ID="Label_Int" runat="server" Text="Int: " Font-Size="Medium"></asp:Label>
                    <br />
                    <asp:Label ID="Label_Luck" runat="server" Text="Luk: " Font-Size="Medium"></asp:Label>
                    <br />
                    <asp:Label ID="Label_Alignment" runat="server" Text="Alignment: " Font-Size="Medium"></asp:Label>
                    <br />
                    <asp:Label ID="Label_Gold" runat="server" Text="Gold: " Font-Size="Medium"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button_Save" runat="server" Text="Save" Style="width: 100%;" OnClick="Button_Save_Click" />
                    <asp:Button ID="Button_Load" runat="server" Text="Load" Style="width: 100%;" OnClick="Button_Load_Click" />
                    <asp:Button ID="Button_Back" runat="server" Text="Quit" Style="width: 100%;" OnClick="Button_Quit_Click" />
                </div>
                <asp:TextBox ID="TextDisplay" runat="server" TextMode="MultiLine" Style="font-size: large; width: 97.5%; margin-left: 15px; min-height: 200px; min-width: 800px; color: white; background-color: rgba(128, 128, 128, 0.6);" ReadOnly="True"></asp:TextBox>
                <script type="text/javascript">
                    window.onload = function () {
                        var textarea = document.getElementById('<%=TextDisplay.ClientID %>');
                        textarea.scrollTop = textarea.scrollHeight - 1;
                    }
                </script>
                <div class="row" style="width: 94%; margin: auto;">
                    <div class="row">
                        <asp:Button ID="ButtonChoice1" CssClass="btn btn-primary" runat="server" Text="Choice1" OnClick="ButtonChoice_Clicked" Style="width: 100%" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice2" CssClass="btn btn-primary" runat="server" Text="Choice2" OnClick="ButtonChoice_Clicked" Style="width: 100%" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice3" CssClass="btn btn-primary" runat="server" Text="Choice3" OnClick="ButtonChoice_Clicked" Style="width: 100%" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice4" CssClass="btn btn-primary" runat="server" Text="Choice4" OnClick="ButtonChoice_Clicked" Style="width: 100%" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>