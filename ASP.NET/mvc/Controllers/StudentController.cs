namespace Controller;

using Entity;
using Microsoft.AspNetCore.Mvc;
using Repository;

[ApiController]
[Route("[controller]")]
public class StudentController
{
    private StudentRepository repo;

    public StudentController(StudentRepository repo)
    {
        this.repo=repo;
    }

    [HttpGet("GetAll")]
    public List<Student> GetStudents()
    {
       return repo.GetStudents();
    }

    [HttpPut("update/id/{id}/name/{name}")]
    public Boolean updateStudent(int id, string name)
    {
        return repo.updateDetails(id,name);
    }

    [HttpDelete("delete/{id}")]
    public Boolean deleteStudent(int id)
    {
        return repo.delete(id);
    }

    [HttpPost("insert")]
    public Boolean insertStudent([FromBody]Student student)
    {
        return repo.create(student);
    }
}