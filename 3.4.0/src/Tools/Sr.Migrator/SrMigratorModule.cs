using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Sr.EntityFramework;

namespace Sr.Migrator
{
    [DependsOn(typeof(SrDataModule))]
    public class SrMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SrDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}