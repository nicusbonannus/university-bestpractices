using System;

namespace UTN.Data.Infraestructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private UTNEntities dbContext;
        public UTNEntities Init()
        {
            return dbContext ?? (dbContext = new UTNEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
