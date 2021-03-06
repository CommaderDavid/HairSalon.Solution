using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string Description { get; set; }
        public string StylistName { get; set; }
        public virtual ICollection<Client> Clients { get; set; }  //imaginary list

        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }
    }
}