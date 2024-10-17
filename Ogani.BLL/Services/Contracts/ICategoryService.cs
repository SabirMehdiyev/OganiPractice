using Ogani.BLL.ViewModels.CategoryViewModels;
using Ogani.DAL.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.BLL.Services.Contracts
{
    public interface ICategoryService : ICrudService<Category,CategoryViewModel,CategoryCreateViewModel,CategoryUpdateViewModel>
    {
    }
}
