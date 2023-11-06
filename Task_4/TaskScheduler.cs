using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class TaskScheduler<TTask, TPriority>
    {
        private readonly List<(TTask task, TPriority priority)> taskQueue = new List<(TTask task, TPriority priority)>();

        public delegate void TaskExecution(TTask task);

        public void AddTask(TTask task, TPriority priority)
        {
            taskQueue.Add((task, priority));
        }

        public void ExecuteNext(TaskExecution executeTask)
        {
            if (taskQueue.Count == 0)
            {
                Console.WriteLine("There is no tasks");
                return;
            }

            var highestPriorityTask = taskQueue
                .OrderByDescending(t => t.priority)
                .First();

            TTask taskToExecute = highestPriorityTask.task;
            taskQueue.Remove(highestPriorityTask);

            executeTask(taskToExecute);
        }

        public void AddToPool(List<TTask> pool, TTask task)
        {
            pool.Add(task);
        }

        public TTask GetFromPool(List<TTask> pool)
        {
            if (pool.Count == 0)
            {
                return default(TTask);
            }

            TTask task = pool[0];
            pool.RemoveAt(0);
            return task;
        }

        public void RunTaskScheduler(TaskExecution executeTask, List<TTask> pool)
        {
            while (true)
            {
                Console.WriteLine("Enter a task or 'exit' to quit");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }
            }

            while (pool.Count > 0)
            {
                ExecuteNext(executeTask);
            }
        }
    }
}
