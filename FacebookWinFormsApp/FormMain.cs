using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        const string k_NextPhoto = "next";
        const string k_PrevtPhoto = "prev";
        
        private MediaConrolsManager m_MediaControls;
        private ContentControlsManager m_ContentControls;
        private LoginLogoutControlsManager m_LoginLogoutControls;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_MediaControls = new MediaConrolsManager(albumPictureBox, albumListBox, albumsTitle, pictureBoxProfile, 
                stopProfileAlbumButton, startProfileAlbumButton, leftAlbumButton, rightAlbumButton );
            m_ContentControls = new ContentControlsManager(biographyTitle, biographyTextBox, likedPagesTitle, likedPagesListBox,
                                likedPagePictureBox, postStatusTitle, postStatusListBox, postStatusButton, moviesAndTVShowsRec, booksRec, musicRec, recommendationTitle);
            m_LoginLogoutControls = new LoginLogoutControlsManager(buttonLogin, buttonLogout);
        }
       
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");          

            if (m_LoginLogoutControls.LoginResult == null)
            {
                m_LoginLogoutControls.Login(m_MediaControls, m_ContentControls);
            }
        }

        private void albumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_MediaControls.DisplaySelectedAlbum();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LoginLogoutControls.Logout(m_MediaControls, m_ContentControls);
        }

        private void LikedPagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ContentControls.DisplaySelectedLikedPage();
        }
        private void postButton_Click(object sender, EventArgs e)
        {
            m_ContentControls.PostStatus(m_LoginLogoutControls.LoggedInUser);
        }

        private void profileAlbumButton_Click(object sender, EventArgs e)
        {
            m_MediaControls.OpenProfileAlbumForm(m_LoginLogoutControls.LoggedInUser); 
        }

        private void stopProfileButton_Click(object sender, EventArgs e)
        {
            m_MediaControls.StopProfileAlbumForm(m_LoginLogoutControls.LoggedInUser);
        }

        private void leftAlbumButton_Click(object sender, EventArgs e)
        {
            m_MediaControls.ShowNextPhoto(k_PrevtPhoto);
        }

        private void rightAlbumButton_Click(object sender, EventArgs e)
        {
            m_MediaControls.ShowNextPhoto(k_NextPhoto);
        }
    }
}
