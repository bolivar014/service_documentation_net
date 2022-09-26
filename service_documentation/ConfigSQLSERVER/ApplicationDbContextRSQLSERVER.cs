using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSQLSERVER
{
    public class ApplicationDbContextRSQLSERVER : DbContext
    {
        public ApplicationDbContextRSQLSERVER(DbContextOptions<ApplicationDbContextRSQLSERVER> options)
            :base(options) { 
        }
    }
}
