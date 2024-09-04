using System.Threading.Tasks;

namespace LeptonXLite.DemoApp.Data
{
    public interface IDemoAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
