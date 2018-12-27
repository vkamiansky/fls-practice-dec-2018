﻿using System;
using TaskList.Interface;
using Newtonsoft.Json;
using System.IO;
using TaskList.DataModel;
using System.Collections.Generic;

namespace TaskList.Data
{
    public class TaskRepository: ITaskRepository
    {

        public void AddTask(DataModelTask task)
        {
            SaveInJson(task);
        }

        public void DeleteTask(string name)
        {
            if(SearchTaskOfName(name))
            {
                File.Delete(@"../DataJson/" + name + ".json");
            }
        }

        public void SaveInJson(DataModelTask task)
        {
            string json = JsonConvert.SerializeObject(task);
            using (StreamWriter file = File.CreateText(@"../DataJson/"+task.Name+ ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, json);
            }
        }

        public DataModelTask ReadTask(string name)
        {
            if (SearchTaskOfName(name)) return DeserializeTask(File.ReadAllText(@"../DataJson/" + name + ".json"));
            else
                return null;
        }

         public List<DataModelTask> ReadAllTasks()
         {
            string[] allFoundFiles = Directory.GetFiles(@"../DataJson/",@"*.json" , SearchOption.AllDirectories);
            List<DataModelTask> tasks = new List<DataModelTask>();
            foreach (string path in allFoundFiles)
            {
                DataModelTask tsk = DeserializeTask(File.ReadAllText(path));
                if (tsk != null)
                {
                    tasks.Add(tsk);
                }
            }
            return tasks;
         }

        public DataModelTask DeserializeTask(string path)
        {
            try
            {
                return JsonConvert.DeserializeObject<DataModelTask>(path);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void ChangeTask(DataModelTask task)
        {
            DataModelTask oldTask = ReadTask(task.Name);
            if (oldTask!=null)
            {
                DeleteTask(oldTask.Name);
                SaveInJson(task);
            }
           
        }


        public bool SearchTaskOfName(string name)
        {
            try
            {
                DeserializeTask(File.ReadAllText(@"../DataJson/" + name + ".json"));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SearchTaskOfId(int Id)
        {
            try
            {
                ReadAllTasks().Find(x => x.Id == Id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
