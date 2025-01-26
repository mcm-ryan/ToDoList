
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public static class Data
    {
        public static List<ToDoItem> ToDoItems => allToDoItems;
        static List<ToDoItem> allToDoItems = new List<ToDoItem>()
        {
            new ToDoItem()
            {
                Id=1,
                Title="Organize Garage",
                Notes="Sort tools and discard old or broken items. Install new storage racks.",
                DateCreated = new DateTime(2017,01,20),
                DateCompleted = null
            },
            new ToDoItem()
            {
                Id=2,
                Title="Submit Tax Returns",
                Notes="Double-check deductions for 2018 and file electronically.",
                DateCreated = new DateTime(2019,02,22),
                DateCompleted = new DateTime(2019,01,30)
            },
            new ToDoItem()
            {
                Id=3,
                Title="Plan Birthday Party",
                Notes="Create guest list, book venue, and order decorations.",
                DateCreated = new DateTime(2019,01,27),
                DateCompleted = new DateTime(2019,01,30)
            },
            new ToDoItem()
            {
                Id=4,
                Title="Fix Leaky Faucet",
                Notes="Buy a new washer or cartridge and install it. Consider plumber if needed.",
                DateCreated = new DateTime(2019,01,20),
                DateCompleted = null
            },
            new ToDoItem()
            {
                Id=5,
                Title="Read 'Clean Code'",
                Notes="Finish chapters 1-5 by the end of the month. Take notes for discussion group.",
                DateCreated = new DateTime(2015,01,20),
                DateCompleted = new DateTime(2015,01,30)
            },
            new ToDoItem()
            {
                Id=6,
                Title="Update Resume",
                Notes="Add recent projects and certifications. Tailor for upcoming job application.",
                DateCreated = new DateTime(2019,01,20),
                DateCompleted = null
            }
        };
    }
}