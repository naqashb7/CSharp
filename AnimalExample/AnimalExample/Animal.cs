using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExample
{
    public abstract class Animal
    {

        ///////////////////////////////////////////Attributes///////////////////////////////

        private int age;
        private string name;

        ///////////////////////////////////////////Constructors/////////////////////////////
        public Animal()
            :base()
        {
            age = 1;
            name = "Bob";

        }


        ////////////////////////////////////////////Methods/////////////////////////////////
        public abstract void eat(String food);
        public void sleep(int lengthOfSleep)
        {
            //sleep method
        }
        public abstract Animal reproduce(Animal[] parent);
        public abstract void breathe();
        public String poo()
        {
            return "I have logged this";
        }
        public void die()
        {
            //die method
        }
    }
}
