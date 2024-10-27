using System.Text.Json;
using ClosedXML.Excel;
using EFCore.BulkExtensions;
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

    public async Task<EmployeeViewModel?> GetEmployeeByIdAsync(int id)
    {
        var employee = await appDbContext.Employees.FindAsync(id);
        if (employee is null) return null;
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
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> UpdateEmployeeAsync(EmployeeViewModel employeeViewModel)
    {
        var employee = await appDbContext.Employees.FindAsync(employeeViewModel.Id);
        if (employee is null) return false;
        employee.FullName = employeeViewModel.FullName;
        employee.Departement = employeeViewModel.Departement;
        employee.DateOfBirth = employeeViewModel.DateOfBirth;
        employee.Age = employeeViewModel.Age;
        employee.PhoneNumber = employeeViewModel.PhoneNumber;
        try
        {
            appDbContext.Employees.Update(employee);
            return await appDbContext.SaveChangesAsync() > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteEmployeeAsync(int id)
    {
        var employee = await appDbContext.Employees.FindAsync(id);
        if (employee is null) return false;
        try
        {
            appDbContext.Employees.Remove(employee);
            return await appDbContext.SaveChangesAsync() > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> ImportEmployeeAsync(List<EmployeeViewModel> employees)
    {
        try
        {
            var employeeEntities = employees.Select(e => new Employee
            {
                FullName = e.FullName,
                Departement = e.Departement,
                DateOfBirth = e.DateOfBirth,
                Age = e.Age,
                PhoneNumber = e.PhoneNumber
            }).ToList();
            await appDbContext.BulkInsertAsync(employeeEntities);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<byte[]> ExportEmployeesToExcelAsync()
    {
        var employees = await GetAllEmployeesAsync();
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Employees");

        // Header
        worksheet.Cell(1, 1).Value = "Employee Id";
        worksheet.Cell(1, 2).Value = "Full Name";
        worksheet.Cell(1, 3).Value = "Departement";
        worksheet.Cell(1, 4).Value = "Date Of Birth";
        worksheet.Cell(1, 5).Value = "Age";
        worksheet.Cell(1, 6).Value = "Phone Number";

        // Data
        for (var i = 0; i < employees.Count; i++)
        {
            worksheet.Cell(i + 2, 1).Value = employees[i].Id;
            worksheet.Cell(i + 2, 2).Value = employees[i].FullName;
            worksheet.Cell(i + 2, 3).Value = employees[i].Departement;
            worksheet.Cell(i + 2, 4).Value = employees[i].DateOfBirth;
            worksheet.Cell(i + 2, 5).Value = employees[i].Age;
            worksheet.Cell(i + 2, 6).Value = employees[i].PhoneNumber;
        }

        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }
}