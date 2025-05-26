namespace StudentApp.Core
{
    public class StudentController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public bool IsStudentApproved(Estudiante estudiante)
        {
            return _studentService.HasApproved(estudiante);
        }
    }
}
