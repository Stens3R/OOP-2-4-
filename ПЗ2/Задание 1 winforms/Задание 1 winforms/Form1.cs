using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Задание_1_winforms.MeasuringDevice;

namespace Задание_1_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dataGridView2.RowCount = 10;
            dataGridView1.RowCount = 10;
            //dataGridView2.ColumnCount = 1;
            dataGridView1.ColumnCount = 1;

            radioButton_mass_device.Checked = true;
            radioButton_imperial_value.Checked = true;
        }

        MeasureDataDevice A;


        private void start_colection_button_Click(object sender, EventArgs e)
        {
            A.NewMeasurementTaken += device_NewMeasurementTaken;
            A.StartCollecting();
        }

        private void stop_colection_button_Click(object sender, EventArgs e)
        {
            A.NewMeasurementTaken -= device_NewMeasurementTaken;
            A.StopCollecting();
        }

        void device_NewMeasurementTaken(object sender, EventArgs e)
        {
            metricValueBox.Text = A.MetricValue().ToString();
            imperialValueBox.Text = A.ImperialValue().ToString();
            most_recent_valueTextBox.Text = A.mostRecentMeasure.ToString();
            int[] arr = A.GetRawData();
            for(int i = 0; i < 10; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = arr[i];
            }
            A.StopCollecting();
        }

        private void create_class_button_Click(object sender, EventArgs e)
        {
            Units value;
            switch (radioButton_metric_value.Checked)
            {
                case true:
                    {
                        value = Units.Metric;
                        break;
                    }
                default:
                    {
                        value = Units.Imperial;
                        break;
                    }
            }
            switch (radioButton_mass_device.Checked)
            {
                case true:
                    {
                        A = new MeasureMassDevice(value);
                        break;
                    }
                default:
                    {
                        A = new MeasureLengthDevice(value);
                        break;
                    }
            }
        }

        private void destroy_class_button_Click(object sender, EventArgs e)
        {
            A.Dispose();
        }
    }
    namespace MeasuringDevice
    {
        using DeviceController;
        using System.ComponentModel;
        using System.IO;

        public enum Units
        {
            Metric,
            Imperial
        }
        public interface IMeasuringDevice
        {
            /// <summary>
            /// Converts the raw data collected by the measuring device into a metric value.
            /// </summary>
            /// <returns>The latest measurement from the device converted to metric units.</returns>
            decimal MetricValue();
            /// <summary>
            /// Converts the raw data collected by the measuring device into an imperial value.
            /// </summary>
            /// <returns>The latest measurement from the device converted to imperial units.</returns>
            decimal ImperialValue();
            /// <summary>
            /// Starts the measuring device.
            /// </summary>
            void StartCollecting();
            /// <summary>
            /// Stops the measuring device. 
            /// </summary>
            void StopCollecting();
            /// <summary
            /// Enables access to the raw data from the device in whatever units are native to the device
            /// </summary>
            /// <returns>The raw data from the device in native format.</returns>
            int[] GetRawData();
            /// <summary>
            /// Returns the file name of the logging file for the device.
            /// </summary>
            /// <returns>The file name of the logging file.</returns>
            string GetLoggingFile();
            /// <summary>
            /// Gets the Units used natively by the device.
            /// </summary>
            Units unitsToUse { get; set; }
            /// <summary>
            /// Gets an array of the measurements taken by the device.
            /// </summary>
            int[] DataCaptured { get; }
            /// <summary>
            /// Gets the most recent measurement taken by the device.
            /// </summary>
            int MostRecentMeasure { get; }
            /// <summary>
            /// Gets or sets the name of the logging file used. 
            /// If the logging file changes this closes the current file and creates the new file
            /// </summary>
            string LoggingFileName { get; set; }
        }

        interface IEventEnabledMeasuringDevice : IMeasuringDevice
        {
            event EventHandler NewMeasurementTaken;
            // Event that fires every heartbeat.
            // event HeartBeatEventHandler HeartBeat;
            // Read only heartbeat interval - set in constructor.
            int HeartBeatInterval { get; }
        }

        public abstract class MeasureDataDevice : IEventEnabledMeasuringDevice
        {

            public int HeartBeatInterval { get; }

            public Units unitsToUse { get; set; }

            public int[] DataCaptured { get; }

            public int MostRecentMeasure { get; }

            public string LoggingFileName { get; set; } = "Файл";

            public int[] dataCaptured;
            public int mostRecentMeasure;
            public DeviceController controller;
            public DeviceType measurementType;
            public StreamWriter LoggingFileWriter;

            public event EventHandler NewMeasurementTaken;
            // public event HeartBeatEventHandler HeartBeat;

            public BackgroundWorker dataCollector;

            event EventHandler IEventEnabledMeasuringDevice.NewMeasurementTaken
            {
                add
                {
                    NewMeasurementTaken += value;
                }

                remove
                {
                    NewMeasurementTaken -= value;
                }
            }

            protected virtual void OnNewMeasurementTaken()
            {
                NewMeasurementTaken?.Invoke(this, null);
            }
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
                LoggingFileWriter = new StreamWriter(LoggingFileName, true);
                GetMeasurements();
            }
            /// <summary>
            /// Stops the measuring device.
            /// </summary>
            public void StopCollecting()
            {
                if (dataCollector != null)
                {
                    dataCollector.CancelAsync();
                }
                if (controller != null)
                {
                    controller.StopDevice();
                    controller = null;
                }
            }
            private void GetMeasurements()
            {
                dataCollector = new BackgroundWorker();
                dataCollector.WorkerSupportsCancellation = true;
                dataCollector.WorkerReportsProgress = true;
                dataCollector.DoWork += new DoWorkEventHandler(DataCollector_DoWork);
                dataCollector.RunWorkerAsync();

                ProgressChangedEventHandler progressChangedEventHandler = DataCollector_ProgressChanged;
                dataCollector.ProgressChanged += progressChangedEventHandler;

            }

            private void DataCollector_ProgressChanged(object sender, ProgressChangedEventArgs e)
            {
                OnNewMeasurementTaken();
            }

            private void DataCollector_DoWork(object sender, DoWorkEventArgs e)
            {
                dataCaptured = new int[10];
                int x = 0;
                Random timer = new Random();
                while (dataCollector.CancellationPending == false)
                {
                    dataCaptured[x] = controller != null ?
                            controller.TakeMeasurement() : dataCaptured[x];
                    mostRecentMeasure = dataCaptured[x];
                    x++;
                    if (x > 9)
                    {
                        x = 0;
                    }
                    dataCollector.ReportProgress(0);
                    if (LoggingFileWriter != null)
                    {
                        LoggingFileWriter.WriteLine($"Measurment - {mostRecentMeasure}");
                    }
                }
            }

            public void Dispose()
            {
                if (dataCollector != null)
                {
                    dataCollector.Dispose();
                }
            }

            public string GetLoggingFile()
            {
                throw new NotImplementedException();
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
                DeviceController device = new DeviceController();
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
}
