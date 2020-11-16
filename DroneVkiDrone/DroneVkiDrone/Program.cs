using System;
using System.Collections.Generic;

namespace DroneVKI
{
    class Program
    {
        static void Main(string[] args)
        {
            var drone = new Drone();
            var signal = new Mail { Adres = "random1@gmail.com" };
            var signal2 = new Mail { Adres = "random2@gmail.com" };
            drone.AddObserver(signal);
            drone.AddObserver(signal2);

            drone.AddOrder("Signal:", "Active mode");

            drone.RemoveObserver(signal2);

            drone.AddOrder("Signal2:", "Error mode");

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
            var signal = $"{title} : {text}";
            NotifyObservers(signal);
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

