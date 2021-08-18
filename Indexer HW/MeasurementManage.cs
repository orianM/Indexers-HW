using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_HW
{
    class MeasurementManage
    {
        public Measurements[] measurements;

        public MeasurementManage(Measurements[] measurements)
        {
            this.measurements = measurements;
        }

        public int this[int day]
        {
            get
            {
                foreach (var getTemperature in measurements)
                {
                    if (getTemperature.Date == day)
                    {
                        return getTemperature.ValueOfMeasurement;
                    }
                }
                return 0;
            }
        }

        public int this[string city]
        {
            get
            {
                foreach (var getLocation in measurements)
                {
                    if (getLocation.Location.ToLower() == city.ToLower())
                    {
                        return getLocation.ValueOfMeasurement;
                    }
                }
                return 0;
            }
        }

        public bool this[string city, int day]
        {
            get
            {
                foreach (var getIfMeasured in measurements)
                {
                    if (getIfMeasured.Location.ToLower() == city.ToLower() && getIfMeasured.Date == day)
                    {
                        return true;
                    }
                }
                return false;
            }
        }


    }
}
