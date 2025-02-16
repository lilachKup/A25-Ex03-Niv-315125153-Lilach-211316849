using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class ZoomInEffect : IPhotoEffectStrategy
    {
        private const int k_Interval = 20;
        private const int k_XLocation = 6;
        private const int k_YLocation = 8;
        private const int k_TargetWidth = 148;
        private const int k_TargetHeight = 122;
        private const float k_Scale = 0.5f;
        private const float k_ScaleIncrement = 0.05f;

        private Timer m_Timer;

        public void ApplyEffect(PictureBox i_PictureBox)
        {
            StopEffect();

            m_Timer = new Timer { Interval = k_Interval };
            float scale = k_Scale;
            int targetWidth = k_TargetWidth;
            int targetHeight = k_TargetHeight;
            int targetX = k_XLocation;
            int targetY = k_YLocation;

            i_PictureBox.Size = new Size((int)(targetWidth * scale), (int)(targetHeight * scale));
            i_PictureBox.Location = new Point(targetX + (targetWidth - i_PictureBox.Width) / 2, targetY + (targetHeight - i_PictureBox.Height) / 2);
            m_Timer.Tick += (sender, e) => updateSize(i_PictureBox, ref scale);
            m_Timer.Start();
        }

        private void updateSize(PictureBox i_PictureBox, ref float io_Scale)
        {
            if (i_PictureBox.Width >= k_TargetWidth || i_PictureBox.Height >= k_TargetHeight)
            {
                i_PictureBox.Size = new Size(k_TargetWidth, k_TargetHeight);
                i_PictureBox.Location = new Point(k_XLocation, k_YLocation);
                StopEffect();
            }
            else
            {
                io_Scale += k_ScaleIncrement;
                i_PictureBox.Size = new Size((int)(k_TargetWidth * io_Scale), (int)(k_TargetHeight * io_Scale));
                i_PictureBox.Location = new Point(k_XLocation + (k_TargetWidth - i_PictureBox.Width) / 2, k_YLocation + (k_TargetHeight - i_PictureBox.Height) / 2);
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



