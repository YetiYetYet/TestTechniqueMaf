using Microsoft.EntityFrameworkCore;

namespace TestMafAlexisBehier.DatabaseContext
{
    public class SocietaireContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server=web-api-dev;database=mfa;user=maf;password=MfaTest2021");
        }
    }
    
}