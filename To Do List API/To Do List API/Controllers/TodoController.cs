using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using To_Do_List_API.Models;
using Microsoft.AspNetCore.Cors;
using To_Do_List_API.Interfaces;

namespace To_Do_List_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : Controller
    {
        private IItems i = new ItemsImpl();
        private List<Items> list;

        [HttpGet]
        public List<Items> get()
        {
            list = i.get();

            bool isEmpty = !list.Any();

            if (isEmpty)
            {
                Response.StatusCode = 204;
            }
            else
            {
                Response.StatusCode = 200;
            }

            return list;
        }

        [HttpPost]
        public void insert(Items item)
        {
            item.done = "0";
            item.status = "0";

            i.insert(item);
            Response.StatusCode = 201;
        }

        [HttpDelete]
        public void delete(int id)
        {
            Response.StatusCode = 200;
            i.delete(id);
        }

        [HttpPut]
        public void setDone(int id)
        {
            Response.StatusCode = 200;
            i.setDone(id);
        }
    }
}