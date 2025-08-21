using System.Data;

namespace PetVaxTrack.Application.AbsFactory
{
    public abstract class AbsDbConnectionFactory
    {
        public abstract IDbConnection CreateConnection();
    }
}
