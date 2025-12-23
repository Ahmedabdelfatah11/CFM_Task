namespace CFM_Task.Models
{
    public class Product
    {
        public int ID { get; set; }  
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
