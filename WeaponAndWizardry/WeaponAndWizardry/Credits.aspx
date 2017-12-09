<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Credits.aspx.cs" Inherits="WeaponAndWizardry.Credits" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--
        Module: Credits.aspx
        Description: Credits View of game
        Author:
            Name: Dongwon(Shawn) Kim  Change: Updated layout     Date: 2017-12-07
        Based On:
            N/A
    -->
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />
    <style>
        .profile {
            background-color: rgba(240, 240, 240, 0.7);
            color: black;
            width: 70%;
            margin: auto;
        }

        .thumbnail {
            float: left;
            width: 10%;
        }
        .profile h3{
            margin-bottom: 4px;
        }
        .profile img{
            margin-right: 10px;
        }
        .profile span{
            font-size: large;
        }

    </style>

    <div style="background: url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0; height: 100% 0; background-position: right center; min-height: 550px;">
        <div>
            <div class="row center">
                <img alt="logo" src="Content/Images/ui/logo_3.png" style="width: 100%;" />
            </div>
        </div>
        
        <table style="width: 100%">
            <tr>
                <td align="center">
                    <h2 style="color: #ffffff; margin:0">Team Ma's Github: <a target="_blank" href="https://github.com/Mas-Studio">Visit our Github!!</a>  </h2>
                </td>
            </tr>

            <tr>
                <td>
                    <div class="profile">
                        <img src="Content/images/credits/george.png" alt="george" class="thumbnail" />
                        <h3>George Lee</h3>
                        <span>Team Lead, Game Engine, Backend</span><br />
                        <span>Github: <a target="_blank" href="https://github.com/NamBlue">https://github.com/NamBlue</a></span>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="profile">
                        <img src="Content/images/credits/steven.jpg" alt="steven" class="thumbnail" />
                        <h3>Steven Ma</h3>
                        <span>Game Design, Script, Concept & Resource</span><br />
                        <span>Github: <a target="_blank" href="https://github.com/nevets915">https://github.com/nevets915</a></span>
                        <span></span>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="profile">
                        <img src="Content/images/credits/shawn.jpg" alt="shawn" class="thumbnail" />
                        <h3>Shawn Kim</h3>
                        <span>Frontend, Resource Reproduce, Database</span><br />
                        <span>Github: <a target="_blank" href="https://github.com/kdw313">https://github.com/kdw313</a></span>
                        <span></span>
                    </div>
                </td>
            </tr>
            
            <tr>
                <td style="width: 100%" align="center">
                    <br /><br />    
                    <asp:Button ID="Button_Load_Back" CssClass="image_button_back" runat="server" Style="width: 230px;" Text="Back" PostBackUrl="~/MainMenu.aspx" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>