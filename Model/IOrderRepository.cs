using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCakeShop.Model
{
   public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
