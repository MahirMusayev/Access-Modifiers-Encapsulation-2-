namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("mahir", true, 100);
            Manager man = new Manager();
            man.GetPromotion(emp);

            Assistant assistant = new Assistant();
            assistant.GetFeedBack(emp);
        }
    }
}
