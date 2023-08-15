using System.Collections;

namespace AbstractFactory
{
    public abstract class Pizza : MassaBase
    {
        public Pizza(int tempoPreparo, string ingredientes)
        {
            this.TempoPreparo = tempoPreparo;
            this.Ingredientes = ingredientes;
        }
    }
}