﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Home
    {
        public void ProvideShelter(Person person)
        {
            Console.WriteLine("Stay Home");
        }
    }
}
