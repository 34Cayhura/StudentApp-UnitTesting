using Xunit;
using StudentApp.Core;

namespace StudentApp.Tests
{
    public class StudentServiceStubTests
    {
        [Fact]
        public void HasApproved_Stub_ReturnsTrue()
        {
            var stub = new StudentServiceStub(true);
            var estudiante = new Estudiante { CI = 22222, Nombre = "StubUser", Nota = 100 };

            bool resultado = stub.HasApproved(estudiante);

            Assert.True(resultado);
        }

        [Fact]
        public void HasApproved_Stub_ReturnsFalse()
        {
            var stub = new StudentServiceStub(false);
            var estudiante = new Estudiante { CI = 33333, Nombre = "StubUser2", Nota = 10 };

            bool resultado = stub.HasApproved(estudiante);

            Assert.False(resultado);
        }
    }
}
