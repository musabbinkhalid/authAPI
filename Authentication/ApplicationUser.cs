using Microsoft.AspNetCore.Identity;
using System;

namespace authApi.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public int emp_id { get; set; }
        public int designation_id { get; set; }
        public int team_id { get; set; }
        public int department_id { get; set; }
        public DateTime registrationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string  ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Deleted { get; set; }


    }
}