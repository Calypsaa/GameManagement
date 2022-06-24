using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagement
{
    class OfferManager : IOffer
    {

        public void Add(Offer offer, Play play)
        {
            Console.WriteLine(play.Name + " Adlı oyuna" + offer.ID + "ID ye sahip teklif eklendi.");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine(offer.ID + "Id ye sahip teklif silindi");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine(offer.ID + "Id ye sahip oyun güncellendi"); ;
        }
    }
}
