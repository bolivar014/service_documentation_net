using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSQLSERVER
{
    public class ApplicationDbContextWSQLSERVER : DbContext
    {
        public ApplicationDbContextWSQLSERVER(DbContextOptions<ApplicationDbContextWSQLSERVER> options)
            : base(options)
        {

        }
    }
}
