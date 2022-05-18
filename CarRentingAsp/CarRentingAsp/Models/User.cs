using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CarRentingAsp.Models
{
    
    public class User : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string LoginName { get; set; }

        public byte[] ProfilePicture { get; set; }

        public string Discriminator { get; set; }
        

    }
}
