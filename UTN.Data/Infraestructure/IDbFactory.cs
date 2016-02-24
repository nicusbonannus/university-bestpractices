using System;

namespace UTN.Data.Infraestructure
{
    public interface IDbFactory : IDisposable
    {
        UTNEntities Init();
    }
}
