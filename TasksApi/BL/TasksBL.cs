using System.Collections.Generic;
using System.IO;
using TasksApi.BO;

namespace TasksApi.BL
{
    public class TasksBL
    {
        private static string _dbPath = $"{System.IO.Directory.GetCurrentDirectory()}/db.json";

        public Task insertTask(Task task)
        {
            var db = _dbPath.readFile().Deserialize<TaskCollectioncs>();
            task.id = db.Tasks.Count;
            db.Tasks.Add(task);
            File.WriteAllText(_dbPath, db.Serialize());
            return task;
        }

        public List<Task> getTasks() => _dbPath.readFile().Deserialize<TaskCollectioncs>().Tasks;

    }
}
