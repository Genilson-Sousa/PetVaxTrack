using PetVaxTrack.Application.Input.Commands.PetsContext;
using PetVaxTrack.Application.Input.Handdlers.Interfaces;
using PetVaxTrack.Application.Output.Results;
using PetVaxTrack.Application.Output.Results.Interfaces;
using PetVaxTrack.Application.Repositories.PetContext;
using PetVaxTrack.Domain.Entities.PetContext;
using PetVaxTrack.Domain.Notifications;

namespace PetVaxTrack.Application.Input.Handdlers.PetsContext
{
    public class InsertOwnerHandler : IHandlerBase<InsertOwnerCommand>
    {
        private readonly IOwnerRepository _repository;

        public InsertOwnerHandler(IOwnerRepository repository)
        {
            _repository = repository;
        }

        public IResultBase Handler(InsertOwnerCommand command)
        {
            var owner = new Owner(command.Name, command.Email, command.Document);
            Result result;
            if (owner.Validation())
            {
                try
                {
                    _repository.IsertOwner(owner);
                    result = new Result(200, $"Dono {owner.Name.FirstName} inserido com sucesso", true);
                    return result;
                }
                catch (Exception ex)
                {

                    result = new Result(500, $"Falha interna do servidor, detalhes: {ex.Message}", false);
                }
            }
            result = new Result(400, $"Falha ao inserir dono {owner.Name.FirstName} verifique os campos e tente novamente!", false);
            result.SetNotifications(owner.Notifications as List<Notification>);
            return result;
        }
    }
}
