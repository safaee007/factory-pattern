using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPatern
{
    public class CarFactory
    {
        public ICar GetCar(string type)
        {
            ICar retVal = null;

            if(type == "B")
            {
                retVal = new Benz();
            }
            else if (type == "F")
            {
                retVal = new Ford();
            }

            return retVal;
        }
    }
}
