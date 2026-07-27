using Entity;
using MySql.Data.MySqlClient;

namespace Repository;

public class StudentRepository
{
    private IConfiguration configuration;

    public StudentRepository(IConfiguration configuration)
    {
        this.configuration=configuration;
    }

    public MySqlConnection GetConnection()
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
            using(var cmd=new MySqlCommand(query, conn))
            {
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student{id=Convert.ToInt32(reader["id"]),
                        name=reader["name"].ToString(),
                        email=reader["email"].ToString()});
                    }
                }
            }
        }
        return students;
    }

    public Boolean updateDetails(int id,string name)
    {
        using(var conn = GetConnection())
        {
            conn.Open();
            string query="UPDATE students set name=@name WHERE id=@id";
            using(var cmd=new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@name",name);
                cmd.ExecuteNonQuery();
            }
        }
        return true;
    }

    public Boolean delete(int id)
    {
        using (var conn = GetConnection())
        {
            conn.Open();
            string query="DELETE FROM students WHERE id=@id";

            using(var cmd=new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id",id);
                cmd.ExecuteNonQuery();
            }
        }
        return true;
    }

    public Boolean create(Student student)
    {
        using (var conn = GetConnection())
        {
            conn.Open();
            string query="INSERT INTO students(id,name,email) VALUES(@id,@name,@email)";
            using(var cmd=new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id",student.id);
                cmd.Parameters.AddWithValue("@name",student.name);
                cmd.Parameters.AddWithValue("@email",student.email);

                cmd.ExecuteNonQuery();
            }
        }
        return true;
    }
}