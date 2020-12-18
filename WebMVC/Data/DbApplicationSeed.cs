namespace WebMVC.Data
{
    public class DbApplicationSeed
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            context.SaveChanges();
        }
    }
}
