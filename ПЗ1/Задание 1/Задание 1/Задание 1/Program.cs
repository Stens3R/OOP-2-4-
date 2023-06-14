using MeasuringDevice;

MeasureLengthDevice A = new(Units.Metric);

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

    enum Units
    {
        Metric,
        Imperial
    }

    class MeasureLengthDevice : IMeasuringDevice
    {
        private Units unitsToUse;
        private int[]? dataCaptured;
        private int mostRecentMeasure;
        private DeviceController? controller;
        private const DeviceType measurementType = DeviceType.LENGTH;


        public MeasureLengthDevice(Units unit)
        {
            unitsToUse = unit;
        }

        public int[] GetRawData()
        {
            return dataCaptured;
        }

        public decimal ImperialValue()
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

        public decimal MetricValue()
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

        public void StartCollecting()
        {
            controller = DeviceController.StartDevice();
            GetMeasurements();
        }

        public void StopCollecting()
        {
            if (controller != null)
            {
                controller.StopDevice();
                controller = null;
            }
        }

        private void GetMeasurements()
        {
            dataCaptured = new int[10];
            System.Threading.ThreadPool.QueueUserWorkItem((dummy) =>
            {
                int x = 0;
                Random timer = new Random();

                while (controller != null)
                {
                    System.Threading.Thread.Sleep(timer.Next(1000, 5000));
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
}

namespace DeviceController
{
    class DeviceController
    {
        private DeviceType deviceType;
        private Random rnd = new Random();
        public static DeviceController StartDevice()
        {
            DeviceController device = new();
            device.deviceType = DeviceType.LENGTH;
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
    enum DeviceType
    {
        LENGTH,
        MASS
    }
}