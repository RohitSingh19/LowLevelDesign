using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesign.DesignPattern.Observer
{
    public class UserService
    {
        private List<IObserver> _observers = new List<IObserver>();
        public UserService(List<IObserver> observers)
        {
             _observers = observers.ToList();
        }
        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer) { _observers.Remove(observer); }
        public void RegisterUser(User user)
        {
            Console.WriteLine("User registered");
            Notify(user);
        }
        private void Notify(User user)
        {
            foreach (IObserver observer in _observers) 
            {
                observer.Update(user);
            }
        }
    }
}
