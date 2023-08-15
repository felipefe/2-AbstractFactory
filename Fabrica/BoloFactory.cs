namespace AbstractFactory
{
    public class BoloFactory : MassaAbstractFactory
    {

        private int tipoBolo;
        private Dictionary<int, Func<MassaBase>> dicionario = new Dictionary<int, Func<MassaBase>>
        {
            {1 , () => new BoloChocolate(10, "Farinha, Cacau")  },
            {2 , () => new BoloLaranja(10, "Farinha, Laranja")  },
        };

        public BoloFactory(int _tipoBolo)
        {
            tipoBolo = _tipoBolo;
        }

        public override MassaBase CriarMassa()
        {
            dicionario.TryGetValue(tipoBolo, out Func<MassaBase> massa);
            return massa.Invoke();
        }
    }
}