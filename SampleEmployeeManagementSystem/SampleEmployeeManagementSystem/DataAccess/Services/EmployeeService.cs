using Microsoft.EntityFrameworkCore;
using SampleEmployeeManagementSystem.DataAccess.Data;
using SampleEmployeeManagementSystem.DataAccess.Entities;
using SampleEmployeeManagementSystem.ViewModels;

namespace SampleEmployeeManagementSystem.DataAccess.Services;

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

    public async Task<EmployeeViewModel> GetEmployeeByIdAsync(int id)
    {
        var employee = await appDbContext.Employees.FindAsync(id);
        return new EmployeeViewModel
        {
            Id = employee.Id,
            FullName = employee.FullName,
            Departement = employee.Departement,
            DateOfBirth = employee.DateOfBirth,
            Age = employee.Age,
            PhoneNumber = employee.PhoneNumber
        };
    }

    public async Task<bool> AddEmployeeAsync(EmployeeViewModel employeeViewModel)
    {
        try
        {
            var employee = new Employee
            {
                FullName = employeeViewModel.FullName,
                Departement = employeeViewModel.Departement,
                DateOfBirth = employeeViewModel.DateOfBirth,
                Age = employeeViewModel.Age,
                PhoneNumber = employeeViewModel.PhoneNumber
            };
            await appDbContext.Employees.AddAsync(employee);
            return await appDbContext.SaveChangesAsync() > 0;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task UpdateEmployeeAsync(EmployeeViewModel employeeViewModel)
    {
        var employee = await appDbContext.Employees.FindAsync(employeeViewModel.Id);
        employee.FullName = employeeViewModel.FullName;
        employee.Departement = employeeViewModel.Departement;
        employee.DateOfBirth = employeeViewModel.DateOfBirth;
        employee.Age = employeeViewModel.Age;
        employee.PhoneNumber = employeeViewModel.PhoneNumber;
        await appDbContext.SaveChangesAsync();
    }

    public async Task DeleteEmployeeAsync(int id)
    {
        var employee = await appDbContext.Employees.FindAsync(id);
        appDbContext.Employees.Remove(employee);
        await appDbContext.SaveChangesAsync();
    }
}