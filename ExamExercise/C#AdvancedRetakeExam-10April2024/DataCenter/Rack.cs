using System.Text;

namespace DataCenter
{
    public class Rack
    {

        private int slots;
        private List<Server> servers;

        public Rack(int slots)
        {
            Slots = slots;
            Servers = new List<Server>();
        }
        public int Slots { get => slots; set => slots = value; }
        public List<Server> Servers { get => servers; set => servers = value; }

        public int GetCount => Servers.Count;
        //•	AddServer(Server server) – adds a Server to the Servers collection, if there are  Slots available.
        //If a Server with the same SerialNumber is already added, do not duplicate servers, just skip the command.
        public void AddServer(Server server)
        {
            if (GetCount < Slots && (!Servers.Any(x => x.SerialNumber == server.SerialNumber)))
            {
                Servers.Add(server);

            }
        }
        //•	RemoveServer(string serialNumber) – attempts to find a Server, within the Servers collection,
        //with SerialNumber value, matching the given parameter. 
        //o If no sever is found, the method returns boolean value - False
        //o   Otherwise, the server is removed from the collection and the method returns boolean value - True
        public bool RemoveServer(string serialNumber)
        {
            var serverToRemove = Servers.Where(x => x.SerialNumber == serialNumber);
            if (serverToRemove.Any())
            {
                Servers.Remove(serverToRemove.First());
                return true;
            }
            return false;
        }
        //•	GetHighestPowerUsage() – returns the ToString() value of the component with the greatest PowerUsage value,
        //among the Servers collection.
        public string GetHighestPowerUsage()
       => Servers.OrderByDescending(x => x.PowerUsage)
            .FirstOrDefault()
            .ToString();
        //•	GetTotalCapacity() – returns the sum of the Capacity of all servers added to the collection.
        public int GetTotalCapacity() => Servers.Sum(x => x.Capacity);
        /*•	DeviceManager() – returns a string format listing all operating servers:
       o	"{count} servers operating:
       {server1}
       {server2}
       {…}
       {servern}"
       */
        public string DeviceManager()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Servers.Count} servers operating:");
            foreach (Server server in Servers)
            {
                sb.AppendLine(server.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
