using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal interface ILoginLogoutObserver
    {
        void OnUserLoggedIn(User i_User);
        void OnUserLoggedOut(User i_User);
    }
}
