using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.Interface
{
    public interface ITaskInfoViewModel
    {
         int Id { get; set; }
         string Name { get; set; }
         double UrgencyMeasure { get; set; }
         double ImportanceMeasure { get; set; }
         string Description { get; set; }
    }
}
