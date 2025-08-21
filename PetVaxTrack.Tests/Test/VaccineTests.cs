using PetVaxTrack.Domain.Entities.VaccineContext;

namespace PetVaxTrack.Tests.Test
{
    [TestClass]
    public class VaccineTests
    {
        private static Vaccine CreateVaccine(
            string description = "Vacina contra raiva", // 18 caracteres (v�lido entre 12 e 30)
            Guid? categoryId = null,
            Guid? petId = null)
        {
            return new Vaccine(
                description: description,
                categoryId: categoryId ?? Guid.NewGuid(),
                petId: petId ?? Guid.NewGuid()
            );
        }
        // Teste descri��o muito curta
        [TestMethod]
        public void Given_TooShortDescription_ShouldFailValidation()
        {
            var vaccine = CreateVaccine(description: "Curta"); // menos de 12 chars
            Assert.IsFalse(vaccine.Validation(), "Esperava falha pois a descri��o � muito curta.");
        }

        // Teste descri��o muito longa
        [TestMethod]
        public void Given_TooLongDescription_ShouldFailValidation()
        {
            var vaccine = CreateVaccine(description: new string('X', 40)); // mais de 30 chars
            Assert.IsFalse(vaccine.Validation(), "Esperava falha pois a descri��o � muito longa.");
        }

        // Teste CategoryId inv�lido
        [TestMethod]
        public void Given_InvalidCategoryId_ShouldFailValidation()
        {
            var vaccine = CreateVaccine(categoryId: Guid.Empty);
            Assert.IsFalse(vaccine.Validation(), "Esperava falha pois CategoryId est� inv�lido (Guid.Empty).");
        }

        // Teste PetId inv�lido
        [TestMethod]
        public void Given_InvalidPetId_ShouldFailValidation()
        {
            var vaccine = CreateVaccine(petId: Guid.Empty);
            Assert.IsFalse(vaccine.Validation(), "Esperava falha pois PetId est� inv�lido (Guid.Empty).");
        }

        // Teste todos os dados v�lidos
        [TestMethod]
        public void Given_AllValidData_ShouldPassValidation()
        {
            var vaccine = CreateVaccine(description: "Vacina da leptospirose");
            Assert.IsTrue(vaccine.Validation(), "Esperava sucesso pois todos os dados s�o v�lidos.");
        }
    }
}