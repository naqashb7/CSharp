using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExample
{
    public class Bat : Mammal , Flying
    {

        ///////////////////////Attributes////////////
        ///




        //////////////////Constructors//////////////



        //////////////////Methods/////////////////////


        public override void eat(string food)
        {
            ///////implement this later
        }

        public void flight()
        {
            Console.WriteLine("I am FLYING!");
        }

        public void landing()
        {
            throw new NotImplementedException();
        }

        public void takeOff()
        {
            throw new NotImplementedException();
        }
    }
}
