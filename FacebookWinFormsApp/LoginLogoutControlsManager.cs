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
    internal class LoginLogoutControlsManager : ILoginLogoutSubject
    {
        private List<ILoginLogoutObserver> m_Observers = new List<ILoginLogoutObserver>();
        private Button m_LoginButton;
        private Button m_LogoutButton;
        FacebookWrapper.LoginResult m_LoginResult;
        private User m_LoggedInUser;

        internal LoginLogoutControlsManager(Button i_LoginButton, Button i_LogoutButton)
        {
            m_LoginButton = i_LoginButton;
            m_LogoutButton = i_LogoutButton;
        }

        public void RegisterObserver(ILoginLogoutObserver i_Observer)
        {
            m_Observers.Add(i_Observer);
        }

        public void RemoveObserver(ILoginLogoutObserver i_Observer)
        {
            m_Observers.Remove(i_Observer);
        }

        public void NotifyLogin()
        {
            if (m_LoggedInUser != null)
            {
                foreach (ILoginLogoutObserver observer in m_Observers)
                {
                    observer.OnUserLoggedIn(m_LoggedInUser);
                }
            }
        }

        public void NotifyLogout()
        {
            if (m_LoggedInUser != null)
            {
                foreach (ILoginLogoutObserver observer in m_Observers)
                {
                    observer.OnUserLoggedOut(m_LoggedInUser);
                }
            }
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
                m_LoginResult = FacebookService.Connect("EABZByIKEAZAcoBO4r8BxyPdt2UWCWyNxsAA43Ect1jHQZATQ4cCGkrccm2YTiXWpmBqNPmTQTAISZB9Xgop9ZAXTtRpwWNXbYSsGRdwzA8e9jFNZADACpdk9e7dEeTWn1yJzkxwUXkiKCRQOZBTZCLzzU5u5pwGhQeZBZBtdTQZC9kC9KJb4EYYi5GOfy9jTCYsDZBPwvGhYAWMmk49nvAT8CCFADzZAnaSmQUshXmsKt0wZDZD");
                /*m_LoginResult = FacebookService.Login(
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
                    );*/

                if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) && m_LoginResult.LoggedInUser != null)
                {
                     m_LoginButton.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    m_LoggedInUser = m_LoginResult.LoggedInUser;

                    //i_MediaConrolsManager.PerformLogin(m_LoggedInUser);
                    //i_ContentControlsManager.PerformLogin(m_LoggedInUser);
                    SetupUI.DisableAndEnableButtons(m_LoginButton, m_LogoutButton);
                    NotifyLogin();
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
            NotifyLogout();
            //i_ContentControlsManager.PerformLogout(m_LoggedInUser);
            FacebookService.LogoutWithUI();
            m_LoginButton.Text = "Login";
            m_LoginResult = null;
            m_LoggedInUser = null;
            SetupUI.DisableAndEnableButtons(m_LogoutButton, m_LoginButton);
            //i_MediaConrolsManager.PerformLogout();
        }
    }
}
