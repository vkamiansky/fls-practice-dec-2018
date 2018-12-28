using System;
using Xunit;
using TaskList.Interface;
using Moq;
using TaskList.Model;
using TaskList.Service;
using TaskList.DataModel;

namespace TaskList.Service.Test
{
    public class TestService
    {
        [Fact]
        public void TestTaskRepositoryAddTask()
        {
            var mock = new Mock<ITaskRepository>();
            var sut = new TaskService();
            DataTask dataTask = new DataTask { Id = 1, Name = "ПРооосто", UrgencyMeasure = 10.5, ImportanceMeasure = 158.225, Description = "Здесь что то есть" };
            Task task = new Task { Id = 1, Name = "ПРооосто", UrgencyMeasure = 10.5, ImportanceMeasure = 158.225, Description = "Здесь что то есть" };
            sut.TaskRepository = mock.Object;
            mock.Setup(x => x.ReadTask(It.Is<string>(o => o == task.Name))).Returns(dataTask);
            // sut.ReadTask()
            Task result = sut.ReadTask(task.Name);
            mock.Verify(x => x.ReadTask(It.Is<string>(o => o == task.Name)),Times.Once);

            Assert.Equal(task.Name, result.Name);
            Assert.Equal(task.Id, result.Id);
            Assert.Equal(task.Description, result.Description);
            Assert.Equal(task.ImportanceMeasure, result.ImportanceMeasure);
            Assert.Equal(task.UrgencyMeasure, result.UrgencyMeasure);
        }
    }
}
