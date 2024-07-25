using MeetPoint.API.Dtos.Categories;
using MeetPoint.API.Dtos.Common;

namespace MeetPoint.API.Services.Interfaces
{
	public interface ICategoriesService
	{
		Task<ResponseDto<List<CategoryDto>>> GetAllCategoriesAsync();
		Task<ResponseDto<CategoryDto>> GetCategoryByIdAsync(Guid id);
		Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto dto);
		Task<ResponseDto<CategoryDto>> EditAsync(CategoryEditDto dto, Guid id);
		Task<ResponseDto<CategoryDto>> DeleteAsync(Guid id);

	}
}
