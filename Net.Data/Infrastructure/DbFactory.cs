namespace Net.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NetDbContext dbContext;

        public NetDbContext Init()
        {
            return dbContext ?? (dbContext = new NetDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}