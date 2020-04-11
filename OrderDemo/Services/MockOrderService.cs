using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Services
{
    public class MockOrderService:IOrderService
    {
        public void ProcessOrder(List<string> dishs)
        {
            File.WriteAllLines(@"c:\dishs.txt",dishs.ToArray());
        }
    }
}
