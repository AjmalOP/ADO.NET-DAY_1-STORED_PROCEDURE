using ADO.NET_DAY_1_STORED_PROCEDURE.Model;

namespace ADO.NET_DAY_1_STORED_PROCEDURE.Services
{
    public interface IStudentService
    {
        public Students StoredProcedure_GetById(int id);
    }
}
