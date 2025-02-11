using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanDeSouzaOOPPart1
{
    class TaskCollection
    {
        List<TaskList> taskLists;

        List<TaskList> TaskLists
        {
            set { if (taskLists != value) taskLists = value; }
            get => taskLists;
        }

        public int TotalNumTasks => taskLists.Sum(t => t.NumTasks); 

        public int TotalNumIncompleteTasks => taskLists.Where(t => t.NumIncompleteTasks >= 1).Sum(t => t.NumIncompleteTasks);

        public void AddTaskList(TaskList taskList) => taskLists.Add(taskList);

        public void RemoveCompletedTasksPerList() 
        {
            foreach (TaskList taskList in taskLists) { taskList.RemoveCompletedTasks(); }
        }
    }
}