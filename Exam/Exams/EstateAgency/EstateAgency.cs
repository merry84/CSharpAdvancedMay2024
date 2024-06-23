using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;

namespace EstateAgency
{
    public class EstateAgency
    {
        /*Next, you are given a class EstateAgency that has RealEstates (a List that stores RealEstate objects). The EstateAgency class should have the following properties:
        •	Capacity - int
        •	RealEstates – List<RealEstate>
        •	Count  - int - returns the number of real estates, in the EstateAgency.
        The class constructor should receive capacity and initialize the RealEstates with a new instance of the collection.
        */
        private List<RealEstate> realEstates;

        public EstateAgency(int capacity)
        {
            Capacity = capacity;
            RealEstates = new List<RealEstate>();//?
        }

        public int Capacity { get; set; }
        public List<RealEstate> RealEstates { get => realEstates; set => realEstates = value; }//?
        public int Count => realEstates.Count;
        //•	Method AddRealEstate(RealEstate realEstate)
        //– adds a new real estate to the collection of RealEstates,if the Capacity allows it.
        //If there is a RealEstate with the same Address, already added, do not duplicate real estates, just skip the command.
        public void AddRealEstate(RealEstate realEstate)
        {
            if (Capacity > Count)
            {
                if (realEstates.Find(x => x.Address == realEstate.Address) == null)
                {
                    realEstates.Add(realEstate);
                }
            }
        }
        //•	Method RemoveRealEstate(string address)
        //– removes a real estate by the given address, if such exists, and returns boolean
        //(true if it is removed, otherwise – false)
        public bool RemoveRealEstate(string address)
        {
            var removeEstate = realEstates.Where(x => x.Address == address);
            if (removeEstate.Any())
            {
                realEstates.Remove(removeEstate.First());
                return true;
            }
            return false;

        }
        //•	Method GetRealEstates(string postalCode)
        //– returns a list of all real estates with the specified postal code.
        public List<RealEstate> GetRealEstates(string postalCode)
        {
            return realEstates.Where(r => r.PostalCode == postalCode).ToList();
        }
        //•	Method GetCheapest()
        //– returns the real estate with the lowest price.
        public RealEstate GetCheapest()
            => realEstates.OrderBy(x => x.Price).First();
        //•	Method GetLargest()
        //– returns the Area of the real estate with the largest size.
        public double GetLargest()
        {
          var largest= realEstates.OrderByDescending(x => x.Size).FirstOrDefault();
            return largest.Size;
        }



                /*•	Method EstateReport() 
        – returns a string with all estates in the following format:
        o	"Real estates available:
        {RealEstate1}
        {RealEstate2}
        (…)
        {RealEstaten}"
                */
                public string EstateReport()
                {
                    var sb = new StringBuilder();
                    sb.AppendLine($"Real estates available:");
                    foreach (var realEstate in realEstates)
                    {
                        sb.AppendLine(realEstate.ToString());
                    }
                    return sb.ToString().TrimEnd();
                }

            }
        }
