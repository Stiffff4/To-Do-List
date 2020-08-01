using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using To_Do_List_API.Interfaces;
using To_Do_List_API.Models;
using System.Data.SqlClient;
using To_Do_List_API.Data;

namespace To_Do_List_API
{
    public class ItemsImpl: IItems
    {

        private ItemsContext _context = new ItemsContext();

        private List<Items> items;
        public List<Items> get()
        {
            items = new List<Items>();

            items = _context.Items.Where(item => item.status == "0").ToList<Items>();

            return items;
        }

        public void insert(Items item)
        {
            _context.Add(item);

            _context.SaveChanges();
        }

        public void setDone(int id)
        {
            var item = _context.Items.Find(id);
            item.done = "1";

            _context.SaveChanges();
        }

        public void delete(int id)
        {
            var item = _context.Items.Find(id);
            item.status = "1";

            _context.SaveChanges();
        }
    }
}
