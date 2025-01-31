﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCRUD.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}