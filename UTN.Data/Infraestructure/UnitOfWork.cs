using System;

namespace UTN.Data.Infraestructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private UTNEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory) {
            this.dbFactory = dbFactory;
        }

        public UTNEntities DbContext {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
