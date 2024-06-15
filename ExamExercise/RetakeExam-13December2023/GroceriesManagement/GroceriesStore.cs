using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
        //Next, you have a Groceries class that contains Stall (a collection for storing products). All entries inside the repository have the same properties.
        //The GroceriesStore class should have the following properties:
        //•	Capacity – int
        // •	Turnover - double
        // •	Stall – List<Product>
        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
        }

        public int Capacity { get; set; }
        public double Turnover { get; set; }


        public List<Product> Stall { get; set; }
        //The class constructor should receive capacity, to set the Turnover's initial value to Zero and initialize Stall with new instance of the collection. 

        public void AddProduct(Product product)
        {
            //adds a product to the Stall collection, if the Capacity allows it. If there is a Product with the same name already added, do not duplicate products, just skip the command.
            if (Stall.Contains(product) || Stall.Count == Capacity)
            {
                return;
            }

            Stall.Add(product);
        }

        public bool RemoveProduct(string name) => Stall.Remove(Stall.FirstOrDefault(n => n.Name == name));
        //attempts to find a product by the given name within the store's stall. If the product is found, it is removed from the stall and the method returns true.
        //If the product with the specified name does not exist in the stall, the method returns false
        public string SellProduct(string name, double quantity)
        {
            //increases the Turnover by the product's price multiplied by the quantity,
            //rounded to the second decimal place and returns a string in the format {ProductName} - {TotalPrice:F2}$.
            //If the product is not found, return "Product not found".
            if (!Stall.Any(p => p.Name == name))
            {
                return $"Product not found";
            }

            Product product = Stall.First(p => p.Name == name);
            double totalPrice = Math.Round(product.Price * quantity, 2);//rounded to the second decimal place (2)
            Turnover += totalPrice;
            return $"{product.Name} - {totalPrice:F2}$";
        }
        //returns the ToString value of the most expensive Product from the Stall.
        public string GetMostExpensive() => Stall.OrderByDescending(p => p.Price).FirstOrDefault().ToString();
       // returns a formatted string that includes the Turnover property, which represents the total amount of money the store has made from selling products:
       // "Total Turnover: {Turnover:F2}$"
       public string CashReport() => $"Total Turnover: {Turnover:F2}$";

        //•	Method PriceList() – returns a string in the following format:
        // o	"Groceries Price List:
        // {Product1}
        // {Product2}
        // {…}
        // {Productn}"
        public string PriceList()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Groceries Price List:");
            foreach (Product product in Stall)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString().Trim();//маха последния интервал trim()
        }

    }
}
