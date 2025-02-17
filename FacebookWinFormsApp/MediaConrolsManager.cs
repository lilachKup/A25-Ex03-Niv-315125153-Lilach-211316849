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
        private const int k_ProfilePicWidth = 148;
        private const int k_ProfilePicHeight = 122;
        private const int k_ProfilePicX = 6;
        private const int k_ProfilePicY = 8;

        private PictureBox m_AlbumsPictureBox;
        private ListBox m_AlbumsListBox;
        private Label m_AlbumsLabel;       
        private PictureBox m_ProfilePictureBox;
        private List <string> m_ProfileAlbum;
        private int m_ProfilePhotoIndex = 0;
        private Button m_StopProfileAlbumButton;    
        private Button m_StartProfileAlbumButton;
        private Button m_LeftAlbumButton;
        private Button m_RightAlbumButton;
        Timer m_Timer;
        private IPhotoEffectStrategy m_PhotoEffectStrategy;
        private IIterator<string> m_AlbumIterator;
        private AlbumCollection m_AlbumCollection;

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
            if (m_AlbumsListBox.SelectedItems.Count == 1)
            {
                m_AlbumCollection = new AlbumCollection(m_AlbumsListBox.SelectedItem as Album);
                m_AlbumIterator = m_AlbumCollection.CreateForwardIterator();
                Album selectedAlbum = m_AlbumsListBox.SelectedItem as Album;

                if (selectedAlbum.PictureAlbumURL != null && selectedAlbum.Count > k_NoPhotos)
                {
                    m_AlbumsPictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
                    m_AlbumsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    m_AlbumsPictureBox.Image = m_AlbumsPictureBox.ErrorImage;
                    MessageBox.Show("No photos in the album"); ////////////////////////////////////////
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
            m_Timer.Tick += timer_Tick;
        }

        private void resetPictureBoxState()
        {
            if (m_PhotoEffectStrategy != null)
            {
                m_PhotoEffectStrategy.StopEffect();  
            }

            m_ProfilePictureBox.Image = null;
            m_ProfilePictureBox.Size = new Size(k_ProfilePicWidth, k_ProfilePicHeight);
            m_ProfilePictureBox.Location = new Point(k_ProfilePicX, k_ProfilePicY);
        }

        private void timer_Tick(object sender, EventArgs e)
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
            if (m_AlbumCollection.IsEmptyAlbum())
            {
                MessageBox.Show("No photos in the album");
            }
            else
            {
                try
                {
                    if (i_Direction == "next")
                    {
                        if (!m_AlbumIterator.HasNext())
                        {
                            m_AlbumIterator = m_AlbumCollection.CreateForwardIterator();
                        }

                        m_AlbumsPictureBox.ImageLocation = m_AlbumIterator.Next();
                    }
                    else
                    {
                        if (!m_AlbumIterator.HasPrevious())
                        {
                            m_AlbumIterator = m_AlbumCollection.CreateReverseIterator();
                        }

                        m_AlbumsPictureBox.ImageLocation = m_AlbumIterator.Previous();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
