namespace LeGrandRestaurant
{
    public class Table
    {
        public void Affecter(Client client)
        {
            EstLibre = false;
        }

        public void Libérer()
        {
            EstLibre = true;
        }

        internal bool EstLibre { get; private set; } = true;
    }
}
