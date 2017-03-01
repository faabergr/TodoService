using Nancy;
using System.Collections.Generic;

namespace TodoService
{
    public class TaskModule : NancyModule
    {
        public TaskModule()
        {
            Get("/", _ => new List<TodoTask>() { new TodoTask { Id = 1, Description = "Mow the lawn" }});
        }
    }
}