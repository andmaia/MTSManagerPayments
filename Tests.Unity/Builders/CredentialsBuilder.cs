using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unity.Builders
{
    public class CredentialsBuilder
    {
        private string Id { get; set; } = Guid.NewGuid().ToString();
        private string Password { get; set; } = Guid.NewGuid().ToString().Substring(0, 10);
        private string Email { get; set; } = $"teste@{Guid.NewGuid().ToString().Substring(0, 10)}";
        private Permission Permission { get; set; }

        public CredentialsBuilder WithId(string id)
        {
            Id = id;
            return this;
        }

        public CredentialsBuilder WithPassword(string password)
        {
            Password = password;
            return this;
        }

        public CredentialsBuilder WithEmail(string email)
        {
            Email = email;
            return this;
        }

        public CredentialsBuilder WithPermission(Permission permission)
        {
            Permission = permission;
            return this;
        }

        public Credentials Build()
        {
            return new Credentials(Id, Password, Email, Permission);
        }
    }

}
