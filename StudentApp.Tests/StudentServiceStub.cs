using StudentApp.Core;

namespace StudentApp.Tests
{
    public class StudentServiceStub : IStudentService
    {
        private readonly bool _returnValue;

        public StudentServiceStub(bool returnValue)
        {
            _returnValue = returnValue;
        }

        public bool HasApproved(Estudiante estudiante)
        {
            return _returnValue;
        }
    }
}
