using CleanArthitecture_KuyumcuApp.Application.Abstractions.Services;
using CleanArthitecture_KuyumcuApp.Application.Features.Commands.Category.CreateCategory;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArthitecture_KuyumcuApp.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    readonly IMediator _mediator;


    // Dependency Injection ile CategoryService'i alıyoruz
    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;

    }

    // Tüm kategorileri listele
    [HttpGet]
    public IActionResult GetAllCategories()
    {
        // Buraya daha sonra kod ekleyeceğiz
        return Ok();
    }

    // Id'ye göre kategori getir
    [HttpGet("{id}")]
    public IActionResult GetCategoryById(string id)
    {
        // Buraya daha sonra kod ekleyeceğiz
        return Ok();
    }

    // Yeni kategori ekle
    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryCommandRequest createCategoryCommandRequest)
    {
        CreateCategoryCommandResponse response = await _mediator.Send(createCategoryCommandRequest);
        return StatusCode((int)HttpStatusCode.Created);
    }

    // Kategori güncelle
    [HttpPut]
    public IActionResult UpdateCategory()
    {
        // Buraya daha sonra kod ekleyeceğiz
        return Ok();
    }

    // Kategori sil
    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(string id)
    {
        // Buraya daha sonra kod ekleyeceğiz
        return Ok();
    }
}
