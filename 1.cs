using System;
using System.Collections.Generic;

// Абстрактний клас Транспортний засіб
public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

// Клас Human
public class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human is walking.");
    }
}

// Спадкоємці класу Транспортний засіб
public class Car : Vehicle
{
    public Car()
    {
        Speed = 100;
        Capacity = 4;
    }

    public override void Move()
    {
        Console.WriteLine("Car is driving.");
    }
}

public class Bus : Vehicle
{
    public Bus()
    {
        Speed = 60;
        Capacity = 50;
    }

    public override void Move()
    {
        Console.WriteLine("Bus is moving.");
    }
}

public class Train : Vehicle
{
    public Train()
    {
        Speed = 120;
        Capacity = 200;
    }

    public override void Move()
    {
        Console.WriteLine("Train is running on tracks.");
    }
}

// Клас Маршрут
public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
}

// Клас для контролю руху транспорту
public class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    private List<Route> routes = new List<Route>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void AddRoute(Route route)
    {
        routes.Add(route);
    }

    public void MoveAllVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }

    public void CalculateOptimalRoute()
    {
        // Розрахунок оптимального маршруту залежно від виду транспорту
        foreach (var route in routes)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car && route.StartPoint == "CityA" && route.EndPoint == "CityB")
                {
                    Console.WriteLine("Optimal route for Car from CityA to CityB");
                }
                else if (vehicle is Bus && route.StartPoint == "CityA" && route.EndPoint == "CityC")
                {
                    Console.WriteLine("Optimal route for Bus from CityA to CityC");
                }
                // Додайте інші варіанти маршрутів для інших видів транспорту
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();

        TransportNetwork network = new TransportNetwork();
        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        network.CalculateOptimalRoute();

        network.MoveAllVehicles();
    }
}
