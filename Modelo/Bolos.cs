using System.Collections;

namespace AbstractFactory
{
    public class BoloLaranja : Bolo
    {
        public BoloLaranja(int tempoPreparo, string ingredientes) : base(tempoPreparo, ingredientes)
        {
        }
    }

    //-------------------------------

    public class BoloChocolate : Bolo
    {
        public BoloChocolate(int tempoPreparo, string ingredientes) : base(tempoPreparo, ingredientes)
        {
        }
    }

}