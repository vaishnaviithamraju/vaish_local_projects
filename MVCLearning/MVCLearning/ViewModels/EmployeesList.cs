using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLearning.ViewModels
{
    public class EmployeesList
    {
        
            public List<EmployeeViewModel> Employees { get; set; }
            public string UserName { get; set; }
      
    }
}