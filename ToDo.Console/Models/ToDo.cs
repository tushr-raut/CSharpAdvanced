using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Models
{
    class ToDo
    {
        public string Type { get; set; }
        public List<Note> Notes { get; set; }
        public List<Item> Items { get; set; }

        public ToDo(string type, List<Note> notes, List<Item> items)
        {
            Type = type;
            Notes = notes;
            Items = items;
        }
    }

    class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Note(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }

    class Item : Note
    {
        public int Quantity { get; set; }

        public Item(int id, string title, string description, int quantity) : base(id, title, description)
        {
            Quantity = quantity;
        }
    }

    //Notes
    //List of items
    //Reminders
}
