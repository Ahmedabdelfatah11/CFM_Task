namespace CFM_Task.Models
{
    public class Customer
    {
        public string ID { get; set; }     
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
