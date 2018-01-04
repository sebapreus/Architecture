using EF;
using Models;
using Repositories;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UoW
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext db = null;

        public UnitOfWork()
        {
            db = new AppDbContext();
        }

        // Słownik będzie używany do sprawdzania instancji repozytoriów
        public Dictionary<Type, object> Repositories = new Dictionary<Type, object>();
        public IBaseRepository<T> Repository<T>() where T : class, IBaseModel
        {
            // Jeżeli instancja danego repozytorium istnieje - zostanie zwrócona
            if (Repositories.Keys.Contains(typeof(T)) == true)
                return Repositories[typeof(T)] as IBaseRepository<T>;
            // Jeżeli nie, zostanie utworzona nowa i dodana do słownika
            IBaseRepository<T> repo = new BaseRepository<T>(db);
            Repositories.Add(typeof(T), repo);
            return repo;
        }
        public void SaveChanges()
        {
            db.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    db.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
