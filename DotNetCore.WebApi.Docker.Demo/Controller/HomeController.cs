using Nancy;

namespace DotNetCore.WebApi.Docker.Demo.Controller
{
    public class HomeController : NancyModule
    {
        public HomeController()
        {
            this.RegisterRoutes();
        }

        public object GetTest()
        {
            return Response.AsJson(new { Message = "This is a simple test API with No 2" });
        }

        private void RegisterRoutes()
        {
            this.Get("test", args => this.GetTest());
        }
    }
}
