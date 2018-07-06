using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC5__Ch16_CMS範例實戰
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
