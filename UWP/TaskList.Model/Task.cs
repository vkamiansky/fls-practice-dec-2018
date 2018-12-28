using System;

namespace TaskList.Model
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UrgencyMeasure { get; set; }
        public double ImportanceMeasure { get; set; }
        public string Description { get; set; }
    }
}
