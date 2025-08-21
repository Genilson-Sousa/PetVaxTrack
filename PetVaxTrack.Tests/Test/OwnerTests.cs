using PetVaxTrack.Domain.Entities.PetContext;
using PetVaxTrack.Domain.Enums;
using PetVaxTrack.Domain.ValueObjects;

namespace PetVaxTrack.Tests.Test
{
    [TestClass]
    public class OwnerTests
    {
        // Helper para criar Owner com dados padrão ou sobrescritos
        private static Owner CreateOwner(
            string firstName = "NomeTeste", // >= 5 chars
            string lastName = "SnomeTeste",   // >= 5 chars
            string email = "teste.Owner@test.com",
            string document = "529.982.247-25", // CPF válido
            EdocumentType docType = EdocumentType.CPF)
        {
            return new Owner(
                name: new Name(firstName, lastName),
                email: email,
                document: new Document(document, docType)
            );
        }

        // Teste para nome inválido
        [TestMethod]
        public void Given_InvalidFirstName_ShouldFailValidation()
        {
            var owner = CreateOwner(firstName: "Te"); // muito curto
            Assert.IsFalse(owner.Validation(), "Esperava falha pois o primeiro nome é muito curto.");
        }

        // Teste para emails inválidos usando Data Driven Tests
        [DataTestMethod]
        [DataRow("plainaddress")]
        [DataRow("missingatsign.com")]
        [DataRow("@missingusername.com")]
        [DataRow("name@domain")]
        [DataRow("name@domain,com")]
        public void Given_InvalidEmails_ShouldFailValidation(string invalidEmail)
        {
            var owner = CreateOwner(email: invalidEmail);
            Assert.IsFalse(owner.Validation(), $"Esperava falha pois o e-mail '{invalidEmail}' é inválido.");
        }

        // Teste para documentos inválidos (CPFs numéricos incorretos)
        [DataTestMethod]
        [DataRow("11111111111")]
        [DataRow("12345678900")]
        [DataRow("22233344455")]
        public void Given_InvalidDocuments_ShouldFailValidation(string invalidDocument)
        {
            var owner = CreateOwner(document: invalidDocument);
            Assert.IsFalse(owner.Validation(), $"Esperava falha pois o documento '{invalidDocument}' é inválido.");
        }

        // Teste para dados totalmente válidos
        [TestMethod]
        public void Given_AllValidData_ShouldPassValidation()
        {
            var owner = CreateOwner(document: "529.982.247-25"); // CPF válido de verdade
            Assert.IsTrue(owner.Validation(), "Esperava sucesso pois todos os dados são válidos.");
        }
    }
}
