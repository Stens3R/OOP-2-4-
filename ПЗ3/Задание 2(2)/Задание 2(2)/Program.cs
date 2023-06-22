using System;
// Патерн поведения (наблюдатель)
PhysicalLightSensor sensor = new PhysicalLightSensor();
LightSensorProcessor processor = new LightSensorProcessor();
Flashlight flashlight = new Flashlight();
sensor.RegisterObserver(processor);
processor.RegisterObserver(flashlight);

while (true)
{
    Console.WriteLine($"Сейчас уровень освещенности: {sensor.Light}");
    sensor.Light += 10;
    Console.WriteLine($"Напряжение с датчика: {processor.Voltage}");
    Thread.Sleep(1000);
}

interface IObserver
{
    void Update(Object ob);
}

interface IObservable
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}

class PhysicalLightSensor : IObservable
{
    private int light;
    public int Light { get => light; set { NotifyObservers(); light = value > 100 ? 0 : value;  } }
    List<IObserver>? observers;
    public PhysicalLightSensor()
    {
        observers = new List<IObserver>();
        light = 40;
    }


    public void NotifyObservers()
    {
        if (observers != null)
        {
            foreach (IObserver o in observers)
            {
                o.Update(to_voltage(light));
            }
        }
    }

    public void RegisterObserver(IObserver o)
    {
        observers?.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers?.Remove(o);
    }

    private int to_voltage(int light) => light;
}

class LightSensorProcessor : IObservable, IObserver
{
    int voltage;
    public int Voltage { get => voltage;set {voltage = value; } }
    List<IObserver>? observers;

    public LightSensorProcessor()
    {
        voltage = 0;
        observers = new List<IObserver>();
    }
    public void NotifyObservers()
    {
        if (observers != null)
        {
            foreach (IObserver o in observers)
            {
                o.Update(voltage_to_bool(voltage));
            }
        }
    }

    public void RegisterObserver(IObserver o)
    {
        observers?.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers?.Remove(o);
    }

    public void Update(object ob)
    {
        voltage = ob is int ? (int)ob : 0;
        NotifyObservers();
    }
    private bool voltage_to_bool(int voltage)
    {
        return (voltage > 40);
    }
}

class Flashlight : IObserver
{
    public void Update(object ob)
    {
        if (ob is bool ? (bool)ob : false)
        {
            Console.WriteLine("Свет включён");
        }
        else 
        {
            Console.WriteLine("Свет выключен");
        }
    }
}