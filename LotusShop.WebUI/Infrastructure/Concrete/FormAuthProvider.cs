using LotusShop.Domain.Abstract;
using LotusShop.Domain.Concrete;
using System.Web.Security;

namespace LotusShop.WebUI.Infrastructure.Concrete
{
    public class FormAuthProvider : IAuthProvider
    {
        [System.Obsolete]
        public bool Authenticate(string username, string password)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result)
                FormsAuthentication.SetAuthCookie(username, false);
            return result;
        }
    }
}