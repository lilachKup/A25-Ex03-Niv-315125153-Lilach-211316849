using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using static System.Net.Mime.MediaTypeNames;

namespace BasicFacebookFeatures
{
    public partial class ProfileAlbumForm : Form
    {
        List<string> m_ClickedImages;
        private Action<IPhotoEffectStrategy> m_OnEffectSelected;

        public ProfileAlbumForm(List<string> i_ImagesFromAlbum, List<string> i_ProfileAlbum, Action<IPhotoEffectStrategy> i_OnEffectSelected)
        {
            InitializeComponent();         
            m_ClickedImages = i_ProfileAlbum;
            m_OnEffectSelected = i_OnEffectSelected;
            showAlbum(i_ImagesFromAlbum);
        }

        private void showAlbum(List<string> i_ImagesFromAlbum)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach (string image in i_ImagesFromAlbum)
            {
                PictureBox picBox = new PictureBox
                {
                    ImageLocation = image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 150,
                    Height = 150,
                    Margin = new Padding(10),
                };

                picBox.Click += new EventHandler(picBox_Click);
                flowLayoutPanel1.Controls.Add(picBox);
            }           
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;

            if(checkIfPictureAlreadySelected(picBox))
            {
                MessageBox.Show("THE IMAGE ALREADY SELECTED");
            }
            else
            {
                MessageBox.Show("THE IMAGE SELECTED");
                m_ClickedImages.Add(picBox.ImageLocation);
            } 
        }       

        private bool checkIfPictureAlreadySelected(PictureBox i_PictureBoxSelected)
        {
            bool isAlreadySelected = false;

            if (m_ClickedImages != null)
            {
                for (int i = 0; i < m_ClickedImages.Count; i++)
                {
                    if (m_ClickedImages[i] == i_PictureBoxSelected.ImageLocation)
                    {
                        isAlreadySelected = true;
                        break;
                    }
                }                
            }

            return isAlreadySelected;
        }

        private void slideInEffectButton_Click(object sender, EventArgs e)
        {
            m_OnEffectSelected?.Invoke(new SlideInEffect());
            this.Close();
        }

        private void fadeInEffectButton_Click(object sender, EventArgs e)
        {
            m_OnEffectSelected?.Invoke(new FadeInEffect());
            this.Close();
        }

        private void zoomInEffectButton_Click(object sender, EventArgs e)
        {
            m_OnEffectSelected?.Invoke(new ZoomInEffect());
            this.Close();
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

    }
}
