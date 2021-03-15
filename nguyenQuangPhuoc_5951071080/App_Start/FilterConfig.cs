using System.Web;
using System.Web.Mvc;

namespace nguyenQuangPhuoc_5951071080
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
