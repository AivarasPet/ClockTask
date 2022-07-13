using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTask
{
    public class ClockValidator 
    {
        private const int MaxHours = 12;
        private const int MinHours = 1;
        private const int MaxMinutes = 59;
        private const int MinMinutes = 0;

        public static bool IsValid(Clock clock)
        {
            return (MinHours <= clock.Hours && clock.Hours <= MaxHours && MinMinutes <= clock.Minutes && clock.Minutes <= MaxMinutes);
        }
    }
}
