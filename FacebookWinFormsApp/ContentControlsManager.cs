using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class ContentControlsManager
    {
        const bool v_ShowControls = true;
        const int k_NoLikedPages = 0;

        private Label m_BiographyTitle;
        private TextBox m_BiographyTextBox;
        private Label m_LikedPagesLable;
        private ListBox m_LikedPagesListBox;
        private PictureBox m_LikedPagePictureBox;
        private Label m_PostStatusLabel;
        private TextBox m_PostStatusTextBox;
        private Button m_PostStatusButton;
        private RecommendationUserControl m_MoviesAndTVShowsRec;
        private RecommendationUserControl m_BooksRec;
        private RecommendationUserControl m_MusicRec;
        private Label m_RecommendationLabel;
        private UserRecommendationDataManager m_UserRecommendationDataManager; 

        internal ContentControlsManager(Label i_BiographyTitle, TextBox i_BiographyTextBox, Label i_LikedPagesLable, ListBox i_LikedPagesListBox, PictureBox i_LikedPagePictureBox, 
            Label i_PostStatusLabel, TextBox i_PostStatusTextBox, Button i_PostStatusButton, RecommendationUserControl i_MoviesAndTVShowsRec, RecommendationUserControl i_BooksRec, 
            RecommendationUserControl i_MusicRec, Label i_RecommendationLabel)
        {
            m_BiographyTitle = i_BiographyTitle;
            m_BiographyTextBox = i_BiographyTextBox;
            m_LikedPagesLable = i_LikedPagesLable;
            m_LikedPagesListBox = i_LikedPagesListBox;
            m_LikedPagePictureBox = i_LikedPagePictureBox;
            m_PostStatusLabel = i_PostStatusLabel;
            m_PostStatusTextBox = i_PostStatusTextBox;
            m_PostStatusButton = i_PostStatusButton;
            m_MoviesAndTVShowsRec = i_MoviesAndTVShowsRec;
            m_BooksRec = i_BooksRec;
            m_MusicRec = i_MusicRec;
            m_RecommendationLabel = i_RecommendationLabel;
            m_UserRecommendationDataManager = new UserRecommendationDataManager();
        }

        internal void PerformLogin(User i_LoggedInUser)
        {
            if (i_LoggedInUser.Email != null)
            {
                m_UserRecommendationDataManager.LoadUserDatafromFile(i_LoggedInUser.Email, m_MoviesAndTVShowsRec.RecommendationTextBox1, m_MoviesAndTVShowsRec.RecommendationTextBox2, m_BooksRec.RecommendationTextBox1, m_BooksRec.RecommendationTextBox2,
                    m_MusicRec.RecommendationTextBox1, m_MusicRec.RecommendationTextBox2, m_MoviesAndTVShowsRec.RecommendationRate1, m_MoviesAndTVShowsRec.RecommendationRate2, m_BooksRec.RecommendationRate1, m_BooksRec.RecommendationRate2,
                     m_MusicRec.RecommendationRate1, m_MusicRec.RecommendationRate2);
            }

            SetupUI.ShowOrHideControls(v_ShowControls, new List<Control> { m_BiographyTitle, m_BiographyTextBox, m_LikedPagesLable, m_LikedPagesListBox, 
                m_LikedPagePictureBox, m_PostStatusLabel, m_PostStatusTextBox, m_PostStatusButton,  m_MoviesAndTVShowsRec, m_BooksRec, m_MusicRec, m_RecommendationLabel });
            GetBiography(i_LoggedInUser);
            PopulateLikedPagesListBox(i_LoggedInUser);
        }

        internal void PerformLogout(User i_LoggedInUser)
        {          
            SetupUI.ShowOrHideControls(!v_ShowControls, new List<Control> { m_BiographyTitle, m_BiographyTextBox, m_LikedPagesLable, m_LikedPagesListBox,
                m_LikedPagePictureBox, m_PostStatusLabel, m_PostStatusTextBox, m_PostStatusButton, m_MoviesAndTVShowsRec, m_BooksRec, m_MusicRec, m_RecommendationLabel  });
            m_BiographyTextBox.Text = string.Empty;
            m_LikedPagesListBox.Items.Clear();
            m_LikedPagePictureBox.Image = null;
            m_PostStatusTextBox.Text = string.Empty;
            if (i_LoggedInUser.Email != null)
            { 
                m_UserRecommendationDataManager.SaveUserDataToFile(i_LoggedInUser.Email, m_MoviesAndTVShowsRec.RecommendationTextBox1, m_MoviesAndTVShowsRec.RecommendationTextBox2, m_BooksRec.RecommendationTextBox1, m_BooksRec.RecommendationTextBox2,
                    m_MusicRec.RecommendationTextBox1, m_MusicRec.RecommendationTextBox2, m_MoviesAndTVShowsRec.RecommendationRate1, m_MoviesAndTVShowsRec.RecommendationRate2, m_BooksRec.RecommendationRate1, m_BooksRec.RecommendationRate2,
                     m_MusicRec.RecommendationRate1, m_MusicRec.RecommendationRate2);
            }

            m_MoviesAndTVShowsRec.ClearText();
            m_BooksRec.ClearText();
            m_MusicRec.ClearText();
        }

        internal void DisplaySelectedLikedPage()
        {
            if (m_LikedPagesListBox.SelectedItems.Count == 1)
            {
                Page selectedPage = m_LikedPagesListBox.SelectedItem as Page;

                if (selectedPage.PictureNormalURL != null)
                {
                    m_LikedPagePictureBox.LoadAsync(selectedPage.PictureNormalURL);
                    m_LikedPagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    m_LikedPagePictureBox.Image = m_LikedPagePictureBox.ErrorImage;
                }
            }
        }

        internal void PopulateLikedPagesListBox(User i_LoggedInUser)
        {
            m_LikedPagesListBox.Items.Clear();
            m_LikedPagesListBox.DisplayMember = "Name";

            foreach (Page page in i_LoggedInUser.LikedPages)
            {
                m_LikedPagesListBox.Items.Add(page);
            }

            if (m_LikedPagesListBox.Items.Count == k_NoLikedPages)
            {
                MessageBox.Show("No Pages to retrieve :");
            }
            else
            {
                m_LikedPagesListBox.SelectedIndex = 0;
            }
        }

        internal void GetBiography(User i_LoggedInUser)
        {
            string userBiography = string.Empty;
            userBiography = $@"{(i_LoggedInUser.Email != null ? "Email: " + i_LoggedInUser.Email : string.Empty)}
{(i_LoggedInUser.Birthday != null ? "BirthDay: " + i_LoggedInUser.Birthday : string.Empty)}
{(i_LoggedInUser.Location != null ? "City of Residence: " + i_LoggedInUser.Location.Name : string.Empty)}";

            if (userBiography == string.Empty)
            {
                userBiography = "No biography available to display";
            }

            m_BiographyTextBox.Text = userBiography;
        }

        internal void PostStatus(User i_LoggedInUser)
        {
            try
            {
                if (!string.IsNullOrEmpty(m_PostStatusTextBox.Text))
                {
                    MessageBox.Show("Posted successfully");
                    postStatus(m_PostStatusTextBox.Text, i_LoggedInUser);
                    m_PostStatusTextBox.Text = string.Empty;
                }
                else
                {
                    throw new Exception("Please write something to post");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                m_PostStatusTextBox.Text = string.Empty;
            }
        }

        private void postStatus(string i_StatusPost , User i_LoggedInUser)
        {
            Status postedStatus = i_LoggedInUser.PostStatus(i_StatusPost);
        }
    }
}
