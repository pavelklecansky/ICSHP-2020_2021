using System;

namespace Exercise07
{
    public class DateTimeException : Exception
    {
        public DateTime CentralEuropeTime { get; }

        public DateTimeException() : this("")
        {
            
        }

        public DateTimeException(string message) : base(message)
        {
            CentralEuropeTime = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}