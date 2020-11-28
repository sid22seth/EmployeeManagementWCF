using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRepository
    {
        EmployeeContract AddEmployee(EmployeeContract employeeContract);
        EmployeeContract GetEmployeeByEmail(string email);
    }
}
