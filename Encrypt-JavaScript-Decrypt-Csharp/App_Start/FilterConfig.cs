using System.Web;
using System.Web.Mvc;

namespace Encrypt_JavaScript_Decrypt_Csharp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}