using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LeptonXLite.DemoApp.Data
{
    /* This is used if database provider does't define
     * IDemoAppDbSchemaMigrator implementation.
     */
    public class NullDemoAppDbSchemaMigrator : IDemoAppDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}