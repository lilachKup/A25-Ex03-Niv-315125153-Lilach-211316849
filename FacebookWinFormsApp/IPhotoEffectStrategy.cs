using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public interface IPhotoEffectStrategy
    {
        void ApplyEffect(PictureBox pictureBox);
        void StopEffect();
    }
}
