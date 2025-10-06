using BlazorApp2.Server.DTOs;
using BlazorApp2.Models;
using Microsoft.AspNetCore.Mvc;
using BlazorApp2.Server.Data;

[ApiController]
[Route("api/[controller]")]
public class DataEntryController : ControllerBase
{
    private readonly AppDbContext _context;

    public DataEntryController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<DataEntryReadDto>> Create([FromBody] DataEntryCreateDto dto)
    {
        if (dto == null)
            return BadRequest("Invalid data.");

        var entity = new DataEntryRecord
        {
            Name = dto.Name,
            ProductModel = dto.ProductModel,
            PartNumber = dto.PartNumber,
            Quantity = dto.Quantity,
            Price = dto.Price,
            CreatedAt = DateTime.Now
        };

        _context.DataEntries.Add(entity);
        await _context.SaveChangesAsync();

        var readDto = new DataEntryReadDto
        {
            Id = entity.Id,
            Name = entity.Name,
            DateTime = entity.CreatedAt,
            ProductModel = entity.ProductModel,
            PartNumber = entity.PartNumber,
            Quantity = entity.Quantity,
            Price = entity.Price
        };

        return Ok(readDto);
    }
}
