using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Measurements m1 = new Measurements("City1", 3);
            Measurements m2 = new Measurements("City2", 5);
            Measurements m3 = new Measurements("City3", 7);
            Measurements[] measurements = { m1, m2, m3 };
            MeasurementManage allMeasurements = new MeasurementManage(measurements);
            var measurement1 = allMeasurements[3];
            var measurement2 = allMeasurements[7];
            var measurement3 = allMeasurements[5];

            Console.WriteLine("February Temperatures");
            Console.WriteLine($"\nday 3: {measurement1}c\nday 7: {measurement2}c\nday 5: {measurement3}c");

            var measurement11 = allMeasurements["city1"];
            var measurement22 = allMeasurements["City2"];
            var measurement33 = allMeasurements["city3"];

            Console.WriteLine("\nFebruary locations");
            Console.WriteLine($"\nCity1 temp: {measurement11}c\nCity2 temp: {measurement22}c\nCity3 temp: {measurement33}c");

            var measurement111 = allMeasurements["city1", 6];
            var measurement222 = allMeasurements["city2", 5];
            var measurement333 = allMeasurements["city3", 10];

            Console.WriteLine("\nFebruary day & city measured true/false ");
            Console.WriteLine($"\ncity1 measured: {measurement111}\ncity2 measured: {measurement222}\ncity3 measured: {measurement333}");
        }
    }
}
