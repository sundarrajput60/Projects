using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class School
    {
        public void Teach(Person person)
        {
            Console.WriteLine("Teaching a person");
        }
    }
}
