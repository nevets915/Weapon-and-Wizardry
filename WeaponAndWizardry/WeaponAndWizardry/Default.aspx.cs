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
        private ScriptEngine _engine;

        protected void Page_Load(object sender, EventArgs e)
        {
            _engine = new ScriptEngine(ImageDisplay, TextDisplay, new List<Button> {ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4});
            _engine.ExecuteLine(0);
        }

        protected void ButtonChoice1_Click(object sender, EventArgs e)
        {
            _engine.ExecuteLine(1);
        }

        protected void ButtonChoice2_Click(object sender, EventArgs e)
        {
            _engine.ExecuteLine(2);
        }

        protected void ButtonChoice3_Click(object sender, EventArgs e)
        {
            _engine.ExecuteLine(3);
        }

        protected void ButtonChoice4_Click(object sender, EventArgs e)
        {
            _engine.ExecuteLine(4);
        }
    }
}