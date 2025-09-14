using System;

namespace TestTask.Classes
{
    public class Statistics
    {
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public Statistics(DateTime date, int count)
        {
            Date = date;
            Count = count;
        }
    }
}
