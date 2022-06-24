using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagement
{
    class PlayManager : IPlay
    {
        public void SellPlay(Play play,Gamer gamer)
        {
            Console.WriteLine(play.Name + "Adlı oyun" + gamer.Name + " Adlı oyuncuya satıldı");
        }
    }
}
