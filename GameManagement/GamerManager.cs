using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagement
{
    class GamerManager : IGamer
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Adlı oyuncu silindi.");
        }

        public void NewEntry(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Adlı oyuncu sisteme giriş yaptı"); 
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Adlı oyuncu güncellendi");
        }
    }
}
