using _09_Dependency_Injection.Models;
using _09_Dependency_Injection.Services.Abstract;

namespace _09_Dependency_Injection.Services.Concrete
{
    public class StudentMySQLService : IStudentService
    {
        public void Create(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
