using System.Web;
using System.Web.Mvc;

namespace _16_TranThanhHau_Buoi1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}