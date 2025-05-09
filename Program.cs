using System.Threading.Tasks;

namespace Task_Seession3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<items> tasks = new List<items>();

            tasks.Add(new items { Title = "Task 1", Description = "First task", Date = DateTime.Now.AddDays(2), Priority = "High" });
            tasks.Add(new items { Title = "Task 2", Description = "Second task", Date = DateTime.Now.AddDays(3), Priority = "Low" });
            tasks.Add(new items { Title = "Task 3", Description = "Third task", Date = DateTime.Now.AddDays(5), Priority = "Medium" });

            foreach (var item in tasks)
            {
                item.display();
            }
            Console.WriteLine("Press to exit..");
            Console.ReadKey();
        }
    }
}
