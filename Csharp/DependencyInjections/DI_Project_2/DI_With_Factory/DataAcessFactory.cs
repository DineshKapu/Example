﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_With_Factory
{
    public class DataAcessFactory
    {
        public static IEmployeeDataAccess GetEmployeeAccessObject()
        {
            return new EmployeeDataAccess();
        }
    }
}
