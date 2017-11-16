<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainScene.aspx.cs" Inherits="WeaponAndWizardry.MainMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />

    
    <div style="background:url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0;height:100% 0; background-position: right center; min-height:650px">
        <div>
            <table style="width: 100%">
                <tr>
                    <td colspan="2">
                        <div class="row">
                            1
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="row">
                            2
                        </div>
                    </td>
                
                    <td rowspan="4">
                        <div class="row" >
                            r2
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="row">
                            3
                        </div>
                    </td>
                
                    <%--<td>
                        <div class="row">
                            r3
                        </div>
                    </td>--%>
                </tr>
                <tr>
                    <td>
                        <div class="row">
                            4
                        </div>
                    </td>
                    <%--<td>
                        <div class="row">
                            r4
                        </div>
                    </td>--%>
                </tr>
                 <tr>
                    <td>
                        <div class="row">
                            5
                        </div>
                    </td>
                    <%--<td>
                        <div class="row">
                            r5
                        </div>
                    </td>--%>
                </tr>
                 <tr>
                    <td>
                        <div class="row">
                            6
                        </div>
                    </td>
                    <td>
                        <div class="row">
                            <div style="float:left">Save</div>
                            &nbsp
                            <div style="float:left">Quit</div>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
