using System;

interface Sensor
{
    public static int getTemperature(int t)
    {
        return t;
    }
}

class SoftwareSensor
{
    public int Temperature;
    
    public void printTemperature()
    {
        Console.WriteLine($"Температура равна {Temperature}");
    }
}

class AdapterSensor : Sensor
{
    public static int getTemperature(int t)
    {
        int c = (t - 32) * 5 / 9;
        return c;
    }
    
}

class Program
{
    static void Main()
    {
        SoftwareSensor s = new SoftwareSensor();
        s.Temperature = AdapterSensor.getTemperature(32);
        
        s.printTemperature();
    }
}
