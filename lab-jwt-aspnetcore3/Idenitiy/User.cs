using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labjwt.aspnetcore3.identity
{
    public class User: IdentityUser
    {
        public string Login { get; set; }
        public string Nome { get; set; }

        public User()
        {
            base.Id = Guid.NewGuid().ToString();
        }
    }

    public class Role<T>: IdentityRole
    {

    }

}
