using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.EF
{
    public class DccyDbContext:DbContext
    {
        public DccyDbContext(DbContextOptions options)
           : base(options)
        {
        }


    }
}
