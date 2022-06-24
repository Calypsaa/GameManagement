using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagement
{
    interface IOffer
    {
        void Add(Offer offer, Play play);
        void Delete(Offer offer);
        void Update(Offer offer);
    }
}
