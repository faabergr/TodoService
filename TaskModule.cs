using Nancy;

namespace TodoService
{
    public class TaskModule : NancyModule
    {
        public TaskModule()
        {
            Get("/", _ => "Hello World!");
        }
    }
}