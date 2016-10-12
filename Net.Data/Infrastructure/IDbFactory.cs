using System;

namespace Net.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NetDbContext Init();
    }
}