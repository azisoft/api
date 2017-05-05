using API.DataAccess.Providers.SqlEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccess.Providers.SqlEntityFramework.Contexts
{
    public class TestContext :  DbContext
    {
        private string _connString;
        public TestContext(string connString) { _connString = connString; }

        public DbSet<NewModel> NewDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
