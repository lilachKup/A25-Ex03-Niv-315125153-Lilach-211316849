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

        internal static void DisableAndEnableButtons(Button i_ButtonTodisable, Button i_ButtonToEnable)
        {
            Color tempButtonColor = i_ButtonTodisable.BackColor;
            i_ButtonTodisable.BackColor = i_ButtonToEnable.BackColor;
            i_ButtonToEnable.BackColor = tempButtonColor;
            i_ButtonToEnable.Enabled = true;
            i_ButtonTodisable.Enabled = false;
        }    
    }
}
