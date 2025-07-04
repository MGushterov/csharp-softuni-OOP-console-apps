﻿namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine) 
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        private const decimal CoffeePrice = 3.50m;
        private const double CoffeeMilliliters = 50;
        public double Caffeine { get; set; }

    }
}
