using BusinessLayer;
using BusinessLayer.Interfaces;
using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementAppWithWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeBusiness employeeBusiness;
        public EmployeeService() 
        {
            employeeBusiness = new EmployeeBusiness();
        }
        public EmployeeContract AddEmployee(EmployeeContract employeeContract)
        {
            try
            {
                return employeeBusiness.AddEmployee(employeeContract);
            }
            catch (Exception e)
            {
                ErrorClass err = new ErrorClass();
                err.success = false;
                err.message = e.Message;
                throw new WebFaultException<ErrorClass>(err, HttpStatusCode.NotFound);
            }
        }
    }
}
