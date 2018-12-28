using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TaskList.Interface
{
    public interface ITaskInfoViewModel
    {
         int Id { get; set; }
         string Name { get; set; }
         double UrgencyMeasureY { get; set; }
         double ImportanceMeasureX { get; set; }
         string Description { get; set; }
         ImpKey Impotance { get; set; }
         UrgKey Urgency { get; set; }
         Color TaskColor { get; set; }
    }
}
