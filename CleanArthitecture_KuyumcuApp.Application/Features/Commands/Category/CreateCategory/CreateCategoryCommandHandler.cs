using CleanArthitecture_KuyumcuApp.Application.Common;
using CleanArthitecture_KuyumcuApp.Application.Repositories;
using MediatR;

namespace CleanArthitecture_KuyumcuApp.Application.Features.Commands.Category.CreateCategory;
public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
{
    readonly ICategoryWriteRepository _categoryWriteRepository;

    public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository)
    {
        _categoryWriteRepository = categoryWriteRepository;
    }

    public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        await _categoryWriteRepository.AddAsync(new()
        {
            Name = request.Name,
            Description = request.Description
        });
        await _categoryWriteRepository.SaveAsync();
        ServiceResponse.Ok($"{request.Name} kategorisi başarıyla eklendi");
        return new();
    }
}
