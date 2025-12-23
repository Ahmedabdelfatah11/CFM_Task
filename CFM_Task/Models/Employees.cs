namespace CFM_Task.Models
{
    public class Employees
    {
        public int ID { get; set; }         
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public int Department_Id { get; set; }   

        public Departments Department { get; set; }
    }

}
