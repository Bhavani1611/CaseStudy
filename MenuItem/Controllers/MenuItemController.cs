using MenuItem.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<Menu> GetItem()
        {
            List<Menu> MenuList = new List<Menu>()
            {   new Menu() {Id=1, Name="Briyani", Active=true, DateOfLaunch=new DateTime(2017,01,01), FreeDelivery=false,Price=100},
                new Menu() {Id=2, Name="Pizza", Active=false, DateOfLaunch=new DateTime(2018,10,03), FreeDelivery=false,Price=200}

            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public Menu GetItemById(int id)
        {
            List<Menu> MenuList = new List<Menu>()
            {   new Menu() {Id=1, Name="Briyani", Active=true, DateOfLaunch=new DateTime(2017,01,01), FreeDelivery=false,Price=100},
                new Menu() {Id=2, Name="Pizza", Active=false, DateOfLaunch=new DateTime(2018,10,03), FreeDelivery=false,Price=200}

            };
            Menu obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;

        }
    }
}
