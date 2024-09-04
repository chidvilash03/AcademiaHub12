using AcademiaHub.Models;

namespace AcademiaHub.Repositories
{
    public interface IAcademiaHubRepository
    {
        public Task<List<Student>> GetAll();
        public Task<Student> GetById(int id);
        public void Insert(Student entity);
        public void Update(Student entity);
        public void Delete(int id);
        public void Save();
    }
}
