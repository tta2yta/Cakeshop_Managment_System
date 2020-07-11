using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCakeShop.Model
{
  public  interface ICategoryRepository
    {
       IEnumerable<Category> AllCategories { get; }
       
    }
}
