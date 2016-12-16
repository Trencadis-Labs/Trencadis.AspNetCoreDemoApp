using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Trencadis.AspNetCoreDemoApp.Routes
{
  public static class RoutesConfig
  {
    public static void ConfigureRoutes(IRouteBuilder routeBuilder)
    {
      routeBuilder.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
    }
  }
}
