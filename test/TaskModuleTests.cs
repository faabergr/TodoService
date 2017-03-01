using System;
using Xunit;
using Nancy;
using Nancy.Testing;
using TodoService;
using System.Threading.Tasks;

namespace TodoService.Tests
{
    public class TaskModuleTests
    {
        [Fact]
        public async Task TaskModule_RootGet_ReturnsOKAsync()
        {
            var bootstrapper =
                new ConfigurableBootstrapper(config => config.Modules(typeof(TaskModule)));
            var sut = new Browser(bootstrapper, defaultsTo => defaultsTo.Accept("application/json"));
            var actual = await sut.Get("/", with => with.HttpRequest());
            Assert.Equal(HttpStatusCode.OK, actual.StatusCode);
        }
    }
}
