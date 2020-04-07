using System.Collections.Generic;
using System.Linq;

namespace OnlineTrading.Domain
{
    public class QuoteRepositoryFake {
        private List<Quote> reservations {get;set;} = new List<Quote>();

        public void AddQuote(Quote reservationToAdd)
        {
            reservations.Add(reservationToAdd);
        }

        public Quote GetById(string id)
        {
            return reservations.FirstOrDefault(s => s.Id == id);
        }
    }
}