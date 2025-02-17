using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class SetupUI
    {
        internal static void ShowOrHideControls(bool i_MakeVisible, List <Control> i_FacebookControls)
        {
            foreach (Control control in i_FacebookControls)
            {            
                if(i_MakeVisible)
                {
                    control.Visible = true;
                }
                else
                {
                    control.Visible = false;
                }
            }
        }

        internal static void DisableAndEnableButtons(List<Button> i_ButtonsToDisable, Button i_ButtonToEnable)
        {
            if(i_ButtonsToDisable.Count == 0)
            {
                throw new ArgumentException("The list of buttons to disable is empty");
            }

            Color disableButtonColor = i_ButtonsToDisable[0].BackColor;
            Color enableButtonColor = i_ButtonToEnable.BackColor;
            i_ButtonToEnable.BackColor = disableButtonColor;
            i_ButtonToEnable.Enabled = true;

            foreach (Button button in i_ButtonsToDisable)
            {
                button.BackColor = enableButtonColor;
                button.Enabled = false;
            }
        }    
    }
}
