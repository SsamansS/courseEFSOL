using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncP_lesson3_2
{
    class StackTaskScheduler : TaskScheduler
    {
        private readonly Stack<Task> tasksList = new Stack<Task>();
        protected override IEnumerable<Task> GetScheduledTasks()
        {
            return tasksList;
        }

        protected override void QueueTask(Task task)
        {
            Console.WriteLine($"    [QueueTask] Задача #{task.Id} поставлена в очередь..");
            tasksList.Push(task);
            ThreadPool.QueueUserWorkItem(ExecuteTasks, null);
        }

        private void ExecuteTasks(object state)
        {
            while (true)
            {
                //Thread.Sleep(2000); // Убрать комментарий для проверки TryExecuteTaskInline
                Task task = null;

                lock (tasksList)
                {
                    if (tasksList.Count == 0)
                    {
                        break;
                    }

                    task = tasksList.Pop();
                    //tasksList.RemoveFirst();
                }

                if(task == null)
                {
                    break;
                }

                base.TryExecuteTask(task);
            }
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            Console.WriteLine($"        [TryExecuteTaskInline] Попытка выполнить задачу #{task.Id} синхронно..");

            lock (tasksList)
            {
                tasksList.TryPop(out task);
            }

            return base.TryExecuteTask(task);
        }
    }
}
