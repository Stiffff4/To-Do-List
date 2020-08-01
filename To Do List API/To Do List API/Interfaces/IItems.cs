using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using To_Do_List_API.Models;

namespace To_Do_List_API.Interfaces
{
    public interface IItems
    {
        public List<Items> get();
        public void insert(Items item);
        public void setDone(int id);
        public void delete(int id);
    }
}
