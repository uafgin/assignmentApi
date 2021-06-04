using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TasksApi.BL;
using TasksApi.BO;

namespace TasksApi.Controllers
{
    [Produces("application/json")]
    [Route("Tasks")]
    public class TasksController : Controller
    {
        [HttpGet]
        [EnableCors("ApiCorsPolicy")]
        [Route("")]
        public List<Task> getTasks()
        {
            return new TasksBL().getTasks();
        }

        [HttpPost]
        [EnableCors("ApiCorsPolicy")]
        [Route("")]
        public Task insertTask([FromBody]Task task)
        {
            return new TasksBL().insertTask(task);
        }

    }
}