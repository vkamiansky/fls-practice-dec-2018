﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TaskList.Interface;
using TaskList.Model;
using TaskList.DataModel;

namespace TaskList.Service
{
    public class TaskService:ITaskService
    {
        ITaskRepository idataTask;
        
        public List<Task> ReadAllTask()
        {
            List<Task> tasks = new List<Task>();
            var r = idataTask.ReadAllTasks();
            foreach(var it in r)
            {
                tasks.Add(new Task { Id = it.Id, Name = it.Name, UrgencyMeasure = it.UrgencyMeasure, ImportanceMeasure = it.ImportanceMeasure, Description = it.Description });
            }
            return tasks;
        }

        public Task ReadTask(string name)
        {
            DataTask dt = idataTask.ReadTask(name);
            return new Task { Id = dt.Id, Name = dt.Name, UrgencyMeasure = dt.UrgencyMeasure, ImportanceMeasure = dt.ImportanceMeasure, Description = dt.Description };
        }

        public void AddTask(Task task)
        {
            DataTask dt = new DataTask { Id = task.Id, Name = task.Name, UrgencyMeasure = task.UrgencyMeasure, ImportanceMeasure = task.ImportanceMeasure, Description = task.Description };
            idataTask.AddTask(dt);
        }

        public void DeleteTask(string name)
        {
            idataTask.DeleteTask(name);
        }
    }
}
