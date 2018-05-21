using Sr.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Sr.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SrDbContext _context;

        public InitialHostDbBuilder(SrDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
