using Data;
using Data.Repositorio;
using Dominio;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			// Create the container as usual.

			var container = new SimpleInjector.Container();
			container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

			// Register your types, for instance:
			container.Register<Persistencia>(Lifestyle.Scoped); 
			container.Register<IMovimentoManualRepositorio, MovimentoManualRepositorio>(Lifestyle.Scoped);
		


			// This is an extension method from the integration package.
			container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

			container.Verify();

			DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
		}
	}
}
