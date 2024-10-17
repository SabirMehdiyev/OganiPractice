using AutoMapper;
using Ogani.BLL.Constants;
using Ogani.BLL.Extentions;
using Ogani.BLL.Services.Contracts;
using Ogani.BLL.ViewModels.CategoryViewModels;
using Ogani.DAL.DataContext.Entities;
using Ogani.DAL.Repositories.Contracts;

namespace Ogani.BLL.Services
{
    public class CategoryManager : CrudManager<Category, CategoryViewModel, CategoryCreateViewModel, CategoryUpdateViewModel>, ICategoryService
    {

        public CategoryManager(IRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override async Task<CategoryViewModel> CreateAsync(CategoryCreateViewModel createViewModel)
        {
            if (!createViewModel.ImageFile.IsImage())
            {
                throw new Exception("Not an Image");
            }
            if (!createViewModel.ImageFile.AllowedSize(2))
            {
                throw new Exception("Invalid image size");
            }

            var imageName = await createViewModel.ImageFile.GenerateFile(FilePathConstants.CategoryImagePath);

            createViewModel.ImageUrl = imageName;

            return await base.CreateAsync(createViewModel);
        }
    }
}
