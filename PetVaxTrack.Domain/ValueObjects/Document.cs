using PetVaxTrack.Domain.Enums;

namespace PetVaxTrack.Domain.ValueObjects
{
    public struct Document
    {
        public Document(string documentNumber, EdocumentType documentType)
        {
            DocumentNumber = documentNumber;
            DocumentType = documentType;
        }
        public string DocumentNumber { get; private set; }
        public EdocumentType DocumentType { get; private set; }
    }
}