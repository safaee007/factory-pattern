﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPatern
{
    class Benz : ICar
    {
        public async Task StartCar()
        {
            Console.WriteLine("Start Benz");
        }
    }
}
