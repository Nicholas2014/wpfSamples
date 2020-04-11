using System.Collections.Generic;
using System.Windows.Documents;
using OrderDemo.Models;

namespace OrderDemo.Services
{
    public interface IDataService
    {
        List<Dish> GetDishList();
    }
}