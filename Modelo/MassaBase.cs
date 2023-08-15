using System.Collections;

namespace AbstractFactory
{
    public class MassaBase
    {
        public int TempoPreparo;
        public string Ingredientes;
        
    }

        public enum TipoBolo : int
    {
        Chocolate = 1,
        Laranja = 2,
    }

    public enum TipoPizza : int
    {
        Calabresa = 1,
        Mussarela = 2,
    }

    public enum TipoMassa
    {
        Pizza,
        Bolo,
    }
}