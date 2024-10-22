using Microsoft.EntityFrameworkCore;
using Bogus;
using SampleEmployeeManagementSystem.DataAccess.Entities;

namespace SampleEmployeeManagementSystem.DataAccess.Extensions
{
    public static class Seed
    {
        public static void GenerateSeed(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var fakeEmployees = new Faker<Employee>()
                .RuleFor(t => t.Id, _ => id++)
                .RuleFor(t => t.FullName, f => f.Person.FullName)
                .RuleFor(t => t.Departement,
                    f => f.PickRandom("Training and development", "Sales", "Finance", "Engineering", "Administration",
                        "Information Technology (IT)", "Quality Assurance (QA)", "Customer support",
                        "Business Development"))
                .RuleFor(t => t.DateOfBirth, f => f.Person.DateOfBirth)
                .RuleFor(t => t.PhoneNumber, f => f.Person.Phone)
                .RuleFor(t => t.Age, (_, p) => p.DateOfBirth.Year - DateTime.Today.Year);

            var employees = fakeEmployees.Generate(60);
            modelBuilder.Entity<Employee>().HasData(employees);
        }
    }
}