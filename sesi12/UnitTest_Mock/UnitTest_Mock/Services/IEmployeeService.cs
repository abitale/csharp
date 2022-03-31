﻿using System.Threading.Tasks;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeeById(int id);
        Task<Employee> GetEmployeeDetails(int id);
    }
}
