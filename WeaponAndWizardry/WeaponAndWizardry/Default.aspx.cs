using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeaponAndWizardry.App_Code;

namespace WeaponAndWizardry
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && WeaponAndWizardry.App_Code.SessionHandler.ScriptEngine == null)
            {
                SessionHandler.ScriptEngine = new ScriptEngine(ImageDisplay, TextDisplay, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });                
                SessionHandler.ScriptEngine.ExecuteLine(0);
                Utility.SaveGuiState(ImageDisplay, TextDisplay.Text);
            }
            else
            {
                Utility.RestoreGuiState(ImageDisplay, TextDisplay);
                SessionHandler.ScriptEngine.UpdateReferences(ImageDisplay, TextDisplay, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
            }
        }

        protected void ButtonChoice1_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(1);
            Utility.SaveGuiState(ImageDisplay, TextDisplay.Text);
        }

        protected void ButtonChoice2_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(2);
            Utility.SaveGuiState(ImageDisplay, TextDisplay.Text);
        }

        protected void ButtonChoice3_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(3);
            Utility.SaveGuiState(ImageDisplay, TextDisplay.Text);
        }

        protected void ButtonChoice4_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(4);
            Utility.SaveGuiState(ImageDisplay, TextDisplay.Text);
        }
    }
}