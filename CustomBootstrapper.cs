namespace TodoService
{
    using Nancy;
    using Nancy.Configuration;
    using Nancy.Diagnostics;

    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        public override void Configure(INancyEnvironment environment)
        {
            environment.Tracing(
                enabled: true,
                displayErrorTraces: true);

            environment.Diagnostics(
                enabled: true,
                password: "password");
        }
    }
}