using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public virtual ICollection<Stylist> Stylists { get; set; }  //imaginary list

        public Client()
        {
            this.Stylists = new HashSet<Stylist>();
        }
    }
}