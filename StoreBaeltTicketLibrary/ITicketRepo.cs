using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary
{
    interface ITicketRepo
    {

        void AddTicket(Ticket ticket);
        List<Ticket> GetAllTickets();
        List<Ticket> GetAllTicketsForOneLicensePlate(string licensePlate);


    }
}
