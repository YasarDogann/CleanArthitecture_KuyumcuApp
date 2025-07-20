using MediatR;

namespace CleanArthitecture_KuyumcuApp.Application.Features.Commands.Category.CreateCategory;
public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
{
    public string Name { get; set; }
    public string? Description { get; set; }
}
