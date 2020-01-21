
using Microsoft.EntityFrameworkCore;
using ProvidersListApp.Models;

namespace ProvidersListApp.Data
{


        public class ProvidersListAppContext :DbContext
    {
            public ProvidersListAppContext(DbContextOptions<ProvidersListAppContext> options)
                : base(options)
            {
            }
            public DbSet<Person> Persons { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Phone> Phones { get; set; }

    }
    }

