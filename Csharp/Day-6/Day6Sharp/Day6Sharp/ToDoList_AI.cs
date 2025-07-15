using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Day6Sharp
{
    class ToDoList_AI
    {
        public string Task { get; set; }
        public string Priority { get; set; }
        ArrayList todoarrylist = new ArrayList();
        internal void AddTask(string usertask,string userpriority)
        {
            todoarrylist.Add(new ToDoList_AI {Task=usertask,Priority=userpriority });
        }
        //display
        internal ArrayList DisplayToDoList()
        {
            return todoarrylist;
        }
        internal void RemoveTask(string usertask)
        {
          foreach(ToDoList_AI item in todoarrylist)
            {
                if(item.Task==usertask)
                {
                    todoarrylist.Remove(usertask);
                }
            }
        }

    }
    class ToDo
    {
        static void Main()
        {
            Console.WriteLine("Enter your choice 1.Add 2.Display 3.Delete");
            //int ch = Convert.ToInt32(Console.ReadLine());
            ToDoList_AI todo = new ToDoList_AI();
            while(true)
            {
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 4)
                    break;
                Console.WriteLine("Enter your choice 1.Add 2.Display 3.Delete");
                switch (ch)
                {
                    case 1:
                        todo.AddTask("Meeting1", "1");
                        todo.AddTask("Training", "2");
                        todo.AddTask("Meeting2", "3");
                        Console.WriteLine("Data Added Successfully");
                        break;
                    case 2:
                        todo.DisplayToDoList();
                        break;
                    case 3:
                        todo.RemoveTask("Training");
                        break;
                    default:
                        break;

                }

            };
            Console.Read();
        }
    }
}
