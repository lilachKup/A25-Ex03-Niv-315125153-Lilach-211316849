using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BasicFacebookFeatures
{
   
    internal class SlideInEffect : IPhotoEffectStrategy
    {
        private const int k_Interval = 10;
        private const int k_TargetX = 6;
        private const int k_SlideStep = 10;

        private Timer m_Timer;

        public void ApplyEffect(PictureBox i_PictureBox)
        {
            StopEffect();
            m_Timer = new Timer { Interval = k_Interval };
            int startX = -i_PictureBox.Width;
            int targetX = k_TargetX;
            i_PictureBox.Left = startX;
            i_PictureBox.Location = new Point(startX, i_PictureBox.Location.Y);

            m_Timer.Tick += (sender, e) => updatePosition(i_PictureBox, targetX);
            m_Timer.Start();
        }

        private void updatePosition(PictureBox i_PictureBox, int i_TargetX)
        {
            if (i_PictureBox.Left < i_TargetX)
            {
                i_PictureBox.Left += k_SlideStep;
            }
            else
            {
                StopEffect();
            }
        }

        public void StopEffect()
        {
            if (m_Timer != null)
            {
                m_Timer.Stop();
                m_Timer.Dispose();
                m_Timer = null;
            }
        }
    }
}
