using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class TicketRepo : ITicketRepo
    {
        static List<Ticket> tickets = new List<Ticket>();

        public TicketRepo()
        {
   
        }

        /// <summary>
        /// A method to add a ticket to the List<Ticket> tickets
        /// </summary>
        /// <param name="ticket"></param>
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        /// <summary>
        /// A method to get all tickets from the List<Ticket> tickets
        /// </summary>
        /// <returns></returns>
        public List<Ticket> GetAllTickets()
        {
            return tickets;
        }

        public List<Ticket> GetAllTicketsForOneLicensePlate(string licensePlate)
        {

            if (licensePlate == null)
            {
                throw new ArgumentException("License plate does not exist");
            }
            return tickets.FindAll(ticket => ticket.LicensePlate == licensePlate);



        }

    }
}
