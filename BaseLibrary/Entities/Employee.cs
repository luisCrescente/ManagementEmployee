﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Employee: BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? CivilId { get; set; }
        public string? FileNumber { get; set; }
        public string?  FullName { get; set; }
        public string? Jobname { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber{ get; set; }
        public string? Photo { get; set; }
        public string? Other { get; set;}

        //RelationShip: Many to One
        public GeneralDepartment? GeneralDepartment { get; set; }
        public long GeneralDepartmentId { get; set; }

        public Department? Department { get; set; }
        public long DepartmentId { get; set; }

        public Branch? Branch { get; set; }
        public long BranchId { get; set; }

        public Town? Town { get; set; }
        public long TownId { get; set; }
    }
}
