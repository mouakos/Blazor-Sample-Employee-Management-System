using Microsoft.EntityFrameworkCore;
using SampleEmployeeManagementSystem.DataAccess.Data;
using SampleEmployeeManagementSystem.ViewModels;

namespace SampleEmployeeManagementSystem.DataAccess;

public class EmployeeService(AppDbContext appDbContext)
{
    public async Task<List<EmployeeViewModel>> GetAllEmployeesAsync()
    {
        return await appDbContext.Employees.OrderBy(employee => employee.FullName).Select(e => new EmployeeViewModel
        {
            Id = e.Id,
            FullName = e.FullName,
            Departement = e.Departement,
            DateOfBirth = e.DateOfBirth,
            Age = e.Age,
            PhoneNumber = e.PhoneNumber
        }).ToListAsync();
    }
}