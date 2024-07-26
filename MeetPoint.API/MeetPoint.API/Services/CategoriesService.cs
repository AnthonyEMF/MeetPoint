using AutoMapper;
using MeetPoint.API.Database;
using MeetPoint.API.Database.Entities;
using MeetPoint.API.Dtos.Categories;
using MeetPoint.API.Dtos.Common;
using MeetPoint.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MeetPoint.API.Services
{
	public class CategoriesService : ICategoriesService
	{
		private readonly MeetPointContext _context;
		private readonly IMapper _mapper;

		public CategoriesService(MeetPointContext context, IMapper mapper)
        {
			this._context = context;
			this._mapper = mapper;
		}

        public async Task<ResponseDto<List<CategoryDto>>> GetAllCategoriesAsync()
		{
			var categoriesEntities = await _context.Categories.ToListAsync();
			var categoriesDtos = _mapper.Map<List<CategoryDto>>(categoriesEntities);

			return new ResponseDto<List<CategoryDto>>
			{
				StatusCode = 200,
				Status = true,
				Message = "Lista de Categorías obtenida correctamente.",
				Data = categoriesDtos
			};
		}

		public async Task<ResponseDto<CategoryDto>> GetCategoryByIdAsync(Guid id)
		{
			var categoryEntity = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
			if (categoryEntity is null)
			{
				return new ResponseDto<CategoryDto>
				{
					StatusCode = 404,
					Status = false,
					Message = "No se encontró la Categoría."
				};
			}

			var categoryDto = _mapper.Map<CategoryDto>(categoryEntity);

			return new ResponseDto<CategoryDto>
			{
				StatusCode = 200,
				Status = true,
				Message = "Categoría encontrada.",
				Data = categoryDto
			};
		}

		public async Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto dto)
		{
			var categoryEntity = _mapper.Map<CategoryEntity>(dto);

			_context.Categories.Add(categoryEntity);
			await _context.SaveChangesAsync();

			var categoryDto = _mapper.Map<CategoryDto>(categoryEntity);

			return new ResponseDto<CategoryDto>
			{
				StatusCode = 201,
				Status = true,
				Message = "Categoría creada correctamente.",
				Data = categoryDto
			};
		}

		public async Task<ResponseDto<CategoryDto>> EditAsync(CategoryEditDto dto, Guid id)
		{
			var categoryEntity = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);

			if (categoryEntity is null)
			{
				return new ResponseDto<CategoryDto>
				{
					StatusCode = 404,
					Status = false,
					Message = "No se encontró la Categoría."
				};
			}

			_mapper.Map<CategoryEditDto, CategoryEntity>(dto, categoryEntity);

			_context.Categories.Update(categoryEntity);
			await _context.SaveChangesAsync();

			var categoryDto = _mapper.Map<CategoryDto>(categoryEntity);

			return new ResponseDto<CategoryDto>
			{
				StatusCode = 200,
				Status = true,
				Message = "Categoría editada correctamente.",
				Data = categoryDto
			};
		}
		public async Task<ResponseDto<CategoryDto>> DeleteAsync(Guid id)
		{
			var categoryEntity = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
			if (categoryEntity is null)
			{
				return new ResponseDto<CategoryDto>
				{
					StatusCode = 404,
					Status = false,
					Message = "No se encontró la Categoría."
				};
			}

			_context.Categories.Remove(categoryEntity);
			await _context.SaveChangesAsync();

			return new ResponseDto<CategoryDto>
			{
				StatusCode = 200,
				Status = true,
				Message = "Categoría eliminada correctamente."
			};
		}
	}
}
