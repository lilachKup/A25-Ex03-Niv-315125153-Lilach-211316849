using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal interface ILoginLogoutSubject
    {
        void RegisterObserver(ILoginLogoutObserver i_Observer);
        void RemoveObserver(ILoginLogoutObserver i_Observer);
        void NotifyLogin();
        void NotifyLogout();
    }
}
