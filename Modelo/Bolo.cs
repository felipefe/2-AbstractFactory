using System.Collections;

namespace AbstractFactory
{
    public abstract class Bolo : MassaBase
    {
        public Bolo(int tempoPreparo, string ingredientes)
        {
            this.TempoPreparo = tempoPreparo;
            this.Ingredientes = ingredientes;
        }
    }
}