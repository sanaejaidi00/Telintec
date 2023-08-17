namespace TelintecApp.Models
{
    public class Holiday
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }

}
