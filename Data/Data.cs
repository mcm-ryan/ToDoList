
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
            Title="Vienna, Austria",
            Notes="Vienna, is one the most beautiful cities in Austria and in Europe as well. Other than the Operas for which it is well known, Vienna also has many beautiful parks...",
            DateCreated = new DateTime(2017,01,20),
            DateCompleted = null
        },
        new ToDoItem()
        {
            Id=2,
            Title="Carpinteria, CA, USA",
            Notes="Carpinteria is a city located on the central coast of California, just south of Santa Barbara. It has many beautiful beaches as well as a popular Avocado Festival which takes place every year in October...",
            DateCreated = new DateTime(2019,02,22),
            DateCompleted = new DateTime(2019,01,30)
        },
        new ToDoItem()
        {
            Id=3,
            Title="San Francisco, CA, USA",
            Notes="San Francisco is a metropolitan area located on the west coast of the United States. Some popular tourist features include the Golden Gate Bridge, Chinatown, and Fisherman's Wharf. There are a variety of popular food options...",
            DateCreated = new DateTime(2019,01,27),
            DateCompleted = new DateTime(2019,01,30)
        },
        new ToDoItem()
        {
            Id=4,
            Title="Tucson, AZ, USA",
            Notes="Tucson is a southwestern city in Arizona that is home to the University of Arizona. It was recently Titled a world gastronomy city, and is well known for its desert landscape and various bike races...",
            DateCreated = new DateTime(2019,01,20),
            DateCompleted = null
        },
        new ToDoItem()
        {
            Id=5,
            Title="Albuquerque, NM, USA",
            Notes="Albuquerque is a city located in New Mexico that is famous for its balloon festivals, picturesque views and references to TV shows.",
            DateCreated = new DateTime(2015,01,20),
            DateCompleted = new DateTime(2015,01,30)
        },
        new ToDoItem()
        {
            Id=7,
            Title="Munich, Germany",
            Notes="Munich is an important city in Germany, located in the heart of Bavaria. It's famous for its traditional Oktoberfest annual festival, and many nice lakes and parks...",
            DateCreated = new DateTime(2019,01,20),
            DateCompleted = null
        }
    };

}
}