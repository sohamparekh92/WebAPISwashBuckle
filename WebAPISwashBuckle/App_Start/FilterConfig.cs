using System.Web;
using System.Web.Mvc;

namespace WebAPISwashBuckle
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
