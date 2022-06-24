using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagement
{
    interface IGamer
    {
        void NewEntry(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
