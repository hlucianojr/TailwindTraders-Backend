using System.ServiceModel;

namespace Tailwind.Traders.Rewards.Registration.Api2
{
    [ServiceContract]
    public interface IUserService
    {

        [OperationContract]
        bool Registration(string email);
    }
}
