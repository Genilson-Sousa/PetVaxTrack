namespace PetVaxTrack.Application.Output.DTOs
{
    public struct VaccineDTO
    {
        public Guid Id { get; set; }
        public string Discription { get; set; }
        public Guid CategoryId { get; set; }
    }
}