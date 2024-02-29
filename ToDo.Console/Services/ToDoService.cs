using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Services
{
    class ToDoService
    {
        private readonly List<Models.ToDo> responses;

        public ToDoService()
        {
            responses = new List<Models.ToDo> {
                new Models.ToDo("Note", new List<Models.Note> { new Models.Note(1, "Test1", "Descr1") }, null),
                new Models.ToDo("List", null, new List<Models.Item>{new Models.Item(1, "Test1", "Desc1", 10)})
            };
        }

        public IList<Models.ToDo> GetToDoList()
        {
            return responses;
        }

        [Obsolete]
        public List<Models.ToDo> GetToDoList(int noteId)
        {
            List<Models.ToDo> responses = new List<Models.ToDo> {
                new Models.ToDo("Note", new List<Models.Note> { new Models.Note(1, "Test1", "Descr1") }, null),
                new Models.ToDo("List", null, new List<Models.Item>{new Models.Item(1, "Test1", "Desc1", 10)})
            };

            //duplicate key
            Dictionary<int, string> dict = new Dictionary<int, string>();


            
            NameValueCollection dict1 = new NameValueCollection();
            dict1.Add("", "");

            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            list.Add(new KeyValuePair<int, string>(1, ""));


            return responses;
        }
    }
}
