using System.Threading.Tasks;
using Abp.Application.Services;
using Something.Authorization.Accounts.Dto;

namespace Something.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
