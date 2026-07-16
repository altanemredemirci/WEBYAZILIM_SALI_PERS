using _09_Dependency_Injection.Models;
using _09_Dependency_Injection.Services.Abstract;

namespace _09_Dependency_Injection.Services.Concrete
{
    public class StudentService : IStudentService
    {
        DataContext context = new DataContext();
        public void Create(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void Delete(Student student)
        {
            context.Students.Remove(student);
            context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            List<Student> students = context.Students.ToList();

            return students;
        }

        public Student GetById(int id)
        {
            Student student = context.Students.Find(id);

            return student;
        }

        public void Update()
        {
            context.SaveChanges();
        }
    }
}
