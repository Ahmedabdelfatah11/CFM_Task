namespace CFM_Task.Models
{
    public class Departments
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
