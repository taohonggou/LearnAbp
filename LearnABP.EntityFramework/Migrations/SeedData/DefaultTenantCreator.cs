using System.Linq;
using LearnABP.EntityFramework;
using LearnABP.MultiTenancy;

namespace LearnABP.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly LearnABPDbContext _context;

        public DefaultTenantCreator(LearnABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
