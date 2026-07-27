using MySql.Data.MySqlClient;
using Model;
namespace Repository;

public class StudentRepository
{
    private IConfiguration configuration;
    public StudentRepository(){}

    public StudentRepository(IConfiguration configuration)
    {
        this.configuration=configuration;
    }

    private MySqlConnection GetConnection()
    {
        return new MySqlConnection(configuration.GetConnectionString("DefaultConnection"));
    }

    public List<Student> GetStudents()
    {
        List<Student> students=new List<Student>();

        using(var conn = GetConnection())
        {
            conn.Open();
            string query="SELECT * FROM students";
            using (var cmd=new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student{id=Convert.ToInt32(reader["id"]),
                                                 name=reader["name"].ToString(),
                                                 email=reader["email"].ToString() });
                    }
                }
            }
            return students;
        }
    }

    public Boolean updateStudent()
    {
        using(var conn = GetConnection())
        {
            conn.Open();
            string query="UPDATE students SET name='Dalton' WHERE id=13";
            using(var cmd=new MySqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        return true;
    }

    public Boolean deleteStudent(int id)
    {
        using(var conn = GetConnection())
        {
            conn.Open();
            string query="DELETE FROM students WHERE id=@id";

            using (var cmd=new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id",id);
                cmd.ExecuteNonQuery();
            }
        }
        return true;
    }
}