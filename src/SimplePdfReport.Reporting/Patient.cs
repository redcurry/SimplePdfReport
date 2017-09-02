using System;

namespace SimplePdfReport.Reporting
{
    public class Patient
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public Doctor Doctor { get; set; }
    }
}