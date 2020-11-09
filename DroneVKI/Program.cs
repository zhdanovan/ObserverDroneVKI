using System;
using System.Collections.Generic;

namespace DroneVKI
{
    class Program
    {
        static void Main(string[] args)
        {
            var drone = new Drone();
            var order = new Mail { Adres = "random1@gmail.com" };
            var order2 = new Mail { Adres = "random2@gmail.com" };
            drone.AddObserver(order);
            drone.AddObserver(order2);

            drone.AddOrder("Order:", "Chocolate");

            drone.RemoveObserver(order2);

            drone.AddOrder("Order2:", "Ham");

            Console.ReadKey();
        }
    }

    interface IObservable
    {
        void AddObserver(IObserver obs);

        void RemoveObserver(IObserver obs);

        void NotifyObservers(object data);
    }

    class Drone : IObservable
    {
        private List<IObserver> observers;

        public Drone()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void NotifyObservers(object data)
        {
            foreach (IObserver observer in observers)
                observer.Update(data);
        }

        public void AddOrder(string title, string text)
        {
            var order = $"{title} : {text}";
            NotifyObservers(order);
        }
    }

    interface IObserver
    {
        void Update(object data);
    }

    class Mail : IObserver
    {
        public string Adres { get; set; }

        public void Update(object data)
        {
            Console.WriteLine(data + " sent on " + Adres);
        }

    }
}
    