namespace UniversityService.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using UniversityService.Data.Entities;

    public sealed class StudentRepository
    {
        private readonly DbContext dbContext;

        public StudentRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Student> GetByName(string name, CancellationToken cancellationToken = default)
        {
            return await Query().SingleOrDefaultAsync(x => x.Name == name, cancellationToken);
        }

        public async Task<IReadOnlyCollection<Student>> GetAllPaged(int skip, int take, CancellationToken cancellationToken = default)
        {
            return await Query()
                .Skip(skip).Take(take)
                .OrderBy(x => x.Id)
                .ToArrayAsync(cancellationToken);
        }

        private IQueryable<Student> Query()
        {
            return dbContext.Set<Student>();
        }
    }
}
