using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Services
{
    class ToDoService
    {
        private List<Models.ToDo> list;
        
        public ToDoService()
        {
            list = new List<Models.ToDo>
            {
                new Models.ToDo
                {
                    Id = 101,
                    Type = "Note",
                    Notes = new List<Models.Note>{
                       new Models.Note
                       {
                           Id = 1,
                           Title = "Test",
                           Description = "Test Descr"
                       }
                    }
                }
            };
        }

        public List<Models.ToDo> GetList()
        {
            return list;
        }
    }
}
