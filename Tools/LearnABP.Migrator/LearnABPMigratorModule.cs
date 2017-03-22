using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using LearnABP.EntityFramework;

namespace LearnABP.Migrator
{
    [DependsOn(typeof(LearnABPDataModule))]
    public class LearnABPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<LearnABPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}