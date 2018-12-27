using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.DataModel
{
    public class DataTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UrgencyMeasure { get; set; }
        public double ImportanceMeasure { get; set; }
        public string Description { get; set; }

        
    }
}
