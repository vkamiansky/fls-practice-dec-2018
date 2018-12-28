
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskList.Model;
using TaskList.Interface;
using TaskList.Service;
using TaskList.DataModel;
using Moq;

namespace TaskList.Service.Test1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestServiceReadTask()
        {
            var mock = new Mock<ITaskRepository>();
            var sut = new TaskService();
            DataTask dataTask = new DataTask { Id = 1, Name = "ПРооосто", UrgencyMeasure = 10.5, ImportanceMeasure = 158.225, Description = "Здесь что то есть" };
            Task task = new Task { Id = 1, Name = "ПРооосто", UrgencyMeasure = 10.5, ImportanceMeasure = 158.225, Description = "Здесь что то есть" };
            sut.TaskRepository = mock.Object;
            mock.Setup(x => x.ReadTask(It.Is<string>(o => o == task.Name))).Returns(dataTask);
            // sut.ReadTask()
            Task result = sut.ReadTask(task.Name);
            mock.Verify(x => x.ReadTask(It.Is<string>(o => o == task.Name)), Times.Once);

            Assert.AreEqual(task.Name, result.Name);
            Assert.AreEqual(task.Id, result.Id);
            Assert.AreEqual(task.Description, result.Description);
            Assert.AreEqual(task.ImportanceMeasure, result.ImportanceMeasure);
            Assert.AreEqual(task.UrgencyMeasure, result.UrgencyMeasure);
        }
    }
}
