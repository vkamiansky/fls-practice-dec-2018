using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaskList.Model;

namespace TaskList.Interface
{
    public interface ITaskService
    {
        List<Task> ReadAllTask();
        Task ReadTask(string name);
        void AddTask(Task task);
        void DeleteTask(string name);
    }
}
