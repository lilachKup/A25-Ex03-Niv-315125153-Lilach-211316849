using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;

namespace BasicFacebookFeatures
{
    internal class MediaConrolsManager : ILoginLogoutObserver
    {
        const bool v_ShowControls = true;
        const int k_TimerInterval = 5000;
        const int k_NoPhotos = 0;
        const int k_OnePhoto = 1;
        const int k_NoAlbums = 0;

        private PictureBox m_AlbumsPictureBox;
        private ListBox m_AlbumsListBox;
        private Label m_AlbumsLabel;       
        private PictureBox m_ProfilePictureBox;
        private List <string> m_ProfileAlbum;
        private int m_ProfilePhotoIndex = 0;
        private Button m_StopProfileAlbumButton;    
        private Button m_StartProfileAlbumButton;
        private List<string> m_AlbumAsList;
        private int m_AlbumPhotoIndex = 0;
        private Button m_LeftAlbumButton;
        private Button m_RightAlbumButton;
        Timer m_Timer;
        private IPhotoEffectStrategy m_PhotoEffectStrategy;

        internal MediaConrolsManager(PictureBox i_AlbumsPictureBox, ListBox i_AlbumsListBox, Label i_AlbumsLabel, PictureBox i_ProfilePictureBox, 
            Button i_StopProfileAlbumButton, Button i_StartProfileAlbumButton, Button i_LeftAlbumButton, Button i_RightAlbumButton)
        {
            m_AlbumsPictureBox = i_AlbumsPictureBox;
            m_AlbumsListBox = i_AlbumsListBox;
            m_AlbumsLabel = i_AlbumsLabel;
            m_ProfilePictureBox = i_ProfilePictureBox;
            m_ProfileAlbum = new List<string>();
            m_StopProfileAlbumButton = i_StopProfileAlbumButton;
            m_StartProfileAlbumButton = i_StartProfileAlbumButton;
            m_AlbumAsList = new List<string>();
            m_Timer = new Timer();
            m_Timer.Interval = k_TimerInterval;
            m_LeftAlbumButton = i_LeftAlbumButton;
            m_RightAlbumButton = i_RightAlbumButton;
        }

        public void OnUserLoggedIn(User i_LoggedInUser)
        {
            SetupUI.ShowOrHideControls(v_ShowControls, new List<Control> { m_AlbumsPictureBox, m_AlbumsListBox, m_AlbumsLabel, 
                 m_ProfilePictureBox, m_StopProfileAlbumButton, m_StartProfileAlbumButton, m_LeftAlbumButton, m_RightAlbumButton });
            SetProfilePhoto(i_LoggedInUser);
            PopulateAlbumsListBox(i_LoggedInUser);
        }

        public void OnUserLoggedOut(User i_LoggedInUser)
        {
            SetupUI.ShowOrHideControls(!v_ShowControls, new List<Control> { m_AlbumsPictureBox, m_AlbumsListBox, m_AlbumsLabel, 
                 m_StopProfileAlbumButton, m_StartProfileAlbumButton, m_LeftAlbumButton, m_RightAlbumButton });
            m_AlbumsPictureBox.Image = null;
            m_AlbumsListBox.Items.Clear();
            m_AlbumAsList.Clear();
            m_AlbumPhotoIndex = 0;
            m_ProfileAlbum.Clear();
            m_ProfilePhotoIndex = 0;
            string imagePath = @"..\..\..\faceBookProfileUnkonws.png";
            m_ProfilePictureBox.Image = Image.FromFile(imagePath);

            if (m_Timer.Enabled)
            {
                m_Timer.Stop();
            }
            if(m_PhotoEffectStrategy != null)
            {
                m_PhotoEffectStrategy.StopEffect();
                m_PhotoEffectStrategy = null;
            }
        }

        internal void SetProfilePhoto(User i_LoggedInUser)
        {
            m_ProfilePictureBox.ImageLocation = i_LoggedInUser.PictureNormalURL;
        }

        internal void PopulateAlbumsListBox(User i_LoggedInUser)
        {
                m_AlbumsListBox.Items.Clear();
                m_AlbumsListBox.DisplayMember = "Name";

                foreach (Album album in i_LoggedInUser.Albums)
                {
                    m_AlbumsListBox.Items.Add(album);
                }

                if (m_AlbumsListBox.Items.Count == k_NoAlbums)
                {
                   MessageBox.Show("No Albums to retrieve :(");
                }
                else
                {
                    m_AlbumsListBox.SelectedIndex = 0;
                }
        }

        internal void DisplaySelectedAlbum()
        {
            m_AlbumAsList.Clear();

            if (m_AlbumsListBox.SelectedItems.Count == 1)
            {
                Album selectedAlbum = m_AlbumsListBox.SelectedItem as Album;

                if (selectedAlbum.PictureAlbumURL != null && selectedAlbum.Count > k_NoPhotos)
                {
                    m_AlbumsPictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
                    m_AlbumsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    m_AlbumAsList = getAlbumAsList();
                }
                else
                {
                    m_AlbumsPictureBox.Image = m_AlbumsPictureBox.ErrorImage;
                }
            }
        }

        internal void OpenProfileAlbumForm(User i_LoggedInUser)
        {
            List<string> photoUrls = new List<string>();

            foreach (Album album in i_LoggedInUser.Albums)
            {
                if (album.Photos.Count > k_NoPhotos)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        if (!string.IsNullOrEmpty(photo.PictureNormalURL))
                        {   
                            photoUrls.Add(photo.PictureNormalURL);
                        }                  
                    }
                }
            }

            if (m_ProfileAlbum.Count > k_NoPhotos)
            {
                m_ProfileAlbum.Clear();
            }

            ProfileAlbumForm profileAlbumForm = new ProfileAlbumForm(photoUrls, m_ProfileAlbum, effect => m_PhotoEffectStrategy = effect);
            profileAlbumForm.ShowDialog();
            checkValidPhotosToProfile(i_LoggedInUser, m_ProfileAlbum);
            if (m_ProfileAlbum.Count > 0)
            {
                SetupUI.DisableAndEnableButtons(new List<Button> { m_StartProfileAlbumButton }, m_StopProfileAlbumButton);
            }
        }

        private void checkValidPhotosToProfile(User i_LoggedInUser, List <string> i_ProfileAlbum)
        {
            if(i_ProfileAlbum.Count == k_NoPhotos)
            {
                MessageBox.Show("No photos selected");
            }
            else if(i_ProfileAlbum.Count == k_OnePhoto)
            {
                m_ProfilePictureBox.ImageLocation = m_ProfileAlbum[0];
            }
            else
            {
                changeProfilePictureToProfileAlbum(i_ProfileAlbum);
            }
        }

        private void changeProfilePictureToProfileAlbum(List <string> i_ProfileAlbum)
        {
            m_Timer.Start();
            m_Timer.Tick += Timer_Tick;
        }

        private void resetPictureBoxState()
        {
            if (m_PhotoEffectStrategy != null)
            {
                m_PhotoEffectStrategy.StopEffect();  
            }

            m_ProfilePictureBox.Image = null;    
            m_ProfilePictureBox.Size = new Size(148, 122);     
            m_ProfilePictureBox.Location = new Point(6, 8); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            m_ProfilePhotoIndex = (m_ProfilePhotoIndex + 1) % m_ProfileAlbum.Count;
            m_ProfilePictureBox.LoadAsync(m_ProfileAlbum[m_ProfilePhotoIndex]);            

            m_ProfilePictureBox.LoadCompleted += (s, ev) =>
            {
                if (m_PhotoEffectStrategy != null)
                {
                    m_PhotoEffectStrategy.ApplyEffect(m_ProfilePictureBox);
                }
            };           
        }
      
        internal void StopProfileAlbumForm(User i_LoggedInUser)
        {
            m_Timer.Stop();
            resetPictureBoxState();
            SetProfilePhoto(i_LoggedInUser);
            m_PhotoEffectStrategy = null;
            SetupUI.DisableAndEnableButtons(new List<Button> { m_StopProfileAlbumButton }, m_StartProfileAlbumButton);
        }


        internal void ShowNextPhoto(string i_Direction)
        {
            if (m_AlbumAsList.Count == k_NoPhotos)
            {
                MessageBox.Show("No photos in the album");
            }
            else if (i_Direction == "next")
            {
                m_AlbumPhotoIndex++;
                m_AlbumsPictureBox.ImageLocation = m_AlbumAsList[m_AlbumPhotoIndex % (m_AlbumAsList.Count - 1)];
            }
            else
            {
                m_AlbumPhotoIndex--;
                if (m_AlbumPhotoIndex < 0)
                {
                    m_AlbumPhotoIndex += m_AlbumAsList.Count;
                }

                m_AlbumsPictureBox.ImageLocation = m_AlbumAsList[m_AlbumPhotoIndex % (m_AlbumAsList.Count - 1)];
            }
        }

        private List<string> getAlbumAsList()
        {
            List<string> photoUrls = new List<string>();
            Album selectedAlbum = m_AlbumsListBox.SelectedItem as Album;

            if (selectedAlbum.Count > k_NoPhotos)
            {
                foreach (Photo photo in selectedAlbum.Photos)
                {
                    if (!string.IsNullOrEmpty(photo.PictureNormalURL))
                    {
                        photoUrls.Add(photo.PictureNormalURL);
                    }
                }
            }
            else
            {
                MessageBox.Show("No photos in the album");
            }
                  
            return photoUrls;
        }
    }
}
