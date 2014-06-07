using FluentData;

namespace Lennon.SexCity.Business
{
    public class BaseBusiness
    {
        private IDbContext _context;

        protected IDbContext GetContext
        {
            get
            {
                if (_context == null)
                {
                    IDbProvider dbProvider = new SqlServerProvider();
                    _context = new FluentData.DbContext().ConnectionStringName("DefaultConnection", dbProvider);
                }
                return _context;
            }
        }

        //public void Update<TEntity>(params TEntity[] entities) where TEntity : class
        //{
        //    if (entities == null) throw new ArgumentNullException("entities");

        //    using (var db=new appstoreEntities())
        //    {

        //        foreach (TEntity entity in entities)
        //        {
        //            DbSet<TEntity> dbSet = db.Set<TEntity>();
        //            try
        //            {
        //                DbEntityEntry<TEntity> entry = db.Entry(entity);
        //                if (entry.State == EntityState.Detached)
        //                {
        //                    dbSet.Attach(entity);
        //                    entry.State = EntityState.Modified;
        //                }
        //            }
        //            catch (InvalidOperationException)
        //            {
        //                TEntity oldEntity = dbSet.Find(entity.Id);
        //                db.Entry(oldEntity).CurrentValues.SetValues(entity);
        //            }
        //        }
        //    }
        //}
    }
}
