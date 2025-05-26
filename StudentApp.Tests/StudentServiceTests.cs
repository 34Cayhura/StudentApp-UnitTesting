using Xunit; // Librería de xUnit
using StudentApp.Core; // Namespace donde está Estudiante y StudentService

namespace StudentApp.Tests
{
    public class StudentServiceTests
    {
        private readonly StudentService _service;

        public StudentServiceTests()
        {
            // Inicializa el servicio antes de cada prueba
            _service = new StudentService();
        }

        [Fact]
        public void HasApproved_ReturnsTrue_WhenNotaIsGreaterOrEqualThan51()
        {
            var estudiante = new Estudiante { CI = 12345, Nombre = "Juan", Nota = 60 };
            bool resultado = _service.HasApproved(estudiante);
            Assert.True(resultado);
        }

        [Fact]
        public void HasApproved_ReturnsFalse_WhenNotaIsLessThan51()
        {
            var estudiante = new Estudiante { CI = 12345, Nombre = "Ana", Nota = 45 };
            bool resultado = _service.HasApproved(estudiante);
            Assert.False(resultado);
        }

        [Fact]
        public void EstudianteProperties_AreCorrectlySet()
        {
            var estudiante = new Estudiante { CI = 98765, Nombre = "Pedro", Nota = 70 };
            Assert.Equal(98765, estudiante.CI);
            Assert.Equal("Pedro", estudiante.Nombre);
            Assert.Equal(70, estudiante.Nota);
        }
    }
}
