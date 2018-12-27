using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaskList.DataModel;


namespace TaskList.Interface
{
   public interface ITaskRepository
    {
       List<DataTask> ReadAllTasks();
       DataTask ReadTask(string name);
       void AddTask(DataTask task);
       void DeleteTask(string name);
    }
}
