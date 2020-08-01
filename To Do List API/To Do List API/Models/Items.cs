using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace To_Do_List_API.Models
{
    public class Items
    {
        [Key]
        public Int32 id { get; set; }
        public string item { get; set; }
        public string done { get; set; }
        public string status { get; set; }

        public Items()
        {

        }
        public Items (string item, string done, string status)
        {
            this.item = item;
            this.done = done;
            this.status = status;
        }
    }
}
