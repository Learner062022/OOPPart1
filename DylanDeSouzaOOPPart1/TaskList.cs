using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanDeSouzaOOPPart1
{
    class TaskList
    {
        List<Task> tasks;
        public string name;

        public TaskList(string name)
        {
            if (this.name == string.Empty) Console.WriteLine("Name cannot be empty.");
            else this.name = name;
        }

        public int NumTasks { get => tasks.Count; }

        public int NumIncompleteTasks { get => tasks.Count(t => !t.IsComplete); }

        public void AddTask(Task task) { tasks.Add(task); }

        public void RemoveCompletedTasks() { tasks.RemoveAll(t => t.IsComplete); }
    }
}