using System;

namespace GameManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() { ID = 1, Name = "Mert Gazi", Surname = "Samur", TcNumber = "1234435546122", DateOfBirth = "24.09.2001" };
            GamerManager gamerManager = new GamerManager();
            gamerManager.NewEntry(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

        }
    }
}
