namespace StudentApp.Core
{
    public class StudentService : IStudentService
    {
        public bool HasApproved(Estudiante estudiante)
        {
            return estudiante.Nota >= 51;
        }
    }
}
