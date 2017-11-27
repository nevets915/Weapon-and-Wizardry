using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Module: MainMenu
/// Description: This page is for Loading the save data of the game
/// Author: 
///	 Name: Dongwon(Shawn) Kim   Date: 2017-11-27
/// Based on:
///    http://www.dotnetcurry.com/aspnet/89/aspnet-redirect-go-back-to-previous-page

/// </summary>
namespace WeaponAndWizardry
{
    public partial class LoadGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Load_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        protected void Button_Load_Game_Click(object sender, EventArgs e)
        {

        }
    }
}