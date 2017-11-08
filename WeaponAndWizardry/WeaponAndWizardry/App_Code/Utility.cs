using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry.App_Code
{
    public static class Utility
    {
        /// <summary>
        /// Creates a deep copy of the Image object
        /// </summary>
        /// <param name="image">The image to copy</param>
        /// <returns>A copy of the image</returns>
        public static Image CopyImage(Image image)
        {
            Image copy = new Image();
            copy.Style["position"] = image.Style["position"].ToString();
            copy.Style["z-index"] = image.Style["z-index"].ToString();
            copy.Style["left"] = image.Style["left"].ToString();
            copy.Style["top"] = image.Style["top"].ToString();
            copy.Width = new Unit(image.Width.Value);
            copy.Height = new Unit(image.Height.Value);
            copy.ImageUrl = image.ImageUrl;
            return copy;
        }

        /// <summary>
        /// Saves the GUI State to Session Variables
        /// </summary>
        /// <param name="imageDisplay">The panel control state to save</param>
        public static void SaveGuiState(Panel imageDisplay, string textDisplay)
        {
            SessionHandler.ImageDisplay.Controls.Clear();
            foreach (Image image in imageDisplay.Controls)
            {
                SessionHandler.ImageDisplay.Controls.Add(Utility.CopyImage(image));
            }
            SessionHandler.TextDisplay = textDisplay;
        }

        /// <summary>
        /// Restores the Session state back to the ImageDisplay
        /// </summary>
        /// <param name="display">The panel control to retore to</param>
        public static void RestoreGuiState(Panel display, TextBox textDisplay)
        {
            display.Controls.Clear();
            foreach (Image image in SessionHandler.ImageDisplay.Controls)
            {
                display.Controls.Add(Utility.CopyImage(image));
            }
            textDisplay.Text = SessionHandler.TextDisplay;
        }
    }
}