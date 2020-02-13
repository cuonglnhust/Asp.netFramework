using System.Web;
using System.Web.Mvc;

namespace Tedushop.Web
{
    public class FilterConfig
    {
        // Lọc request
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
