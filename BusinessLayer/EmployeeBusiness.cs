using BusinessLayer.Interfaces;
using CommonLayer.Contracts;
using RepositoryLayer;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeBusiness()
        {
            employeeRepository = new EmployeeRepository();
        }
        public EmployeeContract AddEmployee(EmployeeContract employeeContract)
        {
            try 
            {
                if (employeeRepository.GetEmployeeByEmail(employeeContract.Email) != null)
                {
                    throw new Exception("Employee already registered, please try with other email id");
                }
                EmployeeContract empDetails = employeeRepository.AddEmployee(employeeContract);
                if (empDetails.Id > 0)
                {
                    return empDetails;
                }
                else
                {
                    throw new Exception("Employee not able to add");
                }
            }
            catch(Exception e) 
            {
                throw new Exception(e.Message);
            }
        }
    }
}
