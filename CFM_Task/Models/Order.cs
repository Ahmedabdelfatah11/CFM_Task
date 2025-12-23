namespace CFM_Task.Models
{
    public class Order
    {
        public string ID { get; set; }     
        public string Customer_Id { get; set; }
        public int Product_Id { get; set; }
        public decimal Amount { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
