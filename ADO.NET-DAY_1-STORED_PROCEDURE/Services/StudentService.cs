using ADO.NET_DAY_1_STORED_PROCEDURE.Model;
using System.Data.SqlClient;
namespace ADO.NET_DAY_1_STORED_PROCEDURE.Services
{
    public class StudentService : IStudentService
    {
        private readonly IConfiguration _configuration;
        public string CString { get; set; }
        public StudentService(IConfiguration configuration)
        {
            _configuration = configuration;
            CString = _configuration["ConnectionStrings:DefaultConnection"];
        }

        public Students StoredProcedure_GetById(int id)
        {
            Students student = new Students();
            using(SqlConnection connection = new SqlConnection(CString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("FindById",connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["StudentID"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                    student.Age = Convert.ToInt32(reader["Age"]);
                }
                return student;
            }
        }
    }
}
