using FluentValidation;
using KanbanBoard.Application.Boards;
using Microsoft.Extensions.DependencyInjection;

namespace KanbanBoard.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

            services.AddScoped<IBoardsService, BoardsService>();

            return services;
        }
    }
}
