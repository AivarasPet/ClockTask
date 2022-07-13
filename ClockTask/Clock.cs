using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTask
{
    public class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public float GetClockDegree()
        {
            if(!ClockValidator.IsValid(this))
            {
                throw new InvalidClockTimeException();
            }
            float hoursArrowPositionInMinutes = 5 * (Hours + ((float) Minutes / 60));
            float differenceInMinutes = Math.Abs(hoursArrowPositionInMinutes - Minutes);
            float degrees = differenceInMinutes / 60 * 360;
            if (degrees > 180)
            {
                degrees = 360 - degrees;
            }
            return degrees;
        }
    }

    [Serializable]
    public class InvalidClockTimeException : Exception
    {
    }
}
