using System.Web;
using System.Web.Mvc;

namespace DOE522_FA2_9882
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
