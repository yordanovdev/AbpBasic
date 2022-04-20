using System.Threading.Tasks;
using Something.Configuration.Dto;

namespace Something.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
