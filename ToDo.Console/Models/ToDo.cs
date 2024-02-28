using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Models
{
    class ToDo
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Note> Notes { get; set; }
        public List<Item> Items { get; set; }
    }

    class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    class Item : Note
    {
        public int Quantity { get; set; }
    }
}
