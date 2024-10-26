using System.ComponentModel.DataAnnotations;

namespace SampleEmployeeManagementSystem.ViewModels;

public class EmployeeViewModel
{
    public int Id { get; set; }
    public string EmployeeIdView => $"EMP{Id:D4}";
    [Required] public string? FullName { get; set; }
    [Required] public string? Departement { get; set; }
    [Required] public DateTime DateOfBirth { get; set; }
    [Required] public int Age { get; set; }
    [Required] public string? PhoneNumber { get; set; }
}