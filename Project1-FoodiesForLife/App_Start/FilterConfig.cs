using System.Web;
using System.Web.Mvc;

namespace Project1_FoodiesForLife
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
