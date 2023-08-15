using System.Collections;

namespace AbstractFactory
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(int tempoPreparo, string ingredientes) : base(tempoPreparo, ingredientes)
        {
        }
    }

    //-------------------------------

    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(int tempoPreparo, string ingredientes) : base(tempoPreparo, ingredientes)
        {
        }
    }

}