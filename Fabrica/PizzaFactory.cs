namespace AbstractFactory
{
    public class PizzaFactory : MassaAbstractFactory
    {

        private int tipoPizza;
        private Dictionary<int, Func<MassaBase>> dicionario = new Dictionary<int, Func<MassaBase>>
        {
            {1, () => new PizzaCalabresa(20, "Molho Calabresa") },
            {2, () => new PizzaCalabresa(15, "Molho Mussarela") },
        };

        public PizzaFactory(int _tipoPizza)
        {
            tipoPizza = _tipoPizza;
        }

        public override MassaBase CriarMassa()
        {
            dicionario.TryGetValue(tipoPizza, out Func<MassaBase> massa);
            return massa.Invoke();
        }
    }
}