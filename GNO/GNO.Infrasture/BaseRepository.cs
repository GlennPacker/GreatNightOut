using System.Data;
using GNO.Models;
using System.Data.Entity;
using System;
using System.Linq;

namespace GNO.Infrasturcture
{
    public class BaseRepository<T> : IDisposable where T : BaseEntity, new()
    {
        private readonly GreatNightOutContext _context;
        private readonly IDbSet<T> _db;

        //private static ILog Log { get; set; }

        protected BaseRepository(GreatNightOutContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public T Get(int id)
        {
            T result = _db.Find(id);
            return result;
        }

        public void Add(T entity)
        {
            _db.Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
            Save();
        }

        public IQueryable<T> List()
        {
            return _db;
        }

        public void Save()
        {
            try {
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                //Log.Error("Error saving to db", ex);
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
