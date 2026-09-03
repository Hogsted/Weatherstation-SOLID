using System;
using Weatherstation.Class;
using Weatherstation.Interface;

Random r = new Random();
WeatherStation station = new WeatherStation();

Display display = new Display();
Logger logger = new Logger();
Dingenot dingenot = new Dingenot();

station.Attach(dingenot);
station.Attach(display);
station.Attach(logger);

for (int i = 0; i < 10; i++)
{
    station.SetTemperature(r.Next(12, 30));
    Thread.Sleep(1000);
}
Console.ReadLine();
