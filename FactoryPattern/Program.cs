namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings and Salutations adventurer!\n" +
                "\n" +
                "What weapon would you like to take on your journey?\n" +
                "\n" +
                "\n" +
                "Type \"sword\" for a long sword.\n" +
                "\n" +
                "Type \"axe\" for a Dane axe.\n" +
                "");

            string weaponChoice = Console.ReadLine();

            IWeapon weapon = WeaponFactory.GetWeapon(weaponChoice);
            weapon.Forge();
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("....");
            Thread.Sleep(2000);
            Console.WriteLine(".....");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("...There!");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine($"That is as fine a looking {weaponChoice} as I've ever made. \n" +
                $"\n" +
                $"Weild it well, adventurer.");
        }
    }
}
