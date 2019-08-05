﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Developer
    {
        public string Name { get; set; }

        public Developer (string n)
        {
            Name = n;
        }

        abstract public House Create();

    }
}
