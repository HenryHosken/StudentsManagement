using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.Models
{
    public class Student
    {
        [Key]

        public required int Id { get; set; }
        public required string? FirstName { get; set; }
        public required string? MiddleName { get; set; }
        public required string? LastName { get; set; }
        public required string? EmailAddres { get; set; }
        public required string? Addres { get; set; }
        public required string? PhoneNumber { get; set; }
        public required string? Country { get; set; }
    }
}
