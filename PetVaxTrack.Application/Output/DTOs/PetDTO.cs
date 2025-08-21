namespace PetVaxTrack.Application.Output.DTOs
{
    public struct PetDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Identifier { get; set; }
    }
}