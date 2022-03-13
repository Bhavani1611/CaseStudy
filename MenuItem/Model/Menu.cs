using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItem.Model
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool FreeDelivery { get; set; }
        public int Price { get; set; }
        public DateTime DateOfLaunch { get; set; }
        public bool Active { get; set; }
    }
}
