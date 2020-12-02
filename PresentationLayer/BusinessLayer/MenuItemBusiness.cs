using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MenuItemBusiness
    {
        private readonly MenuItemRepository menuItemRepository;
        public MenuItemBusiness()
        {
            menuItemRepository = new MenuItemRepository();

        }
        public List<MenuItem> GetAllMenuItems()
        {
            return this.menuItemRepository.GetAllMenuItems();
        }
        public bool InsertMenuItem (MenuItem m)
        {
            if (menuItemRepository.InsertMenuItem(m) > 0)
                return true;
            else
                return false;

        }
        public bool UpdateMenuItem (MenuItem m)
        {
            if (this.menuItemRepository.UpdateMenuItem(m) > 0)
                return true;
            else
                return false;

        }
        public MenuItem GetMenuItemById(int id)
        {
            return menuItemRepository.GetAllMenuItems().FirstOrDefault(s => s.Id == id);
        }
        public List<MenuItem> MinAndMax(decimal a, decimal b)
        {
            return menuItemRepository.GetAllMenuItems().Where(s => s.Price > a && s.Price<b).ToList();
        }
    }
}
