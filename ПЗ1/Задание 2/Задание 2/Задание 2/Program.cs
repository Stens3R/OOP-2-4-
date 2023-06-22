using MeasuringDevice;

MeasureMassDevice A = new(Units.Metric);

A.StartCollecting();
System.Threading.Thread.Sleep(5000);
int[] data = A.GetRawData();
foreach (int i in data)
{
    Console.WriteLine(i);
}
Console.WriteLine("===================");
Console.WriteLine(A.MetricValue());
Console.WriteLine(A.ImperialValue());


namespace MeasuringDevice
{
    using DeviceController;

    public interface IMeasuringDevice
    {
        /// <summary>/// Converts the raw data collected by the measuring device into a metric value
        /// </summary>
        ///<returns>The latest measurement from the device converted to metric units.</returns>
        decimal MetricValue();
        /// <summary>
        /// Converts the raw data collected by the measuring device into an imperial value.
        /// </summary>
        ///<returns>The latest measurement from the device converted to imperial units.</returns>
        decimal ImperialValue();
        /// <summary>
        /// Starts the measuring device.
        /// </summary>
        void StartCollecting();
        /// <summary>
        /// Stops the measuring device. 
        /// </summary>
        void StopCollecting();
        /// <summary>
        /// Enables access to the raw data from the device in whatever units are native to the device
        /// </summary>
        /// <returns>The raw data from the device in native format.</returns>
        int[] GetRawData();
    }

    public enum Units
    {
        Metric,
        Imperial
    }
    public abstract class MeasureDataDevice : IMeasuringDevice
    {
        public Units unitsToUse;
        public int[]? dataCaptured;
        public int mostRecentMeasure;
        public DeviceController? controller;
        public DeviceType measurementType;


        /// <summary>
        /// Converts the raw data collected by the measuring device into a metric value.
        /// </summary>
        /// <returns>The latest measurement from the device converted to metric units.</returns>
        public int[] GetRawData()
        {
            return dataCaptured;
        }
        public abstract decimal MetricValue();
        /// <summary>
        /// Converts the raw data collected by the measuring device into an imperial value.
        /// </summary>
        ///<returns>The latest measurement from the device converted to imperial units.</returns>
        public abstract decimal ImperialValue();
        /// <summary>
        /// Starts the measuring device.
        /// </summary>
        public void StartCollecting()
        {
            controller = DeviceController.StartDevice(measurementType);
            GetMeasurements();
        }
        /// <summary>
        /// Stops the measuring device.
        /// </summary>
        public void StopCollecting()
        {
            if (controller != null)
            {
                controller.StopDevice();
                controller = null;
            }
        }
        public void GetMeasurements()
        {
            dataCaptured = new int[10];
            System.Threading.ThreadPool.QueueUserWorkItem((dummy) =>
            {
                int x = 0;
                Random timer = new Random();
                while (controller != null)
                {
                    System.Threading.Thread.Sleep(timer.Next(500, 1000));
                    dataCaptured[x] = controller != null ?
                        controller.TakeMeasurement() : dataCaptured[x];
                    mostRecentMeasure = dataCaptured[x];
                    x++;
                    if (x == 10)
                    {
                        x = 0;
                    }
                }
            });
        }
    }

    class MeasureMassDevice : MeasureDataDevice
    {
        public MeasureMassDevice(Units unit)
        {
            unitsToUse = unit;
            measurementType = DeviceType.MASS;
        }

        public override decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial)
            {
                return mostRecentMeasure;
            }
            else
            {
                return mostRecentMeasure * 2.2046m;
            }
        }

        public override decimal MetricValue()
        {
            if (unitsToUse == Units.Metric)
            {
                return mostRecentMeasure;
            }
            else
            {
                return mostRecentMeasure * 0.4536m;
            }
        }
    }

    class MeasureLengthDevice : MeasureDataDevice
    {

        public MeasureLengthDevice(Units unit)
        {
            unitsToUse = unit;
            measurementType = DeviceType.LENGTH;
        }
        public override decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial)
            {
                return mostRecentMeasure;
            }
            else
            {
                return mostRecentMeasure * 0.03937m;
            }
        }

        public override decimal MetricValue()
        {
            if (unitsToUse == Units.Metric)
            {
                return mostRecentMeasure;
            }
            else
            {
                return mostRecentMeasure * 25.4m;
            }
        }
    }
}

namespace DeviceController
{
    public class DeviceController
    {
        private DeviceType deviceType;
        private Random rnd = new Random();
        public static DeviceController StartDevice(DeviceType deviceType)
        {
            DeviceController device = new();
            device.deviceType = deviceType;
            return device;
        }

        public void StopDevice()
        {

        }

        public int TakeMeasurement()
        {
            return rnd.Next(1, 101);
        }
    }
    public enum DeviceType
    {
        LENGTH,
        MASS
    }
}