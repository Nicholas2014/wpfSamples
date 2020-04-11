using System.Collections.Generic;
using System.Windows.Documents;

namespace OrderDemo.Services
{
    public interface IOrderService
    {
        void ProcessOrder(List<string> dishs);
    }
}