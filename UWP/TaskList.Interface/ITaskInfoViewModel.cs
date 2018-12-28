﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TaskList.Interface;

namespace TaskList.Interface
{
    public interface ITaskInfoViewModel
    {
         int Id { get; set; }
         string Name { get; set; }
         double UrgencyMeasureY { get; set; }
         double ImportanceMeasureX { get; set; }
         string Description { get; set; }
         ImpKey ImpKey { get; set; }
         UrgKey UrgKey { get; set; }
         Color TaskColor { get; set; }
    }
}
