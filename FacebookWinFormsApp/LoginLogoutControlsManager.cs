using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    internal class LoginLogoutControlsManager
    {
        private Button m_LoginButton;
        private Button m_LogoutButton;
        FacebookWrapper.LoginResult m_LoginResult;
        private User m_LoggedInUser;

        internal LoginLogoutControlsManager(Button i_LoginButton, Button i_LogoutButton)
        {
            m_LoginButton = i_LoginButton;
            m_LogoutButton = i_LogoutButton;
        }

        internal FacebookWrapper.LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }
        }

        internal User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        internal void Login(MediaConrolsManager i_MediaConrolsManager, ContentControlsManager i_ContentControlsManager)
        {
            try
            {
                m_LoginResult = FacebookService.Login(
                    /// (This is our App ID)
                    "8921577487885770",
                    /// requested permissions:
                    "email",
                    "public_profile",
                    "user_photos",
                    "user_birthday",
                    "user_events",
                    "user_likes",
                    "user_posts",
                    "user_link"
                    );

                if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) && m_LoginResult.LoggedInUser != null)
                {
                     m_LoginButton.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    m_LoggedInUser = m_LoginResult.LoggedInUser;

                    i_MediaConrolsManager.PerformLogin(m_LoggedInUser);
                    i_ContentControlsManager.PerformLogin(m_LoggedInUser);
                    SetupUI.DisableAndEnableButtons(m_LoginButton, m_LogoutButton);
                }
                else
                {
                    throw new Exception("you didnt logged in");
                }
            }

            catch (Exception ex)
            {
                m_LoginResult = null;
                m_LoggedInUser = null;
                MessageBox.Show(ex.Message);
            }     
        }

        internal void Logout(MediaConrolsManager i_MediaConrolsManager, ContentControlsManager i_ContentControlsManager)
        {
            i_ContentControlsManager.PerformLogout(m_LoggedInUser);
            FacebookService.LogoutWithUI();
            m_LoginButton.Text = "Login";
            m_LoginResult = null;
            m_LoggedInUser = null;
            SetupUI.DisableAndEnableButtons(m_LogoutButton, m_LoginButton);
            i_MediaConrolsManager.PerformLogout();
        }
    }
}
