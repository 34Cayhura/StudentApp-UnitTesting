namespace StudentApp.Core
{
    public class StudentServiceStub : IStudentService
    {
        private readonly bool _approvalResult;

        public StudentServiceStub(bool approvalResult)
        {
            _approvalResult = approvalResult;
        }

        public bool HasApproved(Estudiante estudiante)
        {
            // Retorna siempre el valor fijo configurado para simular el comportamiento.
            return _approvalResult;
        }
    }
}
