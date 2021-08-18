using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_HW
{
    class Measurements
    {
        int[,] februaryTemperatures { get; set; } = new int[2, 28];
        public string Location { get; set; }
        public int Date { get; set; }
        public int ValueOfMeasurement { get; set; }

        public Measurements(string location, int date)
        {
            Location = location;
            Date = date;

            Random randomTemperature = new Random();
            int day = 1;
            for (int i = 0; i < februaryTemperatures.GetLength(0); i++)
            {
                if (i == 0)
                {

                    for (int i2 = 0; i2 < februaryTemperatures.GetLength(1); i2++)
                    {
                        februaryTemperatures[i, i2] = day;
                        day++;
                    }
                }
                else
                {
                    for (int i2 = 0; i2 < februaryTemperatures.GetLength(1); i2++)
                    {
                        februaryTemperatures[i, i2] = randomTemperature.Next(24, 41);
                    }
                }
            }

            ValueOfMeasurement = februaryTemperatures[1, date];
        }
    }
}
