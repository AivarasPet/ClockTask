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

        private const int fullCircleRadius = 360;

        public float GetClockDegree()
        {
            if(!ClockValidator.IsValid(this))
            {
                throw new InvalidClockTimeException();
            }
            float hoursArrowPositionInMinutes = 5 * (Hours + ((float) Minutes / 60));
            float differenceInMinutes = Math.Abs(hoursArrowPositionInMinutes - Minutes);
            float degrees = differenceInMinutes / 60 * fullCircleRadius;
            if (degrees > fullCircleRadius / 2)
            {
                degrees = fullCircleRadius - degrees;
            }
            return degrees;
        }
    }

    [Serializable]
    public class InvalidClockTimeException : Exception
    {
    }
}
