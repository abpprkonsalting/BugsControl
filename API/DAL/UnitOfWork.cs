using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        public GenericRepository<Project> ProjectsRepository { get; }
        public GenericRepository<User> UsersRepository { get; }
        public GenericRepository<Bug> BugsRepository { get; }
        public void Save();
    }

        public class UnitOfWork : IUnitOfWork
    {
        private BugsControlContext _context;
        private GenericRepository<Project> projectsRepository;
        private GenericRepository<User> usersRepository;
        private GenericRepository<Bug> bugsRepository;

        public GenericRepository<Project> ProjectsRepository
        {
            get
            {

                if (this.projectsRepository == null)
                {
                    this.projectsRepository = new GenericRepository<Project>(_context);
                }
                return projectsRepository;
            }
        }

        public GenericRepository<User> UsersRepository
        {
            get
            {
                if (this.usersRepository == null)
                {
                    this.usersRepository = new GenericRepository<User>(_context);
                }
                return usersRepository;
            }
        }

        public GenericRepository<Bug> BugsRepository
        {
            get
            {

                if (this.bugsRepository == null)
                {
                    this.bugsRepository = new GenericRepository<Bug>(_context);
                }
                return bugsRepository;
            }
        }

        public UnitOfWork(IServiceProvider provider, BugsControlContext context)
        {
            this._context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
