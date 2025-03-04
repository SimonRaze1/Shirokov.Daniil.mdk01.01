namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Moderator moderator = new Moderator();  
            Guest guest = new Guest();
            Vip vip = new Vip();

            guest.Login = "testUser";
            moderator.Login = "Moderator121";
            admin.Login = "admin545";
            vip.Login = "vip194200";

            admin.Work("лого", moderator, guest);
            Console.WriteLine("-----------------------------------");
            moderator.Work("flower" , guest, vip);
            Console.WriteLine("-----------------------------------");
            guest.Work("car", admin, vip);
            Console.WriteLine("-----------------------------------");
            vip.Work("лого", moderator, admin);
            Console.WriteLine("-----------------------------------");
        }
    }
}
