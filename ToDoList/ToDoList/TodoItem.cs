using System;
using System.Text;
using SQLite;

namespace ToDoList
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
        public TodoItem()
        {
        }
        public override string ToString()
        {
            return "ID" + ID + " Name " + Name + " Text " + Text;
        }
    }
}
