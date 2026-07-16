using _09_Dependency_Injection.Models;

namespace _09_Dependency_Injection.Services.Abstract
{
    public interface IStudentService
    {
        //interface içerisinde metod tanımlamaları yapılır. Sadece metotların gövdesi yoktur. Metotların gövdeleri, bu interface'i implement eden sınıflarda yazılır.

        void Create(Student student);
        void Update();
        void Delete(Student student);
        List<Student> GetAll();
        Student GetById(int id);
    }
}
