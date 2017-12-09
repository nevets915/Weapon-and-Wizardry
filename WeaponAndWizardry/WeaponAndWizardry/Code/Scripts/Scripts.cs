using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Represents a script scenario that uses ScriptEngine API
    /// to dictate the game flow.
    /// Author:
    ///     Name: Jia Qi Lee (George) Date: 2017-11-15
    /// </summary>
    public partial class WebGameEngine
    {
        private static Choices nextChoice = new Choices("Next");

        #region Properties

        /// <summary>
        /// Gets or Sets the HP stat of the character
        /// </summary>
        public int HP
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("HP"))
                    {
                        return Int32.Parse(label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("HP"))
                    {
                        if (value > 100)
                        {
                            value = 100;
                        }
                        label.Text = "HP: " + value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Strength stat of the character
        /// </summary>
        public Strength Str
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Str"))
                    {
                        return (Strength)Enum.Parse(typeof(Strength), label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Str"))
                    {
                        if (value > Strength.Herculean)
                        {
                            value = Strength.Herculean;
                        }
                        if (value < Strength.Pitiful)
                        {
                            value = Strength.Pitiful;
                        }
                        label.Text = "Str: " + value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Dexterity stat of the character
        /// </summary>
        public Dexterity Dex
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Dex"))
                    {
                        return (Dexterity)Enum.Parse(typeof(Dexterity), label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Dex"))
                    {
                        if (value > Dexterity.Agile)
                        {
                            value = Dexterity.Agile;
                        }
                        if (value < Dexterity.Uncoordinated)
                        {
                            value = Dexterity.Uncoordinated;
                        }
                        label.Text = "Dex: " + value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Intelligence stat of the character
        /// </summary>
        public Intelligence Int
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Int"))
                    {
                        return (Intelligence)Enum.Parse(typeof(Intelligence), label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Int"))
                    {
                        if (value > Intelligence.Enlightened)
                        {
                            value = Intelligence.Enlightened;
                        }
                        if (value < Intelligence.Dumb)
                        {
                            value = Intelligence.Dumb;
                        }
                        label.Text = "Int: " + value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Luck stat of the character
        /// </summary>
        public Luck Luk
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Luk"))
                    {
                        return (Luck)Enum.Parse(typeof(Luck), label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Luk"))
                    {
                        if (value > Luck.Blessed)
                        {
                            value = Luck.Blessed;
                        }
                        if (value < Luck.Jinxed)
                        {
                            value = Luck.Jinxed;
                        }
                        label.Text = "Luk: " + value;
                    }
                }
            }
        }

        public Alignment Align
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Alignment"))
                    {
                        return (Alignment)Enum.Parse(typeof(Alignment), label.Text.Substring(10));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Alignment"))
                    {
                        if (value > Alignment.Adored)
                        {
                            value = Alignment.Adored;
                        }
                        if (value < Alignment.Wicked)
                        {
                            value = Alignment.Wicked;
                        }
                        label.Text = "Alignment: " + value;
                    }
                }
            }
        }

        public int Gold
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Gold"))
                    {
                        return Int32.Parse(label.Text.Substring(5));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Gold"))
                    {
                        label.Text = "Gold: " + value;
                    }
                }
            }
        }

        #endregion Properties

        private void LoadScripts()
        {
            LoadPrologueScripts();
            LoadChapterOneScripts();
            LoadEndingScripts();
        }
    }
}