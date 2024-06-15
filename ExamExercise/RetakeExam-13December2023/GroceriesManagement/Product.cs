namespace GroceriesManagement
{
    public class Product
    {
        //You are given a class Product with the following properties:
        // •	Name – string
        // •	Price - double
        // The class constructor should receive name and price. 
        // •	Override the ToString() method in the following format:
        // "{Name}: {Price:F2}$"
        private string name;
        private double price;
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return ($"{Name}: {Price:F2}$");
        }

    }
    
}
