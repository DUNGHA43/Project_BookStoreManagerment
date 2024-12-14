using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBLL
    {
        private readonly CategoryDAL _category;

        public CategoryBLL()
        {
            _category = new CategoryDAL();
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            return await _category.GetAllCategoriesAsync();
        }
    }
}
