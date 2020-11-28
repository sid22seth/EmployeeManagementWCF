using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Contracts
{
    [DataContract]
    public class EmployeeContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public decimal Salary { get; set; }
        [DataMember]
        public String Email { get; set; }
    }
}
