using LearnABP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace LearnABP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly LearnABPDbContext _context;

        public InitialHostDbBuilder(LearnABPDbContext context)
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
