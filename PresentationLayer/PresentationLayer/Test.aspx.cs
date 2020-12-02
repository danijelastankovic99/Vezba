using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Xceed.Wpf.Toolkit;

namespace PresentationLayer
{
    public partial class Test : System.Web.UI.Page
    {
        private readonly MenuItemBusiness menuItemBusiness;
        public Test()
        {
            menuItemBusiness = new MenuItemBusiness();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {  ListBox1.Items.Clear();
            List<MenuItem> mn = menuItemBusiness.GetAllMenuItems();
          
            foreach(MenuItem m in mn)
            {
                ListBox1.Items.Add(m.Id+". " +m.Title+ ", "+m.Description + " ( " +m.Price+ " ) ");

            }
        }
        protected void Kreiraj_Click(object sender, EventArgs e)
        {
            MenuItem m = new MenuItem();
            m.Price = Convert.ToDecimal( TextBox3.Text);
            m.Title = TextBox1.Text;
            m.Description = TextBox2.Text;
            if (this.menuItemBusiness.InsertMenuItem(m) == true)
            {
                RefreshData();

            }
            else
                Console.WriteLine("Greska");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MenuItem m = new MenuItem();
            m.Title = TextBox1.Text;
            m.Description = TextBox2.Text;
            m.Price = Convert.ToDecimal(TextBox3.Text);
            m.Id = int.Parse(ListBox1.SelectedItem.ToString().Split('.')[0]);
            if (this.menuItemBusiness.UpdateMenuItem(m) == true)
            {

                RefreshData();
            }
            else
                Console.WriteLine("Greska");
        }
    }
}