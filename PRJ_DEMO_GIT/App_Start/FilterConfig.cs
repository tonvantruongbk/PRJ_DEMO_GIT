using System.Web;
using System.Web.Mvc;

namespace PRJ_DEMO_GIT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
