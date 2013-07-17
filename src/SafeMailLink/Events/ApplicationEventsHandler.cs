using System.Web;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using SafeMailLink.Events;
using SafeMailLink.Modules;

[assembly: PreApplicationStartMethod(typeof(ApplicationEventsHandler), "RegisterModules")]

namespace SafeMailLink.Events
{
	public class ApplicationEventsHandler
	{
		private static bool modulesRegistered;

		public ApplicationEventsHandler()
		{
		}

		public static void RegisterModules()
		{
			if (modulesRegistered)
			{
				return;
			}

			DynamicModuleUtility.RegisterModule(typeof(RegisterFilters));

			modulesRegistered = true;
		}
	}
}