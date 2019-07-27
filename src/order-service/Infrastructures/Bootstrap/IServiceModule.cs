using Microsoft.Extensions.DependencyInjection;

namespace orderService.Infrastructures.Bootstrap
{
    public interface IServiceModule
    {
        void Load(IServiceCollection services);
    }
}