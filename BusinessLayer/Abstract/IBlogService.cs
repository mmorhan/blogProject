using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
        List<Blog> GetBlogListByWriterWithCategory(int id);
        List<Blog> GetByBlogId(int id);
        int GetWriterId(int id);
        List<Blog> GetLast3Post();
    }
}
