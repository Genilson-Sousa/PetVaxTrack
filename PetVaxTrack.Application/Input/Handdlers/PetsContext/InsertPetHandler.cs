using PetVaxTrack.Application.Input.Commands.PetsContext;
using PetVaxTrack.Application.Input.Handdlers.Interfaces;
using PetVaxTrack.Application.Output.Results;
using PetVaxTrack.Application.Output.Results.Interfaces;
using PetVaxTrack.Application.Repositories.PetContext;
using PetVaxTrack.Domain.Entities.PetContext;
using PetVaxTrack.Domain.Notifications;

namespace PetVaxTrack.Application.Input.Handdlers.PetsContext
{
    public class InsertPetHandler : IHandlerBase<InsertPetCommand>
    {
        private readonly IPetRepository _Repository;

        public InsertPetHandler(IPetRepository repository)
        {
            _Repository = repository;
        }

        public IResultBase Handler(InsertPetCommand command)
        {
            var pet = new Pet(command.Name, command.Age, command.OwnerId, command.Identifier);
            Result result;
            if (pet.Validation())
            {
                try
                {
                    _Repository.IsertPet(pet);
                    result = new Result(200, $"Pet {pet.Name.FirstName} inserido com sucesso.", true);
                    return result;
                }
                catch (Exception ex)
                {
                    result = new Result(500, $"Falha interna do servidor {ex.Message}", false);
                }
               
            }
            result = new Result(400, $"Erro ao inserir Pet {pet.Name.FirstName}  verifique os campos e tente novamente", false);
            result.SetNotifications(pet.Notifications as List<Notification>);
            return result;
        }
    }
}
