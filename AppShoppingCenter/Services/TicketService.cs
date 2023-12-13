using AppShoppingCenter.Models;

namespace AppShoppingCenter.Services
{
    public class TicketService
    {
        public Ticket GetTicket(string TicketNumber)
        {
            return null!;
        }

        public List<Ticket> GetTicketList(int userId)
        {
            return new List<Ticket> 
            {
                new Ticket()
            };
        }
    }
}
