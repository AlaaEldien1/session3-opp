using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_opp
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        public Duration(int hours, int minutes, int seconds)
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        public Duration(int seconds) : this(0, 0, seconds)
        {
        }
        public override string ToString()
        {
            return $"hours : {Hours}  minute : {Minutes} seconds : {Seconds}";
        }
        public override bool Equals(object obj)
        {
            if (obj is null || GetType() != obj.GetType())
            {
                return false;
            }
            Duration other = (Duration)obj;
            return other.Hours == Hours && other.Minutes == Minutes && other.Seconds == Seconds;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Hours;
            hash = hash * 23 + Minutes;
            hash = hash * 23 + Seconds;
            return hash;
        }
        public static Duration operator +(Duration obj, Duration obj2)
        {
            return new Duration(obj.Hours + obj2.Hours, obj.Minutes + obj2.Minutes, obj.Seconds + obj2.Seconds);
        }
        public static Duration operator +(Duration obj, int seonds)
        {
            Duration obj2 = new Duration(seonds);
            return obj + obj2;
        }
        public static Duration operator +(int seonds, Duration obj)
        {
            Duration obj2 = new Duration(seonds);
            return obj + obj2;
        }
        public static Duration operator ++(Duration obj)
        {

            return obj + 60;
        }
        public static Duration operator --(Duration obj)
        {
            int totalSeconds = obj.Hours * 3600 + obj.Minutes * 60 + obj.Seconds;
            if (totalSeconds > 0)
            {
                totalSeconds -= 60;
            }
            return new Duration(totalSeconds);
        }
        public static Duration operator -(Duration obj1, Duration obj2)
        {
            return new Duration(obj1.Hours - obj2.Hours, obj1.Minutes - obj2.Minutes, obj1.Seconds - obj1.Seconds);
        }
        public static bool operator >(Duration obj1, Duration obj2)
        {
            if (obj1.Hours > obj2.Hours)
                return true;
            else if (obj1.Hours < obj2.Hours)
                return false;

            if (obj1.Minutes > obj2.Minutes)
                return true;
            else if (obj1.Minutes < obj2.Minutes)
                return false;

            return obj1.Seconds > obj2.Seconds;
        }
        public static bool operator <(Duration obj1, Duration obj2)
        {
            if (obj1.Hours < obj2.Hours)
                return true;
            else if (obj1.Hours > obj2.Hours)
                return false;

            if (obj1.Minutes < obj2.Minutes)
                return true;
            else if (obj1.Minutes > obj2.Minutes)
                return false;

            return obj1.Seconds < obj2.Seconds;
        }
        public static bool operator >=(Duration obj1, Duration obj2)
        {
            if (obj1.Hours > obj2.Hours)
                return true;
            else if (obj1.Hours < obj2.Hours)
                return false;

            if (obj1.Minutes > obj2.Minutes)
                return true;
            else if (obj1.Minutes < obj2.Minutes)
                return false;

            return obj1.Seconds >= obj2.Seconds;
        }
        public static bool operator <=(Duration obj1, Duration obj2)
        {
            if (obj1.Hours < obj2.Hours)
                return true;
            else if (obj1.Hours > obj2.Hours)
                return false;

            if (obj1.Minutes < obj2.Minutes)
                return true;
            else if (obj1.Minutes > obj2.Minutes)
                return false;

            return obj1.Seconds <= obj2.Seconds;
        }
    }

}
