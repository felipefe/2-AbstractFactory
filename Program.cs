namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            MassaAbstractFactory fabrica = null;
            MassaBase massa = null;

            TipoMassa tipoMassa = TipoMassa.Bolo;
            int tipoBolo = (int)TipoBolo.Laranja;
            int tipoPizza = (int)TipoPizza.Mussarela;

            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                    fabrica = new PizzaFactory(tipoPizza);
                    break;
                case TipoMassa.Bolo:
                    fabrica = new BoloFactory(tipoBolo);
                    break;
            }

            massa = fabrica.CriarMassa();

            Console.WriteLine($"Tempo preparo: {massa.TempoPreparo} Ingredientes: {massa.Ingredientes}");

        }
    }
}
