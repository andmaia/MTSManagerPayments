using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;



namespace Domain.Entities
{
    public class Credentials
    {
        public Credentials()
        {
        }

        public Credentials(string id, string password, string email, Permission permission)
        {
            Id = id;
            Password = password;
            Email = email;
            Permission = permission;
        }

        public string Id { get; set; }
        public string Password { get; set; }  
        public string Email { get; set; }
        public Permission Permission {  get; set; }
    }
}
