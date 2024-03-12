using System;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern.Example1
{
    public class ObserverExample1 : MonoBehaviour
    {
        private void Start()
        {
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Add(new Investor("Atakan"));
            ibm.Add(new Investor("Atakan2"));
            
            ibm.Price = 120.10;
            ibm.Price = 120.20;
            ibm.Price = 120.30;
            
        }
    }
    
    
    //Subject
    abstract class Stock
    {
        private string _symbol;
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        public Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public void Add(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Remove(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
            Debug.Log("Stock Notify( ) called");
        }

        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                    
                }
            }
            
        }
        public string Symbol => _symbol;
        
        
    }
    
    
    // The 'ConcreteSubject' class

    class IBM : Stock
    {
        public IBM(string symbol, double price) : base(symbol, price)
        {
        }
    }

    interface IInvestor
    {
        void Update(Stock stock);
    }

    class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;

        // Constructor
        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Debug.Log("Notified "+ _name+" of "+ stock+"'s " + "change to "+stock.Price);
        }

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}