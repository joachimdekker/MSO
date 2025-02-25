﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    abstract class Condiment
    {
        protected Condiment()
        {

        }
    }

    class Milk : Condiment
    {
        public int Quantity { get; set; }
        public Milk(int q = 1) : base()
        {
            Quantity = q;
        }

        public string Make()
        {
            return " + milk";
        }

        public decimal Price()
        {
            return 0.50m;
        }
    }

    class Cacao : Condiment
    {
        public Cacao() : base()
        {

        }
        public string Make()
        {
            return " + cacao";
        }

        public decimal Price()
        {
            return 0.25m;
        }
    }

    public enum SyrupType { Caramel, Chocolate, Hazelnut }
    class Syrup : Condiment
    {
        private SyrupType _syrupType;
        public Syrup(SyrupType type) : base()
        {
            _syrupType = type;
        }
        public string Make()
        {
            return $"{_syrupType} syrup ";
        }

        public decimal Price()
        {
            return 0.55m;
        }
    }
}
