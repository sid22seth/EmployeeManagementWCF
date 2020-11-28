using CommonLayer.Contracts;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeManagementEntities employeeManagementEntitiesObj;
        public EmployeeRepository()
        {
            employeeManagementEntitiesObj = new EmployeeManagementEntities();
        }
        public EmployeeContract AddEmployee(EmployeeContract employeeContract)
        {
            EmployeeDetail employee = new EmployeeDetail()
            {
                Name = employeeContract.Name,
                Email = employeeContract.Email,
                Salary = employeeContract.Salary
            };
            employeeManagementEntitiesObj.EmployeeDetails.Add(employee);
            employeeManagementEntitiesObj.SaveChanges();
            employeeContract.Id = employee.id;
            return employeeContract;
        }
        public EmployeeContract GetEmployeeByEmail(string email)
        {
            EmployeeDetail employeeDetail = (from a in employeeManagementEntitiesObj.EmployeeDetails
                                             where a.Email == email
                                             select a).FirstOrDefault();
            if (employeeDetail != null)
            {
                EmployeeContract employeeContract = new EmployeeContract()
                {
                    Name = employeeDetail.Name,
                    Email = employeeDetail.Email,
                    Salary = employeeDetail.Salary,
                    Id = employeeDetail.id
                };
                return employeeContract;
            }
            return null;
        }
    }
}
