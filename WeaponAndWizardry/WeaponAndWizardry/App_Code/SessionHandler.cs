using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry.App_Code
{
    /// <summary>
    /// A wrapper to allow safe use of Session variables
    /// </summary>
    public static class SessionHandler
    {
        /// <summary>
        /// Strongly-typed Script Engine string index
        /// </summary>
        private const string _engine = "engine";

        /// <summary>
        /// Strongly-typed Image Display string index
        /// </summary>
        private const string _imageDisplay = "imagedisplay";

        /// <summary>
        /// Strongly-typed Text Display string index
        /// </summary>
        private const string _textDisplay = "textdisplay";

        /// <summary>
        /// Strongly-typed Choice Buttons string index
        /// </summary>
        private const string _choiceButtons = "choicebuttons";
        
        /// <summary>
        /// Returns the Session object of type Script Engine
        /// </summary>
        public static ScriptEngine ScriptEngine
        {
            get
            {
                if (HttpContext.Current.Session[_engine] == null)
                {
                    return null;
                }
                else
                {
                    return (ScriptEngine)HttpContext.Current.Session[_engine];
                }
            }
            set
            {
                HttpContext.Current.Session[_engine] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type Panel
        /// Which is the container for image display
        /// </summary>
        public static Panel ImageDisplay
        {
            get
            {
                if (HttpContext.Current.Session[_imageDisplay] == null)
                {
                    HttpContext.Current.Session[_imageDisplay] = new Panel();
                }
                return (Panel)HttpContext.Current.Session[_imageDisplay];
            }
            set
            {
                HttpContext.Current.Session[_imageDisplay] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type string
        /// Which is the text data for text display
        /// </summary>
        public static string TextDisplay
        {
            get
            {
                if (HttpContext.Current.Session[_textDisplay] == null)
                {
                    return null; //If we return empty string instead, the user may think an empty string was initially assigned
                }
                else
                {
                    return (string)HttpContext.Current.Session[_textDisplay];
                }
            }
            set
            {
                HttpContext.Current.Session[_textDisplay] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type string[]
        /// Which is the text data for each choice button
        /// </summary>
        public static string[] ChoiceButtons
        {
            get
            {
                if (HttpContext.Current.Session[_choiceButtons] == null)
                {
                    HttpContext.Current.Session[_choiceButtons] = new string[4];
                }
                return (string[])HttpContext.Current.Session[_choiceButtons];
            }
            set
            {
                HttpContext.Current.Session[_choiceButtons] = value;
            }
        }
    }
}