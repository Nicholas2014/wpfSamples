using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using OrderDemo.Models;

namespace OrderDemo.Services
{
    public class XmlDataService : IDataService
    {
        public List<Dish> GetDishList()
        {
            var doc = XDocument.Load(Path.Combine(Environment.CurrentDirectory, @"Data\Data.xml"));
            return doc.Descendants("Dish").Select(r => new Dish()
            {
                Name = r.Attribute("Name").Value
            }).ToList();
        }
    }
}
