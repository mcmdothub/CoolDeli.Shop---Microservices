namespace OrderSevice.API.Data
{
    public class DbOrdersSeed
    {
        public static void Initialize(OrdersDbContext context)
        {
            context.Database.EnsureCreated();

            context.SaveChanges();
        }
    }
}
