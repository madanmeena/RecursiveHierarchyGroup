namespace RecursiveHierarchyGroup
{
    public class Employee
    {
        public int Id { get; set; }
        public int? ManagerId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}