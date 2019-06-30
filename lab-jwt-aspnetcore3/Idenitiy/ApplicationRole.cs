using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labjwt.aspnetcore3.Idenitiy
{
    public class ApplicationRole
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
