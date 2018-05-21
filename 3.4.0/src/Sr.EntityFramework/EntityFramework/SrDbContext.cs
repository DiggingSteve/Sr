using System.Data.Common;
using Abp.Zero.EntityFramework;
using Sr.Authorization.Roles;
using Sr.Authorization.Users;
using Sr.MultiTenancy;

namespace Sr.EntityFramework
{
    public class SrDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SrDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SrDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SrDbContext since ABP automatically handles it.
         */
        public SrDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SrDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SrDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
