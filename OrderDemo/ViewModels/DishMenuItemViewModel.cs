using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderDemo.Models;

namespace OrderDemo.ViewModels
{
    public class DishMenuItemViewModel:ViewModelBase
    {
        public Dish Dish { get; set; }
		private bool isSelected;

		public bool IsSelected
		{
			get { return isSelected; }
			set { isSelected = value; }
		}


	}
}
