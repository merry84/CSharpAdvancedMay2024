namespace DataCenter
{
    public class Server
    {
        /*First, create a class Server with the following properties:
         •	SerialNumber - string
         •	Model - string
         •	Capacity - int
         •	PowerUsage - int
         The class constructor should receive serialNumber, model, capacity and powerUsage.
         Override the ToString() method in the following format:
         "Server {SerialNumber}: {Model}, {Capacity}TB, {PowerUsage}W"
         */
        private string serialNumber;
        private string model;
        private int capacity;
        private int powerUsage;

        public Server(string serialNumber, string model, int capacity, int powerUsage)
        {
            SerialNumber = serialNumber;
            Model = model;
            Capacity = capacity;
            PowerUsage = powerUsage;
        }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Model { get => model; set => model = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int PowerUsage { get => powerUsage; set => powerUsage = value; }

        public override string ToString()
        => $"Server {SerialNumber}: {Model}, {Capacity}TB, {PowerUsage}W";


    }
}
