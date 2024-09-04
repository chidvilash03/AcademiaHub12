using AcademiaHub.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademiaHub.Repositories
{ 
    public class AcademiaHubRepository : IAcademiaHubRepository
    {
        private readonly AcademiaHubContext _context;

        public AcademiaHubRepository(AcademiaHubContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAll()
        {
            var studentDetails = await _context.Students.ToListAsync();
            return studentDetails;
        }

        public Task<Student> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }

}
