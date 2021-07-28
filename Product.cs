namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Product))
            {
                return false;
            }
            return Name.Equals((obj as Product).Name) && Price.Equals((obj as Product).Price);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
