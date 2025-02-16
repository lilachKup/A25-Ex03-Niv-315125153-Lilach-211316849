using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FadeInEffect : IPhotoEffectStrategy
    {
        private const int k_TimerInterval = 50;
        private const float k_InitialOpacity = 0f;
        private const float k_OpacityIncrement = 0.1f;
        private const float k_MaxOpacity = 1f;
        private const int k_SourceX = 0; 
        private const int k_SourceY = 0; 
        private const int k_DestX = 0;
        private const int k_DestY = 0;

        private Timer m_Timer;
        private float m_Opacity;
        private PictureBox m_TargetPictureBox;
        private Image m_OriginalImage;

        public void ApplyEffect(PictureBox pictureBox)
        {
            StopEffect();
            m_TargetPictureBox = pictureBox;
            m_OriginalImage = pictureBox.Image;
            m_Opacity = k_InitialOpacity;

            m_Timer = new Timer { Interval = k_TimerInterval };
            m_Timer.Tick += (sender, e) => updateOpacity();
            m_Timer.Start();
        }

        private void updateOpacity()
        {
            if (m_Opacity >= k_MaxOpacity)
            {
                StopEffect();
            }
            else
            {
                m_Opacity += k_OpacityIncrement;
                m_TargetPictureBox.Image = setImageOpacity(m_OriginalImage, m_Opacity);
            }
        }

        private Image setImageOpacity(Image i_Image, float i_Opacity)
        {
            Bitmap opacityAdjustedImage = null;

            if (i_Image != null)
            {
                opacityAdjustedImage = new Bitmap(i_Image.Width, i_Image.Height);

                using (Graphics g = Graphics.FromImage(opacityAdjustedImage))
                {
                    ColorMatrix matrix = new ColorMatrix();
                    matrix.Matrix33 = i_Opacity;
                    ImageAttributes attributes = new ImageAttributes();

                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(i_Image, new Rectangle(k_DestX, k_DestY, opacityAdjustedImage.Width, opacityAdjustedImage.Height),
                                k_SourceX, k_SourceY, i_Image.Width, i_Image.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            return opacityAdjustedImage;
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
